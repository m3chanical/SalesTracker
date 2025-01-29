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
using ff14bot;

namespace SalesTracker;

public partial class SettingsForm : Form
{
    private List<Sale> _saleRange = new List<Sale>();

    public static SettingsForm Instance { get; set; }
    public SettingsForm()
    {
        InitializeComponent();
        SetDoubleBuffer(salesDataGrid, true);
        SetDoubleBuffer(rangeSalesDataGrid, true);

        logListBox.DataSource = Logger.LogList;
        salesDataGrid.DataSource = SalesSettings.Instance.Sales;
        salesDataGrid.Columns[0].DefaultCellStyle.Format = "MM'/'dd'/'yy HH:mm";
        salesDataGrid.Columns[4].DefaultCellStyle.Format = "n0";

        rangeSalesDataGrid.DataSource = _saleRange;
        rangeSalesDataGrid.Columns[0].DefaultCellStyle.Format = "MM'/'dd'/'yy HH:mm";
        rangeSalesDataGrid.Columns[4].DefaultCellStyle.Format = "n0";

        Text = $"RB Statistics v{SalesPlugin.CurrentVersion} {Core.Me.Name}";
        Instance = this;
    }

    public void UpdateSalesDgv()
    {
        if (!IsHandleCreated) return;
        salesDataGrid.BeginInvoke((Action) delegate
        {
            //Logger.Info("Begun Invoke for Dgv");
            salesDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            salesDataGrid.DataSource = typeof(List<Sale>); // list<sale> or Sale?
            salesDataGrid.DataSource = SalesSettings.Instance.Sales;
            salesDataGrid.Update();
            salesDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            salesDataGrid.FirstDisplayedScrollingRowIndex = salesDataGrid.RowCount - 1;
            Task.Run(CalculateStatistics);
        });
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
            List<Sale> salesRange;
            if (fullRangeCheckbox.Checked) // use full date range
            {
                salesRange = SalesSettings.Instance.Sales; // full range
            }
            else
            {
                salesRange = _saleRange; // when dates are selected
            }

            if (!salesRange.Any()) // e.g. new install or cleared stats
                return false;

            TimeSpan timeElapsed = salesRange.Last().SalesDateTime.Subtract(salesRange.First().SalesDateTime);
            lastSaleLabel.Text = salesRange.Last().SalesDateTime.ToString("g");
            salesLabel.Text = salesRange.Count.ToString();
            int gilSum = 0, itemSum = 0;
            foreach (Sale sale in salesRange)
            {
                gilSum += sale.SoldPrice;
                itemSum += sale.AmountSold;
            }

            totalSoldLabel.Text = itemSum.ToString();
            gilLabel.Text = gilSum.ToString();

            totalSoldLabel.Text = $"{itemSum}";
            gilLabel.Text = $"{gilSum:n0}";
            if (itemSum > 0)
                gilPerItemLabel.Text = $"{gilSum / (itemSum):n0}";
            gilPerSaleLabel.Text = $"{gilSum / salesRange.Count:n0}";

            if (timeElapsed.TotalDays > 0) gilPerDayLabel.Text = timeElapsed.TotalDays < 1 ? $"{gilSum:n0}" : $"{gilSum / timeElapsed.TotalDays:n0}";
            if (timeElapsed.TotalHours > 0) gilPerHourLabel.Text = $"{gilSum / timeElapsed.TotalHours:n0}";

            return true;
        });
    }

    private async void SettingsForm_Load(object sender, EventArgs e)
    {
        // update dgv
        await Task.Run(CalculateStatistics);
    }

    private void setDateButton_Click(object sender, EventArgs e)
    {
        // get date range and set list
        // trigger calculate?
        // update datagrid
        fullRangeCheckbox.Checked = false;
        statsGroupBox.Text = $"Gil Statistics - {startDate.Value.Date.ToString("MM/dd/yy")} to {endDate.Value.Date.ToString("MM/dd/yy")}";

        _saleRange = SalesSettings.Instance.Sales.Where(x =>
            x.SalesDateTime.Date <= endDate.Value.Date && x.SalesDateTime.Date >= startDate.Value.Date).ToList();
        rangeSalesDataGrid.Update();

        rangeSalesDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        rangeSalesDataGrid.DataSource = typeof(List<Sale>); // list<sale> or Sale?
        rangeSalesDataGrid.DataSource = _saleRange;
        rangeSalesDataGrid.Update();
        rangeSalesDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;

        Task.Run(CalculateStatistics);

    }

    private void fullRangeCheckbox_CheckedChanged(object sender, EventArgs e)
    {
        if (fullRangeCheckbox.Checked)
        {
            statsGroupBox.Text = $"Gil Statistics - Full Range";
            _saleRange.Clear();

            // TODO: break this stuff out to its own function or something. i keep repeating it.
            rangeSalesDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            rangeSalesDataGrid.DataSource = typeof(List<Sale>); // list<sale> or Sale?
            rangeSalesDataGrid.DataSource = _saleRange;
            rangeSalesDataGrid.Update();
            rangeSalesDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;

            Task.Run(CalculateStatistics);
        }

    }

    private void resetButton_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = MessageBox.Show("This will delete all sales data, are you sure? (Recommend backing up first)", "Data Yeeter", MessageBoxButtons.YesNo);
        if(dialogResult == DialogResult.Yes)
            SalesSettings.Instance.Sales.Clear();
    }

    private void verboseCheckbox_CheckedChanged(object sender, EventArgs e)
    {
        Logger.log_verbose = verboseCheckbox.Checked;
    }
}