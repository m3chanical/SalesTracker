using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesTracker
{
    public partial class SettingsForm : Form, INotifyPropertyChanged
    {
        /*
         * TODO:
         *  average gil per sale
         *  gil per hour
         *  maybe track total gil delta
         *  datagrid listing all sales and their data
         */
        public event PropertyChangedEventHandler PropertyChanged;
         
        private int _gil;
        private int _sales;
        public int Gil
        {
            get => _gil;
            set
            {
                _gil = value;
                OnPropertyChanged("Gil");
            }
        }

        public int Sales
        {
            get => _sales;
            set
            {
                _sales = value;
                OnPropertyChanged("Sales");
            }
        }

        public SettingsForm() 
        {
            InitializeComponent();
            SetDoubleBuffer(salesDataGrid, true);
            salesDataGrid.RowsAdded += salesDataGrid_RowsAdded;
        }

        private void SetDoubleBuffer(Control dataGridView, bool doublebuffered)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, dataGridView, new object[] {DoubleBuffered});
        }

        public void SaleAdded()
        {
            Logger.Info("Update DataGrid");
            salesDataGrid.Refresh(); //maybe refresh?
        }

        protected virtual void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            salesDataGrid.Refresh();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) 
        {
            switch (tabControl1.SelectedIndex) {
                case 0: // Statistics page
                    break;
                case 1: // Sales List page
                    break;
                case 2: // log page
                    break;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private async void salesDataGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lastSaleLabel.Text = salesDataGrid.Rows[salesDataGrid.RowCount - 1].Cells[0].Value.ToString(); ;
                await CalculateStatistics();
        }

        private async Task<bool> CalculateStatistics()
        {
            //TODO
            return await Task.Run<bool>(() =>
            {
                salesLabel.Text = salesDataGrid.RowCount.ToString();
                int gilsum = 0, itemsum = 0;
                foreach (SalesSettings.Sale sale in SalesSettings.Instance.Sales)
                {
                    gilsum += sale.SoldPrice;
                    itemsum += sale.AmountSold;
                }

                totalSoldLabel.Text = itemsum.ToString();
                gilLabel.Text = gilsum.ToString();
                gilPerDayLabel.Text = SalesSettings.Instance.Sales.Where(r => r.SalesDateTime.Date == DateTime.Today.Date).Sum(r => r.SoldPrice).ToString(); // meow?
                return true; 
            });
        }

        private async void SettingsForm_Load(object sender, EventArgs e) 
        {
            
            if (Logger.LogList != null) logListBox.DataSource = Logger.LogList;
            await Task.Run(() => salesDataGrid.DataSource = SalesSettings.Instance.Sales);
            await Task.Run(CalculateStatistics);
        }
    }
}
