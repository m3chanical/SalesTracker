
namespace SalesTracker
{
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.statsTab = new System.Windows.Forms.TabPage();
            this.daterange = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.fullRangeCheckbox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.setDateButton = new System.Windows.Forms.Button();
            this.verboseCheckbox = new System.Windows.Forms.CheckBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.statsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gilLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.salesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalSoldLabel = new System.Windows.Forms.Label();
            this.gilPerHourLabel = new System.Windows.Forms.Label();
            this.gilPerDayLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lastSaleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gilPerSaleLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gilPerItemLabel = new System.Windows.Forms.Label();
            this.salesTab = new System.Windows.Forms.TabPage();
            this.salesDataGrid = new System.Windows.Forms.DataGridView();
            this.salesDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountSoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemSoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logTabPage = new System.Windows.Forms.TabPage();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.selectedSalesPage = new System.Windows.Forms.TabPage();
            this.rangeSalesDataGrid = new System.Windows.Forms.DataGridView();
            this.salesDateTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountSoldDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemSoldDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settingsFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.statsTab.SuspendLayout();
            this.daterange.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.statsGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.salesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            this.logTabPage.SuspendLayout();
            this.selectedSalesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rangeSalesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.statsTab);
            this.tabControl1.Controls.Add(this.salesTab);
            this.tabControl1.Controls.Add(this.logTabPage);
            this.tabControl1.Controls.Add(this.selectedSalesPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 561);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // statsTab
            // 
            this.statsTab.Controls.Add(this.daterange);
            this.statsTab.Controls.Add(this.resetButton);
            this.statsTab.Controls.Add(this.statsGroupBox);
            this.statsTab.Location = new System.Drawing.Point(4, 22);
            this.statsTab.Name = "statsTab";
            this.statsTab.Padding = new System.Windows.Forms.Padding(3);
            this.statsTab.Size = new System.Drawing.Size(576, 535);
            this.statsTab.TabIndex = 0;
            this.statsTab.Text = "Statistics";
            this.statsTab.UseVisualStyleBackColor = true;
            // 
            // daterange
            // 
            this.daterange.Controls.Add(this.tableLayoutPanel2);
            this.daterange.Dock = System.Windows.Forms.DockStyle.Top;
            this.daterange.Location = new System.Drawing.Point(3, 149);
            this.daterange.Name = "daterange";
            this.daterange.Size = new System.Drawing.Size(570, 138);
            this.daterange.TabIndex = 6;
            this.daterange.TabStop = false;
            this.daterange.Text = "Stats Date Range";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.74603F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.25397F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.Controls.Add(this.startDate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.fullRangeCheckbox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.endDate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.setDateButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.verboseCheckbox, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(564, 119);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(123, 3);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(252, 20);
            this.startDate.TabIndex = 4;
            // 
            // fullRangeCheckbox
            // 
            this.fullRangeCheckbox.Checked = true;
            this.fullRangeCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fullRangeCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullRangeCheckbox.Location = new System.Drawing.Point(3, 87);
            this.fullRangeCheckbox.Name = "fullRangeCheckbox";
            this.fullRangeCheckbox.Size = new System.Drawing.Size(114, 29);
            this.fullRangeCheckbox.TabIndex = 8;
            this.fullRangeCheckbox.Text = "Use Full Range?";
            this.fullRangeCheckbox.UseVisualStyleBackColor = true;
            this.fullRangeCheckbox.CheckedChanged += new System.EventHandler(this.fullRangeCheckbox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 42);
            this.label6.TabIndex = 5;
            this.label6.Text = "Start Date:";
            // 
            // endDate
            // 
            this.endDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endDate.Location = new System.Drawing.Point(123, 45);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(252, 20);
            this.endDate.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 42);
            this.label8.TabIndex = 7;
            this.label8.Text = "End Date:";
            // 
            // setDateButton
            // 
            this.setDateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setDateButton.Location = new System.Drawing.Point(381, 3);
            this.setDateButton.Name = "setDateButton";
            this.setDateButton.Size = new System.Drawing.Size(116, 36);
            this.setDateButton.TabIndex = 9;
            this.setDateButton.Text = "Set Dates";
            this.setDateButton.UseVisualStyleBackColor = true;
            this.setDateButton.Click += new System.EventHandler(this.setDateButton_Click);
            // 
            // verboseCheckbox
            // 
            this.verboseCheckbox.AutoSize = true;
            this.verboseCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verboseCheckbox.Location = new System.Drawing.Point(381, 87);
            this.verboseCheckbox.Name = "verboseCheckbox";
            this.verboseCheckbox.Size = new System.Drawing.Size(116, 29);
            this.verboseCheckbox.TabIndex = 10;
            this.verboseCheckbox.Text = "Verbose Logging?";
            this.verboseCheckbox.UseVisualStyleBackColor = true;
            this.verboseCheckbox.CheckedChanged += new System.EventHandler(this.verboseCheckbox_CheckedChanged);
            // 
            // resetButton
            // 
            this.resetButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resetButton.Location = new System.Drawing.Point(3, 509);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(570, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset Statistics";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // statsGroupBox
            // 
            this.statsGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.statsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.statsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.statsGroupBox.Name = "statsGroupBox";
            this.statsGroupBox.Size = new System.Drawing.Size(570, 146);
            this.statsGroupBox.TabIndex = 3;
            this.statsGroupBox.TabStop = false;
            this.statsGroupBox.Text = "Gil Statistics";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.63636F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.36364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.Controls.Add(this.gilLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.salesLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.totalSoldLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.gilPerHourLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.gilPerDayLabel, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lastSaleLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.gilPerSaleLabel, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.gilPerItemLabel, 5, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(564, 127);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gilLabel
            // 
            this.gilLabel.AutoSize = true;
            this.gilLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gilLabel.Location = new System.Drawing.Point(73, 38);
            this.gilLabel.Name = "gilLabel";
            this.gilLabel.Size = new System.Drawing.Size(85, 38);
            this.gilLabel.TabIndex = 3;
            this.gilLabel.Text = "0";
            this.gilLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Gil Earned:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salesLabel
            // 
            this.salesLabel.AutoSize = true;
            this.salesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesLabel.Location = new System.Drawing.Point(73, 0);
            this.salesLabel.Name = "salesLabel";
            this.salesLabel.Size = new System.Drawing.Size(85, 38);
            this.salesLabel.TabIndex = 1;
            this.salesLabel.Text = "0";
            this.salesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Made:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(164, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 38);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Items Sold:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalSoldLabel
            // 
            this.totalSoldLabel.AutoSize = true;
            this.totalSoldLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalSoldLabel.Location = new System.Drawing.Point(257, 0);
            this.totalSoldLabel.Name = "totalSoldLabel";
            this.totalSoldLabel.Size = new System.Drawing.Size(96, 38);
            this.totalSoldLabel.TabIndex = 5;
            this.totalSoldLabel.Text = "0";
            this.totalSoldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gilPerHourLabel
            // 
            this.gilPerHourLabel.AutoSize = true;
            this.gilPerHourLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gilPerHourLabel.Location = new System.Drawing.Point(257, 38);
            this.gilPerHourLabel.Name = "gilPerHourLabel";
            this.gilPerHourLabel.Size = new System.Drawing.Size(96, 38);
            this.gilPerHourLabel.TabIndex = 7;
            this.gilPerHourLabel.Text = "0";
            this.gilPerHourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gilPerDayLabel
            // 
            this.gilPerDayLabel.AutoSize = true;
            this.gilPerDayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gilPerDayLabel.Location = new System.Drawing.Point(257, 76);
            this.gilPerDayLabel.Name = "gilPerDayLabel";
            this.gilPerDayLabel.Size = new System.Drawing.Size(96, 51);
            this.gilPerDayLabel.TabIndex = 8;
            this.gilPerDayLabel.Text = "0";
            this.gilPerDayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(164, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 38);
            this.label9.TabIndex = 10;
            this.label9.Text = "Average Gil per Hour:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastSaleLabel
            // 
            this.lastSaleLabel.AutoSize = true;
            this.lastSaleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastSaleLabel.Location = new System.Drawing.Point(73, 76);
            this.lastSaleLabel.Name = "lastSaleLabel";
            this.lastSaleLabel.Size = new System.Drawing.Size(85, 51);
            this.lastSaleLabel.TabIndex = 9;
            this.lastSaleLabel.Text = "0";
            this.lastSaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Sale:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(164, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 51);
            this.label10.TabIndex = 11;
            this.label10.Text = "Average Gil per Day:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(359, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 38);
            this.label4.TabIndex = 12;
            this.label4.Text = "Average Gil per Sale:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gilPerSaleLabel
            // 
            this.gilPerSaleLabel.AutoSize = true;
            this.gilPerSaleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gilPerSaleLabel.Location = new System.Drawing.Point(473, 0);
            this.gilPerSaleLabel.Name = "gilPerSaleLabel";
            this.gilPerSaleLabel.Size = new System.Drawing.Size(88, 38);
            this.gilPerSaleLabel.TabIndex = 13;
            this.gilPerSaleLabel.Text = "0";
            this.gilPerSaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(359, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 38);
            this.label7.TabIndex = 14;
            this.label7.Text = "Average Gil per Item:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gilPerItemLabel
            // 
            this.gilPerItemLabel.AutoSize = true;
            this.gilPerItemLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gilPerItemLabel.Location = new System.Drawing.Point(473, 38);
            this.gilPerItemLabel.Name = "gilPerItemLabel";
            this.gilPerItemLabel.Size = new System.Drawing.Size(88, 38);
            this.gilPerItemLabel.TabIndex = 15;
            this.gilPerItemLabel.Text = "0";
            this.gilPerItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salesTab
            // 
            this.salesTab.Controls.Add(this.salesDataGrid);
            this.salesTab.Location = new System.Drawing.Point(4, 22);
            this.salesTab.Name = "salesTab";
            this.salesTab.Padding = new System.Windows.Forms.Padding(3);
            this.salesTab.Size = new System.Drawing.Size(576, 535);
            this.salesTab.TabIndex = 1;
            this.salesTab.Text = "Full Sales List";
            this.salesTab.UseVisualStyleBackColor = true;
            // 
            // salesDataGrid
            // 
            this.salesDataGrid.AllowUserToAddRows = false;
            this.salesDataGrid.AllowUserToDeleteRows = false;
            this.salesDataGrid.AutoGenerateColumns = false;
            this.salesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesDateTimeDataGridViewTextBoxColumn,
            this.amountSoldDataGridViewTextBoxColumn,
            this.itemSoldDataGridViewTextBoxColumn,
            this.itemIdDataGridViewTextBoxColumn,
            this.soldPriceDataGridViewTextBoxColumn});
            this.salesDataGrid.DataSource = this.saleBindingSource;
            this.salesDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesDataGrid.Location = new System.Drawing.Point(3, 3);
            this.salesDataGrid.Name = "salesDataGrid";
            this.salesDataGrid.ReadOnly = true;
            this.salesDataGrid.Size = new System.Drawing.Size(570, 529);
            this.salesDataGrid.TabIndex = 0;
            // 
            // salesDateTimeDataGridViewTextBoxColumn
            // 
            this.salesDateTimeDataGridViewTextBoxColumn.DataPropertyName = "SalesDateTime";
            this.salesDateTimeDataGridViewTextBoxColumn.FillWeight = 109.1371F;
            this.salesDateTimeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.salesDateTimeDataGridViewTextBoxColumn.Name = "salesDateTimeDataGridViewTextBoxColumn";
            this.salesDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.salesDateTimeDataGridViewTextBoxColumn.ToolTipText = "Time this sale occurred.";
            // 
            // amountSoldDataGridViewTextBoxColumn
            // 
            this.amountSoldDataGridViewTextBoxColumn.DataPropertyName = "AmountSold";
            this.amountSoldDataGridViewTextBoxColumn.FillWeight = 49.42074F;
            this.amountSoldDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountSoldDataGridViewTextBoxColumn.Name = "amountSoldDataGridViewTextBoxColumn";
            this.amountSoldDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountSoldDataGridViewTextBoxColumn.ToolTipText = "Amount of items sold this sale.";
            // 
            // itemSoldDataGridViewTextBoxColumn
            // 
            this.itemSoldDataGridViewTextBoxColumn.DataPropertyName = "ItemSold";
            this.itemSoldDataGridViewTextBoxColumn.FillWeight = 211.7555F;
            this.itemSoldDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemSoldDataGridViewTextBoxColumn.Name = "itemSoldDataGridViewTextBoxColumn";
            this.itemSoldDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemSoldDataGridViewTextBoxColumn.ToolTipText = "Item name of the sale.";
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.FillWeight = 52.26362F;
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemIdDataGridViewTextBoxColumn.ToolTipText = "Item Id of the sold item.";
            // 
            // soldPriceDataGridViewTextBoxColumn
            // 
            this.soldPriceDataGridViewTextBoxColumn.DataPropertyName = "SoldPrice";
            this.soldPriceDataGridViewTextBoxColumn.FillWeight = 77.42311F;
            this.soldPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.soldPriceDataGridViewTextBoxColumn.Name = "soldPriceDataGridViewTextBoxColumn";
            this.soldPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.soldPriceDataGridViewTextBoxColumn.ToolTipText = "Total price of the sale.";
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataSource = typeof(SalesTracker.Sale);
            // 
            // logTabPage
            // 
            this.logTabPage.Controls.Add(this.logListBox);
            this.logTabPage.Location = new System.Drawing.Point(4, 22);
            this.logTabPage.Name = "logTabPage";
            this.logTabPage.Size = new System.Drawing.Size(576, 535);
            this.logTabPage.TabIndex = 2;
            this.logTabPage.Text = "Sales Logs";
            this.logTabPage.UseVisualStyleBackColor = true;
            // 
            // logListBox
            // 
            this.logListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logListBox.FormattingEnabled = true;
            this.logListBox.Location = new System.Drawing.Point(0, 0);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(576, 535);
            this.logListBox.TabIndex = 0;
            // 
            // selectedSalesPage
            // 
            this.selectedSalesPage.Controls.Add(this.rangeSalesDataGrid);
            this.selectedSalesPage.Location = new System.Drawing.Point(4, 22);
            this.selectedSalesPage.Name = "selectedSalesPage";
            this.selectedSalesPage.Padding = new System.Windows.Forms.Padding(3);
            this.selectedSalesPage.Size = new System.Drawing.Size(576, 535);
            this.selectedSalesPage.TabIndex = 3;
            this.selectedSalesPage.Text = "Selected Sales Range";
            this.selectedSalesPage.UseVisualStyleBackColor = true;
            // 
            // rangeSalesDataGrid
            // 
            this.rangeSalesDataGrid.AutoGenerateColumns = false;
            this.rangeSalesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rangeSalesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesDateTimeDataGridViewTextBoxColumn1,
            this.amountSoldDataGridViewTextBoxColumn1,
            this.itemSoldDataGridViewTextBoxColumn1,
            this.itemIdDataGridViewTextBoxColumn1,
            this.soldPriceDataGridViewTextBoxColumn1});
            this.rangeSalesDataGrid.DataSource = this.saleBindingSource;
            this.rangeSalesDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rangeSalesDataGrid.Location = new System.Drawing.Point(3, 3);
            this.rangeSalesDataGrid.Name = "rangeSalesDataGrid";
            this.rangeSalesDataGrid.Size = new System.Drawing.Size(570, 529);
            this.rangeSalesDataGrid.TabIndex = 0;
            // 
            // salesDateTimeDataGridViewTextBoxColumn1
            // 
            this.salesDateTimeDataGridViewTextBoxColumn1.DataPropertyName = "SalesDateTime";
            this.salesDateTimeDataGridViewTextBoxColumn1.HeaderText = "SalesDateTime";
            this.salesDateTimeDataGridViewTextBoxColumn1.Name = "salesDateTimeDataGridViewTextBoxColumn1";
            // 
            // amountSoldDataGridViewTextBoxColumn1
            // 
            this.amountSoldDataGridViewTextBoxColumn1.DataPropertyName = "AmountSold";
            this.amountSoldDataGridViewTextBoxColumn1.HeaderText = "AmountSold";
            this.amountSoldDataGridViewTextBoxColumn1.Name = "amountSoldDataGridViewTextBoxColumn1";
            // 
            // itemSoldDataGridViewTextBoxColumn1
            // 
            this.itemSoldDataGridViewTextBoxColumn1.DataPropertyName = "ItemSold";
            this.itemSoldDataGridViewTextBoxColumn1.HeaderText = "ItemSold";
            this.itemSoldDataGridViewTextBoxColumn1.Name = "itemSoldDataGridViewTextBoxColumn1";
            // 
            // itemIdDataGridViewTextBoxColumn1
            // 
            this.itemIdDataGridViewTextBoxColumn1.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn1.HeaderText = "ItemId";
            this.itemIdDataGridViewTextBoxColumn1.Name = "itemIdDataGridViewTextBoxColumn1";
            // 
            // soldPriceDataGridViewTextBoxColumn1
            // 
            this.soldPriceDataGridViewTextBoxColumn1.DataPropertyName = "SoldPrice";
            this.soldPriceDataGridViewTextBoxColumn1.HeaderText = "SoldPrice";
            this.soldPriceDataGridViewTextBoxColumn1.Name = "soldPriceDataGridViewTextBoxColumn1";
            // 
            // settingsFormBindingSource
            // 
            this.settingsFormBindingSource.DataSource = typeof(SalesTracker.SettingsForm);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RB Statistics";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.statsTab.ResumeLayout(false);
            this.daterange.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.statsGroupBox.ResumeLayout(false);
            this.statsGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.salesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            this.logTabPage.ResumeLayout(false);
            this.selectedSalesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rangeSalesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsFormBindingSource)).EndInit();
            this.ResumeLayout(false);

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
}