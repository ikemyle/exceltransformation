namespace EpplusSample.UserControls
{
    partial class ExcelExporter
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CreateExcel = new ReaLTaiizor.Controls.ForeverButton();
            this.nightHeaderLabel1 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.dungeonComboBox1 = new ReaLTaiizor.Controls.DungeonComboBox();
            this.nightLabel3 = new ReaLTaiizor.Controls.NightLabel();
            this.poisonDataGridView1 = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.nightLabel2 = new ReaLTaiizor.Controls.NightLabel();
            this.chkUseFormatting = new ReaLTaiizor.Controls.DungeonCheckBox();
            this.chkAutoFit = new ReaLTaiizor.Controls.DungeonCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateExcel
            // 
            this.CreateExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateExcel.BackColor = System.Drawing.Color.Transparent;
            this.CreateExcel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(198)))), ((int)(((byte)(211)))));
            this.CreateExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateExcel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CreateExcel.Location = new System.Drawing.Point(887, 46);
            this.CreateExcel.Name = "CreateExcel";
            this.CreateExcel.Rounded = true;
            this.CreateExcel.Size = new System.Drawing.Size(133, 44);
            this.CreateExcel.TabIndex = 75;
            this.CreateExcel.Text = "Create Excel";
            this.CreateExcel.TextColor = System.Drawing.Color.Black;
            this.CreateExcel.Click += new System.EventHandler(this.CreateExcel_Click);
            // 
            // nightHeaderLabel1
            // 
            this.nightHeaderLabel1.AutoSize = true;
            this.nightHeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.nightHeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel1.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel1.Location = new System.Drawing.Point(3, 13);
            this.nightHeaderLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.nightHeaderLabel1.Name = "nightHeaderLabel1";
            this.nightHeaderLabel1.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel1.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel1.Size = new System.Drawing.Size(207, 40);
            this.nightHeaderLabel1.TabIndex = 72;
            this.nightHeaderLabel1.Text = "Excel Exporter";
            this.nightHeaderLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel1.UseCompatibleTextRendering = true;
            // 
            // dungeonComboBox1
            // 
            this.dungeonComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.dungeonComboBox1.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.dungeonComboBox1.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.dungeonComboBox1.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.dungeonComboBox1.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.dungeonComboBox1.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.dungeonComboBox1.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.dungeonComboBox1.ColorG = System.Drawing.Color.WhiteSmoke;
            this.dungeonComboBox1.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(198)))), ((int)(((byte)(211)))));
            this.dungeonComboBox1.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(198)))), ((int)(((byte)(211)))));
            this.dungeonComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dungeonComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dungeonComboBox1.DropDownHeight = 100;
            this.dungeonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dungeonComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dungeonComboBox1.ForeColor = System.Drawing.Color.White;
            this.dungeonComboBox1.FormattingEnabled = true;
            this.dungeonComboBox1.HoverSelectionColor = System.Drawing.Color.Empty;
            this.dungeonComboBox1.IntegralHeight = false;
            this.dungeonComboBox1.ItemHeight = 20;
            this.dungeonComboBox1.Items.AddRange(new object[] {
            "Northwind Orders",
            "NorthWind Products",
            "NorthWind Salesmen",
            "Order Details",
            "select a db object",
            "Supplier by City",
            "Yearly Sales"});
            this.dungeonComboBox1.Location = new System.Drawing.Point(137, 82);
            this.dungeonComboBox1.Name = "dungeonComboBox1";
            this.dungeonComboBox1.Size = new System.Drawing.Size(357, 26);
            this.dungeonComboBox1.Sorted = true;
            this.dungeonComboBox1.StartIndex = 0;
            this.dungeonComboBox1.TabIndex = 82;
            this.dungeonComboBox1.SelectedValueChanged += new System.EventHandler(this.dungeonComboBox1_SelectedValueChanged);
            // 
            // nightLabel3
            // 
            this.nightLabel3.AutoSize = true;
            this.nightLabel3.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nightLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nightLabel3.Location = new System.Drawing.Point(7, 82);
            this.nightLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.nightLabel3.Name = "nightLabel3";
            this.nightLabel3.Size = new System.Drawing.Size(124, 21);
            this.nightLabel3.TabIndex = 83;
            this.nightLabel3.Text = "Data view object";
            this.nightLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // poisonDataGridView1
            // 
            this.poisonDataGridView1.AllowUserToResizeRows = false;
            this.poisonDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poisonDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.poisonDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poisonDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.poisonDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.poisonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.poisonDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.poisonDataGridView1.EnableHeadersVisualStyles = false;
            this.poisonDataGridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.poisonDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.poisonDataGridView1.Location = new System.Drawing.Point(11, 127);
            this.poisonDataGridView1.Name = "poisonDataGridView1";
            this.poisonDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.poisonDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.poisonDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.poisonDataGridView1.Size = new System.Drawing.Size(1027, 485);
            this.poisonDataGridView1.TabIndex = 84;
            this.poisonDataGridView1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // nightLabel2
            // 
            this.nightLabel2.AutoSize = true;
            this.nightLabel2.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nightLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nightLabel2.Location = new System.Drawing.Point(7, 46);
            this.nightLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.nightLabel2.Name = "nightLabel2";
            this.nightLabel2.Size = new System.Drawing.Size(214, 21);
            this.nightLabel2.TabIndex = 74;
            this.nightLabel2.Text = "Export to Excel from a dataset";
            this.nightLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkUseFormatting
            // 
            this.chkUseFormatting.BackColor = System.Drawing.Color.Transparent;
            this.chkUseFormatting.Checked = false;
            this.chkUseFormatting.CheckedBackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(85)))), ((int)(((byte)(32)))));
            this.chkUseFormatting.CheckedBackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(123)))), ((int)(((byte)(82)))));
            this.chkUseFormatting.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(88)))), ((int)(((byte)(55)))));
            this.chkUseFormatting.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chkUseFormatting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkUseFormatting.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chkUseFormatting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(95)))));
            this.chkUseFormatting.Location = new System.Drawing.Point(518, 88);
            this.chkUseFormatting.Name = "chkUseFormatting";
            this.chkUseFormatting.Size = new System.Drawing.Size(160, 15);
            this.chkUseFormatting.TabIndex = 85;
            this.chkUseFormatting.Text = "Use formatting";
            // 
            // chkAutoFit
            // 
            this.chkAutoFit.BackColor = System.Drawing.Color.Transparent;
            this.chkAutoFit.Checked = true;
            this.chkAutoFit.CheckedBackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(85)))), ((int)(((byte)(32)))));
            this.chkAutoFit.CheckedBackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(123)))), ((int)(((byte)(82)))));
            this.chkAutoFit.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(88)))), ((int)(((byte)(55)))));
            this.chkAutoFit.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chkAutoFit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAutoFit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chkAutoFit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(95)))));
            this.chkAutoFit.Location = new System.Drawing.Point(695, 88);
            this.chkAutoFit.Name = "chkAutoFit";
            this.chkAutoFit.Size = new System.Drawing.Size(160, 15);
            this.chkAutoFit.TabIndex = 86;
            this.chkAutoFit.Text = "Auto fit columns";
            // 
            // ExcelExporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.chkAutoFit);
            this.Controls.Add(this.chkUseFormatting);
            this.Controls.Add(this.poisonDataGridView1);
            this.Controls.Add(this.nightLabel3);
            this.Controls.Add(this.dungeonComboBox1);
            this.Controls.Add(this.CreateExcel);
            this.Controls.Add(this.nightLabel2);
            this.Controls.Add(this.nightHeaderLabel1);
            this.Name = "ExcelExporter";
            this.Size = new System.Drawing.Size(1225, 581);
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.ForeverButton CreateExcel;
        private ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel1;
        private ReaLTaiizor.Controls.DungeonComboBox dungeonComboBox1;
        private ReaLTaiizor.Controls.NightLabel nightLabel3;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView1;
        private ReaLTaiizor.Controls.NightLabel nightLabel2;
        private ReaLTaiizor.Controls.DungeonCheckBox chkUseFormatting;
        private ReaLTaiizor.Controls.DungeonCheckBox chkAutoFit;
    }
}
