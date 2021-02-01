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
            gilLabel.DataBindings.Add(new Binding("Text", this, "Gil"));
            salesLabel.DataBindings.Add(new Binding("Text", this, "Sales"));
        }

        protected virtual void OnPropertyChanged(string property)
        {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
