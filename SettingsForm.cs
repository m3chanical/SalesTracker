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

        private async void tabControl1_SelectedIndexChanged(object sender, EventArgs e) 
        {
            switch (tabControl1.SelectedIndex) {
                case 0: // Statistics page
                    await Task.Run(CalculateStatistics);
                    break;
                case 1: // Sales List page
                    break;
                case 2: // Log page
                    break;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private async void salesDataGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        { 
            await CalculateStatistics();
        }

        private async Task<bool> CalculateStatistics()
        {
            //TODO
            return await Task.Run(() =>
            {
                lastSaleLabel.Text = ((DateTime)salesDataGrid.Rows[salesDataGrid.RowCount - 1].Cells[0].Value).ToString("g");
                salesLabel.Text = SalesSettings.Instance.Sales.Count.ToString();
                int gilSum = 0, itemSum = 0;
                foreach (SalesSettings.Sale sale in SalesSettings.Instance.Sales)
                {
                    gilSum += sale.SoldPrice;
                    itemSum += sale.AmountSold;
                }

                totalSoldLabel.Text = $"{itemSum}";
                gilLabel.Text = $"{gilSum:n0}";
                if (itemSum != 0)
                    gilPerItemLabel.Text = $"{gilSum / (itemSum):n0}"; 
                gilPerSaleLabel.Text = $"{gilSum / salesDataGrid.RowCount:n0}";

                // list might need to be sorted by date just in case? sorting a bindinglist isn't straightforward
                var days = (SalesSettings.Instance.Sales.Last().SalesDateTime.Date -
                            SalesSettings.Instance.Sales.First().SalesDateTime.Date).Days; // needs to be .Date so it'll calculate it right. i dunno.
                if(days > 0 ) gilPerDayLabel.Text = $"{gilSum / days:n0}";
                
                var hours = (SalesSettings.Instance.Sales.Last().SalesDateTime -
                             SalesSettings.Instance.Sales.First().SalesDateTime).Hours; // this timespan can't use DateTime.Date ??? Test more.
                if(hours > 0) gilPerHourLabel.Text = $"{gilSum / hours:n0}";

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
