﻿
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
            this.settingsFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.statsTab.SuspendLayout();
            this.statsGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.salesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.salesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.saleBindingSource)).BeginInit();
            this.logTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.settingsFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.statsTab);
            this.tabControl1.Controls.Add(this.salesTab);
            this.tabControl1.Controls.Add(this.logTabPage);
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
            this.statsTab.Controls.Add(this.statsGroupBox);
            this.statsTab.Location = new System.Drawing.Point(4, 22);
            this.statsTab.Name = "statsTab";
            this.statsTab.Padding = new System.Windows.Forms.Padding(3);
            this.statsTab.Size = new System.Drawing.Size(576, 535);
            this.statsTab.TabIndex = 0;
            this.statsTab.Text = "Statistics";
            this.statsTab.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.14724F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.85276F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
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
            this.gilLabel.Location = new System.Drawing.Point(85, 38);
            this.gilLabel.Name = "gilLabel";
            this.gilLabel.Size = new System.Drawing.Size(13, 13);
            this.gilLabel.TabIndex = 3;
            this.gilLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Gil Earned:";
            // 
            // salesLabel
            // 
            this.salesLabel.AutoSize = true;
            this.salesLabel.Location = new System.Drawing.Point(85, 0);
            this.salesLabel.Name = "salesLabel";
            this.salesLabel.Size = new System.Drawing.Size(13, 13);
            this.salesLabel.TabIndex = 1;
            this.salesLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Made:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Items Sold:";
            // 
            // totalSoldLabel
            // 
            this.totalSoldLabel.AutoSize = true;
            this.totalSoldLabel.Location = new System.Drawing.Point(253, 0);
            this.totalSoldLabel.Name = "totalSoldLabel";
            this.totalSoldLabel.Size = new System.Drawing.Size(13, 13);
            this.totalSoldLabel.TabIndex = 5;
            this.totalSoldLabel.Text = "0";
            // 
            // gilPerHourLabel
            // 
            this.gilPerHourLabel.AutoSize = true;
            this.gilPerHourLabel.Location = new System.Drawing.Point(253, 38);
            this.gilPerHourLabel.Name = "gilPerHourLabel";
            this.gilPerHourLabel.Size = new System.Drawing.Size(13, 13);
            this.gilPerHourLabel.TabIndex = 7;
            this.gilPerHourLabel.Text = "0";
            // 
            // gilPerDayLabel
            // 
            this.gilPerDayLabel.AutoSize = true;
            this.gilPerDayLabel.Location = new System.Drawing.Point(253, 76);
            this.gilPerDayLabel.Name = "gilPerDayLabel";
            this.gilPerDayLabel.Size = new System.Drawing.Size(13, 13);
            this.gilPerDayLabel.TabIndex = 8;
            this.gilPerDayLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 26);
            this.label9.TabIndex = 10;
            this.label9.Text = "Average Gil per Hour:";
            // 
            // lastSaleLabel
            // 
            this.lastSaleLabel.AutoSize = true;
            this.lastSaleLabel.Location = new System.Drawing.Point(85, 76);
            this.lastSaleLabel.Name = "lastSaleLabel";
            this.lastSaleLabel.Size = new System.Drawing.Size(13, 13);
            this.lastSaleLabel.TabIndex = 9;
            this.lastSaleLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Sale:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(161, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 26);
            this.label10.TabIndex = 11;
            this.label10.Text = "Average Gil per Day:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Average Gil per Sale:";
            // 
            // gilPerSaleLabel
            // 
            this.gilPerSaleLabel.AutoSize = true;
            this.gilPerSaleLabel.Location = new System.Drawing.Point(457, 0);
            this.gilPerSaleLabel.Name = "gilPerSaleLabel";
            this.gilPerSaleLabel.Size = new System.Drawing.Size(13, 13);
            this.gilPerSaleLabel.TabIndex = 13;
            this.gilPerSaleLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Average Gil per Item:";
            // 
            // gilPerItemLabel
            // 
            this.gilPerItemLabel.AutoSize = true;
            this.gilPerItemLabel.Location = new System.Drawing.Point(457, 38);
            this.gilPerItemLabel.Name = "gilPerItemLabel";
            this.gilPerItemLabel.Size = new System.Drawing.Size(13, 13);
            this.gilPerItemLabel.TabIndex = 15;
            this.gilPerItemLabel.Text = "0";
            // 
            // salesTab
            // 
            this.salesTab.Controls.Add(this.salesDataGrid);
            this.salesTab.Location = new System.Drawing.Point(4, 22);
            this.salesTab.Name = "salesTab";
            this.salesTab.Padding = new System.Windows.Forms.Padding(3);
            this.salesTab.Size = new System.Drawing.Size(576, 535);
            this.salesTab.TabIndex = 1;
            this.salesTab.Text = "Sales List";
            this.salesTab.UseVisualStyleBackColor = true;
            // 
            // salesDataGrid
            // 
            this.salesDataGrid.AllowUserToAddRows = false;
            this.salesDataGrid.AllowUserToDeleteRows = false;
            this.salesDataGrid.AutoGenerateColumns = false;
            this.salesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.salesDateTimeDataGridViewTextBoxColumn, this.amountSoldDataGridViewTextBoxColumn, this.itemSoldDataGridViewTextBoxColumn, this.itemIdDataGridViewTextBoxColumn, this.soldPriceDataGridViewTextBoxColumn});
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
            this.salesDateTimeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.salesDateTimeDataGridViewTextBoxColumn.Name = "salesDateTimeDataGridViewTextBoxColumn";
            this.salesDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.salesDateTimeDataGridViewTextBoxColumn.ToolTipText = "Time this sale occurred.";
            // 
            // amountSoldDataGridViewTextBoxColumn
            // 
            this.amountSoldDataGridViewTextBoxColumn.DataPropertyName = "AmountSold";
            this.amountSoldDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountSoldDataGridViewTextBoxColumn.Name = "amountSoldDataGridViewTextBoxColumn";
            this.amountSoldDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountSoldDataGridViewTextBoxColumn.ToolTipText = "Amount of items sold this sale.";
            // 
            // itemSoldDataGridViewTextBoxColumn
            // 
            this.itemSoldDataGridViewTextBoxColumn.DataPropertyName = "ItemSold";
            this.itemSoldDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemSoldDataGridViewTextBoxColumn.Name = "itemSoldDataGridViewTextBoxColumn";
            this.itemSoldDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemSoldDataGridViewTextBoxColumn.ToolTipText = "Item name of the sale.";
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemIdDataGridViewTextBoxColumn.ToolTipText = "Item Id of the sold item.";
            // 
            // soldPriceDataGridViewTextBoxColumn
            // 
            this.soldPriceDataGridViewTextBoxColumn.DataPropertyName = "SoldPrice";
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
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RB Statistics";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.statsTab.ResumeLayout(false);
            this.statsGroupBox.ResumeLayout(false);
            this.statsGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.salesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.salesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.saleBindingSource)).EndInit();
            this.logTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.settingsFormBindingSource)).EndInit();
            this.ResumeLayout(false);
        }

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
    }
}