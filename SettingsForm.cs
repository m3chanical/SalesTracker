using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            gilLabel.DataBindings.Add(new Binding("Text", this, "Gil", true, DataSourceUpdateMode.OnPropertyChanged, "", "n0"));
            salesLabel.DataBindings.Add(new Binding("Text", this, "Sales"));

            if (SalesPlugin.Database != null) salesDataGrid.DataSource = SalesPlugin.Database.Sales;
            if(Logger.LogList != null) logListBox.DataSource = Logger.LogList;
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
            Logger.Info("Row added to Database.");
            await CalculateStatistics();
        }

        private async Task<bool> CalculateStatistics()
        {
            //TODO
            return await Task.Run<bool>(() =>
            {
                return true; 
            });
        }

        private void SettingsForm_Load(object sender, EventArgs e) 
        {

        }
    }
}
