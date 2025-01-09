namespace EpplusSample
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.nightForm1 = new ReaLTaiizor.Forms.NightForm();
            this.Pages = new ReaLTaiizor.Controls.MaterialTabControl();
            this.ExcelCreator = new System.Windows.Forms.TabPage();
            this.excelExporter1 = new EpplusSample.UserControls.ExcelExporter();
            this.ExcelExisting = new System.Windows.Forms.TabPage();
            this.formatExcel1 = new EpplusSample.UserControls.FormatExcel();
            this.ViewPage = new System.Windows.Forms.TabPage();
            this.dataViews2 = new EpplusSample.UserControls.DataViews();
            this.HelpPage = new System.Windows.Forms.TabPage();
            this.HelpImage = new System.Windows.Forms.PictureBox();
            this.GetHelp = new ReaLTaiizor.Controls.ForeverButton();
            this.nightLabel23 = new ReaLTaiizor.Controls.NightLabel();
            this.nightLabel24 = new ReaLTaiizor.Controls.NightLabel();
            this.nightHeaderLabel5 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightPanel1 = new ReaLTaiizor.Controls.NightPanel();
            this.ViewMenu = new ReaLTaiizor.Controls.NightPanel();
            this.ViewIcon = new System.Windows.Forms.PictureBox();
            this.LibrarySeparator = new ReaLTaiizor.Controls.SpaceSeparatorVertical();
            this.HelpMenu = new ReaLTaiizor.Controls.NightPanel();
            this.HelpIcon = new System.Windows.Forms.PictureBox();
            this.HelpSeparator = new ReaLTaiizor.Controls.SpaceSeparatorVertical();
            this.OpenExcelMenu = new ReaLTaiizor.Controls.NightPanel();
            this.GameIcon = new System.Windows.Forms.PictureBox();
            this.GameSeparator = new ReaLTaiizor.Controls.SpaceSeparatorVertical();
            this.ExcelMenu = new ReaLTaiizor.Controls.NightPanel();
            this.AppIcon = new System.Windows.Forms.PictureBox();
            this.AppSeparator = new ReaLTaiizor.Controls.SpaceSeparatorVertical();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.parrotControlEllipse1 = new ReaLTaiizor.Controls.ParrotControlEllipse();
            this.parrotControlEllipse2 = new ReaLTaiizor.Controls.ParrotControlEllipse();
            this.parrotControlEllipse3 = new ReaLTaiizor.Controls.ParrotControlEllipse();
            this.parrotControlEllipse4 = new ReaLTaiizor.Controls.ParrotControlEllipse();
            this.parrotControlEllipse5 = new ReaLTaiizor.Controls.ParrotControlEllipse();
            this.PageChanger = new System.Windows.Forms.Timer(this.components);
            this.nightForm1.SuspendLayout();
            this.Pages.SuspendLayout();
            this.ExcelCreator.SuspendLayout();
            this.ExcelExisting.SuspendLayout();
            this.ViewPage.SuspendLayout();
            this.HelpPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HelpImage)).BeginInit();
            this.nightPanel1.SuspendLayout();
            this.ViewMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewIcon)).BeginInit();
            this.HelpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HelpIcon)).BeginInit();
            this.OpenExcelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameIcon)).BeginInit();
            this.ExcelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // nightForm1
            // 
            this.nightForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.nightForm1.Controls.Add(this.Pages);
            this.nightForm1.Controls.Add(this.nightPanel1);
            this.nightForm1.Controls.Add(this.nightControlBox1);
            this.nightForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nightForm1.DrawIcon = true;
            this.nightForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightForm1.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.nightForm1.Location = new System.Drawing.Point(0, 0);
            this.nightForm1.MinimumSize = new System.Drawing.Size(100, 42);
            this.nightForm1.Name = "nightForm1";
            this.nightForm1.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.nightForm1.Size = new System.Drawing.Size(1200, 800);
            this.nightForm1.TabIndex = 0;
            this.nightForm1.Text = "Excel management";
            this.nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            this.nightForm1.TitleBarTextColor = System.Drawing.Color.Gainsboro;
            // 
            // Pages
            // 
            this.Pages.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.Pages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pages.Controls.Add(this.ExcelCreator);
            this.Pages.Controls.Add(this.ExcelExisting);
            this.Pages.Controls.Add(this.ViewPage);
            this.Pages.Controls.Add(this.HelpPage);
            this.Pages.Depth = 0;
            this.Pages.ItemSize = new System.Drawing.Size(0, 20);
            this.Pages.Location = new System.Drawing.Point(75, 31);
            this.Pages.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.Pages.Multiline = true;
            this.Pages.Name = "Pages";
            this.Pages.Padding = new System.Drawing.Point(0, 0);
            this.Pages.SelectedIndex = 0;
            this.Pages.Size = new System.Drawing.Size(1126, 769);
            this.Pages.TabIndex = 5;
            // 
            // ExcelCreator
            // 
            this.ExcelCreator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ExcelCreator.Controls.Add(this.excelExporter1);
            this.ExcelCreator.Location = new System.Drawing.Point(4, 4);
            this.ExcelCreator.Name = "ExcelCreator";
            this.ExcelCreator.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.ExcelCreator.Size = new System.Drawing.Size(1098, 761);
            this.ExcelCreator.TabIndex = 1;
            this.ExcelCreator.Text = "ExcelPage";
            // 
            // excelExporter1
            // 
            this.excelExporter1.BackColor = System.Drawing.Color.Transparent;
            this.excelExporter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.excelExporter1.Location = new System.Drawing.Point(0, 0);
            this.excelExporter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.excelExporter1.Name = "excelExporter1";
            this.excelExporter1.Size = new System.Drawing.Size(1098, 741);
            this.excelExporter1.TabIndex = 0;
            this.excelExporter1.Load += new System.EventHandler(this.excelExporter1_Load);
            // 
            // ExcelExisting
            // 
            this.ExcelExisting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ExcelExisting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExcelExisting.Controls.Add(this.formatExcel1);
            this.ExcelExisting.Location = new System.Drawing.Point(4, 4);
            this.ExcelExisting.Name = "ExcelExisting";
            this.ExcelExisting.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.ExcelExisting.Size = new System.Drawing.Size(1098, 761);
            this.ExcelExisting.TabIndex = 2;
            this.ExcelExisting.Text = "Open Excel File";
            // 
            // formatExcel1
            // 
            this.formatExcel1.BackColor = System.Drawing.Color.Transparent;
            this.formatExcel1.Location = new System.Drawing.Point(18, 18);
            this.formatExcel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formatExcel1.Name = "formatExcel1";
            this.formatExcel1.Size = new System.Drawing.Size(1025, 628);
            this.formatExcel1.TabIndex = 0;
            // 
            // ViewPage
            // 
            this.ViewPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ViewPage.Controls.Add(this.dataViews2);
            this.ViewPage.Location = new System.Drawing.Point(4, 4);
            this.ViewPage.Name = "ViewPage";
            this.ViewPage.Size = new System.Drawing.Size(1098, 761);
            this.ViewPage.TabIndex = 5;
            this.ViewPage.Text = "View Managemnt";
            // 
            // dataViews2
            // 
            this.dataViews2.BackColor = System.Drawing.Color.Transparent;
            this.dataViews2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViews2.Location = new System.Drawing.Point(0, 0);
            this.dataViews2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataViews2.Name = "dataViews2";
            this.dataViews2.Size = new System.Drawing.Size(1098, 761);
            this.dataViews2.TabIndex = 0;
            // 
            // HelpPage
            // 
            this.HelpPage.AutoScroll = true;
            this.HelpPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.HelpPage.Controls.Add(this.HelpImage);
            this.HelpPage.Controls.Add(this.GetHelp);
            this.HelpPage.Controls.Add(this.nightLabel23);
            this.HelpPage.Controls.Add(this.nightLabel24);
            this.HelpPage.Controls.Add(this.nightHeaderLabel5);
            this.HelpPage.Location = new System.Drawing.Point(4, 4);
            this.HelpPage.Name = "HelpPage";
            this.HelpPage.Padding = new System.Windows.Forms.Padding(20);
            this.HelpPage.Size = new System.Drawing.Size(1098, 761);
            this.HelpPage.TabIndex = 4;
            this.HelpPage.Text = "HelpPage";
            // 
            // HelpImage
            // 
            this.HelpImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpImage.BackColor = System.Drawing.Color.Transparent;
            this.HelpImage.Image = ((System.Drawing.Image)(resources.GetObject("HelpImage.Image")));
            this.HelpImage.Location = new System.Drawing.Point(31, 154);
            this.HelpImage.Name = "HelpImage";
            this.HelpImage.Size = new System.Drawing.Size(1043, 584);
            this.HelpImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HelpImage.TabIndex = 8;
            this.HelpImage.TabStop = false;
            // 
            // GetHelp
            // 
            this.GetHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetHelp.BackColor = System.Drawing.Color.Transparent;
            this.GetHelp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(198)))), ((int)(((byte)(211)))));
            this.GetHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetHelp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GetHelp.Location = new System.Drawing.Point(941, 69);
            this.GetHelp.Name = "GetHelp";
            this.GetHelp.Rounded = true;
            this.GetHelp.Size = new System.Drawing.Size(133, 44);
            this.GetHelp.TabIndex = 7;
            this.GetHelp.Text = "Get help";
            this.GetHelp.TextColor = System.Drawing.Color.Black;
            this.GetHelp.Click += new System.EventHandler(this.GetHelp_Click);
            // 
            // nightLabel23
            // 
            this.nightLabel23.AutoSize = true;
            this.nightLabel23.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel23.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nightLabel23.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nightLabel23.Location = new System.Drawing.Point(27, 96);
            this.nightLabel23.Margin = new System.Windows.Forms.Padding(3);
            this.nightLabel23.Name = "nightLabel23";
            this.nightLabel23.Size = new System.Drawing.Size(292, 21);
            this.nightLabel23.TabIndex = 6;
            this.nightLabel23.Text = "Get additional help by clicking \"Get help\"";
            this.nightLabel23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nightLabel24
            // 
            this.nightLabel24.AutoSize = true;
            this.nightLabel24.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.nightLabel24.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nightLabel24.Location = new System.Drawing.Point(27, 69);
            this.nightLabel24.Margin = new System.Windows.Forms.Padding(3);
            this.nightLabel24.Name = "nightLabel24";
            this.nightLabel24.Size = new System.Drawing.Size(76, 21);
            this.nightLabel24.TabIndex = 5;
            this.nightLabel24.Text = "Get Help";
            this.nightLabel24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nightHeaderLabel5
            // 
            this.nightHeaderLabel5.AutoSize = true;
            this.nightHeaderLabel5.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.nightHeaderLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel5.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel5.Location = new System.Drawing.Point(23, 23);
            this.nightHeaderLabel5.Margin = new System.Windows.Forms.Padding(3);
            this.nightHeaderLabel5.Name = "nightHeaderLabel5";
            this.nightHeaderLabel5.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel5.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel5.Size = new System.Drawing.Size(73, 40);
            this.nightHeaderLabel5.TabIndex = 4;
            this.nightHeaderLabel5.Text = "Help";
            this.nightHeaderLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel5.UseCompatibleTextRendering = true;
            // 
            // nightPanel1
            // 
            this.nightPanel1.Controls.Add(this.ViewMenu);
            this.nightPanel1.Controls.Add(this.HelpMenu);
            this.nightPanel1.Controls.Add(this.OpenExcelMenu);
            this.nightPanel1.Controls.Add(this.ExcelMenu);
            this.nightPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.nightPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightPanel1.LeftSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.nightPanel1.Location = new System.Drawing.Point(0, 31);
            this.nightPanel1.Name = "nightPanel1";
            this.nightPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.nightPanel1.RightSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.nightPanel1.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Right;
            this.nightPanel1.Size = new System.Drawing.Size(75, 769);
            this.nightPanel1.TabIndex = 1;
            // 
            // ViewMenu
            // 
            this.ViewMenu.Controls.Add(this.ViewIcon);
            this.ViewMenu.Controls.Add(this.LibrarySeparator);
            this.ViewMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ViewMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ViewMenu.LeftSideColor = System.Drawing.Color.Transparent;
            this.ViewMenu.Location = new System.Drawing.Point(5, 634);
            this.ViewMenu.Name = "ViewMenu";
            this.ViewMenu.Padding = new System.Windows.Forms.Padding(5);
            this.ViewMenu.RightSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.ViewMenu.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            this.ViewMenu.Size = new System.Drawing.Size(65, 65);
            this.ViewMenu.TabIndex = 7;
            this.ViewMenu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // ViewIcon
            // 
            this.ViewIcon.Enabled = false;
            this.ViewIcon.Image = ((System.Drawing.Image)(resources.GetObject("ViewIcon.Image")));
            this.ViewIcon.Location = new System.Drawing.Point(18, 17);
            this.ViewIcon.Name = "ViewIcon";
            this.ViewIcon.Size = new System.Drawing.Size(30, 30);
            this.ViewIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ViewIcon.TabIndex = 4;
            this.ViewIcon.TabStop = false;
            // 
            // LibrarySeparator
            // 
            this.LibrarySeparator.Customization = "ICAg/yAgIP8gICD/ICAg/w==";
            this.LibrarySeparator.Enabled = false;
            this.LibrarySeparator.Font = new System.Drawing.Font("Verdana", 8F);
            this.LibrarySeparator.Image = null;
            this.LibrarySeparator.Location = new System.Drawing.Point(5, 17);
            this.LibrarySeparator.Name = "LibrarySeparator";
            this.LibrarySeparator.NoRounding = false;
            this.LibrarySeparator.Size = new System.Drawing.Size(4, 30);
            this.LibrarySeparator.TabIndex = 7;
            this.LibrarySeparator.Text = "LibrarySeparator";
            this.LibrarySeparator.Transparent = true;
            // 
            // HelpMenu
            // 
            this.HelpMenu.Controls.Add(this.HelpIcon);
            this.HelpMenu.Controls.Add(this.HelpSeparator);
            this.HelpMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HelpMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.HelpMenu.LeftSideColor = System.Drawing.Color.Transparent;
            this.HelpMenu.Location = new System.Drawing.Point(5, 699);
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Padding = new System.Windows.Forms.Padding(5);
            this.HelpMenu.RightSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.HelpMenu.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            this.HelpMenu.Size = new System.Drawing.Size(65, 65);
            this.HelpMenu.TabIndex = 5;
            this.HelpMenu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // HelpIcon
            // 
            this.HelpIcon.Enabled = false;
            this.HelpIcon.Image = ((System.Drawing.Image)(resources.GetObject("HelpIcon.Image")));
            this.HelpIcon.Location = new System.Drawing.Point(18, 17);
            this.HelpIcon.Name = "HelpIcon";
            this.HelpIcon.Size = new System.Drawing.Size(30, 30);
            this.HelpIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HelpIcon.TabIndex = 5;
            this.HelpIcon.TabStop = false;
            // 
            // HelpSeparator
            // 
            this.HelpSeparator.Customization = "ICAg/yAgIP8gICD/ICAg/w==";
            this.HelpSeparator.Enabled = false;
            this.HelpSeparator.Font = new System.Drawing.Font("Verdana", 8F);
            this.HelpSeparator.Image = null;
            this.HelpSeparator.Location = new System.Drawing.Point(5, 17);
            this.HelpSeparator.Name = "HelpSeparator";
            this.HelpSeparator.NoRounding = false;
            this.HelpSeparator.Size = new System.Drawing.Size(4, 30);
            this.HelpSeparator.TabIndex = 7;
            this.HelpSeparator.Text = "spaceSeparatorVertical4";
            this.HelpSeparator.Transparent = true;
            // 
            // OpenExcelMenu
            // 
            this.OpenExcelMenu.Controls.Add(this.GameIcon);
            this.OpenExcelMenu.Controls.Add(this.GameSeparator);
            this.OpenExcelMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenExcelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpenExcelMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.OpenExcelMenu.LeftSideColor = System.Drawing.Color.Transparent;
            this.OpenExcelMenu.Location = new System.Drawing.Point(5, 70);
            this.OpenExcelMenu.Name = "OpenExcelMenu";
            this.OpenExcelMenu.Padding = new System.Windows.Forms.Padding(5);
            this.OpenExcelMenu.RightSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.OpenExcelMenu.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            this.OpenExcelMenu.Size = new System.Drawing.Size(65, 65);
            this.OpenExcelMenu.TabIndex = 4;
            this.OpenExcelMenu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // GameIcon
            // 
            this.GameIcon.Enabled = false;
            this.GameIcon.Image = global::EpplusSample.Properties.Resources.OpenExcel;
            this.GameIcon.Location = new System.Drawing.Point(18, 17);
            this.GameIcon.Name = "GameIcon";
            this.GameIcon.Size = new System.Drawing.Size(30, 30);
            this.GameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GameIcon.TabIndex = 2;
            this.GameIcon.TabStop = false;
            // 
            // GameSeparator
            // 
            this.GameSeparator.Customization = "ICAg/yAgIP8gICD/ICAg/w==";
            this.GameSeparator.Enabled = false;
            this.GameSeparator.Font = new System.Drawing.Font("Verdana", 8F);
            this.GameSeparator.Image = null;
            this.GameSeparator.Location = new System.Drawing.Point(5, 17);
            this.GameSeparator.Name = "GameSeparator";
            this.GameSeparator.NoRounding = false;
            this.GameSeparator.Size = new System.Drawing.Size(4, 30);
            this.GameSeparator.TabIndex = 7;
            this.GameSeparator.Text = "spaceSeparatorVertical3";
            this.GameSeparator.Transparent = true;
            // 
            // ExcelMenu
            // 
            this.ExcelMenu.Controls.Add(this.AppIcon);
            this.ExcelMenu.Controls.Add(this.AppSeparator);
            this.ExcelMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExcelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExcelMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ExcelMenu.LeftSideColor = System.Drawing.Color.Transparent;
            this.ExcelMenu.Location = new System.Drawing.Point(5, 5);
            this.ExcelMenu.Name = "ExcelMenu";
            this.ExcelMenu.Padding = new System.Windows.Forms.Padding(5);
            this.ExcelMenu.RightSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.ExcelMenu.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            this.ExcelMenu.Size = new System.Drawing.Size(65, 65);
            this.ExcelMenu.TabIndex = 3;
            this.ExcelMenu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // AppIcon
            // 
            this.AppIcon.Enabled = false;
            this.AppIcon.Image = global::EpplusSample.Properties.Resources.Excel;
            this.AppIcon.InitialImage = null;
            this.AppIcon.Location = new System.Drawing.Point(18, 17);
            this.AppIcon.Name = "AppIcon";
            this.AppIcon.Size = new System.Drawing.Size(30, 30);
            this.AppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AppIcon.TabIndex = 3;
            this.AppIcon.TabStop = false;
            // 
            // AppSeparator
            // 
            this.AppSeparator.BackColor = System.Drawing.Color.Transparent;
            this.AppSeparator.Customization = "ICAg/yAgIP8gICD/ICAg/w==";
            this.AppSeparator.Enabled = false;
            this.AppSeparator.Font = new System.Drawing.Font("Verdana", 8F);
            this.AppSeparator.Image = null;
            this.AppSeparator.Location = new System.Drawing.Point(5, 17);
            this.AppSeparator.Name = "AppSeparator";
            this.AppSeparator.NoRounding = false;
            this.AppSeparator.Size = new System.Drawing.Size(4, 30);
            this.AppSeparator.TabIndex = 7;
            this.AppSeparator.Text = "spaceSeparatorVertical2";
            this.AppSeparator.Transparent = true;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(-39, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 0;
            // 
            // parrotControlEllipse1
            // 
            this.parrotControlEllipse1.CornerRadius = 10;
            this.parrotControlEllipse1.EffectedControl = null;
            // 
            // parrotControlEllipse2
            // 
            this.parrotControlEllipse2.CornerRadius = 10;
            this.parrotControlEllipse2.EffectedControl = this.ExcelMenu;
            // 
            // parrotControlEllipse3
            // 
            this.parrotControlEllipse3.CornerRadius = 10;
            this.parrotControlEllipse3.EffectedControl = this.OpenExcelMenu;
            // 
            // parrotControlEllipse4
            // 
            this.parrotControlEllipse4.CornerRadius = 10;
            this.parrotControlEllipse4.EffectedControl = null;
            // 
            // parrotControlEllipse5
            // 
            this.parrotControlEllipse5.CornerRadius = 10;
            this.parrotControlEllipse5.EffectedControl = this.HelpMenu;
            // 
            // PageChanger
            // 
            this.PageChanger.Enabled = true;
            this.PageChanger.Interval = 5005;
            this.PageChanger.Tick += new System.EventHandler(this.PageChanger_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.nightForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1032);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReaLTaiizor Store";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.nightForm1.ResumeLayout(false);
            this.Pages.ResumeLayout(false);
            this.ExcelCreator.ResumeLayout(false);
            this.ExcelExisting.ResumeLayout(false);
            this.ViewPage.ResumeLayout(false);
            this.HelpPage.ResumeLayout(false);
            this.HelpPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HelpImage)).EndInit();
            this.nightPanel1.ResumeLayout(false);
            this.ViewMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewIcon)).EndInit();
            this.HelpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HelpIcon)).EndInit();
            this.OpenExcelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GameIcon)).EndInit();
            this.ExcelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private ReaLTaiizor.Forms.NightForm nightForm1;
        private ReaLTaiizor.Controls.NightPanel nightPanel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.ParrotControlEllipse parrotControlEllipse1;
        private ReaLTaiizor.Controls.SpaceSeparatorVertical GameSeparator;
        private ReaLTaiizor.Controls.NightPanel OpenExcelMenu;
        private ReaLTaiizor.Controls.SpaceSeparatorVertical HelpSeparator;
        private ReaLTaiizor.Controls.NightPanel HelpMenu;
        private ReaLTaiizor.Controls.SpaceSeparatorVertical AppSeparator;
        private ReaLTaiizor.Controls.NightPanel ExcelMenu;
        private ReaLTaiizor.Controls.ParrotControlEllipse parrotControlEllipse2;
        private System.Windows.Forms.PictureBox HelpIcon;
        private System.Windows.Forms.PictureBox GameIcon;
        private System.Windows.Forms.PictureBox AppIcon;
        private ReaLTaiizor.Controls.ParrotControlEllipse parrotControlEllipse3;
        private ReaLTaiizor.Controls.ParrotControlEllipse parrotControlEllipse4;
        private ReaLTaiizor.Controls.ParrotControlEllipse parrotControlEllipse5;
        private System.Windows.Forms.Timer PageChanger;
        private ReaLTaiizor.Controls.NightPanel ViewMenu;
        private System.Windows.Forms.PictureBox ViewIcon;
        private ReaLTaiizor.Controls.SpaceSeparatorVertical LibrarySeparator;
        private UserControls.DataViews dataViews1;
        private ReaLTaiizor.Controls.MaterialTabControl Pages;
        private System.Windows.Forms.TabPage ExcelCreator;
        private System.Windows.Forms.TabPage ExcelExisting;
        private System.Windows.Forms.TabPage HelpPage;
        private System.Windows.Forms.PictureBox HelpImage;
        private ReaLTaiizor.Controls.ForeverButton GetHelp;
        private ReaLTaiizor.Controls.NightLabel nightLabel23;
        private ReaLTaiizor.Controls.NightLabel nightLabel24;
        private ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel5;
        private System.Windows.Forms.TabPage ViewPage;
        private UserControls.DataViews dataViews2;
        private UserControls.ExcelExporter excelExporter1;
        private UserControls.FormatExcel formatExcel1;
    }
}