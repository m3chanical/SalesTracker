
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.statsTab = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
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
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.salesTab = new System.Windows.Forms.TabPage();
            this.salesDataGrid = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.logTabPage = new System.Windows.Forms.TabPage();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.statsTab.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.statsGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.salesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGrid)).BeginInit();
            this.logTabPage.SuspendLayout();
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
            this.statsTab.Controls.Add(this.flowLayoutPanel1);
            this.statsTab.Location = new System.Drawing.Point(4, 22);
            this.statsTab.Name = "statsTab";
            this.statsTab.Padding = new System.Windows.Forms.Padding(3);
            this.statsTab.Size = new System.Drawing.Size(576, 535);
            this.statsTab.TabIndex = 0;
            this.statsTab.Text = "Statistics";
            this.statsTab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.statsGroupBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(570, 529);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // statsGroupBox
            // 
            this.statsGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.statsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.statsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.statsGroupBox.Name = "statsGroupBox";
            this.statsGroupBox.Size = new System.Drawing.Size(323, 211);
            this.statsGroupBox.TabIndex = 2;
            this.statsGroupBox.TabStop = false;
            this.statsGroupBox.Text = "Gil Statistics";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Controls.Add(this.gilLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.salesLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.totalSoldLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.gilPerHourLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.gilPerDayLabel, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(317, 192);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gilLabel
            // 
            this.gilLabel.AutoSize = true;
            this.gilLabel.Location = new System.Drawing.Point(89, 86);
            this.gilLabel.Name = "gilLabel";
            this.gilLabel.Size = new System.Drawing.Size(13, 13);
            this.gilLabel.TabIndex = 3;
            this.gilLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gil Earned:";
            // 
            // salesLabel
            // 
            this.salesLabel.AutoSize = true;
            this.salesLabel.Location = new System.Drawing.Point(89, 0);
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
            this.label5.Location = new System.Drawing.Point(175, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Items Sold:";
            // 
            // totalSoldLabel
            // 
            this.totalSoldLabel.AutoSize = true;
            this.totalSoldLabel.Location = new System.Drawing.Point(267, 0);
            this.totalSoldLabel.Name = "totalSoldLabel";
            this.totalSoldLabel.Size = new System.Drawing.Size(13, 13);
            this.totalSoldLabel.TabIndex = 5;
            this.totalSoldLabel.Text = "0";
            // 
            // gilPerHourLabel
            // 
            this.gilPerHourLabel.AutoSize = true;
            this.gilPerHourLabel.Location = new System.Drawing.Point(267, 86);
            this.gilPerHourLabel.Name = "gilPerHourLabel";
            this.gilPerHourLabel.Size = new System.Drawing.Size(13, 13);
            this.gilPerHourLabel.TabIndex = 7;
            this.gilPerHourLabel.Text = "0";
            // 
            // gilPerDayLabel
            // 
            this.gilPerDayLabel.AutoSize = true;
            this.gilPerDayLabel.Location = new System.Drawing.Point(267, 172);
            this.gilPerDayLabel.Name = "gilPerDayLabel";
            this.gilPerDayLabel.Size = new System.Drawing.Size(13, 13);
            this.gilPerDayLabel.TabIndex = 8;
            this.gilPerDayLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Gil per Hour:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Sale:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(175, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Gil per Day:";
            // 
            // salesTab
            // 
            this.salesTab.Controls.Add(this.deleteButton);
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
            this.salesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.salesDataGrid.Location = new System.Drawing.Point(3, 3);
            this.salesDataGrid.Name = "salesDataGrid";
            this.salesDataGrid.ReadOnly = true;
            this.salesDataGrid.Size = new System.Drawing.Size(570, 500);
            this.salesDataGrid.TabIndex = 0;
            this.salesDataGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.salesDataGrid_RowsAdded);
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deleteButton.Location = new System.Drawing.Point(3, 509);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(570, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete Row";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
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
            this.flowLayoutPanel1.ResumeLayout(false);
            this.statsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.salesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGrid)).EndInit();
            this.logTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage statsTab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox statsGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label gilLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label salesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalSoldLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage salesTab;
        private System.Windows.Forms.DataGridView salesDataGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label gilPerHourLabel;
        private System.Windows.Forms.Label gilPerDayLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TabPage logTabPage;
        private System.Windows.Forms.ListBox logListBox;
    }
}