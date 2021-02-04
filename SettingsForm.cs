using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesTracker
{
    public partial class SettingsForm : Form
    {
        public SettingsForm() 
        {
            InitializeComponent();
            SetDoubleBuffer(salesDataGrid, true);

            logListBox.DataSource = Logger.LogList;
            salesDataGrid.DataSource = SalesSettings.Instance.Sales;
        }

        private void SetDoubleBuffer(Control dataGridView, bool doublebuffered)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, 
                dataGridView, 
                new object[] {doublebuffered});
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
                default:
                    return;
            }
        }

        private async Task<bool> CalculateStatistics()
        {
            return await Task.Run(() =>
            {
                if (!SalesSettings.Instance.Sales.Any()) // e.g. new install
                    return false; 

                lastSaleLabel.Text = SalesSettings.Instance.Sales.Last().SalesDateTime.ToString("MM/dd/yy HH:mm");
                salesLabel.Text = SalesSettings.Instance.Sales.Count.ToString();
                int gilSum = 0, itemSum = 0;
                foreach (Sale sale in SalesSettings.Instance.Sales)
                {
                    gilSum += sale.SoldPrice;
                    itemSum += sale.AmountSold;
                }

                totalSoldLabel.Text = itemSum.ToString();
                gilLabel.Text = gilSum.ToString();
                if(itemSum > 0) gilPerItemLabel.Text = (gilSum / itemSum).ToString();
                if(SalesSettings.Instance.Sales.Count > 0 ) gilPerSaleLabel.Text = (gilSum / SalesSettings.Instance.Sales.Count).ToString();
                
                totalSoldLabel.Text = $"{itemSum}";
                gilLabel.Text = $"{gilSum:n0}";
                if (itemSum != 0)
                    gilPerItemLabel.Text = $"{gilSum / (itemSum):n0}"; 
                gilPerSaleLabel.Text = $"{gilSum / SalesSettings.Instance.Sales.Count:n0}";

                var timeElapsed = SalesSettings.Instance.Sales.Last().SalesDateTime
                                    .Subtract(SalesSettings.Instance.Sales.First().SalesDateTime);

                if (timeElapsed.TotalDays > 0) gilPerDayLabel.Text = timeElapsed.TotalDays < 1 ? $"{gilSum:n0}" : $"{gilSum / timeElapsed.TotalDays:n0}";
                if(timeElapsed.TotalHours > 0) gilPerHourLabel.Text = $"{gilSum / timeElapsed.TotalHours:n0}";

                return true; 
            });
        }

        private async void SettingsForm_Load(object sender, EventArgs e)
        {
            // update dgv
            await Task.Run(CalculateStatistics);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            // update dgv
            logListBox.Refresh();
            salesDataGrid.Refresh(); // not sure if Refresh works. might need Upate() or to simply null it and re-add.
        }
    }
}
