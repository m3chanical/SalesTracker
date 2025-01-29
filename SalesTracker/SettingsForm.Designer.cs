using System.ComponentModel;

namespace SalesTracker;

partial class SettingsForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
        tabControl1 = new System.Windows.Forms.TabControl();
        statsTab = new System.Windows.Forms.TabPage();
        daterange = new System.Windows.Forms.GroupBox();
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        startDate = new System.Windows.Forms.DateTimePicker();
        fullRangeCheckbox = new System.Windows.Forms.CheckBox();
        label6 = new System.Windows.Forms.Label();
        endDate = new System.Windows.Forms.DateTimePicker();
        label8 = new System.Windows.Forms.Label();
        setDateButton = new System.Windows.Forms.Button();
        verboseCheckbox = new System.Windows.Forms.CheckBox();
        resetButton = new System.Windows.Forms.Button();
        statsGroupBox = new System.Windows.Forms.GroupBox();
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        gilLabel = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        salesLabel = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        totalSoldLabel = new System.Windows.Forms.Label();
        gilPerHourLabel = new System.Windows.Forms.Label();
        gilPerDayLabel = new System.Windows.Forms.Label();
        label9 = new System.Windows.Forms.Label();
        lastSaleLabel = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label10 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        gilPerSaleLabel = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        gilPerItemLabel = new System.Windows.Forms.Label();
        salesTab = new System.Windows.Forms.TabPage();
        salesDataGrid = new System.Windows.Forms.DataGridView();
        salesDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        amountSoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        itemSoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        soldPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        saleBindingSource = new System.Windows.Forms.BindingSource(components);
        logTabPage = new System.Windows.Forms.TabPage();
        logListBox = new System.Windows.Forms.ListBox();
        selectedSalesPage = new System.Windows.Forms.TabPage();
        rangeSalesDataGrid = new System.Windows.Forms.DataGridView();
        salesDateTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        amountSoldDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        itemSoldDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        itemIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        soldPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        settingsFormBindingSource = new System.Windows.Forms.BindingSource(components);
        tabControl1.SuspendLayout();
        statsTab.SuspendLayout();
        daterange.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        statsGroupBox.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        salesTab.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)salesDataGrid).BeginInit();
        ((System.ComponentModel.ISupportInitialize)saleBindingSource).BeginInit();
        logTabPage.SuspendLayout();
        selectedSalesPage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)rangeSalesDataGrid).BeginInit();
        ((System.ComponentModel.ISupportInitialize)settingsFormBindingSource).BeginInit();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(statsTab);
        tabControl1.Controls.Add(salesTab);
        tabControl1.Controls.Add(logTabPage);
        tabControl1.Controls.Add(selectedSalesPage);
        tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        tabControl1.Location = new System.Drawing.Point(0, 0);
        tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new System.Drawing.Size(681, 647);
        tabControl1.TabIndex = 0;
        tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
        // 
        // statsTab
        // 
        statsTab.Controls.Add(daterange);
        statsTab.Controls.Add(resetButton);
        statsTab.Controls.Add(statsGroupBox);
        statsTab.Location = new System.Drawing.Point(4, 24);
        statsTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        statsTab.Name = "statsTab";
        statsTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        statsTab.Size = new System.Drawing.Size(673, 619);
        statsTab.TabIndex = 0;
        statsTab.Text = "Statistics";
        statsTab.UseVisualStyleBackColor = true;
        // 
        // daterange
        // 
        daterange.Controls.Add(tableLayoutPanel2);
        daterange.Dock = System.Windows.Forms.DockStyle.Top;
        daterange.Location = new System.Drawing.Point(4, 171);
        daterange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        daterange.Name = "daterange";
        daterange.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        daterange.Size = new System.Drawing.Size(665, 159);
        daterange.TabIndex = 6;
        daterange.TabStop = false;
        daterange.Text = "Stats Date Range";
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 4;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.74603F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.25397F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
        tableLayoutPanel2.Controls.Add(startDate, 1, 0);
        tableLayoutPanel2.Controls.Add(fullRangeCheckbox, 0, 2);
        tableLayoutPanel2.Controls.Add(label6, 0, 0);
        tableLayoutPanel2.Controls.Add(endDate, 1, 1);
        tableLayoutPanel2.Controls.Add(label8, 0, 1);
        tableLayoutPanel2.Controls.Add(setDateButton, 2, 0);
        tableLayoutPanel2.Controls.Add(verboseCheckbox, 2, 2);
        tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel2.Location = new System.Drawing.Point(4, 19);
        tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 3;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
        tableLayoutPanel2.Size = new System.Drawing.Size(657, 137);
        tableLayoutPanel2.TabIndex = 9;
        // 
        // startDate
        // 
        startDate.Location = new System.Drawing.Point(143, 3);
        startDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        startDate.Name = "startDate";
        startDate.Size = new System.Drawing.Size(292, 23);
        startDate.TabIndex = 4;
        // 
        // fullRangeCheckbox
        // 
        fullRangeCheckbox.Checked = true;
        fullRangeCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
        fullRangeCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
        fullRangeCheckbox.Location = new System.Drawing.Point(4, 99);
        fullRangeCheckbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        fullRangeCheckbox.Name = "fullRangeCheckbox";
        fullRangeCheckbox.Size = new System.Drawing.Size(131, 35);
        fullRangeCheckbox.TabIndex = 8;
        fullRangeCheckbox.Text = "Use Full Range?";
        fullRangeCheckbox.UseVisualStyleBackColor = true;
        fullRangeCheckbox.CheckedChanged += fullRangeCheckbox_CheckedChanged;
        // 
        // label6
        // 
        label6.Dock = System.Windows.Forms.DockStyle.Fill;
        label6.Location = new System.Drawing.Point(4, 0);
        label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(131, 48);
        label6.TabIndex = 5;
        label6.Text = "Start Date:";
        // 
        // endDate
        // 
        endDate.Dock = System.Windows.Forms.DockStyle.Fill;
        endDate.Location = new System.Drawing.Point(143, 51);
        endDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        endDate.Name = "endDate";
        endDate.Size = new System.Drawing.Size(292, 23);
        endDate.TabIndex = 6;
        // 
        // label8
        // 
        label8.Dock = System.Windows.Forms.DockStyle.Fill;
        label8.Location = new System.Drawing.Point(4, 48);
        label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(131, 48);
        label8.TabIndex = 7;
        label8.Text = "End Date:";
        // 
        // setDateButton
        // 
        setDateButton.Dock = System.Windows.Forms.DockStyle.Fill;
        setDateButton.Location = new System.Drawing.Point(443, 3);
        setDateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        setDateButton.Name = "setDateButton";
        setDateButton.Size = new System.Drawing.Size(134, 42);
        setDateButton.TabIndex = 9;
        setDateButton.Text = "Set Dates";
        setDateButton.UseVisualStyleBackColor = true;
        setDateButton.Click += setDateButton_Click;
        // 
        // verboseCheckbox
        // 
        verboseCheckbox.AutoSize = true;
        verboseCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
        verboseCheckbox.Location = new System.Drawing.Point(443, 99);
        verboseCheckbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        verboseCheckbox.Name = "verboseCheckbox";
        verboseCheckbox.Size = new System.Drawing.Size(134, 35);
        verboseCheckbox.TabIndex = 10;
        verboseCheckbox.Text = "Verbose Logging?";
        verboseCheckbox.UseVisualStyleBackColor = true;
        verboseCheckbox.CheckedChanged += verboseCheckbox_CheckedChanged;
        // 
        // resetButton
        // 
        resetButton.Dock = System.Windows.Forms.DockStyle.Bottom;
        resetButton.Location = new System.Drawing.Point(4, 589);
        resetButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        resetButton.Name = "resetButton";
        resetButton.Size = new System.Drawing.Size(665, 27);
        resetButton.TabIndex = 5;
        resetButton.Text = "Reset Statistics";
        resetButton.UseVisualStyleBackColor = true;
        resetButton.Click += resetButton_Click;
        // 
        // statsGroupBox
        // 
        statsGroupBox.Controls.Add(tableLayoutPanel1);
        statsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
        statsGroupBox.Location = new System.Drawing.Point(4, 3);
        statsGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        statsGroupBox.Name = "statsGroupBox";
        statsGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        statsGroupBox.Size = new System.Drawing.Size(665, 168);
        statsGroupBox.TabIndex = 3;
        statsGroupBox.TabStop = false;
        statsGroupBox.Text = "Gil Statistics";
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.AutoSize = true;
        tableLayoutPanel1.ColumnCount = 6;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.63636F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.36364F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
        tableLayoutPanel1.Controls.Add(gilLabel, 1, 1);
        tableLayoutPanel1.Controls.Add(label3, 0, 1);
        tableLayoutPanel1.Controls.Add(salesLabel, 1, 0);
        tableLayoutPanel1.Controls.Add(label1, 0, 0);
        tableLayoutPanel1.Controls.Add(label5, 2, 0);
        tableLayoutPanel1.Controls.Add(totalSoldLabel, 3, 0);
        tableLayoutPanel1.Controls.Add(gilPerHourLabel, 3, 1);
        tableLayoutPanel1.Controls.Add(gilPerDayLabel, 3, 2);
        tableLayoutPanel1.Controls.Add(label9, 2, 1);
        tableLayoutPanel1.Controls.Add(lastSaleLabel, 1, 2);
        tableLayoutPanel1.Controls.Add(label2, 0, 2);
        tableLayoutPanel1.Controls.Add(label10, 2, 2);
        tableLayoutPanel1.Controls.Add(label4, 4, 0);
        tableLayoutPanel1.Controls.Add(gilPerSaleLabel, 5, 0);
        tableLayoutPanel1.Controls.Add(label7, 4, 1);
        tableLayoutPanel1.Controls.Add(gilPerItemLabel, 5, 1);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(4, 19);
        tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
        tableLayoutPanel1.Size = new System.Drawing.Size(657, 146);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // gilLabel
        // 
        gilLabel.AutoSize = true;
        gilLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        gilLabel.Location = new System.Drawing.Point(85, 44);
        gilLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        gilLabel.Name = "gilLabel";
        gilLabel.Size = new System.Drawing.Size(97, 44);
        gilLabel.TabIndex = 3;
        gilLabel.Text = "0";
        gilLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Dock = System.Windows.Forms.DockStyle.Fill;
        label3.Location = new System.Drawing.Point(4, 44);
        label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(73, 44);
        label3.TabIndex = 2;
        label3.Text = "Total Gil Earned:";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // salesLabel
        // 
        salesLabel.AutoSize = true;
        salesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        salesLabel.Location = new System.Drawing.Point(85, 0);
        salesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        salesLabel.Name = "salesLabel";
        salesLabel.Size = new System.Drawing.Size(97, 44);
        salesLabel.TabIndex = 1;
        salesLabel.Text = "0";
        salesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Dock = System.Windows.Forms.DockStyle.Fill;
        label1.Location = new System.Drawing.Point(4, 0);
        label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(73, 44);
        label1.TabIndex = 0;
        label1.Text = "Sales Made:";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Dock = System.Windows.Forms.DockStyle.Fill;
        label5.Location = new System.Drawing.Point(190, 0);
        label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(100, 44);
        label5.TabIndex = 6;
        label5.Text = "Total Items Sold:";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // totalSoldLabel
        // 
        totalSoldLabel.AutoSize = true;
        totalSoldLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        totalSoldLabel.Location = new System.Drawing.Point(298, 0);
        totalSoldLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        totalSoldLabel.Name = "totalSoldLabel";
        totalSoldLabel.Size = new System.Drawing.Size(111, 44);
        totalSoldLabel.TabIndex = 5;
        totalSoldLabel.Text = "0";
        totalSoldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // gilPerHourLabel
        // 
        gilPerHourLabel.AutoSize = true;
        gilPerHourLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        gilPerHourLabel.Location = new System.Drawing.Point(298, 44);
        gilPerHourLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        gilPerHourLabel.Name = "gilPerHourLabel";
        gilPerHourLabel.Size = new System.Drawing.Size(111, 44);
        gilPerHourLabel.TabIndex = 7;
        gilPerHourLabel.Text = "0";
        gilPerHourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // gilPerDayLabel
        // 
        gilPerDayLabel.AutoSize = true;
        gilPerDayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        gilPerDayLabel.Location = new System.Drawing.Point(298, 88);
        gilPerDayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        gilPerDayLabel.Name = "gilPerDayLabel";
        gilPerDayLabel.Size = new System.Drawing.Size(111, 58);
        gilPerDayLabel.TabIndex = 8;
        gilPerDayLabel.Text = "0";
        gilPerDayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Dock = System.Windows.Forms.DockStyle.Fill;
        label9.Location = new System.Drawing.Point(190, 44);
        label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(100, 44);
        label9.TabIndex = 10;
        label9.Text = "Average Gil per Hour:";
        label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lastSaleLabel
        // 
        lastSaleLabel.AutoSize = true;
        lastSaleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        lastSaleLabel.Location = new System.Drawing.Point(85, 88);
        lastSaleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        lastSaleLabel.Name = "lastSaleLabel";
        lastSaleLabel.Size = new System.Drawing.Size(97, 58);
        lastSaleLabel.TabIndex = 9;
        lastSaleLabel.Text = "0";
        lastSaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Dock = System.Windows.Forms.DockStyle.Fill;
        label2.Location = new System.Drawing.Point(4, 88);
        label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(73, 58);
        label2.TabIndex = 4;
        label2.Text = "Last Sale:";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Dock = System.Windows.Forms.DockStyle.Fill;
        label10.Location = new System.Drawing.Point(190, 88);
        label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(100, 58);
        label10.TabIndex = 11;
        label10.Text = "Average Gil per Day:";
        label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Dock = System.Windows.Forms.DockStyle.Fill;
        label4.Location = new System.Drawing.Point(417, 0);
        label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(125, 44);
        label4.TabIndex = 12;
        label4.Text = "Average Gil per Sale:";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // gilPerSaleLabel
        // 
        gilPerSaleLabel.AutoSize = true;
        gilPerSaleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        gilPerSaleLabel.Location = new System.Drawing.Point(550, 0);
        gilPerSaleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        gilPerSaleLabel.Name = "gilPerSaleLabel";
        gilPerSaleLabel.Size = new System.Drawing.Size(103, 44);
        gilPerSaleLabel.TabIndex = 13;
        gilPerSaleLabel.Text = "0";
        gilPerSaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Dock = System.Windows.Forms.DockStyle.Fill;
        label7.Location = new System.Drawing.Point(417, 44);
        label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(125, 44);
        label7.TabIndex = 14;
        label7.Text = "Average Gil per Item:";
        label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // gilPerItemLabel
        // 
        gilPerItemLabel.AutoSize = true;
        gilPerItemLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        gilPerItemLabel.Location = new System.Drawing.Point(550, 44);
        gilPerItemLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        gilPerItemLabel.Name = "gilPerItemLabel";
        gilPerItemLabel.Size = new System.Drawing.Size(103, 44);
        gilPerItemLabel.TabIndex = 15;
        gilPerItemLabel.Text = "0";
        gilPerItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // salesTab
        // 
        salesTab.Controls.Add(salesDataGrid);
        salesTab.Location = new System.Drawing.Point(4, 24);
        salesTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        salesTab.Name = "salesTab";
        salesTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        salesTab.Size = new System.Drawing.Size(673, 619);
        salesTab.TabIndex = 1;
        salesTab.Text = "Full Sales List";
        salesTab.UseVisualStyleBackColor = true;
        // 
        // salesDataGrid
        // 
        salesDataGrid.AllowUserToAddRows = false;
        salesDataGrid.AllowUserToDeleteRows = false;
        salesDataGrid.AutoGenerateColumns = false;
        salesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        salesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        salesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { salesDateTimeDataGridViewTextBoxColumn, amountSoldDataGridViewTextBoxColumn, itemSoldDataGridViewTextBoxColumn, itemIdDataGridViewTextBoxColumn, soldPriceDataGridViewTextBoxColumn });
        salesDataGrid.DataSource = saleBindingSource;
        salesDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
        salesDataGrid.Location = new System.Drawing.Point(4, 3);
        salesDataGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        salesDataGrid.Name = "salesDataGrid";
        salesDataGrid.ReadOnly = true;
        salesDataGrid.Size = new System.Drawing.Size(665, 613);
        salesDataGrid.TabIndex = 0;
        // 
        // salesDateTimeDataGridViewTextBoxColumn
        // 
        salesDateTimeDataGridViewTextBoxColumn.DataPropertyName = "SalesDateTime";
        salesDateTimeDataGridViewTextBoxColumn.FillWeight = 109.1371F;
        salesDateTimeDataGridViewTextBoxColumn.HeaderText = "Time";
        salesDateTimeDataGridViewTextBoxColumn.Name = "salesDateTimeDataGridViewTextBoxColumn";
        salesDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
        salesDateTimeDataGridViewTextBoxColumn.ToolTipText = "Time this sale occurred.";
        salesDateTimeDataGridViewTextBoxColumn.Width = 136;
        // 
        // amountSoldDataGridViewTextBoxColumn
        // 
        amountSoldDataGridViewTextBoxColumn.DataPropertyName = "AmountSold";
        amountSoldDataGridViewTextBoxColumn.FillWeight = 49.42074F;
        amountSoldDataGridViewTextBoxColumn.HeaderText = "Amount";
        amountSoldDataGridViewTextBoxColumn.Name = "amountSoldDataGridViewTextBoxColumn";
        amountSoldDataGridViewTextBoxColumn.ReadOnly = true;
        amountSoldDataGridViewTextBoxColumn.ToolTipText = "Amount of items sold this sale.";
        amountSoldDataGridViewTextBoxColumn.Width = 61;
        // 
        // itemSoldDataGridViewTextBoxColumn
        // 
        itemSoldDataGridViewTextBoxColumn.DataPropertyName = "ItemSold";
        itemSoldDataGridViewTextBoxColumn.FillWeight = 211.7555F;
        itemSoldDataGridViewTextBoxColumn.HeaderText = "Item";
        itemSoldDataGridViewTextBoxColumn.Name = "itemSoldDataGridViewTextBoxColumn";
        itemSoldDataGridViewTextBoxColumn.ReadOnly = true;
        itemSoldDataGridViewTextBoxColumn.ToolTipText = "Item name of the sale.";
        itemSoldDataGridViewTextBoxColumn.Width = 264;
        // 
        // itemIdDataGridViewTextBoxColumn
        // 
        itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
        itemIdDataGridViewTextBoxColumn.FillWeight = 52.26362F;
        itemIdDataGridViewTextBoxColumn.HeaderText = "ItemId";
        itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
        itemIdDataGridViewTextBoxColumn.ReadOnly = true;
        itemIdDataGridViewTextBoxColumn.ToolTipText = "Item Id of the sold item.";
        itemIdDataGridViewTextBoxColumn.Width = 65;
        // 
        // soldPriceDataGridViewTextBoxColumn
        // 
        soldPriceDataGridViewTextBoxColumn.DataPropertyName = "SoldPrice";
        soldPriceDataGridViewTextBoxColumn.FillWeight = 77.42311F;
        soldPriceDataGridViewTextBoxColumn.HeaderText = "Price";
        soldPriceDataGridViewTextBoxColumn.Name = "soldPriceDataGridViewTextBoxColumn";
        soldPriceDataGridViewTextBoxColumn.ReadOnly = true;
        soldPriceDataGridViewTextBoxColumn.ToolTipText = "Total price of the sale.";
        soldPriceDataGridViewTextBoxColumn.Width = 96;
        // 
        // saleBindingSource
        // 
        saleBindingSource.DataSource = typeof(SalesTracker.Sale);
        // 
        // logTabPage
        // 
        logTabPage.Controls.Add(logListBox);
        logTabPage.Location = new System.Drawing.Point(4, 24);
        logTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        logTabPage.Name = "logTabPage";
        logTabPage.Size = new System.Drawing.Size(673, 619);
        logTabPage.TabIndex = 2;
        logTabPage.Text = "Sales Logs";
        logTabPage.UseVisualStyleBackColor = true;
        // 
        // logListBox
        // 
        logListBox.Dock = System.Windows.Forms.DockStyle.Fill;
        logListBox.FormattingEnabled = true;
        logListBox.ItemHeight = 15;
        logListBox.Location = new System.Drawing.Point(0, 0);
        logListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        logListBox.Name = "logListBox";
        logListBox.Size = new System.Drawing.Size(673, 619);
        logListBox.TabIndex = 0;
        // 
        // selectedSalesPage
        // 
        selectedSalesPage.Controls.Add(rangeSalesDataGrid);
        selectedSalesPage.Location = new System.Drawing.Point(4, 24);
        selectedSalesPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        selectedSalesPage.Name = "selectedSalesPage";
        selectedSalesPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        selectedSalesPage.Size = new System.Drawing.Size(673, 619);
        selectedSalesPage.TabIndex = 3;
        selectedSalesPage.Text = "Selected Sales Range";
        selectedSalesPage.UseVisualStyleBackColor = true;
        // 
        // rangeSalesDataGrid
        // 
        rangeSalesDataGrid.AutoGenerateColumns = false;
        rangeSalesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        rangeSalesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { salesDateTimeDataGridViewTextBoxColumn1, amountSoldDataGridViewTextBoxColumn1, itemSoldDataGridViewTextBoxColumn1, itemIdDataGridViewTextBoxColumn1, soldPriceDataGridViewTextBoxColumn1 });
        rangeSalesDataGrid.DataSource = saleBindingSource;
        rangeSalesDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
        rangeSalesDataGrid.Location = new System.Drawing.Point(4, 3);
        rangeSalesDataGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        rangeSalesDataGrid.Name = "rangeSalesDataGrid";
        rangeSalesDataGrid.Size = new System.Drawing.Size(665, 613);
        rangeSalesDataGrid.TabIndex = 0;
        // 
        // salesDateTimeDataGridViewTextBoxColumn1
        // 
        salesDateTimeDataGridViewTextBoxColumn1.DataPropertyName = "SalesDateTime";
        salesDateTimeDataGridViewTextBoxColumn1.HeaderText = "SalesDateTime";
        salesDateTimeDataGridViewTextBoxColumn1.Name = "salesDateTimeDataGridViewTextBoxColumn1";
        salesDateTimeDataGridViewTextBoxColumn1.Width = 100;
        // 
        // amountSoldDataGridViewTextBoxColumn1
        // 
        amountSoldDataGridViewTextBoxColumn1.DataPropertyName = "AmountSold";
        amountSoldDataGridViewTextBoxColumn1.HeaderText = "AmountSold";
        amountSoldDataGridViewTextBoxColumn1.Name = "amountSoldDataGridViewTextBoxColumn1";
        amountSoldDataGridViewTextBoxColumn1.Width = 100;
        // 
        // itemSoldDataGridViewTextBoxColumn1
        // 
        itemSoldDataGridViewTextBoxColumn1.DataPropertyName = "ItemSold";
        itemSoldDataGridViewTextBoxColumn1.HeaderText = "ItemSold";
        itemSoldDataGridViewTextBoxColumn1.Name = "itemSoldDataGridViewTextBoxColumn1";
        itemSoldDataGridViewTextBoxColumn1.Width = 100;
        // 
        // itemIdDataGridViewTextBoxColumn1
        // 
        itemIdDataGridViewTextBoxColumn1.DataPropertyName = "ItemId";
        itemIdDataGridViewTextBoxColumn1.HeaderText = "ItemId";
        itemIdDataGridViewTextBoxColumn1.Name = "itemIdDataGridViewTextBoxColumn1";
        itemIdDataGridViewTextBoxColumn1.Width = 100;
        // 
        // soldPriceDataGridViewTextBoxColumn1
        // 
        soldPriceDataGridViewTextBoxColumn1.DataPropertyName = "SoldPrice";
        soldPriceDataGridViewTextBoxColumn1.HeaderText = "SoldPrice";
        soldPriceDataGridViewTextBoxColumn1.Name = "soldPriceDataGridViewTextBoxColumn1";
        soldPriceDataGridViewTextBoxColumn1.Width = 100;
        // 
        // settingsFormBindingSource
        // 
        settingsFormBindingSource.DataSource = typeof(SalesTracker.SettingsForm);
        // 
        // SettingsForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(681, 647);
        Controls.Add(tabControl1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        //Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "RB Statistics";
        Load += SettingsForm_Load;
        tabControl1.ResumeLayout(false);
        statsTab.ResumeLayout(false);
        daterange.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel2.PerformLayout();
        statsGroupBox.ResumeLayout(false);
        statsGroupBox.PerformLayout();
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        salesTab.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)salesDataGrid).EndInit();
        ((System.ComponentModel.ISupportInitialize)saleBindingSource).EndInit();
        logTabPage.ResumeLayout(false);
        selectedSalesPage.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)rangeSalesDataGrid).EndInit();
        ((System.ComponentModel.ISupportInitialize)settingsFormBindingSource).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridViewTextBoxColumn amountSoldDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn itemSoldDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn salesDateTimeDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn soldPriceDataGridViewTextBoxColumn1;

    private System.Windows.Forms.DataGridView rangeSalesDataGrid;

    private System.Windows.Forms.TabPage selectedSalesPage;

    private System.Windows.Forms.Button setDateButton;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.CheckBox fullRangeCheckbox;

    private System.Windows.Forms.DateTimePicker endDate;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label8;

    private System.Windows.Forms.GroupBox daterange;

    private System.Windows.Forms.Button resetButton;
    private System.Windows.Forms.DateTimePicker startDate;

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage statsTab;
    private System.Windows.Forms.TabPage salesTab;
    private System.Windows.Forms.DataGridView salesDataGrid;
    private System.Windows.Forms.TabPage logTabPage;
    private System.Windows.Forms.ListBox logListBox;
    private System.Windows.Forms.GroupBox statsGroupBox;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label gilLabel;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label salesLabel;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label totalSoldLabel;
    private System.Windows.Forms.Label gilPerHourLabel;
    private System.Windows.Forms.Label gilPerDayLabel;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label lastSaleLabel;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label gilPerSaleLabel;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label gilPerItemLabel;
    private System.Windows.Forms.BindingSource settingsFormBindingSource;
    private System.Windows.Forms.BindingSource saleBindingSource;
    private System.Windows.Forms.DataGridViewTextBoxColumn salesDateTimeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn amountSoldDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn itemSoldDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn soldPriceDataGridViewTextBoxColumn;
    private System.Windows.Forms.CheckBox verboseCheckbox;
}