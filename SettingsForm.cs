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

        public SettingsForm(SalesPlugin sp) 
        {
            InitializeComponent();
            gilLabel.DataBindings.Add(new Binding("Text", this, "Gil", true, DataSourceUpdateMode.OnPropertyChanged, "", "n0"));
            salesLabel.DataBindings.Add(new Binding("Text", this, "Sales"));

            if (SalesPlugin.Database != null) salesDataGrid.DataSource = SalesPlugin.Database.Sales;
            sp.SaleAdded += SaleAdded;
        }

        void SaleAdded(object s, EventArgs e)
        {
            salesDataGrid.Update(); //maybe refresh?
        }

        protected virtual void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            salesDataGrid.Update();
        }
    }
}
