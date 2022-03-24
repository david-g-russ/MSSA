namespace PersonalFinanceApp
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbcMain = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tbDash = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.pnlDGraph = new MetroSet_UI.Controls.MetroSetPanel();
            this.chtDTrans = new LiveCharts.WinForms.CartesianChart();
            this.tbcDashView = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tbDPastTrans = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.grdDPastTrans = new System.Windows.Forms.DataGridView();
            this.tbDFutTrans = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.grdDFutTrans = new System.Windows.Forms.DataGridView();
            this.pnlDCharts = new MetroSet_UI.Controls.MetroSetPanel();
            this.chtDLoans = new LiveCharts.WinForms.CartesianChart();
            this.metroSetDivider1 = new MetroSet_UI.Controls.MetroSetDivider();
            this.pieDCategory = new LiveCharts.WinForms.PieChart();
            this.tbTrans = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.pnlTGraph = new MetroSet_UI.Controls.MetroSetPanel();
            this.chtTTrans = new LiveCharts.WinForms.CartesianChart();
            this.tbcTransView = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tbTPastTrans = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.grdTPastTrans = new System.Windows.Forms.DataGridView();
            this.tbTFutTrans = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.grdTFutTrans = new System.Windows.Forms.DataGridView();
            this.tbcTrans = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tbTAdd = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.cmbTAloanID = new System.Windows.Forms.ComboBox();
            this.cmbTAcategoryID = new System.Windows.Forms.ComboBox();
            this.btnTAdd = new MetroSet_UI.Controls.MetroSetButton();
            this.lblTAloanID = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblTAcategoryID = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtTArecurIntervalDays = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblTArecurIntervalDays = new MetroSet_UI.Controls.MetroSetLabel();
            this.swTAisRecurring = new MetroSet_UI.Controls.MetroSetSwitch();
            this.lblTAisRecurring = new MetroSet_UI.Controls.MetroSetLabel();
            this.dteTAdate = new System.Windows.Forms.DateTimePicker();
            this.lblTAdate = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtTAvalue = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblTAvalue = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtTAtransName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblTAtransName = new MetroSet_UI.Controls.MetroSetLabel();
            this.tbTEdit = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.cmbTEcategoryID = new System.Windows.Forms.ComboBox();
            this.cmbTEloanID = new System.Windows.Forms.ComboBox();
            this.btnTEdit = new MetroSet_UI.Controls.MetroSetButton();
            this.lblTEloanID = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblcategoryID = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtTErecurIntervalDays = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblTErecurIntervalDays = new MetroSet_UI.Controls.MetroSetLabel();
            this.swTEisRecurring = new MetroSet_UI.Controls.MetroSetSwitch();
            this.lblTEisRecurring = new MetroSet_UI.Controls.MetroSetLabel();
            this.dteTEdate = new System.Windows.Forms.DateTimePicker();
            this.lblTEdate = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtTEvalue = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblTEvalue = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtTEtransName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblTEtransName = new MetroSet_UI.Controls.MetroSetLabel();
            this.tbTRemove = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.dteTRdate = new System.Windows.Forms.DateTimePicker();
            this.lblTRdate = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtTRvalue = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblTRvalue = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtTRtransName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblTRtransName = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnTRemove = new MetroSet_UI.Controls.MetroSetButton();
            this.tbLoans = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.pnlLGraph = new MetroSet_UI.Controls.MetroSetPanel();
            this.chtLLoans = new LiveCharts.WinForms.CartesianChart();
            this.tbcLoansView = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tbLloans = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.grdLloans = new System.Windows.Forms.DataGridView();
            this.tbcLoans = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tbLAdd = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.txtLApayment = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtLAdurationMonths = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btnLAdd = new MetroSet_UI.Controls.MetroSetButton();
            this.lblLApayment = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtLAfixedAPR = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblLAfixedAPR = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblLAdurationMonths = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtLAbalance = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblLAbalance = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtLAloanName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblLAloanName = new MetroSet_UI.Controls.MetroSetLabel();
            this.tbLEdit = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.txtLEpayment = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtLEdurationMonths = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblLEpayment = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtLEfixedAPR = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblLEfixedAPR = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblLEdurationMonths = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtLEbalance = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblLEbalance = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtLEloanName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblLEloanName = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnLEdit = new MetroSet_UI.Controls.MetroSetButton();
            this.tbLRemove = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.txtLRbalance = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblLRbalance = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtLRloanName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblLRloanName = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnLRemove = new MetroSet_UI.Controls.MetroSetButton();
            this.tbCalendar = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.pnlCalendar = new MetroSet_UI.Controls.MetroSetPanel();
            this.lblYear = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblMonth = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblSaturday = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblFri = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblThurs = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblWed = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblTuesday = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblMonday = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblSunday = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnPrevious = new MetroSet_UI.Controls.MetroSetButton();
            this.btnNext = new MetroSet_UI.Controls.MetroSetButton();
            this.flwDayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCGraph = new MetroSet_UI.Controls.MetroSetPanel();
            this.chtCTrans = new LiveCharts.WinForms.CartesianChart();
            this.tbBudget = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.tbcBudgetView = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tbCcategories = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.grdBcategories = new System.Windows.Forms.DataGridView();
            this.tbcBudget = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tbBAdd = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.btnBAdd = new MetroSet_UI.Controls.MetroSetButton();
            this.txtBAcategoryName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblBAcategoryName = new MetroSet_UI.Controls.MetroSetLabel();
            this.tbBEdit = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.txtBEcategoryName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblBEcategoryName = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnBEdit = new MetroSet_UI.Controls.MetroSetButton();
            this.tbBRemove = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.txtBRcategoryName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblBRcategoryName = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnBRemove = new MetroSet_UI.Controls.MetroSetButton();
            this.pnlBcharts = new MetroSet_UI.Controls.MetroSetPanel();
            this.pieBCategory = new LiveCharts.WinForms.PieChart();
            this.metroSetDivider2 = new MetroSet_UI.Controls.MetroSetDivider();
            this.chtBCategory = new LiveCharts.WinForms.CartesianChart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtTSusername = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblSubHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbcMain.SuspendLayout();
            this.tbDash.SuspendLayout();
            this.pnlDGraph.SuspendLayout();
            this.tbcDashView.SuspendLayout();
            this.tbDPastTrans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDPastTrans)).BeginInit();
            this.tbDFutTrans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDFutTrans)).BeginInit();
            this.pnlDCharts.SuspendLayout();
            this.tbTrans.SuspendLayout();
            this.pnlTGraph.SuspendLayout();
            this.tbcTransView.SuspendLayout();
            this.tbTPastTrans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTPastTrans)).BeginInit();
            this.tbTFutTrans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTFutTrans)).BeginInit();
            this.tbcTrans.SuspendLayout();
            this.tbTAdd.SuspendLayout();
            this.tbTEdit.SuspendLayout();
            this.tbTRemove.SuspendLayout();
            this.tbLoans.SuspendLayout();
            this.pnlLGraph.SuspendLayout();
            this.tbcLoansView.SuspendLayout();
            this.tbLloans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLloans)).BeginInit();
            this.tbcLoans.SuspendLayout();
            this.tbLAdd.SuspendLayout();
            this.tbLEdit.SuspendLayout();
            this.tbLRemove.SuspendLayout();
            this.tbCalendar.SuspendLayout();
            this.pnlCalendar.SuspendLayout();
            this.pnlCGraph.SuspendLayout();
            this.tbBudget.SuspendLayout();
            this.tbcBudgetView.SuspendLayout();
            this.tbCcategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBcategories)).BeginInit();
            this.tbcBudget.SuspendLayout();
            this.tbBAdd.SuspendLayout();
            this.tbBEdit.SuspendLayout();
            this.tbBRemove.SuspendLayout();
            this.pnlBcharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.errorProvider1.SetIconAlignment(this.metroSetControlBox1, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.metroSetControlBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(2461, 0);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "doughnut-6722291_640-removebg-preview.png");
            // 
            // tbcMain
            // 
            this.tbcMain.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.tbcMain.AnimateTime = 200;
            this.tbcMain.BackgroundColor = System.Drawing.Color.White;
            this.tbcMain.Controls.Add(this.tbDash);
            this.tbcMain.Controls.Add(this.tbTrans);
            this.tbcMain.Controls.Add(this.tbLoans);
            this.tbcMain.Controls.Add(this.tbCalendar);
            this.tbcMain.Controls.Add(this.tbBudget);
            this.tbcMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbcMain.ImageList = this.imageList1;
            this.tbcMain.IsDerivedStyle = true;
            this.tbcMain.ItemSize = new System.Drawing.Size(100, 38);
            this.tbcMain.Location = new System.Drawing.Point(12, 186);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 2;
            this.tbcMain.SelectedTextColor = System.Drawing.Color.White;
            this.tbcMain.Size = new System.Drawing.Size(2536, 1242);
            this.tbcMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcMain.Speed = 100;
            this.tbcMain.Style = MetroSet_UI.Enums.Style.Light;
            this.tbcMain.StyleManager = null;
            this.tbcMain.TabIndex = 1;
            this.tbcMain.ThemeAuthor = "Narwin";
            this.tbcMain.ThemeName = "MetroLite";
            this.tbcMain.UnselectedTextColor = System.Drawing.Color.Gray;
            this.tbcMain.UseAnimation = false;
            // 
            // tbDash
            // 
            this.tbDash.BaseColor = System.Drawing.Color.White;
            this.tbDash.Controls.Add(this.pnlDGraph);
            this.tbDash.Controls.Add(this.tbcDashView);
            this.tbDash.Controls.Add(this.pnlDCharts);
            this.tbDash.Font = null;
            this.tbDash.ImageIndex = 0;
            this.tbDash.ImageKey = null;
            this.tbDash.IsDerivedStyle = true;
            this.tbDash.Location = new System.Drawing.Point(4, 42);
            this.tbDash.Name = "tbDash";
            this.tbDash.Size = new System.Drawing.Size(2528, 1196);
            this.tbDash.Style = MetroSet_UI.Enums.Style.Light;
            this.tbDash.StyleManager = null;
            this.tbDash.TabIndex = 0;
            this.tbDash.Text = "Dashboard";
            this.tbDash.ThemeAuthor = "Narwin";
            this.tbDash.ThemeName = "MetroLite";
            this.tbDash.ToolTipText = null;
            // 
            // pnlDGraph
            // 
            this.pnlDGraph.BackgroundColor = System.Drawing.Color.White;
            this.pnlDGraph.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.pnlDGraph.BorderThickness = 1;
            this.pnlDGraph.Controls.Add(this.chtDTrans);
            this.pnlDGraph.IsDerivedStyle = true;
            this.pnlDGraph.Location = new System.Drawing.Point(46, 52);
            this.pnlDGraph.Name = "pnlDGraph";
            this.pnlDGraph.Size = new System.Drawing.Size(1065, 595);
            this.pnlDGraph.Style = MetroSet_UI.Enums.Style.Light;
            this.pnlDGraph.StyleManager = null;
            this.pnlDGraph.TabIndex = 5;
            this.pnlDGraph.ThemeAuthor = "Narwin";
            this.pnlDGraph.ThemeName = "MetroLite";
            // 
            // chtDTrans
            // 
            this.chtDTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chtDTrans.Location = new System.Drawing.Point(0, 0);
            this.chtDTrans.Name = "chtDTrans";
            this.chtDTrans.Size = new System.Drawing.Size(1065, 595);
            this.chtDTrans.TabIndex = 2;
            // 
            // tbcDashView
            // 
            this.tbcDashView.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.tbcDashView.AnimateTime = 200;
            this.tbcDashView.BackgroundColor = System.Drawing.Color.White;
            this.tbcDashView.Controls.Add(this.tbDPastTrans);
            this.tbcDashView.Controls.Add(this.tbDFutTrans);
            this.tbcDashView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbcDashView.IsDerivedStyle = true;
            this.tbcDashView.ItemSize = new System.Drawing.Size(100, 38);
            this.tbcDashView.Location = new System.Drawing.Point(1192, 52);
            this.tbcDashView.Name = "tbcDashView";
            this.tbcDashView.SelectedIndex = 0;
            this.tbcDashView.SelectedTextColor = System.Drawing.Color.White;
            this.tbcDashView.Size = new System.Drawing.Size(1293, 1103);
            this.tbcDashView.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcDashView.Speed = 100;
            this.tbcDashView.Style = MetroSet_UI.Enums.Style.Light;
            this.tbcDashView.StyleManager = null;
            this.tbcDashView.TabIndex = 4;
            this.tbcDashView.ThemeAuthor = "Narwin";
            this.tbcDashView.ThemeName = "MetroLite";
            this.tbcDashView.UnselectedTextColor = System.Drawing.Color.Gray;
            this.tbcDashView.UseAnimation = false;
            // 
            // tbDPastTrans
            // 
            this.tbDPastTrans.BaseColor = System.Drawing.Color.White;
            this.tbDPastTrans.Controls.Add(this.grdDPastTrans);
            this.tbDPastTrans.Font = null;
            this.tbDPastTrans.ImageIndex = 0;
            this.tbDPastTrans.ImageKey = null;
            this.tbDPastTrans.IsDerivedStyle = true;
            this.tbDPastTrans.Location = new System.Drawing.Point(4, 42);
            this.tbDPastTrans.Name = "tbDPastTrans";
            this.tbDPastTrans.Size = new System.Drawing.Size(1285, 1057);
            this.tbDPastTrans.Style = MetroSet_UI.Enums.Style.Light;
            this.tbDPastTrans.StyleManager = null;
            this.tbDPastTrans.TabIndex = 0;
            this.tbDPastTrans.Text = "Past Transactions";
            this.tbDPastTrans.ThemeAuthor = "Narwin";
            this.tbDPastTrans.ThemeName = "MetroLite";
            this.tbDPastTrans.ToolTipText = null;
            // 
            // grdDPastTrans
            // 
            this.grdDPastTrans.AllowUserToAddRows = false;
            this.grdDPastTrans.AllowUserToDeleteRows = false;
            this.grdDPastTrans.AllowUserToResizeColumns = false;
            this.grdDPastTrans.AllowUserToResizeRows = false;
            this.grdDPastTrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDPastTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDPastTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDPastTrans.Location = new System.Drawing.Point(0, 0);
            this.grdDPastTrans.Name = "grdDPastTrans";
            this.grdDPastTrans.ReadOnly = true;
            this.grdDPastTrans.RowHeadersWidth = 62;
            this.grdDPastTrans.RowTemplate.Height = 28;
            this.grdDPastTrans.Size = new System.Drawing.Size(1285, 1057);
            this.grdDPastTrans.TabIndex = 0;
            // 
            // tbDFutTrans
            // 
            this.tbDFutTrans.BaseColor = System.Drawing.Color.White;
            this.tbDFutTrans.Controls.Add(this.grdDFutTrans);
            this.tbDFutTrans.Font = null;
            this.tbDFutTrans.ImageIndex = 0;
            this.tbDFutTrans.ImageKey = null;
            this.tbDFutTrans.IsDerivedStyle = true;
            this.tbDFutTrans.Location = new System.Drawing.Point(4, 42);
            this.tbDFutTrans.Name = "tbDFutTrans";
            this.tbDFutTrans.Size = new System.Drawing.Size(1285, 1057);
            this.tbDFutTrans.Style = MetroSet_UI.Enums.Style.Light;
            this.tbDFutTrans.StyleManager = null;
            this.tbDFutTrans.TabIndex = 1;
            this.tbDFutTrans.Text = "Future Transactions";
            this.tbDFutTrans.ThemeAuthor = "Narwin";
            this.tbDFutTrans.ThemeName = "MetroLite";
            this.tbDFutTrans.ToolTipText = null;
            // 
            // grdDFutTrans
            // 
            this.grdDFutTrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDFutTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDFutTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDFutTrans.Location = new System.Drawing.Point(0, 0);
            this.grdDFutTrans.Name = "grdDFutTrans";
            this.grdDFutTrans.RowHeadersWidth = 62;
            this.grdDFutTrans.RowTemplate.Height = 28;
            this.grdDFutTrans.Size = new System.Drawing.Size(1285, 1057);
            this.grdDFutTrans.TabIndex = 0;
            // 
            // pnlDCharts
            // 
            this.pnlDCharts.BackgroundColor = System.Drawing.Color.White;
            this.pnlDCharts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.pnlDCharts.BorderThickness = 1;
            this.pnlDCharts.Controls.Add(this.chtDLoans);
            this.pnlDCharts.Controls.Add(this.metroSetDivider1);
            this.pnlDCharts.Controls.Add(this.pieDCategory);
            this.pnlDCharts.IsDerivedStyle = true;
            this.pnlDCharts.Location = new System.Drawing.Point(46, 690);
            this.pnlDCharts.Name = "pnlDCharts";
            this.pnlDCharts.Size = new System.Drawing.Size(1065, 465);
            this.pnlDCharts.Style = MetroSet_UI.Enums.Style.Light;
            this.pnlDCharts.StyleManager = null;
            this.pnlDCharts.TabIndex = 3;
            this.pnlDCharts.ThemeAuthor = "Narwin";
            this.pnlDCharts.ThemeName = "MetroLite";
            // 
            // chtDLoans
            // 
            this.chtDLoans.Dock = System.Windows.Forms.DockStyle.Left;
            this.chtDLoans.Location = new System.Drawing.Point(0, 0);
            this.chtDLoans.Name = "chtDLoans";
            this.chtDLoans.Size = new System.Drawing.Size(481, 465);
            this.chtDLoans.TabIndex = 3;
            // 
            // metroSetDivider1
            // 
            this.metroSetDivider1.IsDerivedStyle = true;
            this.metroSetDivider1.Location = new System.Drawing.Point(529, 31);
            this.metroSetDivider1.Name = "metroSetDivider1";
            this.metroSetDivider1.Orientation = MetroSet_UI.Enums.DividerStyle.Vertical;
            this.metroSetDivider1.Size = new System.Drawing.Size(4, 415);
            this.metroSetDivider1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetDivider1.StyleManager = null;
            this.metroSetDivider1.TabIndex = 2;
            this.metroSetDivider1.Text = "metroSetDivider1";
            this.metroSetDivider1.ThemeAuthor = "Narwin";
            this.metroSetDivider1.ThemeName = "MetroLite";
            this.metroSetDivider1.Thickness = 1;
            // 
            // pieDCategory
            // 
            this.pieDCategory.Dock = System.Windows.Forms.DockStyle.Right;
            this.pieDCategory.Location = new System.Drawing.Point(582, 0);
            this.pieDCategory.Name = "pieDCategory";
            this.pieDCategory.Size = new System.Drawing.Size(483, 465);
            this.pieDCategory.TabIndex = 1;
            // 
            // tbTrans
            // 
            this.tbTrans.BaseColor = System.Drawing.Color.White;
            this.tbTrans.Controls.Add(this.pnlTGraph);
            this.tbTrans.Controls.Add(this.tbcTransView);
            this.tbTrans.Controls.Add(this.tbcTrans);
            this.tbTrans.Font = null;
            this.tbTrans.ImageIndex = 0;
            this.tbTrans.ImageKey = null;
            this.tbTrans.IsDerivedStyle = true;
            this.tbTrans.Location = new System.Drawing.Point(4, 42);
            this.tbTrans.Name = "tbTrans";
            this.tbTrans.Size = new System.Drawing.Size(2528, 1196);
            this.tbTrans.Style = MetroSet_UI.Enums.Style.Light;
            this.tbTrans.StyleManager = null;
            this.tbTrans.TabIndex = 1;
            this.tbTrans.Text = "Transactions";
            this.tbTrans.ThemeAuthor = "Narwin";
            this.tbTrans.ThemeName = "MetroLite";
            this.tbTrans.ToolTipText = null;
            // 
            // pnlTGraph
            // 
            this.pnlTGraph.BackgroundColor = System.Drawing.Color.White;
            this.pnlTGraph.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.pnlTGraph.BorderThickness = 1;
            this.pnlTGraph.Controls.Add(this.chtTTrans);
            this.pnlTGraph.IsDerivedStyle = true;
            this.pnlTGraph.Location = new System.Drawing.Point(55, 591);
            this.pnlTGraph.Name = "pnlTGraph";
            this.pnlTGraph.Size = new System.Drawing.Size(1105, 564);
            this.pnlTGraph.Style = MetroSet_UI.Enums.Style.Light;
            this.pnlTGraph.StyleManager = null;
            this.pnlTGraph.TabIndex = 6;
            this.pnlTGraph.ThemeAuthor = "Narwin";
            this.pnlTGraph.ThemeName = "MetroLite";
            // 
            // chtTTrans
            // 
            this.chtTTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chtTTrans.Location = new System.Drawing.Point(0, 0);
            this.chtTTrans.Name = "chtTTrans";
            this.chtTTrans.Size = new System.Drawing.Size(1105, 564);
            this.chtTTrans.TabIndex = 0;
            // 
            // tbcTransView
            // 
            this.tbcTransView.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.tbcTransView.AnimateTime = 200;
            this.tbcTransView.BackgroundColor = System.Drawing.Color.White;
            this.tbcTransView.Controls.Add(this.tbTPastTrans);
            this.tbcTransView.Controls.Add(this.tbTFutTrans);
            this.tbcTransView.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbcTransView.IsDerivedStyle = true;
            this.tbcTransView.ItemSize = new System.Drawing.Size(100, 38);
            this.tbcTransView.Location = new System.Drawing.Point(1192, 52);
            this.tbcTransView.Name = "tbcTransView";
            this.tbcTransView.SelectedIndex = 0;
            this.tbcTransView.SelectedTextColor = System.Drawing.Color.White;
            this.tbcTransView.Size = new System.Drawing.Size(1293, 1103);
            this.tbcTransView.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcTransView.Speed = 100;
            this.tbcTransView.Style = MetroSet_UI.Enums.Style.Light;
            this.tbcTransView.StyleManager = null;
            this.tbcTransView.TabIndex = 5;
            this.tbcTransView.ThemeAuthor = "Narwin";
            this.tbcTransView.ThemeName = "MetroLite";
            this.tbcTransView.UnselectedTextColor = System.Drawing.Color.Gray;
            this.tbcTransView.UseAnimation = false;
            // 
            // tbTPastTrans
            // 
            this.tbTPastTrans.BaseColor = System.Drawing.Color.White;
            this.tbTPastTrans.Controls.Add(this.grdTPastTrans);
            this.tbTPastTrans.Font = null;
            this.tbTPastTrans.ImageIndex = 0;
            this.tbTPastTrans.ImageKey = null;
            this.tbTPastTrans.IsDerivedStyle = true;
            this.tbTPastTrans.Location = new System.Drawing.Point(4, 42);
            this.tbTPastTrans.Name = "tbTPastTrans";
            this.tbTPastTrans.Size = new System.Drawing.Size(1285, 1057);
            this.tbTPastTrans.Style = MetroSet_UI.Enums.Style.Light;
            this.tbTPastTrans.StyleManager = null;
            this.tbTPastTrans.TabIndex = 0;
            this.tbTPastTrans.Text = "Past Transactions";
            this.tbTPastTrans.ThemeAuthor = "Narwin";
            this.tbTPastTrans.ThemeName = "MetroLite";
            this.tbTPastTrans.ToolTipText = null;
            // 
            // grdTPastTrans
            // 
            this.grdTPastTrans.AllowUserToAddRows = false;
            this.grdTPastTrans.AllowUserToDeleteRows = false;
            this.grdTPastTrans.AllowUserToResizeColumns = false;
            this.grdTPastTrans.AllowUserToResizeRows = false;
            this.grdTPastTrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdTPastTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTPastTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTPastTrans.Location = new System.Drawing.Point(0, 0);
            this.grdTPastTrans.Name = "grdTPastTrans";
            this.grdTPastTrans.ReadOnly = true;
            this.grdTPastTrans.RowHeadersWidth = 62;
            this.grdTPastTrans.RowTemplate.Height = 28;
            this.grdTPastTrans.Size = new System.Drawing.Size(1285, 1057);
            this.grdTPastTrans.TabIndex = 0;
            this.grdTPastTrans.SelectionChanged += new System.EventHandler(this.grdTPastTrans_SelectionChanged);
            // 
            // tbTFutTrans
            // 
            this.tbTFutTrans.BaseColor = System.Drawing.Color.White;
            this.tbTFutTrans.Controls.Add(this.grdTFutTrans);
            this.tbTFutTrans.Font = null;
            this.tbTFutTrans.ImageIndex = 0;
            this.tbTFutTrans.ImageKey = null;
            this.tbTFutTrans.IsDerivedStyle = true;
            this.tbTFutTrans.Location = new System.Drawing.Point(4, 42);
            this.tbTFutTrans.Name = "tbTFutTrans";
            this.tbTFutTrans.Size = new System.Drawing.Size(1285, 1057);
            this.tbTFutTrans.Style = MetroSet_UI.Enums.Style.Light;
            this.tbTFutTrans.StyleManager = null;
            this.tbTFutTrans.TabIndex = 1;
            this.tbTFutTrans.Text = "Future Transactions";
            this.tbTFutTrans.ThemeAuthor = "Narwin";
            this.tbTFutTrans.ThemeName = "MetroLite";
            this.tbTFutTrans.ToolTipText = null;
            // 
            // grdTFutTrans
            // 
            this.grdTFutTrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdTFutTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTFutTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTFutTrans.Location = new System.Drawing.Point(0, 0);
            this.grdTFutTrans.Name = "grdTFutTrans";
            this.grdTFutTrans.RowHeadersWidth = 62;
            this.grdTFutTrans.RowTemplate.Height = 28;
            this.grdTFutTrans.Size = new System.Drawing.Size(1285, 1057);
            this.grdTFutTrans.TabIndex = 0;
            this.grdTFutTrans.SelectionChanged += new System.EventHandler(this.grdTFutTrans_SelectionChanged);
            // 
            // tbcTrans
            // 
            this.tbcTrans.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.tbcTrans.AnimateTime = 200;
            this.tbcTrans.BackgroundColor = System.Drawing.Color.White;
            this.tbcTrans.Controls.Add(this.tbTAdd);
            this.tbcTrans.Controls.Add(this.tbTEdit);
            this.tbcTrans.Controls.Add(this.tbTRemove);
            this.tbcTrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbcTrans.IsDerivedStyle = true;
            this.tbcTrans.ItemSize = new System.Drawing.Size(100, 38);
            this.tbcTrans.Location = new System.Drawing.Point(51, 52);
            this.tbcTrans.Name = "tbcTrans";
            this.tbcTrans.SelectedIndex = 0;
            this.tbcTrans.SelectedTextColor = System.Drawing.Color.White;
            this.tbcTrans.Size = new System.Drawing.Size(1113, 495);
            this.tbcTrans.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcTrans.Speed = 100;
            this.tbcTrans.Style = MetroSet_UI.Enums.Style.Light;
            this.tbcTrans.StyleManager = null;
            this.tbcTrans.TabIndex = 0;
            this.tbcTrans.ThemeAuthor = "Narwin";
            this.tbcTrans.ThemeName = "MetroLite";
            this.tbcTrans.UnselectedTextColor = System.Drawing.Color.Gray;
            this.tbcTrans.UseAnimation = false;
            // 
            // tbTAdd
            // 
            this.tbTAdd.BaseColor = System.Drawing.Color.White;
            this.tbTAdd.Controls.Add(this.cmbTAloanID);
            this.tbTAdd.Controls.Add(this.cmbTAcategoryID);
            this.tbTAdd.Controls.Add(this.btnTAdd);
            this.tbTAdd.Controls.Add(this.lblTAloanID);
            this.tbTAdd.Controls.Add(this.lblTAcategoryID);
            this.tbTAdd.Controls.Add(this.txtTArecurIntervalDays);
            this.tbTAdd.Controls.Add(this.lblTArecurIntervalDays);
            this.tbTAdd.Controls.Add(this.swTAisRecurring);
            this.tbTAdd.Controls.Add(this.lblTAisRecurring);
            this.tbTAdd.Controls.Add(this.dteTAdate);
            this.tbTAdd.Controls.Add(this.lblTAdate);
            this.tbTAdd.Controls.Add(this.txtTAvalue);
            this.tbTAdd.Controls.Add(this.lblTAvalue);
            this.tbTAdd.Controls.Add(this.txtTAtransName);
            this.tbTAdd.Controls.Add(this.lblTAtransName);
            this.tbTAdd.Font = null;
            this.tbTAdd.ImageIndex = 0;
            this.tbTAdd.ImageKey = null;
            this.tbTAdd.IsDerivedStyle = true;
            this.tbTAdd.Location = new System.Drawing.Point(4, 42);
            this.tbTAdd.Name = "tbTAdd";
            this.tbTAdd.Size = new System.Drawing.Size(1105, 449);
            this.tbTAdd.Style = MetroSet_UI.Enums.Style.Light;
            this.tbTAdd.StyleManager = null;
            this.tbTAdd.TabIndex = 0;
            this.tbTAdd.Text = "Add Transaction";
            this.tbTAdd.ThemeAuthor = "Narwin";
            this.tbTAdd.ThemeName = "MetroLite";
            this.tbTAdd.ToolTipText = null;
            // 
            // cmbTAloanID
            // 
            this.cmbTAloanID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbTAloanID.FormattingEnabled = true;
            this.cmbTAloanID.Location = new System.Drawing.Point(298, 357);
            this.cmbTAloanID.Name = "cmbTAloanID";
            this.cmbTAloanID.Size = new System.Drawing.Size(375, 33);
            this.cmbTAloanID.TabIndex = 16;
            this.cmbTAloanID.Visible = false;
            this.cmbTAloanID.Validating += new System.ComponentModel.CancelEventHandler(this.cmbTAloanID_Validating);
            this.cmbTAloanID.Validated += new System.EventHandler(this.cmbTAloanID_Validated);
            // 
            // cmbTAcategoryID
            // 
            this.cmbTAcategoryID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbTAcategoryID.FormattingEnabled = true;
            this.cmbTAcategoryID.Location = new System.Drawing.Point(298, 292);
            this.cmbTAcategoryID.Name = "cmbTAcategoryID";
            this.cmbTAcategoryID.Size = new System.Drawing.Size(375, 33);
            this.cmbTAcategoryID.TabIndex = 15;
            this.cmbTAcategoryID.SelectedValueChanged += new System.EventHandler(this.cmbTAcategoryID_SelectedValueChanged);
            this.cmbTAcategoryID.Validating += new System.ComponentModel.CancelEventHandler(this.cmbTAcategoryID_Validating);
            this.cmbTAcategoryID.Validated += new System.EventHandler(this.cmbTAcategoryID_Validated);
            // 
            // btnTAdd
            // 
            this.btnTAdd.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnTAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnTAdd.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnTAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTAdd.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnTAdd.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnTAdd.HoverTextColor = System.Drawing.Color.White;
            this.btnTAdd.IsDerivedStyle = true;
            this.btnTAdd.Location = new System.Drawing.Point(0, 426);
            this.btnTAdd.Name = "btnTAdd";
            this.btnTAdd.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnTAdd.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnTAdd.NormalTextColor = System.Drawing.Color.White;
            this.btnTAdd.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnTAdd.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnTAdd.PressTextColor = System.Drawing.Color.White;
            this.btnTAdd.Size = new System.Drawing.Size(1105, 23);
            this.btnTAdd.Style = MetroSet_UI.Enums.Style.Light;
            this.btnTAdd.StyleManager = null;
            this.btnTAdd.TabIndex = 14;
            this.btnTAdd.Text = "Add Transaction";
            this.btnTAdd.ThemeAuthor = "Narwin";
            this.btnTAdd.ThemeName = "MetroLite";
            this.btnTAdd.Click += new System.EventHandler(this.btnTAdd_Click);
            // 
            // lblTAloanID
            // 
            this.lblTAloanID.AutoSize = true;
            this.lblTAloanID.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTAloanID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTAloanID.IsDerivedStyle = true;
            this.lblTAloanID.Location = new System.Drawing.Point(0, 325);
            this.lblTAloanID.Name = "lblTAloanID";
            this.lblTAloanID.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblTAloanID.Size = new System.Drawing.Size(177, 65);
            this.lblTAloanID.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTAloanID.StyleManager = null;
            this.lblTAloanID.TabIndex = 12;
            this.lblTAloanID.Text = "Loan Applied To:";
            this.lblTAloanID.ThemeAuthor = "Narwin";
            this.lblTAloanID.ThemeName = "MetroLite";
            this.lblTAloanID.Visible = false;
            // 
            // lblTAcategoryID
            // 
            this.lblTAcategoryID.AutoSize = true;
            this.lblTAcategoryID.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTAcategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTAcategoryID.IsDerivedStyle = true;
            this.lblTAcategoryID.Location = new System.Drawing.Point(0, 260);
            this.lblTAcategoryID.Name = "lblTAcategoryID";
            this.lblTAcategoryID.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblTAcategoryID.Size = new System.Drawing.Size(221, 65);
            this.lblTAcategoryID.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTAcategoryID.StyleManager = null;
            this.lblTAcategoryID.TabIndex = 10;
            this.lblTAcategoryID.Text = "Transaction Category:";
            this.lblTAcategoryID.ThemeAuthor = "Narwin";
            this.lblTAcategoryID.ThemeName = "MetroLite";
            // 
            // txtTArecurIntervalDays
            // 
            this.txtTArecurIntervalDays.AutoCompleteCustomSource = null;
            this.txtTArecurIntervalDays.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTArecurIntervalDays.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTArecurIntervalDays.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTArecurIntervalDays.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTArecurIntervalDays.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTArecurIntervalDays.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtTArecurIntervalDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTArecurIntervalDays.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtTArecurIntervalDays.Image = null;
            this.txtTArecurIntervalDays.IsDerivedStyle = true;
            this.txtTArecurIntervalDays.Lines = null;
            this.txtTArecurIntervalDays.Location = new System.Drawing.Point(673, 230);
            this.txtTArecurIntervalDays.MaxLength = 32767;
            this.txtTArecurIntervalDays.Multiline = false;
            this.txtTArecurIntervalDays.Name = "txtTArecurIntervalDays";
            this.txtTArecurIntervalDays.ReadOnly = false;
            this.txtTArecurIntervalDays.Size = new System.Drawing.Size(375, 30);
            this.txtTArecurIntervalDays.Style = MetroSet_UI.Enums.Style.Light;
            this.txtTArecurIntervalDays.StyleManager = null;
            this.txtTArecurIntervalDays.TabIndex = 9;
            this.txtTArecurIntervalDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTArecurIntervalDays.ThemeAuthor = "Narwin";
            this.txtTArecurIntervalDays.ThemeName = "MetroLite";
            this.txtTArecurIntervalDays.UseSystemPasswordChar = false;
            this.txtTArecurIntervalDays.Visible = false;
            this.txtTArecurIntervalDays.WatermarkText = "";
            this.txtTArecurIntervalDays.Validating += new System.ComponentModel.CancelEventHandler(this.txtTArecurIntervalDays_Validating);
            this.txtTArecurIntervalDays.Validated += new System.EventHandler(this.txtTArecurIntervalDays_Validated);
            // 
            // lblTArecurIntervalDays
            // 
            this.lblTArecurIntervalDays.AutoSize = true;
            this.lblTArecurIntervalDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTArecurIntervalDays.IsDerivedStyle = true;
            this.lblTArecurIntervalDays.Location = new System.Drawing.Point(406, 233);
            this.lblTArecurIntervalDays.Name = "lblTArecurIntervalDays";
            this.lblTArecurIntervalDays.Size = new System.Drawing.Size(250, 25);
            this.lblTArecurIntervalDays.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTArecurIntervalDays.StyleManager = null;
            this.lblTArecurIntervalDays.TabIndex = 8;
            this.lblTArecurIntervalDays.Text = "Recurrance Interval (Days):";
            this.lblTArecurIntervalDays.ThemeAuthor = "Narwin";
            this.lblTArecurIntervalDays.ThemeName = "MetroLite";
            this.lblTArecurIntervalDays.Visible = false;
            // 
            // swTAisRecurring
            // 
            this.swTAisRecurring.BackColor = System.Drawing.Color.Transparent;
            this.swTAisRecurring.BackgroundColor = System.Drawing.Color.Empty;
            this.swTAisRecurring.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.swTAisRecurring.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.swTAisRecurring.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.swTAisRecurring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swTAisRecurring.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.swTAisRecurring.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.swTAisRecurring.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.swTAisRecurring.IsDerivedStyle = true;
            this.swTAisRecurring.Location = new System.Drawing.Point(298, 236);
            this.swTAisRecurring.Name = "swTAisRecurring";
            this.swTAisRecurring.Size = new System.Drawing.Size(58, 22);
            this.swTAisRecurring.Style = MetroSet_UI.Enums.Style.Light;
            this.swTAisRecurring.StyleManager = null;
            this.swTAisRecurring.Switched = false;
            this.swTAisRecurring.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.swTAisRecurring.TabIndex = 7;
            this.swTAisRecurring.Text = "swTAisRecurring";
            this.swTAisRecurring.ThemeAuthor = "Narwin";
            this.swTAisRecurring.ThemeName = "MetroLite";
            this.swTAisRecurring.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.swTAisRecurring.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.swTAisRecurring_SwitchedChanged);
            // 
            // lblTAisRecurring
            // 
            this.lblTAisRecurring.AutoSize = true;
            this.lblTAisRecurring.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTAisRecurring.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTAisRecurring.IsDerivedStyle = true;
            this.lblTAisRecurring.Location = new System.Drawing.Point(0, 195);
            this.lblTAisRecurring.Name = "lblTAisRecurring";
            this.lblTAisRecurring.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblTAisRecurring.Size = new System.Drawing.Size(224, 65);
            this.lblTAisRecurring.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTAisRecurring.StyleManager = null;
            this.lblTAisRecurring.TabIndex = 6;
            this.lblTAisRecurring.Text = "Recurring Transaction:";
            this.lblTAisRecurring.ThemeAuthor = "Narwin";
            this.lblTAisRecurring.ThemeName = "MetroLite";
            // 
            // dteTAdate
            // 
            this.dteTAdate.Location = new System.Drawing.Point(298, 165);
            this.dteTAdate.Name = "dteTAdate";
            this.dteTAdate.Size = new System.Drawing.Size(375, 30);
            this.dteTAdate.TabIndex = 5;
            this.dteTAdate.Validating += new System.ComponentModel.CancelEventHandler(this.dteTAdate_Validating);
            this.dteTAdate.Validated += new System.EventHandler(this.dteTAdate_Validated);
            // 
            // lblTAdate
            // 
            this.lblTAdate.AutoSize = true;
            this.lblTAdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTAdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTAdate.IsDerivedStyle = true;
            this.lblTAdate.Location = new System.Drawing.Point(0, 130);
            this.lblTAdate.Name = "lblTAdate";
            this.lblTAdate.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblTAdate.Size = new System.Drawing.Size(203, 65);
            this.lblTAdate.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTAdate.StyleManager = null;
            this.lblTAdate.TabIndex = 4;
            this.lblTAdate.Text = "Date of Transaction:";
            this.lblTAdate.ThemeAuthor = "Narwin";
            this.lblTAdate.ThemeName = "MetroLite";
            // 
            // txtTAvalue
            // 
            this.txtTAvalue.AutoCompleteCustomSource = null;
            this.txtTAvalue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTAvalue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTAvalue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTAvalue.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTAvalue.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTAvalue.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtTAvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTAvalue.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtTAvalue.Image = null;
            this.txtTAvalue.IsDerivedStyle = true;
            this.txtTAvalue.Lines = null;
            this.txtTAvalue.Location = new System.Drawing.Point(298, 100);
            this.txtTAvalue.MaxLength = 32767;
            this.txtTAvalue.Multiline = false;
            this.txtTAvalue.Name = "txtTAvalue";
            this.txtTAvalue.ReadOnly = false;
            this.txtTAvalue.Size = new System.Drawing.Size(375, 30);
            this.txtTAvalue.Style = MetroSet_UI.Enums.Style.Light;
            this.txtTAvalue.StyleManager = null;
            this.txtTAvalue.TabIndex = 3;
            this.txtTAvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTAvalue.ThemeAuthor = "Narwin";
            this.txtTAvalue.ThemeName = "MetroLite";
            this.txtTAvalue.UseSystemPasswordChar = false;
            this.txtTAvalue.WatermarkText = "";
            this.txtTAvalue.Validating += new System.ComponentModel.CancelEventHandler(this.txtTAvalue_Validating);
            this.txtTAvalue.Validated += new System.EventHandler(this.txtTAvalue_Validated);
            // 
            // lblTAvalue
            // 
            this.lblTAvalue.AutoSize = true;
            this.lblTAvalue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTAvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTAvalue.IsDerivedStyle = true;
            this.lblTAvalue.Location = new System.Drawing.Point(0, 65);
            this.lblTAvalue.Name = "lblTAvalue";
            this.lblTAvalue.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblTAvalue.Size = new System.Drawing.Size(213, 65);
            this.lblTAvalue.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTAvalue.StyleManager = null;
            this.lblTAvalue.TabIndex = 2;
            this.lblTAvalue.Text = "Value of Transaction:";
            this.lblTAvalue.ThemeAuthor = "Narwin";
            this.lblTAvalue.ThemeName = "MetroLite";
            // 
            // txtTAtransName
            // 
            this.txtTAtransName.AutoCompleteCustomSource = null;
            this.txtTAtransName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTAtransName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTAtransName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTAtransName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTAtransName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTAtransName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtTAtransName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTAtransName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtTAtransName.Image = null;
            this.txtTAtransName.IsDerivedStyle = true;
            this.txtTAtransName.Lines = null;
            this.txtTAtransName.Location = new System.Drawing.Point(298, 35);
            this.txtTAtransName.MaxLength = 32767;
            this.txtTAtransName.Multiline = false;
            this.txtTAtransName.Name = "txtTAtransName";
            this.txtTAtransName.ReadOnly = false;
            this.txtTAtransName.Size = new System.Drawing.Size(750, 30);
            this.txtTAtransName.Style = MetroSet_UI.Enums.Style.Light;
            this.txtTAtransName.StyleManager = null;
            this.txtTAtransName.TabIndex = 1;
            this.txtTAtransName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTAtransName.ThemeAuthor = "Narwin";
            this.txtTAtransName.ThemeName = "MetroLite";
            this.txtTAtransName.UseSystemPasswordChar = false;
            this.txtTAtransName.WatermarkText = "";
            this.txtTAtransName.Validating += new System.ComponentModel.CancelEventHandler(this.txtTAtransName_Validating);
            this.txtTAtransName.Validated += new System.EventHandler(this.txtTAtransName_Validated);
            // 
            // lblTAtransName
            // 
            this.lblTAtransName.AutoSize = true;
            this.lblTAtransName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTAtransName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTAtransName.IsDerivedStyle = true;
            this.lblTAtransName.Location = new System.Drawing.Point(0, 0);
            this.lblTAtransName.Name = "lblTAtransName";
            this.lblTAtransName.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblTAtransName.Size = new System.Drawing.Size(193, 65);
            this.lblTAtransName.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTAtransName.StyleManager = null;
            this.lblTAtransName.TabIndex = 0;
            this.lblTAtransName.Text = "Transaction Name:";
            this.lblTAtransName.ThemeAuthor = "Narwin";
            this.lblTAtransName.ThemeName = "MetroLite";
            // 
            // tbTEdit
            // 
            this.tbTEdit.BaseColor = System.Drawing.Color.White;
            this.tbTEdit.Controls.Add(this.cmbTEcategoryID);
            this.tbTEdit.Controls.Add(this.cmbTEloanID);
            this.tbTEdit.Controls.Add(this.btnTEdit);
            this.tbTEdit.Controls.Add(this.lblTEloanID);
            this.tbTEdit.Controls.Add(this.lblcategoryID);
            this.tbTEdit.Controls.Add(this.txtTErecurIntervalDays);
            this.tbTEdit.Controls.Add(this.lblTErecurIntervalDays);
            this.tbTEdit.Controls.Add(this.swTEisRecurring);
            this.tbTEdit.Controls.Add(this.lblTEisRecurring);
            this.tbTEdit.Controls.Add(this.dteTEdate);
            this.tbTEdit.Controls.Add(this.lblTEdate);
            this.tbTEdit.Controls.Add(this.txtTEvalue);
            this.tbTEdit.Controls.Add(this.lblTEvalue);
            this.tbTEdit.Controls.Add(this.txtTEtransName);
            this.tbTEdit.Controls.Add(this.lblTEtransName);
            this.tbTEdit.Font = null;
            this.tbTEdit.ImageIndex = 0;
            this.tbTEdit.ImageKey = null;
            this.tbTEdit.IsDerivedStyle = true;
            this.tbTEdit.Location = new System.Drawing.Point(4, 42);
            this.tbTEdit.Name = "tbTEdit";
            this.tbTEdit.Size = new System.Drawing.Size(1105, 449);
            this.tbTEdit.Style = MetroSet_UI.Enums.Style.Light;
            this.tbTEdit.StyleManager = null;
            this.tbTEdit.TabIndex = 1;
            this.tbTEdit.Text = "Edit Transaction";
            this.tbTEdit.ThemeAuthor = "Narwin";
            this.tbTEdit.ThemeName = "MetroLite";
            this.tbTEdit.ToolTipText = null;
            // 
            // cmbTEcategoryID
            // 
            this.cmbTEcategoryID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbTEcategoryID.FormattingEnabled = true;
            this.cmbTEcategoryID.Location = new System.Drawing.Point(298, 292);
            this.cmbTEcategoryID.Name = "cmbTEcategoryID";
            this.cmbTEcategoryID.Size = new System.Drawing.Size(375, 33);
            this.cmbTEcategoryID.TabIndex = 30;
            this.cmbTEcategoryID.SelectedValueChanged += new System.EventHandler(this.cmbTEcategoryID_SelectedValueChanged);
            this.cmbTEcategoryID.Validating += new System.ComponentModel.CancelEventHandler(this.cmbTEcategoryID_Validating);
            this.cmbTEcategoryID.Validated += new System.EventHandler(this.cmbTEcategoryID_Validated);
            // 
            // cmbTEloanID
            // 
            this.cmbTEloanID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbTEloanID.FormattingEnabled = true;
            this.cmbTEloanID.Location = new System.Drawing.Point(298, 357);
            this.cmbTEloanID.Name = "cmbTEloanID";
            this.cmbTEloanID.Size = new System.Drawing.Size(375, 33);
            this.cmbTEloanID.TabIndex = 29;
            this.cmbTEloanID.Validating += new System.ComponentModel.CancelEventHandler(this.cmbTEloanID_Validating);
            this.cmbTEloanID.Validated += new System.EventHandler(this.cmbTEloanID_Validated);
            // 
            // btnTEdit
            // 
            this.btnTEdit.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnTEdit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnTEdit.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnTEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTEdit.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnTEdit.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnTEdit.HoverTextColor = System.Drawing.Color.White;
            this.btnTEdit.IsDerivedStyle = true;
            this.btnTEdit.Location = new System.Drawing.Point(0, 426);
            this.btnTEdit.Name = "btnTEdit";
            this.btnTEdit.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnTEdit.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnTEdit.NormalTextColor = System.Drawing.Color.White;
            this.btnTEdit.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnTEdit.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnTEdit.PressTextColor = System.Drawing.Color.White;
            this.btnTEdit.Size = new System.Drawing.Size(1105, 23);
            this.btnTEdit.Style = MetroSet_UI.Enums.Style.Light;
            this.btnTEdit.StyleManager = null;
            this.btnTEdit.TabIndex = 28;
            this.btnTEdit.Text = "Edit Transaction";
            this.btnTEdit.ThemeAuthor = "Narwin";
            this.btnTEdit.ThemeName = "MetroLite";
            this.btnTEdit.Click += new System.EventHandler(this.btnTEdit_Click);
            // 
            // lblTEloanID
            // 
            this.lblTEloanID.AutoSize = true;
            this.lblTEloanID.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTEloanID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTEloanID.IsDerivedStyle = true;
            this.lblTEloanID.Location = new System.Drawing.Point(0, 325);
            this.lblTEloanID.Name = "lblTEloanID";
            this.lblTEloanID.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblTEloanID.Size = new System.Drawing.Size(177, 65);
            this.lblTEloanID.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTEloanID.StyleManager = null;
            this.lblTEloanID.TabIndex = 26;
            this.lblTEloanID.Text = "Loan Applied To:";
            this.lblTEloanID.ThemeAuthor = "Narwin";
            this.lblTEloanID.ThemeName = "MetroLite";
            this.lblTEloanID.Visible = false;
            // 
            // lblcategoryID
            // 
            this.lblcategoryID.AutoSize = true;
            this.lblcategoryID.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblcategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblcategoryID.IsDerivedStyle = true;
            this.lblcategoryID.Location = new System.Drawing.Point(0, 260);
            this.lblcategoryID.Name = "lblcategoryID";
            this.lblcategoryID.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblcategoryID.Size = new System.Drawing.Size(221, 65);
            this.lblcategoryID.Style = MetroSet_UI.Enums.Style.Light;
            this.lblcategoryID.StyleManager = null;
            this.lblcategoryID.TabIndex = 24;
            this.lblcategoryID.Text = "Transaction Category:";
            this.lblcategoryID.ThemeAuthor = "Narwin";
            this.lblcategoryID.ThemeName = "MetroLite";
            // 
            // txtTErecurIntervalDays
            // 
            this.txtTErecurIntervalDays.AutoCompleteCustomSource = null;
            this.txtTErecurIntervalDays.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTErecurIntervalDays.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTErecurIntervalDays.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTErecurIntervalDays.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTErecurIntervalDays.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTErecurIntervalDays.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtTErecurIntervalDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTErecurIntervalDays.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtTErecurIntervalDays.Image = null;
            this.txtTErecurIntervalDays.IsDerivedStyle = true;
            this.txtTErecurIntervalDays.Lines = null;
            this.txtTErecurIntervalDays.Location = new System.Drawing.Point(673, 230);
            this.txtTErecurIntervalDays.MaxLength = 32767;
            this.txtTErecurIntervalDays.Multiline = false;
            this.txtTErecurIntervalDays.Name = "txtTErecurIntervalDays";
            this.txtTErecurIntervalDays.ReadOnly = false;
            this.txtTErecurIntervalDays.Size = new System.Drawing.Size(375, 30);
            this.txtTErecurIntervalDays.Style = MetroSet_UI.Enums.Style.Light;
            this.txtTErecurIntervalDays.StyleManager = null;
            this.txtTErecurIntervalDays.TabIndex = 23;
            this.txtTErecurIntervalDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTErecurIntervalDays.ThemeAuthor = "Narwin";
            this.txtTErecurIntervalDays.ThemeName = "MetroLite";
            this.txtTErecurIntervalDays.UseSystemPasswordChar = false;
            this.txtTErecurIntervalDays.Visible = false;
            this.txtTErecurIntervalDays.WatermarkText = "";
            this.txtTErecurIntervalDays.Validating += new System.ComponentModel.CancelEventHandler(this.txtTErecurIntervalDays_Validating);
            this.txtTErecurIntervalDays.Validated += new System.EventHandler(this.txtTErecurIntervalDays_Validated);
            // 
            // lblTErecurIntervalDays
            // 
            this.lblTErecurIntervalDays.AutoSize = true;
            this.lblTErecurIntervalDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTErecurIntervalDays.IsDerivedStyle = true;
            this.lblTErecurIntervalDays.Location = new System.Drawing.Point(406, 233);
            this.lblTErecurIntervalDays.Name = "lblTErecurIntervalDays";
            this.lblTErecurIntervalDays.Size = new System.Drawing.Size(250, 25);
            this.lblTErecurIntervalDays.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTErecurIntervalDays.StyleManager = null;
            this.lblTErecurIntervalDays.TabIndex = 22;
            this.lblTErecurIntervalDays.Text = "Recurrance Interval (Days):";
            this.lblTErecurIntervalDays.ThemeAuthor = "Narwin";
            this.lblTErecurIntervalDays.ThemeName = "MetroLite";
            this.lblTErecurIntervalDays.Visible = false;
            // 
            // swTEisRecurring
            // 
            this.swTEisRecurring.BackColor = System.Drawing.Color.Transparent;
            this.swTEisRecurring.BackgroundColor = System.Drawing.Color.Empty;
            this.swTEisRecurring.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.swTEisRecurring.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.swTEisRecurring.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.swTEisRecurring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swTEisRecurring.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.swTEisRecurring.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.swTEisRecurring.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.swTEisRecurring.IsDerivedStyle = true;
            this.swTEisRecurring.Location = new System.Drawing.Point(298, 236);
            this.swTEisRecurring.Name = "swTEisRecurring";
            this.swTEisRecurring.Size = new System.Drawing.Size(58, 22);
            this.swTEisRecurring.Style = MetroSet_UI.Enums.Style.Light;
            this.swTEisRecurring.StyleManager = null;
            this.swTEisRecurring.Switched = false;
            this.swTEisRecurring.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.swTEisRecurring.TabIndex = 21;
            this.swTEisRecurring.Text = "swTAisRecurring";
            this.swTEisRecurring.ThemeAuthor = "Narwin";
            this.swTEisRecurring.ThemeName = "MetroLite";
            this.swTEisRecurring.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.swTEisRecurring.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.swTEisRecurring_SwitchedChanged);
            // 
            // lblTEisRecurring
            // 
            this.lblTEisRecurring.AutoSize = true;
            this.lblTEisRecurring.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTEisRecurring.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTEisRecurring.IsDerivedStyle = true;
            this.lblTEisRecurring.Location = new System.Drawing.Point(0, 195);
            this.lblTEisRecurring.Name = "lblTEisRecurring";
            this.lblTEisRecurring.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblTEisRecurring.Size = new System.Drawing.Size(224, 65);
            this.lblTEisRecurring.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTEisRecurring.StyleManager = null;
            this.lblTEisRecurring.TabIndex = 20;
            this.lblTEisRecurring.Text = "Recurring Transaction:";
            this.lblTEisRecurring.ThemeAuthor = "Narwin";
            this.lblTEisRecurring.ThemeName = "MetroLite";
            // 
            // dteTEdate
            // 
            this.dteTEdate.Location = new System.Drawing.Point(298, 165);
            this.dteTEdate.Name = "dteTEdate";
            this.dteTEdate.Size = new System.Drawing.Size(375, 30);
            this.dteTEdate.TabIndex = 19;
            this.dteTEdate.Validating += new System.ComponentModel.CancelEventHandler(this.dteTEdate_Validating);
            this.dteTEdate.Validated += new System.EventHandler(this.dteTEdate_Validated);
            // 
            // lblTEdate
            // 
            this.lblTEdate.AutoSize = true;
            this.lblTEdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTEdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTEdate.IsDerivedStyle = true;
            this.lblTEdate.Location = new System.Drawing.Point(0, 130);
            this.lblTEdate.Name = "lblTEdate";
            this.lblTEdate.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblTEdate.Size = new System.Drawing.Size(203, 65);
            this.lblTEdate.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTEdate.StyleManager = null;
            this.lblTEdate.TabIndex = 18;
            this.lblTEdate.Text = "Date of Transaction:";
            this.lblTEdate.ThemeAuthor = "Narwin";
            this.lblTEdate.ThemeName = "MetroLite";
            // 
            // txtTEvalue
            // 
            this.txtTEvalue.AutoCompleteCustomSource = null;
            this.txtTEvalue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTEvalue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTEvalue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTEvalue.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTEvalue.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTEvalue.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtTEvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTEvalue.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtTEvalue.Image = null;
            this.txtTEvalue.IsDerivedStyle = true;
            this.txtTEvalue.Lines = null;
            this.txtTEvalue.Location = new System.Drawing.Point(298, 100);
            this.txtTEvalue.MaxLength = 32767;
            this.txtTEvalue.Multiline = false;
            this.txtTEvalue.Name = "txtTEvalue";
            this.txtTEvalue.ReadOnly = false;
            this.txtTEvalue.Size = new System.Drawing.Size(375, 30);
            this.txtTEvalue.Style = MetroSet_UI.Enums.Style.Light;
            this.txtTEvalue.StyleManager = null;
            this.txtTEvalue.TabIndex = 17;
            this.txtTEvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTEvalue.ThemeAuthor = "Narwin";
            this.txtTEvalue.ThemeName = "MetroLite";
            this.txtTEvalue.UseSystemPasswordChar = false;
            this.txtTEvalue.WatermarkText = "";
            this.txtTEvalue.Validating += new System.ComponentModel.CancelEventHandler(this.txtTEvalue_Validating);
            this.txtTEvalue.Validated += new System.EventHandler(this.txtTEvalue_Validated);
            // 
            // lblTEvalue
            // 
            this.lblTEvalue.AutoSize = true;
            this.lblTEvalue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTEvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTEvalue.IsDerivedStyle = true;
            this.lblTEvalue.Location = new System.Drawing.Point(0, 65);
            this.lblTEvalue.Name = "lblTEvalue";
            this.lblTEvalue.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblTEvalue.Size = new System.Drawing.Size(213, 65);
            this.lblTEvalue.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTEvalue.StyleManager = null;
            this.lblTEvalue.TabIndex = 16;
            this.lblTEvalue.Text = "Value of Transaction:";
            this.lblTEvalue.ThemeAuthor = "Narwin";
            this.lblTEvalue.ThemeName = "MetroLite";
            // 
            // txtTEtransName
            // 
            this.txtTEtransName.AutoCompleteCustomSource = null;
            this.txtTEtransName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTEtransName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTEtransName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTEtransName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTEtransName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTEtransName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtTEtransName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTEtransName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtTEtransName.Image = null;
            this.txtTEtransName.IsDerivedStyle = true;
            this.txtTEtransName.Lines = null;
            this.txtTEtransName.Location = new System.Drawing.Point(298, 35);
            this.txtTEtransName.MaxLength = 32767;
            this.txtTEtransName.Multiline = false;
            this.txtTEtransName.Name = "txtTEtransName";
            this.txtTEtransName.ReadOnly = false;
            this.txtTEtransName.Size = new System.Drawing.Size(750, 30);
            this.txtTEtransName.Style = MetroSet_UI.Enums.Style.Light;
            this.txtTEtransName.StyleManager = null;
            this.txtTEtransName.TabIndex = 15;
            this.txtTEtransName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTEtransName.ThemeAuthor = "Narwin";
            this.txtTEtransName.ThemeName = "MetroLite";
            this.txtTEtransName.UseSystemPasswordChar = false;
            this.txtTEtransName.WatermarkText = "";
            this.txtTEtransName.Validating += new System.ComponentModel.CancelEventHandler(this.txtTEtransName_Validating);
            this.txtTEtransName.Validated += new System.EventHandler(this.txtTEtransName_Validated);
            // 
            // lblTEtransName
            // 
            this.lblTEtransName.AutoSize = true;
            this.lblTEtransName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTEtransName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTEtransName.IsDerivedStyle = true;
            this.lblTEtransName.Location = new System.Drawing.Point(0, 0);
            this.lblTEtransName.Name = "lblTEtransName";
            this.lblTEtransName.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblTEtransName.Size = new System.Drawing.Size(193, 65);
            this.lblTEtransName.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTEtransName.StyleManager = null;
            this.lblTEtransName.TabIndex = 14;
            this.lblTEtransName.Text = "Transaction Name:";
            this.lblTEtransName.ThemeAuthor = "Narwin";
            this.lblTEtransName.ThemeName = "MetroLite";
            // 
            // tbTRemove
            // 
            this.tbTRemove.BaseColor = System.Drawing.Color.White;
            this.tbTRemove.Controls.Add(this.dteTRdate);
            this.tbTRemove.Controls.Add(this.lblTRdate);
            this.tbTRemove.Controls.Add(this.txtTRvalue);
            this.tbTRemove.Controls.Add(this.lblTRvalue);
            this.tbTRemove.Controls.Add(this.txtTRtransName);
            this.tbTRemove.Controls.Add(this.lblTRtransName);
            this.tbTRemove.Controls.Add(this.btnTRemove);
            this.tbTRemove.Font = null;
            this.tbTRemove.ImageIndex = 0;
            this.tbTRemove.ImageKey = null;
            this.tbTRemove.IsDerivedStyle = true;
            this.tbTRemove.Location = new System.Drawing.Point(4, 42);
            this.tbTRemove.Name = "tbTRemove";
            this.tbTRemove.Size = new System.Drawing.Size(1105, 449);
            this.tbTRemove.Style = MetroSet_UI.Enums.Style.Light;
            this.tbTRemove.StyleManager = null;
            this.tbTRemove.TabIndex = 2;
            this.tbTRemove.Text = "Remove Transaction";
            this.tbTRemove.ThemeAuthor = "Narwin";
            this.tbTRemove.ThemeName = "MetroLite";
            this.tbTRemove.ToolTipText = null;
            // 
            // dteTRdate
            // 
            this.dteTRdate.Location = new System.Drawing.Point(298, 165);
            this.dteTRdate.Name = "dteTRdate";
            this.dteTRdate.Size = new System.Drawing.Size(375, 30);
            this.dteTRdate.TabIndex = 35;
            // 
            // lblTRdate
            // 
            this.lblTRdate.AutoSize = true;
            this.lblTRdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTRdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTRdate.IsDerivedStyle = true;
            this.lblTRdate.Location = new System.Drawing.Point(0, 130);
            this.lblTRdate.Name = "lblTRdate";
            this.lblTRdate.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblTRdate.Size = new System.Drawing.Size(203, 65);
            this.lblTRdate.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTRdate.StyleManager = null;
            this.lblTRdate.TabIndex = 34;
            this.lblTRdate.Text = "Date of Transaction:";
            this.lblTRdate.ThemeAuthor = "Narwin";
            this.lblTRdate.ThemeName = "MetroLite";
            // 
            // txtTRvalue
            // 
            this.txtTRvalue.AutoCompleteCustomSource = null;
            this.txtTRvalue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTRvalue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTRvalue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTRvalue.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTRvalue.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTRvalue.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtTRvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTRvalue.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtTRvalue.Image = null;
            this.txtTRvalue.IsDerivedStyle = true;
            this.txtTRvalue.Lines = null;
            this.txtTRvalue.Location = new System.Drawing.Point(298, 100);
            this.txtTRvalue.MaxLength = 32767;
            this.txtTRvalue.Multiline = false;
            this.txtTRvalue.Name = "txtTRvalue";
            this.txtTRvalue.ReadOnly = true;
            this.txtTRvalue.Size = new System.Drawing.Size(375, 30);
            this.txtTRvalue.Style = MetroSet_UI.Enums.Style.Light;
            this.txtTRvalue.StyleManager = null;
            this.txtTRvalue.TabIndex = 33;
            this.txtTRvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTRvalue.ThemeAuthor = "Narwin";
            this.txtTRvalue.ThemeName = "MetroLite";
            this.txtTRvalue.UseSystemPasswordChar = false;
            this.txtTRvalue.WatermarkText = "";
            // 
            // lblTRvalue
            // 
            this.lblTRvalue.AutoSize = true;
            this.lblTRvalue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTRvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTRvalue.IsDerivedStyle = true;
            this.lblTRvalue.Location = new System.Drawing.Point(0, 65);
            this.lblTRvalue.Name = "lblTRvalue";
            this.lblTRvalue.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblTRvalue.Size = new System.Drawing.Size(213, 65);
            this.lblTRvalue.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTRvalue.StyleManager = null;
            this.lblTRvalue.TabIndex = 32;
            this.lblTRvalue.Text = "Value of Transaction:";
            this.lblTRvalue.ThemeAuthor = "Narwin";
            this.lblTRvalue.ThemeName = "MetroLite";
            // 
            // txtTRtransName
            // 
            this.txtTRtransName.AutoCompleteCustomSource = null;
            this.txtTRtransName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTRtransName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTRtransName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTRtransName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTRtransName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTRtransName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtTRtransName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTRtransName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtTRtransName.Image = null;
            this.txtTRtransName.IsDerivedStyle = true;
            this.txtTRtransName.Lines = null;
            this.txtTRtransName.Location = new System.Drawing.Point(298, 35);
            this.txtTRtransName.MaxLength = 32767;
            this.txtTRtransName.Multiline = false;
            this.txtTRtransName.Name = "txtTRtransName";
            this.txtTRtransName.ReadOnly = true;
            this.txtTRtransName.Size = new System.Drawing.Size(750, 30);
            this.txtTRtransName.Style = MetroSet_UI.Enums.Style.Light;
            this.txtTRtransName.StyleManager = null;
            this.txtTRtransName.TabIndex = 31;
            this.txtTRtransName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTRtransName.ThemeAuthor = "Narwin";
            this.txtTRtransName.ThemeName = "MetroLite";
            this.txtTRtransName.UseSystemPasswordChar = false;
            this.txtTRtransName.WatermarkText = "";
            // 
            // lblTRtransName
            // 
            this.lblTRtransName.AutoSize = true;
            this.lblTRtransName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTRtransName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTRtransName.IsDerivedStyle = true;
            this.lblTRtransName.Location = new System.Drawing.Point(0, 0);
            this.lblTRtransName.Name = "lblTRtransName";
            this.lblTRtransName.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblTRtransName.Size = new System.Drawing.Size(193, 65);
            this.lblTRtransName.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTRtransName.StyleManager = null;
            this.lblTRtransName.TabIndex = 30;
            this.lblTRtransName.Text = "Transaction Name:";
            this.lblTRtransName.ThemeAuthor = "Narwin";
            this.lblTRtransName.ThemeName = "MetroLite";
            // 
            // btnTRemove
            // 
            this.btnTRemove.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnTRemove.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnTRemove.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnTRemove.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTRemove.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnTRemove.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnTRemove.HoverTextColor = System.Drawing.Color.White;
            this.btnTRemove.IsDerivedStyle = true;
            this.btnTRemove.Location = new System.Drawing.Point(0, 426);
            this.btnTRemove.Name = "btnTRemove";
            this.btnTRemove.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnTRemove.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnTRemove.NormalTextColor = System.Drawing.Color.White;
            this.btnTRemove.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnTRemove.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnTRemove.PressTextColor = System.Drawing.Color.White;
            this.btnTRemove.Size = new System.Drawing.Size(1105, 23);
            this.btnTRemove.Style = MetroSet_UI.Enums.Style.Light;
            this.btnTRemove.StyleManager = null;
            this.btnTRemove.TabIndex = 29;
            this.btnTRemove.Text = "Remove Transaction";
            this.btnTRemove.ThemeAuthor = "Narwin";
            this.btnTRemove.ThemeName = "MetroLite";
            this.btnTRemove.Click += new System.EventHandler(this.btnTRemove_Click);
            // 
            // tbLoans
            // 
            this.tbLoans.BaseColor = System.Drawing.Color.White;
            this.tbLoans.Controls.Add(this.pnlLGraph);
            this.tbLoans.Controls.Add(this.tbcLoansView);
            this.tbLoans.Controls.Add(this.tbcLoans);
            this.tbLoans.Font = null;
            this.tbLoans.ImageIndex = 0;
            this.tbLoans.ImageKey = null;
            this.tbLoans.IsDerivedStyle = true;
            this.tbLoans.Location = new System.Drawing.Point(4, 42);
            this.tbLoans.Name = "tbLoans";
            this.tbLoans.Size = new System.Drawing.Size(2528, 1196);
            this.tbLoans.Style = MetroSet_UI.Enums.Style.Light;
            this.tbLoans.StyleManager = null;
            this.tbLoans.TabIndex = 2;
            this.tbLoans.Text = "Loans";
            this.tbLoans.ThemeAuthor = "Narwin";
            this.tbLoans.ThemeName = "MetroLite";
            this.tbLoans.ToolTipText = null;
            // 
            // pnlLGraph
            // 
            this.pnlLGraph.BackgroundColor = System.Drawing.Color.White;
            this.pnlLGraph.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.pnlLGraph.BorderThickness = 1;
            this.pnlLGraph.Controls.Add(this.chtLLoans);
            this.pnlLGraph.IsDerivedStyle = true;
            this.pnlLGraph.Location = new System.Drawing.Point(55, 591);
            this.pnlLGraph.Name = "pnlLGraph";
            this.pnlLGraph.Size = new System.Drawing.Size(1105, 564);
            this.pnlLGraph.Style = MetroSet_UI.Enums.Style.Light;
            this.pnlLGraph.StyleManager = null;
            this.pnlLGraph.TabIndex = 9;
            this.pnlLGraph.ThemeAuthor = "Narwin";
            this.pnlLGraph.ThemeName = "MetroLite";
            // 
            // chtLLoans
            // 
            this.chtLLoans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chtLLoans.Location = new System.Drawing.Point(0, 0);
            this.chtLLoans.Name = "chtLLoans";
            this.chtLLoans.Size = new System.Drawing.Size(1105, 564);
            this.chtLLoans.TabIndex = 0;
            // 
            // tbcLoansView
            // 
            this.tbcLoansView.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.tbcLoansView.AnimateTime = 200;
            this.tbcLoansView.BackgroundColor = System.Drawing.Color.White;
            this.tbcLoansView.Controls.Add(this.tbLloans);
            this.tbcLoansView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbcLoansView.IsDerivedStyle = true;
            this.tbcLoansView.ItemSize = new System.Drawing.Size(100, 38);
            this.tbcLoansView.Location = new System.Drawing.Point(1192, 52);
            this.tbcLoansView.Name = "tbcLoansView";
            this.tbcLoansView.SelectedIndex = 0;
            this.tbcLoansView.SelectedTextColor = System.Drawing.Color.White;
            this.tbcLoansView.Size = new System.Drawing.Size(1293, 1103);
            this.tbcLoansView.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcLoansView.Speed = 100;
            this.tbcLoansView.Style = MetroSet_UI.Enums.Style.Light;
            this.tbcLoansView.StyleManager = null;
            this.tbcLoansView.TabIndex = 8;
            this.tbcLoansView.ThemeAuthor = "Narwin";
            this.tbcLoansView.ThemeName = "MetroLite";
            this.tbcLoansView.UnselectedTextColor = System.Drawing.Color.Gray;
            this.tbcLoansView.UseAnimation = false;
            // 
            // tbLloans
            // 
            this.tbLloans.BaseColor = System.Drawing.Color.White;
            this.tbLloans.Controls.Add(this.grdLloans);
            this.tbLloans.Font = null;
            this.tbLloans.ImageIndex = 0;
            this.tbLloans.ImageKey = null;
            this.tbLloans.IsDerivedStyle = true;
            this.tbLloans.Location = new System.Drawing.Point(4, 42);
            this.tbLloans.Name = "tbLloans";
            this.tbLloans.Size = new System.Drawing.Size(1285, 1057);
            this.tbLloans.Style = MetroSet_UI.Enums.Style.Light;
            this.tbLloans.StyleManager = null;
            this.tbLloans.TabIndex = 0;
            this.tbLloans.Text = "Loans";
            this.tbLloans.ThemeAuthor = "Narwin";
            this.tbLloans.ThemeName = "MetroLite";
            this.tbLloans.ToolTipText = null;
            // 
            // grdLloans
            // 
            this.grdLloans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdLloans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLloans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLloans.Location = new System.Drawing.Point(0, 0);
            this.grdLloans.Name = "grdLloans";
            this.grdLloans.RowHeadersWidth = 62;
            this.grdLloans.RowTemplate.Height = 28;
            this.grdLloans.Size = new System.Drawing.Size(1285, 1057);
            this.grdLloans.TabIndex = 0;
            this.grdLloans.SelectionChanged += new System.EventHandler(this.grdLloans_SelectionChanged);
            // 
            // tbcLoans
            // 
            this.tbcLoans.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.tbcLoans.AnimateTime = 200;
            this.tbcLoans.BackgroundColor = System.Drawing.Color.White;
            this.tbcLoans.Controls.Add(this.tbLAdd);
            this.tbcLoans.Controls.Add(this.tbLEdit);
            this.tbcLoans.Controls.Add(this.tbLRemove);
            this.tbcLoans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbcLoans.IsDerivedStyle = true;
            this.tbcLoans.ItemSize = new System.Drawing.Size(100, 38);
            this.tbcLoans.Location = new System.Drawing.Point(51, 52);
            this.tbcLoans.Name = "tbcLoans";
            this.tbcLoans.SelectedIndex = 0;
            this.tbcLoans.SelectedTextColor = System.Drawing.Color.White;
            this.tbcLoans.Size = new System.Drawing.Size(1113, 495);
            this.tbcLoans.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcLoans.Speed = 100;
            this.tbcLoans.Style = MetroSet_UI.Enums.Style.Light;
            this.tbcLoans.StyleManager = null;
            this.tbcLoans.TabIndex = 7;
            this.tbcLoans.ThemeAuthor = "Narwin";
            this.tbcLoans.ThemeName = "MetroLite";
            this.tbcLoans.UnselectedTextColor = System.Drawing.Color.Gray;
            this.tbcLoans.UseAnimation = false;
            // 
            // tbLAdd
            // 
            this.tbLAdd.BaseColor = System.Drawing.Color.White;
            this.tbLAdd.Controls.Add(this.txtLApayment);
            this.tbLAdd.Controls.Add(this.txtLAdurationMonths);
            this.tbLAdd.Controls.Add(this.btnLAdd);
            this.tbLAdd.Controls.Add(this.lblLApayment);
            this.tbLAdd.Controls.Add(this.txtLAfixedAPR);
            this.tbLAdd.Controls.Add(this.lblLAfixedAPR);
            this.tbLAdd.Controls.Add(this.lblLAdurationMonths);
            this.tbLAdd.Controls.Add(this.txtLAbalance);
            this.tbLAdd.Controls.Add(this.lblLAbalance);
            this.tbLAdd.Controls.Add(this.txtLAloanName);
            this.tbLAdd.Controls.Add(this.lblLAloanName);
            this.tbLAdd.Font = null;
            this.tbLAdd.ImageIndex = 0;
            this.tbLAdd.ImageKey = null;
            this.tbLAdd.IsDerivedStyle = true;
            this.tbLAdd.Location = new System.Drawing.Point(4, 42);
            this.tbLAdd.Name = "tbLAdd";
            this.tbLAdd.Size = new System.Drawing.Size(1105, 449);
            this.tbLAdd.Style = MetroSet_UI.Enums.Style.Light;
            this.tbLAdd.StyleManager = null;
            this.tbLAdd.TabIndex = 0;
            this.tbLAdd.Text = "Add Loan";
            this.tbLAdd.ThemeAuthor = "Narwin";
            this.tbLAdd.ThemeName = "MetroLite";
            this.tbLAdd.ToolTipText = null;
            // 
            // txtLApayment
            // 
            this.txtLApayment.AutoCompleteCustomSource = null;
            this.txtLApayment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLApayment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLApayment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLApayment.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtLApayment.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLApayment.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtLApayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLApayment.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtLApayment.Image = null;
            this.txtLApayment.IsDerivedStyle = true;
            this.txtLApayment.Lines = null;
            this.txtLApayment.Location = new System.Drawing.Point(298, 295);
            this.txtLApayment.MaxLength = 32767;
            this.txtLApayment.Multiline = false;
            this.txtLApayment.Name = "txtLApayment";
            this.txtLApayment.ReadOnly = true;
            this.txtLApayment.Size = new System.Drawing.Size(375, 30);
            this.txtLApayment.Style = MetroSet_UI.Enums.Style.Light;
            this.txtLApayment.StyleManager = null;
            this.txtLApayment.TabIndex = 16;
            this.txtLApayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLApayment.ThemeAuthor = "Narwin";
            this.txtLApayment.ThemeName = "MetroLite";
            this.txtLApayment.UseSystemPasswordChar = false;
            this.txtLApayment.WatermarkText = "";
            // 
            // txtLAdurationMonths
            // 
            this.txtLAdurationMonths.AutoCompleteCustomSource = null;
            this.txtLAdurationMonths.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLAdurationMonths.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLAdurationMonths.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLAdurationMonths.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtLAdurationMonths.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLAdurationMonths.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtLAdurationMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLAdurationMonths.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtLAdurationMonths.Image = null;
            this.txtLAdurationMonths.IsDerivedStyle = true;
            this.txtLAdurationMonths.Lines = null;
            this.txtLAdurationMonths.Location = new System.Drawing.Point(298, 165);
            this.txtLAdurationMonths.MaxLength = 32767;
            this.txtLAdurationMonths.Multiline = false;
            this.txtLAdurationMonths.Name = "txtLAdurationMonths";
            this.txtLAdurationMonths.ReadOnly = false;
            this.txtLAdurationMonths.Size = new System.Drawing.Size(375, 30);
            this.txtLAdurationMonths.Style = MetroSet_UI.Enums.Style.Light;
            this.txtLAdurationMonths.StyleManager = null;
            this.txtLAdurationMonths.TabIndex = 15;
            this.txtLAdurationMonths.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLAdurationMonths.ThemeAuthor = "Narwin";
            this.txtLAdurationMonths.ThemeName = "MetroLite";
            this.txtLAdurationMonths.UseSystemPasswordChar = false;
            this.txtLAdurationMonths.WatermarkText = "";
            this.txtLAdurationMonths.Validating += new System.ComponentModel.CancelEventHandler(this.txtLAdurationMonths_Validating);
            this.txtLAdurationMonths.Validated += new System.EventHandler(this.txtLAdurationMonths_Validated);
            // 
            // btnLAdd
            // 
            this.btnLAdd.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLAdd.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnLAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLAdd.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnLAdd.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnLAdd.HoverTextColor = System.Drawing.Color.White;
            this.btnLAdd.IsDerivedStyle = true;
            this.btnLAdd.Location = new System.Drawing.Point(0, 426);
            this.btnLAdd.Name = "btnLAdd";
            this.btnLAdd.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLAdd.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLAdd.NormalTextColor = System.Drawing.Color.White;
            this.btnLAdd.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnLAdd.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnLAdd.PressTextColor = System.Drawing.Color.White;
            this.btnLAdd.Size = new System.Drawing.Size(1105, 23);
            this.btnLAdd.Style = MetroSet_UI.Enums.Style.Light;
            this.btnLAdd.StyleManager = null;
            this.btnLAdd.TabIndex = 14;
            this.btnLAdd.Text = "Add Loan";
            this.btnLAdd.ThemeAuthor = "Narwin";
            this.btnLAdd.ThemeName = "MetroLite";
            this.btnLAdd.Click += new System.EventHandler(this.btnLAdd_Click);
            // 
            // lblLApayment
            // 
            this.lblLApayment.AutoSize = true;
            this.lblLApayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLApayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLApayment.IsDerivedStyle = true;
            this.lblLApayment.Location = new System.Drawing.Point(0, 260);
            this.lblLApayment.Name = "lblLApayment";
            this.lblLApayment.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblLApayment.Size = new System.Drawing.Size(268, 65);
            this.lblLApayment.Style = MetroSet_UI.Enums.Style.Light;
            this.lblLApayment.StyleManager = null;
            this.lblLApayment.TabIndex = 10;
            this.lblLApayment.Text = "Standard Payment Amount:";
            this.lblLApayment.ThemeAuthor = "Narwin";
            this.lblLApayment.ThemeName = "MetroLite";
            // 
            // txtLAfixedAPR
            // 
            this.txtLAfixedAPR.AutoCompleteCustomSource = null;
            this.txtLAfixedAPR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLAfixedAPR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLAfixedAPR.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLAfixedAPR.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtLAfixedAPR.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLAfixedAPR.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtLAfixedAPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLAfixedAPR.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtLAfixedAPR.Image = null;
            this.txtLAfixedAPR.IsDerivedStyle = true;
            this.txtLAfixedAPR.Lines = null;
            this.txtLAfixedAPR.Location = new System.Drawing.Point(298, 230);
            this.txtLAfixedAPR.MaxLength = 32767;
            this.txtLAfixedAPR.Multiline = false;
            this.txtLAfixedAPR.Name = "txtLAfixedAPR";
            this.txtLAfixedAPR.ReadOnly = false;
            this.txtLAfixedAPR.Size = new System.Drawing.Size(375, 30);
            this.txtLAfixedAPR.Style = MetroSet_UI.Enums.Style.Light;
            this.txtLAfixedAPR.StyleManager = null;
            this.txtLAfixedAPR.TabIndex = 9;
            this.txtLAfixedAPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLAfixedAPR.ThemeAuthor = "Narwin";
            this.txtLAfixedAPR.ThemeName = "MetroLite";
            this.txtLAfixedAPR.UseSystemPasswordChar = false;
            this.txtLAfixedAPR.WatermarkText = "";
            this.txtLAfixedAPR.Validating += new System.ComponentModel.CancelEventHandler(this.txtLAfixedAPR_Validating);
            this.txtLAfixedAPR.Validated += new System.EventHandler(this.txtLAfixedAPR_Validated);
            // 
            // lblLAfixedAPR
            // 
            this.lblLAfixedAPR.AutoSize = true;
            this.lblLAfixedAPR.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLAfixedAPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLAfixedAPR.IsDerivedStyle = true;
            this.lblLAfixedAPR.Location = new System.Drawing.Point(0, 195);
            this.lblLAfixedAPR.Name = "lblLAfixedAPR";
            this.lblLAfixedAPR.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblLAfixedAPR.Size = new System.Drawing.Size(163, 65);
            this.lblLAfixedAPR.Style = MetroSet_UI.Enums.Style.Light;
            this.lblLAfixedAPR.StyleManager = null;
            this.lblLAfixedAPR.TabIndex = 6;
            this.lblLAfixedAPR.Text = "Fixed APR (%):";
            this.lblLAfixedAPR.ThemeAuthor = "Narwin";
            this.lblLAfixedAPR.ThemeName = "MetroLite";
            // 
            // lblLAdurationMonths
            // 
            this.lblLAdurationMonths.AutoSize = true;
            this.lblLAdurationMonths.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLAdurationMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLAdurationMonths.IsDerivedStyle = true;
            this.lblLAdurationMonths.Location = new System.Drawing.Point(0, 130);
            this.lblLAdurationMonths.Name = "lblLAdurationMonths";
            this.lblLAdurationMonths.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblLAdurationMonths.Size = new System.Drawing.Size(239, 65);
            this.lblLAdurationMonths.Style = MetroSet_UI.Enums.Style.Light;
            this.lblLAdurationMonths.StyleManager = null;
            this.lblLAdurationMonths.TabIndex = 4;
            this.lblLAdurationMonths.Text = "Loan Duration (Months):";
            this.lblLAdurationMonths.ThemeAuthor = "Narwin";
            this.lblLAdurationMonths.ThemeName = "MetroLite";
            // 
            // txtLAbalance
            // 
            this.txtLAbalance.AutoCompleteCustomSource = null;
            this.txtLAbalance.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLAbalance.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLAbalance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLAbalance.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtLAbalance.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLAbalance.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtLAbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLAbalance.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtLAbalance.Image = null;
            this.txtLAbalance.IsDerivedStyle = true;
            this.txtLAbalance.Lines = null;
            this.txtLAbalance.Location = new System.Drawing.Point(298, 100);
            this.txtLAbalance.MaxLength = 32767;
            this.txtLAbalance.Multiline = false;
            this.txtLAbalance.Name = "txtLAbalance";
            this.txtLAbalance.ReadOnly = false;
            this.txtLAbalance.Size = new System.Drawing.Size(375, 30);
            this.txtLAbalance.Style = MetroSet_UI.Enums.Style.Light;
            this.txtLAbalance.StyleManager = null;
            this.txtLAbalance.TabIndex = 3;
            this.txtLAbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLAbalance.ThemeAuthor = "Narwin";
            this.txtLAbalance.ThemeName = "MetroLite";
            this.txtLAbalance.UseSystemPasswordChar = false;
            this.txtLAbalance.WatermarkText = "";
            this.txtLAbalance.Validating += new System.ComponentModel.CancelEventHandler(this.txtLAbalance_Validating);
            this.txtLAbalance.Validated += new System.EventHandler(this.txtLAbalance_Validated);
            // 
            // lblLAbalance
            // 
            this.lblLAbalance.AutoSize = true;
            this.lblLAbalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLAbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLAbalance.IsDerivedStyle = true;
            this.lblLAbalance.Location = new System.Drawing.Point(0, 65);
            this.lblLAbalance.Name = "lblLAbalance";
            this.lblLAbalance.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblLAbalance.Size = new System.Drawing.Size(153, 65);
            this.lblLAbalance.Style = MetroSet_UI.Enums.Style.Light;
            this.lblLAbalance.StyleManager = null;
            this.lblLAbalance.TabIndex = 2;
            this.lblLAbalance.Text = "Loan Balance:";
            this.lblLAbalance.ThemeAuthor = "Narwin";
            this.lblLAbalance.ThemeName = "MetroLite";
            // 
            // txtLAloanName
            // 
            this.txtLAloanName.AutoCompleteCustomSource = null;
            this.txtLAloanName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLAloanName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLAloanName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLAloanName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtLAloanName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLAloanName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtLAloanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLAloanName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtLAloanName.Image = null;
            this.txtLAloanName.IsDerivedStyle = true;
            this.txtLAloanName.Lines = null;
            this.txtLAloanName.Location = new System.Drawing.Point(298, 35);
            this.txtLAloanName.MaxLength = 32767;
            this.txtLAloanName.Multiline = false;
            this.txtLAloanName.Name = "txtLAloanName";
            this.txtLAloanName.ReadOnly = false;
            this.txtLAloanName.Size = new System.Drawing.Size(750, 30);
            this.txtLAloanName.Style = MetroSet_UI.Enums.Style.Light;
            this.txtLAloanName.StyleManager = null;
            this.txtLAloanName.TabIndex = 1;
            this.txtLAloanName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLAloanName.ThemeAuthor = "Narwin";
            this.txtLAloanName.ThemeName = "MetroLite";
            this.txtLAloanName.UseSystemPasswordChar = false;
            this.txtLAloanName.WatermarkText = "";
            this.txtLAloanName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLAloanName_Validating);
            this.txtLAloanName.Validated += new System.EventHandler(this.txtLAloanName_Validated);
            // 
            // lblLAloanName
            // 
            this.lblLAloanName.AutoSize = true;
            this.lblLAloanName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLAloanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLAloanName.IsDerivedStyle = true;
            this.lblLAloanName.Location = new System.Drawing.Point(0, 0);
            this.lblLAloanName.Name = "lblLAloanName";
            this.lblLAloanName.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblLAloanName.Size = new System.Drawing.Size(134, 65);
            this.lblLAloanName.Style = MetroSet_UI.Enums.Style.Light;
            this.lblLAloanName.StyleManager = null;
            this.lblLAloanName.TabIndex = 0;
            this.lblLAloanName.Text = "Loan Name:";
            this.lblLAloanName.ThemeAuthor = "Narwin";
            this.lblLAloanName.ThemeName = "MetroLite";
            // 
            // tbLEdit
            // 
            this.tbLEdit.BaseColor = System.Drawing.Color.White;
            this.tbLEdit.Controls.Add(this.txtLEpayment);
            this.tbLEdit.Controls.Add(this.txtLEdurationMonths);
            this.tbLEdit.Controls.Add(this.lblLEpayment);
            this.tbLEdit.Controls.Add(this.txtLEfixedAPR);
            this.tbLEdit.Controls.Add(this.lblLEfixedAPR);
            this.tbLEdit.Controls.Add(this.lblLEdurationMonths);
            this.tbLEdit.Controls.Add(this.txtLEbalance);
            this.tbLEdit.Controls.Add(this.lblLEbalance);
            this.tbLEdit.Controls.Add(this.txtLEloanName);
            this.tbLEdit.Controls.Add(this.lblLEloanName);
            this.tbLEdit.Controls.Add(this.btnLEdit);
            this.tbLEdit.Font = null;
            this.tbLEdit.ImageIndex = 0;
            this.tbLEdit.ImageKey = null;
            this.tbLEdit.IsDerivedStyle = true;
            this.tbLEdit.Location = new System.Drawing.Point(4, 42);
            this.tbLEdit.Name = "tbLEdit";
            this.tbLEdit.Size = new System.Drawing.Size(1105, 449);
            this.tbLEdit.Style = MetroSet_UI.Enums.Style.Light;
            this.tbLEdit.StyleManager = null;
            this.tbLEdit.TabIndex = 1;
            this.tbLEdit.Text = "Edit Loan";
            this.tbLEdit.ThemeAuthor = "Narwin";
            this.tbLEdit.ThemeName = "MetroLite";
            this.tbLEdit.ToolTipText = null;
            // 
            // txtLEpayment
            // 
            this.txtLEpayment.AutoCompleteCustomSource = null;
            this.txtLEpayment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLEpayment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLEpayment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLEpayment.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtLEpayment.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLEpayment.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtLEpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLEpayment.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtLEpayment.Image = null;
            this.txtLEpayment.IsDerivedStyle = true;
            this.txtLEpayment.Lines = null;
            this.txtLEpayment.Location = new System.Drawing.Point(298, 295);
            this.txtLEpayment.MaxLength = 32767;
            this.txtLEpayment.Multiline = false;
            this.txtLEpayment.Name = "txtLEpayment";
            this.txtLEpayment.ReadOnly = true;
            this.txtLEpayment.Size = new System.Drawing.Size(375, 30);
            this.txtLEpayment.Style = MetroSet_UI.Enums.Style.Light;
            this.txtLEpayment.StyleManager = null;
            this.txtLEpayment.TabIndex = 38;
            this.txtLEpayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLEpayment.ThemeAuthor = "Narwin";
            this.txtLEpayment.ThemeName = "MetroLite";
            this.txtLEpayment.UseSystemPasswordChar = false;
            this.txtLEpayment.WatermarkText = "";
            // 
            // txtLEdurationMonths
            // 
            this.txtLEdurationMonths.AutoCompleteCustomSource = null;
            this.txtLEdurationMonths.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLEdurationMonths.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLEdurationMonths.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLEdurationMonths.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtLEdurationMonths.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLEdurationMonths.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtLEdurationMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLEdurationMonths.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtLEdurationMonths.Image = null;
            this.txtLEdurationMonths.IsDerivedStyle = true;
            this.txtLEdurationMonths.Lines = null;
            this.txtLEdurationMonths.Location = new System.Drawing.Point(298, 165);
            this.txtLEdurationMonths.MaxLength = 32767;
            this.txtLEdurationMonths.Multiline = false;
            this.txtLEdurationMonths.Name = "txtLEdurationMonths";
            this.txtLEdurationMonths.ReadOnly = false;
            this.txtLEdurationMonths.Size = new System.Drawing.Size(375, 30);
            this.txtLEdurationMonths.Style = MetroSet_UI.Enums.Style.Light;
            this.txtLEdurationMonths.StyleManager = null;
            this.txtLEdurationMonths.TabIndex = 37;
            this.txtLEdurationMonths.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLEdurationMonths.ThemeAuthor = "Narwin";
            this.txtLEdurationMonths.ThemeName = "MetroLite";
            this.txtLEdurationMonths.UseSystemPasswordChar = false;
            this.txtLEdurationMonths.WatermarkText = "";
            this.txtLEdurationMonths.Validating += new System.ComponentModel.CancelEventHandler(this.txtLEdurationMonths_Validating);
            this.txtLEdurationMonths.Validated += new System.EventHandler(this.txtLEdurationMonths_Validated);
            // 
            // lblLEpayment
            // 
            this.lblLEpayment.AutoSize = true;
            this.lblLEpayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLEpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLEpayment.IsDerivedStyle = true;
            this.lblLEpayment.Location = new System.Drawing.Point(0, 260);
            this.lblLEpayment.Name = "lblLEpayment";
            this.lblLEpayment.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblLEpayment.Size = new System.Drawing.Size(268, 65);
            this.lblLEpayment.Style = MetroSet_UI.Enums.Style.Light;
            this.lblLEpayment.StyleManager = null;
            this.lblLEpayment.TabIndex = 36;
            this.lblLEpayment.Text = "Standard Payment Amount:";
            this.lblLEpayment.ThemeAuthor = "Narwin";
            this.lblLEpayment.ThemeName = "MetroLite";
            // 
            // txtLEfixedAPR
            // 
            this.txtLEfixedAPR.AutoCompleteCustomSource = null;
            this.txtLEfixedAPR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLEfixedAPR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLEfixedAPR.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLEfixedAPR.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtLEfixedAPR.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLEfixedAPR.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtLEfixedAPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLEfixedAPR.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtLEfixedAPR.Image = null;
            this.txtLEfixedAPR.IsDerivedStyle = true;
            this.txtLEfixedAPR.Lines = null;
            this.txtLEfixedAPR.Location = new System.Drawing.Point(298, 230);
            this.txtLEfixedAPR.MaxLength = 32767;
            this.txtLEfixedAPR.Multiline = false;
            this.txtLEfixedAPR.Name = "txtLEfixedAPR";
            this.txtLEfixedAPR.ReadOnly = false;
            this.txtLEfixedAPR.Size = new System.Drawing.Size(375, 30);
            this.txtLEfixedAPR.Style = MetroSet_UI.Enums.Style.Light;
            this.txtLEfixedAPR.StyleManager = null;
            this.txtLEfixedAPR.TabIndex = 35;
            this.txtLEfixedAPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLEfixedAPR.ThemeAuthor = "Narwin";
            this.txtLEfixedAPR.ThemeName = "MetroLite";
            this.txtLEfixedAPR.UseSystemPasswordChar = false;
            this.txtLEfixedAPR.WatermarkText = "";
            this.txtLEfixedAPR.Validating += new System.ComponentModel.CancelEventHandler(this.txtLEfixedAPR_Validating);
            this.txtLEfixedAPR.Validated += new System.EventHandler(this.txtLEfixedAPR_Validated);
            // 
            // lblLEfixedAPR
            // 
            this.lblLEfixedAPR.AutoSize = true;
            this.lblLEfixedAPR.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLEfixedAPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLEfixedAPR.IsDerivedStyle = true;
            this.lblLEfixedAPR.Location = new System.Drawing.Point(0, 195);
            this.lblLEfixedAPR.Name = "lblLEfixedAPR";
            this.lblLEfixedAPR.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblLEfixedAPR.Size = new System.Drawing.Size(163, 65);
            this.lblLEfixedAPR.Style = MetroSet_UI.Enums.Style.Light;
            this.lblLEfixedAPR.StyleManager = null;
            this.lblLEfixedAPR.TabIndex = 34;
            this.lblLEfixedAPR.Text = "Fixed APR (%):";
            this.lblLEfixedAPR.ThemeAuthor = "Narwin";
            this.lblLEfixedAPR.ThemeName = "MetroLite";
            // 
            // lblLEdurationMonths
            // 
            this.lblLEdurationMonths.AutoSize = true;
            this.lblLEdurationMonths.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLEdurationMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLEdurationMonths.IsDerivedStyle = true;
            this.lblLEdurationMonths.Location = new System.Drawing.Point(0, 130);
            this.lblLEdurationMonths.Name = "lblLEdurationMonths";
            this.lblLEdurationMonths.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblLEdurationMonths.Size = new System.Drawing.Size(239, 65);
            this.lblLEdurationMonths.Style = MetroSet_UI.Enums.Style.Light;
            this.lblLEdurationMonths.StyleManager = null;
            this.lblLEdurationMonths.TabIndex = 33;
            this.lblLEdurationMonths.Text = "Loan Duration (Months):";
            this.lblLEdurationMonths.ThemeAuthor = "Narwin";
            this.lblLEdurationMonths.ThemeName = "MetroLite";
            // 
            // txtLEbalance
            // 
            this.txtLEbalance.AutoCompleteCustomSource = null;
            this.txtLEbalance.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLEbalance.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLEbalance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLEbalance.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtLEbalance.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLEbalance.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtLEbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLEbalance.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtLEbalance.Image = null;
            this.txtLEbalance.IsDerivedStyle = true;
            this.txtLEbalance.Lines = null;
            this.txtLEbalance.Location = new System.Drawing.Point(298, 100);
            this.txtLEbalance.MaxLength = 32767;
            this.txtLEbalance.Multiline = false;
            this.txtLEbalance.Name = "txtLEbalance";
            this.txtLEbalance.ReadOnly = false;
            this.txtLEbalance.Size = new System.Drawing.Size(375, 30);
            this.txtLEbalance.Style = MetroSet_UI.Enums.Style.Light;
            this.txtLEbalance.StyleManager = null;
            this.txtLEbalance.TabIndex = 32;
            this.txtLEbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLEbalance.ThemeAuthor = "Narwin";
            this.txtLEbalance.ThemeName = "MetroLite";
            this.txtLEbalance.UseSystemPasswordChar = false;
            this.txtLEbalance.WatermarkText = "";
            this.txtLEbalance.Validating += new System.ComponentModel.CancelEventHandler(this.txtLEbalance_Validating);
            this.txtLEbalance.Validated += new System.EventHandler(this.txtLEbalance_Validated);
            // 
            // lblLEbalance
            // 
            this.lblLEbalance.AutoSize = true;
            this.lblLEbalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLEbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLEbalance.IsDerivedStyle = true;
            this.lblLEbalance.Location = new System.Drawing.Point(0, 65);
            this.lblLEbalance.Name = "lblLEbalance";
            this.lblLEbalance.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblLEbalance.Size = new System.Drawing.Size(153, 65);
            this.lblLEbalance.Style = MetroSet_UI.Enums.Style.Light;
            this.lblLEbalance.StyleManager = null;
            this.lblLEbalance.TabIndex = 31;
            this.lblLEbalance.Text = "Loan Balance:";
            this.lblLEbalance.ThemeAuthor = "Narwin";
            this.lblLEbalance.ThemeName = "MetroLite";
            // 
            // txtLEloanName
            // 
            this.txtLEloanName.AutoCompleteCustomSource = null;
            this.txtLEloanName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLEloanName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLEloanName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLEloanName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtLEloanName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLEloanName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtLEloanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLEloanName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtLEloanName.Image = null;
            this.txtLEloanName.IsDerivedStyle = true;
            this.txtLEloanName.Lines = null;
            this.txtLEloanName.Location = new System.Drawing.Point(298, 35);
            this.txtLEloanName.MaxLength = 32767;
            this.txtLEloanName.Multiline = false;
            this.txtLEloanName.Name = "txtLEloanName";
            this.txtLEloanName.ReadOnly = false;
            this.txtLEloanName.Size = new System.Drawing.Size(750, 30);
            this.txtLEloanName.Style = MetroSet_UI.Enums.Style.Light;
            this.txtLEloanName.StyleManager = null;
            this.txtLEloanName.TabIndex = 30;
            this.txtLEloanName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLEloanName.ThemeAuthor = "Narwin";
            this.txtLEloanName.ThemeName = "MetroLite";
            this.txtLEloanName.UseSystemPasswordChar = false;
            this.txtLEloanName.WatermarkText = "";
            this.txtLEloanName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLEloanName_Validating);
            this.txtLEloanName.Validated += new System.EventHandler(this.txtLEloanName_Validated);
            // 
            // lblLEloanName
            // 
            this.lblLEloanName.AutoSize = true;
            this.lblLEloanName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLEloanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLEloanName.IsDerivedStyle = true;
            this.lblLEloanName.Location = new System.Drawing.Point(0, 0);
            this.lblLEloanName.Name = "lblLEloanName";
            this.lblLEloanName.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblLEloanName.Size = new System.Drawing.Size(134, 65);
            this.lblLEloanName.Style = MetroSet_UI.Enums.Style.Light;
            this.lblLEloanName.StyleManager = null;
            this.lblLEloanName.TabIndex = 29;
            this.lblLEloanName.Text = "Loan Name:";
            this.lblLEloanName.ThemeAuthor = "Narwin";
            this.lblLEloanName.ThemeName = "MetroLite";
            // 
            // btnLEdit
            // 
            this.btnLEdit.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLEdit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLEdit.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnLEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLEdit.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnLEdit.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnLEdit.HoverTextColor = System.Drawing.Color.White;
            this.btnLEdit.IsDerivedStyle = true;
            this.btnLEdit.Location = new System.Drawing.Point(0, 426);
            this.btnLEdit.Name = "btnLEdit";
            this.btnLEdit.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLEdit.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLEdit.NormalTextColor = System.Drawing.Color.White;
            this.btnLEdit.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnLEdit.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnLEdit.PressTextColor = System.Drawing.Color.White;
            this.btnLEdit.Size = new System.Drawing.Size(1105, 23);
            this.btnLEdit.Style = MetroSet_UI.Enums.Style.Light;
            this.btnLEdit.StyleManager = null;
            this.btnLEdit.TabIndex = 28;
            this.btnLEdit.Text = "Edit Loan";
            this.btnLEdit.ThemeAuthor = "Narwin";
            this.btnLEdit.ThemeName = "MetroLite";
            this.btnLEdit.Click += new System.EventHandler(this.btnLEdit_Click);
            // 
            // tbLRemove
            // 
            this.tbLRemove.BaseColor = System.Drawing.Color.White;
            this.tbLRemove.Controls.Add(this.txtLRbalance);
            this.tbLRemove.Controls.Add(this.lblLRbalance);
            this.tbLRemove.Controls.Add(this.txtLRloanName);
            this.tbLRemove.Controls.Add(this.lblLRloanName);
            this.tbLRemove.Controls.Add(this.btnLRemove);
            this.tbLRemove.Font = null;
            this.tbLRemove.ImageIndex = 0;
            this.tbLRemove.ImageKey = null;
            this.tbLRemove.IsDerivedStyle = true;
            this.tbLRemove.Location = new System.Drawing.Point(4, 42);
            this.tbLRemove.Name = "tbLRemove";
            this.tbLRemove.Size = new System.Drawing.Size(1105, 449);
            this.tbLRemove.Style = MetroSet_UI.Enums.Style.Light;
            this.tbLRemove.StyleManager = null;
            this.tbLRemove.TabIndex = 2;
            this.tbLRemove.Text = "Remove Loan";
            this.tbLRemove.ThemeAuthor = "Narwin";
            this.tbLRemove.ThemeName = "MetroLite";
            this.tbLRemove.ToolTipText = null;
            // 
            // txtLRbalance
            // 
            this.txtLRbalance.AutoCompleteCustomSource = null;
            this.txtLRbalance.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLRbalance.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLRbalance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLRbalance.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtLRbalance.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLRbalance.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtLRbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLRbalance.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtLRbalance.Image = null;
            this.txtLRbalance.IsDerivedStyle = true;
            this.txtLRbalance.Lines = null;
            this.txtLRbalance.Location = new System.Drawing.Point(298, 100);
            this.txtLRbalance.MaxLength = 32767;
            this.txtLRbalance.Multiline = false;
            this.txtLRbalance.Name = "txtLRbalance";
            this.txtLRbalance.ReadOnly = true;
            this.txtLRbalance.Size = new System.Drawing.Size(375, 30);
            this.txtLRbalance.Style = MetroSet_UI.Enums.Style.Light;
            this.txtLRbalance.StyleManager = null;
            this.txtLRbalance.TabIndex = 33;
            this.txtLRbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLRbalance.ThemeAuthor = "Narwin";
            this.txtLRbalance.ThemeName = "MetroLite";
            this.txtLRbalance.UseSystemPasswordChar = false;
            this.txtLRbalance.WatermarkText = "";
            // 
            // lblLRbalance
            // 
            this.lblLRbalance.AutoSize = true;
            this.lblLRbalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLRbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLRbalance.IsDerivedStyle = true;
            this.lblLRbalance.Location = new System.Drawing.Point(0, 65);
            this.lblLRbalance.Name = "lblLRbalance";
            this.lblLRbalance.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblLRbalance.Size = new System.Drawing.Size(153, 65);
            this.lblLRbalance.Style = MetroSet_UI.Enums.Style.Light;
            this.lblLRbalance.StyleManager = null;
            this.lblLRbalance.TabIndex = 32;
            this.lblLRbalance.Text = "Loan Balance:";
            this.lblLRbalance.ThemeAuthor = "Narwin";
            this.lblLRbalance.ThemeName = "MetroLite";
            // 
            // txtLRloanName
            // 
            this.txtLRloanName.AutoCompleteCustomSource = null;
            this.txtLRloanName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLRloanName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLRloanName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLRloanName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtLRloanName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLRloanName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtLRloanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLRloanName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtLRloanName.Image = null;
            this.txtLRloanName.IsDerivedStyle = true;
            this.txtLRloanName.Lines = null;
            this.txtLRloanName.Location = new System.Drawing.Point(298, 35);
            this.txtLRloanName.MaxLength = 32767;
            this.txtLRloanName.Multiline = false;
            this.txtLRloanName.Name = "txtLRloanName";
            this.txtLRloanName.ReadOnly = true;
            this.txtLRloanName.Size = new System.Drawing.Size(750, 30);
            this.txtLRloanName.Style = MetroSet_UI.Enums.Style.Light;
            this.txtLRloanName.StyleManager = null;
            this.txtLRloanName.TabIndex = 31;
            this.txtLRloanName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLRloanName.ThemeAuthor = "Narwin";
            this.txtLRloanName.ThemeName = "MetroLite";
            this.txtLRloanName.UseSystemPasswordChar = false;
            this.txtLRloanName.WatermarkText = "";
            // 
            // lblLRloanName
            // 
            this.lblLRloanName.AutoSize = true;
            this.lblLRloanName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLRloanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLRloanName.IsDerivedStyle = true;
            this.lblLRloanName.Location = new System.Drawing.Point(0, 0);
            this.lblLRloanName.Name = "lblLRloanName";
            this.lblLRloanName.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblLRloanName.Size = new System.Drawing.Size(134, 65);
            this.lblLRloanName.Style = MetroSet_UI.Enums.Style.Light;
            this.lblLRloanName.StyleManager = null;
            this.lblLRloanName.TabIndex = 30;
            this.lblLRloanName.Text = "Loan Name:";
            this.lblLRloanName.ThemeAuthor = "Narwin";
            this.lblLRloanName.ThemeName = "MetroLite";
            // 
            // btnLRemove
            // 
            this.btnLRemove.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLRemove.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLRemove.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnLRemove.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLRemove.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnLRemove.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnLRemove.HoverTextColor = System.Drawing.Color.White;
            this.btnLRemove.IsDerivedStyle = true;
            this.btnLRemove.Location = new System.Drawing.Point(0, 426);
            this.btnLRemove.Name = "btnLRemove";
            this.btnLRemove.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLRemove.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLRemove.NormalTextColor = System.Drawing.Color.White;
            this.btnLRemove.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnLRemove.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnLRemove.PressTextColor = System.Drawing.Color.White;
            this.btnLRemove.Size = new System.Drawing.Size(1105, 23);
            this.btnLRemove.Style = MetroSet_UI.Enums.Style.Light;
            this.btnLRemove.StyleManager = null;
            this.btnLRemove.TabIndex = 29;
            this.btnLRemove.Text = "Remove Loan";
            this.btnLRemove.ThemeAuthor = "Narwin";
            this.btnLRemove.ThemeName = "MetroLite";
            this.btnLRemove.Click += new System.EventHandler(this.btnLRemove_Click);
            // 
            // tbCalendar
            // 
            this.tbCalendar.BaseColor = System.Drawing.Color.White;
            this.tbCalendar.Controls.Add(this.pnlCalendar);
            this.tbCalendar.Controls.Add(this.pnlCGraph);
            this.tbCalendar.Font = null;
            this.tbCalendar.ImageIndex = 0;
            this.tbCalendar.ImageKey = null;
            this.tbCalendar.IsDerivedStyle = true;
            this.tbCalendar.Location = new System.Drawing.Point(4, 42);
            this.tbCalendar.Name = "tbCalendar";
            this.tbCalendar.Size = new System.Drawing.Size(2528, 1196);
            this.tbCalendar.Style = MetroSet_UI.Enums.Style.Light;
            this.tbCalendar.StyleManager = null;
            this.tbCalendar.TabIndex = 3;
            this.tbCalendar.Text = "Calendar";
            this.tbCalendar.ThemeAuthor = "Narwin";
            this.tbCalendar.ThemeName = "MetroLite";
            this.tbCalendar.ToolTipText = null;
            // 
            // pnlCalendar
            // 
            this.pnlCalendar.BackgroundColor = System.Drawing.Color.White;
            this.pnlCalendar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.pnlCalendar.BorderThickness = 1;
            this.pnlCalendar.Controls.Add(this.lblYear);
            this.pnlCalendar.Controls.Add(this.lblMonth);
            this.pnlCalendar.Controls.Add(this.lblSaturday);
            this.pnlCalendar.Controls.Add(this.lblFri);
            this.pnlCalendar.Controls.Add(this.lblThurs);
            this.pnlCalendar.Controls.Add(this.lblWed);
            this.pnlCalendar.Controls.Add(this.lblTuesday);
            this.pnlCalendar.Controls.Add(this.lblMonday);
            this.pnlCalendar.Controls.Add(this.lblSunday);
            this.pnlCalendar.Controls.Add(this.btnPrevious);
            this.pnlCalendar.Controls.Add(this.btnNext);
            this.pnlCalendar.Controls.Add(this.flwDayContainer);
            this.pnlCalendar.IsDerivedStyle = true;
            this.pnlCalendar.Location = new System.Drawing.Point(35, 17);
            this.pnlCalendar.Name = "pnlCalendar";
            this.pnlCalendar.Size = new System.Drawing.Size(2450, 874);
            this.pnlCalendar.Style = MetroSet_UI.Enums.Style.Light;
            this.pnlCalendar.StyleManager = null;
            this.pnlCalendar.TabIndex = 1;
            this.pnlCalendar.ThemeAuthor = "Narwin";
            this.pnlCalendar.ThemeName = "MetroLite";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.IsDerivedStyle = true;
            this.lblYear.Location = new System.Drawing.Point(1352, 15);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(130, 55);
            this.lblYear.Style = MetroSet_UI.Enums.Style.Light;
            this.lblYear.StyleManager = null;
            this.lblYear.TabIndex = 23;
            this.lblYear.Text = "Year";
            this.lblYear.ThemeAuthor = "Narwin";
            this.lblYear.ThemeName = "MetroLite";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.IsDerivedStyle = true;
            this.lblMonth.Location = new System.Drawing.Point(989, 15);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(163, 55);
            this.lblMonth.Style = MetroSet_UI.Enums.Style.Light;
            this.lblMonth.StyleManager = null;
            this.lblMonth.TabIndex = 22;
            this.lblMonth.Text = "Month";
            this.lblMonth.ThemeAuthor = "Narwin";
            this.lblMonth.ThemeName = "MetroLite";
            // 
            // lblSaturday
            // 
            this.lblSaturday.AutoSize = true;
            this.lblSaturday.Font = new System.Drawing.Font("Reem Kufi", 15.75F);
            this.lblSaturday.IsDerivedStyle = true;
            this.lblSaturday.Location = new System.Drawing.Point(2219, 58);
            this.lblSaturday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(160, 61);
            this.lblSaturday.Style = MetroSet_UI.Enums.Style.Light;
            this.lblSaturday.StyleManager = null;
            this.lblSaturday.TabIndex = 21;
            this.lblSaturday.Text = "Saturday";
            this.lblSaturday.ThemeAuthor = "Narwin";
            this.lblSaturday.ThemeName = "MetroLite";
            // 
            // lblFri
            // 
            this.lblFri.AutoSize = true;
            this.lblFri.Font = new System.Drawing.Font("Reem Kufi", 15.75F);
            this.lblFri.IsDerivedStyle = true;
            this.lblFri.Location = new System.Drawing.Point(1881, 58);
            this.lblFri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFri.Name = "lblFri";
            this.lblFri.Size = new System.Drawing.Size(119, 61);
            this.lblFri.Style = MetroSet_UI.Enums.Style.Light;
            this.lblFri.StyleManager = null;
            this.lblFri.TabIndex = 20;
            this.lblFri.Text = "Friday";
            this.lblFri.ThemeAuthor = "Narwin";
            this.lblFri.ThemeName = "MetroLite";
            // 
            // lblThurs
            // 
            this.lblThurs.AutoSize = true;
            this.lblThurs.Font = new System.Drawing.Font("Reem Kufi", 15.75F);
            this.lblThurs.IsDerivedStyle = true;
            this.lblThurs.Location = new System.Drawing.Point(1513, 58);
            this.lblThurs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThurs.Name = "lblThurs";
            this.lblThurs.Size = new System.Drawing.Size(161, 61);
            this.lblThurs.Style = MetroSet_UI.Enums.Style.Light;
            this.lblThurs.StyleManager = null;
            this.lblThurs.TabIndex = 19;
            this.lblThurs.Text = "Thursday";
            this.lblThurs.ThemeAuthor = "Narwin";
            this.lblThurs.ThemeName = "MetroLite";
            // 
            // lblWed
            // 
            this.lblWed.AutoSize = true;
            this.lblWed.Font = new System.Drawing.Font("Reem Kufi", 15.75F);
            this.lblWed.IsDerivedStyle = true;
            this.lblWed.Location = new System.Drawing.Point(1155, 58);
            this.lblWed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWed.Name = "lblWed";
            this.lblWed.Size = new System.Drawing.Size(194, 61);
            this.lblWed.Style = MetroSet_UI.Enums.Style.Light;
            this.lblWed.StyleManager = null;
            this.lblWed.TabIndex = 18;
            this.lblWed.Text = "Wednesday";
            this.lblWed.ThemeAuthor = "Narwin";
            this.lblWed.ThemeName = "MetroLite";
            // 
            // lblTuesday
            // 
            this.lblTuesday.AutoSize = true;
            this.lblTuesday.Font = new System.Drawing.Font("Reem Kufi", 15.75F);
            this.lblTuesday.IsDerivedStyle = true;
            this.lblTuesday.Location = new System.Drawing.Point(827, 58);
            this.lblTuesday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(146, 61);
            this.lblTuesday.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTuesday.StyleManager = null;
            this.lblTuesday.TabIndex = 17;
            this.lblTuesday.Text = "Tuesday";
            this.lblTuesday.ThemeAuthor = "Narwin";
            this.lblTuesday.ThemeName = "MetroLite";
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.Font = new System.Drawing.Font("Reem Kufi", 15.75F);
            this.lblMonday.IsDerivedStyle = true;
            this.lblMonday.Location = new System.Drawing.Point(487, 58);
            this.lblMonday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(147, 61);
            this.lblMonday.Style = MetroSet_UI.Enums.Style.Light;
            this.lblMonday.StyleManager = null;
            this.lblMonday.TabIndex = 16;
            this.lblMonday.Text = "Monday";
            this.lblMonday.ThemeAuthor = "Narwin";
            this.lblMonday.ThemeName = "MetroLite";
            // 
            // lblSunday
            // 
            this.lblSunday.AutoSize = true;
            this.lblSunday.Font = new System.Drawing.Font("Reem Kufi", 15.75F);
            this.lblSunday.IsDerivedStyle = true;
            this.lblSunday.Location = new System.Drawing.Point(133, 58);
            this.lblSunday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(136, 61);
            this.lblSunday.Style = MetroSet_UI.Enums.Style.Light;
            this.lblSunday.StyleManager = null;
            this.lblSunday.TabIndex = 15;
            this.lblSunday.Text = "Sunday";
            this.lblSunday.ThemeAuthor = "Narwin";
            this.lblSunday.ThemeName = "MetroLite";
            // 
            // btnPrevious
            // 
            this.btnPrevious.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnPrevious.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnPrevious.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPrevious.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnPrevious.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnPrevious.HoverTextColor = System.Drawing.Color.White;
            this.btnPrevious.IsDerivedStyle = true;
            this.btnPrevious.Location = new System.Drawing.Point(678, 31);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnPrevious.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnPrevious.NormalTextColor = System.Drawing.Color.White;
            this.btnPrevious.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnPrevious.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnPrevious.PressTextColor = System.Drawing.Color.White;
            this.btnPrevious.Size = new System.Drawing.Size(50, 15);
            this.btnPrevious.Style = MetroSet_UI.Enums.Style.Light;
            this.btnPrevious.StyleManager = null;
            this.btnPrevious.TabIndex = 14;
            this.btnPrevious.Text = "<";
            this.btnPrevious.ThemeAuthor = "Narwin";
            this.btnPrevious.ThemeName = "MetroLite";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnNext.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnNext.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNext.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnNext.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnNext.HoverTextColor = System.Drawing.Color.White;
            this.btnNext.IsDerivedStyle = true;
            this.btnNext.Location = new System.Drawing.Point(1719, 31);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnNext.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnNext.NormalTextColor = System.Drawing.Color.White;
            this.btnNext.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnNext.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnNext.PressTextColor = System.Drawing.Color.White;
            this.btnNext.Size = new System.Drawing.Size(50, 15);
            this.btnNext.Style = MetroSet_UI.Enums.Style.Light;
            this.btnNext.StyleManager = null;
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = ">";
            this.btnNext.ThemeAuthor = "Narwin";
            this.btnNext.ThemeName = "MetroLite";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // flwDayContainer
            // 
            this.flwDayContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flwDayContainer.Location = new System.Drawing.Point(0, 126);
            this.flwDayContainer.Margin = new System.Windows.Forms.Padding(2);
            this.flwDayContainer.Name = "flwDayContainer";
            this.flwDayContainer.Size = new System.Drawing.Size(2450, 748);
            this.flwDayContainer.TabIndex = 12;
            // 
            // pnlCGraph
            // 
            this.pnlCGraph.BackgroundColor = System.Drawing.Color.White;
            this.pnlCGraph.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.pnlCGraph.BorderThickness = 1;
            this.pnlCGraph.Controls.Add(this.chtCTrans);
            this.pnlCGraph.IsDerivedStyle = true;
            this.pnlCGraph.Location = new System.Drawing.Point(35, 911);
            this.pnlCGraph.Name = "pnlCGraph";
            this.pnlCGraph.Size = new System.Drawing.Size(2450, 282);
            this.pnlCGraph.Style = MetroSet_UI.Enums.Style.Light;
            this.pnlCGraph.StyleManager = null;
            this.pnlCGraph.TabIndex = 0;
            this.pnlCGraph.ThemeAuthor = "Narwin";
            this.pnlCGraph.ThemeName = "MetroLite";
            // 
            // chtCTrans
            // 
            this.chtCTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chtCTrans.Location = new System.Drawing.Point(0, 0);
            this.chtCTrans.Name = "chtCTrans";
            this.chtCTrans.Size = new System.Drawing.Size(2450, 282);
            this.chtCTrans.TabIndex = 0;
            // 
            // tbBudget
            // 
            this.tbBudget.BaseColor = System.Drawing.Color.White;
            this.tbBudget.Controls.Add(this.tbcBudgetView);
            this.tbBudget.Controls.Add(this.tbcBudget);
            this.tbBudget.Controls.Add(this.pnlBcharts);
            this.tbBudget.Font = null;
            this.tbBudget.ImageIndex = 0;
            this.tbBudget.ImageKey = null;
            this.tbBudget.IsDerivedStyle = true;
            this.tbBudget.Location = new System.Drawing.Point(4, 42);
            this.tbBudget.Name = "tbBudget";
            this.tbBudget.Size = new System.Drawing.Size(2528, 1196);
            this.tbBudget.Style = MetroSet_UI.Enums.Style.Light;
            this.tbBudget.StyleManager = null;
            this.tbBudget.TabIndex = 4;
            this.tbBudget.Text = "Budget";
            this.tbBudget.ThemeAuthor = "Narwin";
            this.tbBudget.ThemeName = "MetroLite";
            this.tbBudget.ToolTipText = null;
            // 
            // tbcBudgetView
            // 
            this.tbcBudgetView.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.tbcBudgetView.AnimateTime = 200;
            this.tbcBudgetView.BackgroundColor = System.Drawing.Color.White;
            this.tbcBudgetView.Controls.Add(this.tbCcategories);
            this.tbcBudgetView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbcBudgetView.IsDerivedStyle = true;
            this.tbcBudgetView.ItemSize = new System.Drawing.Size(100, 38);
            this.tbcBudgetView.Location = new System.Drawing.Point(1192, 52);
            this.tbcBudgetView.Name = "tbcBudgetView";
            this.tbcBudgetView.SelectedIndex = 0;
            this.tbcBudgetView.SelectedTextColor = System.Drawing.Color.White;
            this.tbcBudgetView.Size = new System.Drawing.Size(1293, 635);
            this.tbcBudgetView.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcBudgetView.Speed = 100;
            this.tbcBudgetView.Style = MetroSet_UI.Enums.Style.Light;
            this.tbcBudgetView.StyleManager = null;
            this.tbcBudgetView.TabIndex = 9;
            this.tbcBudgetView.ThemeAuthor = "Narwin";
            this.tbcBudgetView.ThemeName = "MetroLite";
            this.tbcBudgetView.UnselectedTextColor = System.Drawing.Color.Gray;
            this.tbcBudgetView.UseAnimation = false;
            // 
            // tbCcategories
            // 
            this.tbCcategories.BaseColor = System.Drawing.Color.White;
            this.tbCcategories.Controls.Add(this.grdBcategories);
            this.tbCcategories.Font = null;
            this.tbCcategories.ImageIndex = 0;
            this.tbCcategories.ImageKey = null;
            this.tbCcategories.IsDerivedStyle = true;
            this.tbCcategories.Location = new System.Drawing.Point(4, 42);
            this.tbCcategories.Name = "tbCcategories";
            this.tbCcategories.Size = new System.Drawing.Size(1285, 589);
            this.tbCcategories.Style = MetroSet_UI.Enums.Style.Light;
            this.tbCcategories.StyleManager = null;
            this.tbCcategories.TabIndex = 0;
            this.tbCcategories.Text = "Categories";
            this.tbCcategories.ThemeAuthor = "Narwin";
            this.tbCcategories.ThemeName = "MetroLite";
            this.tbCcategories.ToolTipText = null;
            // 
            // grdBcategories
            // 
            this.grdBcategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdBcategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBcategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBcategories.Location = new System.Drawing.Point(0, 0);
            this.grdBcategories.Name = "grdBcategories";
            this.grdBcategories.RowHeadersWidth = 62;
            this.grdBcategories.RowTemplate.Height = 28;
            this.grdBcategories.Size = new System.Drawing.Size(1285, 589);
            this.grdBcategories.TabIndex = 0;
            this.grdBcategories.SelectionChanged += new System.EventHandler(this.grdBcategories_SelectionChanged);
            // 
            // tbcBudget
            // 
            this.tbcBudget.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.tbcBudget.AnimateTime = 200;
            this.tbcBudget.BackgroundColor = System.Drawing.Color.White;
            this.tbcBudget.Controls.Add(this.tbBAdd);
            this.tbcBudget.Controls.Add(this.tbBEdit);
            this.tbcBudget.Controls.Add(this.tbBRemove);
            this.tbcBudget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbcBudget.IsDerivedStyle = true;
            this.tbcBudget.ItemSize = new System.Drawing.Size(100, 38);
            this.tbcBudget.Location = new System.Drawing.Point(51, 52);
            this.tbcBudget.Name = "tbcBudget";
            this.tbcBudget.SelectedIndex = 0;
            this.tbcBudget.SelectedTextColor = System.Drawing.Color.White;
            this.tbcBudget.Size = new System.Drawing.Size(1113, 181);
            this.tbcBudget.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcBudget.Speed = 100;
            this.tbcBudget.Style = MetroSet_UI.Enums.Style.Light;
            this.tbcBudget.StyleManager = null;
            this.tbcBudget.TabIndex = 8;
            this.tbcBudget.ThemeAuthor = "Narwin";
            this.tbcBudget.ThemeName = "MetroLite";
            this.tbcBudget.UnselectedTextColor = System.Drawing.Color.Gray;
            this.tbcBudget.UseAnimation = false;
            // 
            // tbBAdd
            // 
            this.tbBAdd.BaseColor = System.Drawing.Color.White;
            this.tbBAdd.Controls.Add(this.btnBAdd);
            this.tbBAdd.Controls.Add(this.txtBAcategoryName);
            this.tbBAdd.Controls.Add(this.lblBAcategoryName);
            this.tbBAdd.Font = null;
            this.tbBAdd.ImageIndex = 0;
            this.tbBAdd.ImageKey = null;
            this.tbBAdd.IsDerivedStyle = true;
            this.tbBAdd.Location = new System.Drawing.Point(4, 42);
            this.tbBAdd.Name = "tbBAdd";
            this.tbBAdd.Size = new System.Drawing.Size(1105, 135);
            this.tbBAdd.Style = MetroSet_UI.Enums.Style.Light;
            this.tbBAdd.StyleManager = null;
            this.tbBAdd.TabIndex = 0;
            this.tbBAdd.Text = "Add Category";
            this.tbBAdd.ThemeAuthor = "Narwin";
            this.tbBAdd.ThemeName = "MetroLite";
            this.tbBAdd.ToolTipText = null;
            // 
            // btnBAdd
            // 
            this.btnBAdd.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBAdd.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnBAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBAdd.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnBAdd.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnBAdd.HoverTextColor = System.Drawing.Color.White;
            this.btnBAdd.IsDerivedStyle = true;
            this.btnBAdd.Location = new System.Drawing.Point(0, 112);
            this.btnBAdd.Name = "btnBAdd";
            this.btnBAdd.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBAdd.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBAdd.NormalTextColor = System.Drawing.Color.White;
            this.btnBAdd.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnBAdd.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnBAdd.PressTextColor = System.Drawing.Color.White;
            this.btnBAdd.Size = new System.Drawing.Size(1105, 23);
            this.btnBAdd.Style = MetroSet_UI.Enums.Style.Light;
            this.btnBAdd.StyleManager = null;
            this.btnBAdd.TabIndex = 14;
            this.btnBAdd.Text = "Add Category";
            this.btnBAdd.ThemeAuthor = "Narwin";
            this.btnBAdd.ThemeName = "MetroLite";
            this.btnBAdd.Click += new System.EventHandler(this.btnBAdd_Click);
            // 
            // txtBAcategoryName
            // 
            this.txtBAcategoryName.AutoCompleteCustomSource = null;
            this.txtBAcategoryName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBAcategoryName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBAcategoryName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtBAcategoryName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBAcategoryName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtBAcategoryName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtBAcategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBAcategoryName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtBAcategoryName.Image = null;
            this.txtBAcategoryName.IsDerivedStyle = true;
            this.txtBAcategoryName.Lines = null;
            this.txtBAcategoryName.Location = new System.Drawing.Point(298, 35);
            this.txtBAcategoryName.MaxLength = 32767;
            this.txtBAcategoryName.Multiline = false;
            this.txtBAcategoryName.Name = "txtBAcategoryName";
            this.txtBAcategoryName.ReadOnly = false;
            this.txtBAcategoryName.Size = new System.Drawing.Size(750, 30);
            this.txtBAcategoryName.Style = MetroSet_UI.Enums.Style.Light;
            this.txtBAcategoryName.StyleManager = null;
            this.txtBAcategoryName.TabIndex = 1;
            this.txtBAcategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBAcategoryName.ThemeAuthor = "Narwin";
            this.txtBAcategoryName.ThemeName = "MetroLite";
            this.txtBAcategoryName.UseSystemPasswordChar = false;
            this.txtBAcategoryName.WatermarkText = "";
            this.txtBAcategoryName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBAcategoryName_Validating);
            this.txtBAcategoryName.Validated += new System.EventHandler(this.txtBAcategoryName_Validated);
            // 
            // lblBAcategoryName
            // 
            this.lblBAcategoryName.AutoSize = true;
            this.lblBAcategoryName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBAcategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBAcategoryName.IsDerivedStyle = true;
            this.lblBAcategoryName.Location = new System.Drawing.Point(0, 0);
            this.lblBAcategoryName.Name = "lblBAcategoryName";
            this.lblBAcategoryName.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblBAcategoryName.Size = new System.Drawing.Size(170, 65);
            this.lblBAcategoryName.Style = MetroSet_UI.Enums.Style.Light;
            this.lblBAcategoryName.StyleManager = null;
            this.lblBAcategoryName.TabIndex = 0;
            this.lblBAcategoryName.Text = "Category Name:";
            this.lblBAcategoryName.ThemeAuthor = "Narwin";
            this.lblBAcategoryName.ThemeName = "MetroLite";
            // 
            // tbBEdit
            // 
            this.tbBEdit.BaseColor = System.Drawing.Color.White;
            this.tbBEdit.Controls.Add(this.txtBEcategoryName);
            this.tbBEdit.Controls.Add(this.lblBEcategoryName);
            this.tbBEdit.Controls.Add(this.btnBEdit);
            this.tbBEdit.Font = null;
            this.tbBEdit.ImageIndex = 0;
            this.tbBEdit.ImageKey = null;
            this.tbBEdit.IsDerivedStyle = true;
            this.tbBEdit.Location = new System.Drawing.Point(4, 42);
            this.tbBEdit.Name = "tbBEdit";
            this.tbBEdit.Size = new System.Drawing.Size(1105, 135);
            this.tbBEdit.Style = MetroSet_UI.Enums.Style.Light;
            this.tbBEdit.StyleManager = null;
            this.tbBEdit.TabIndex = 1;
            this.tbBEdit.Text = "Edit Category";
            this.tbBEdit.ThemeAuthor = "Narwin";
            this.tbBEdit.ThemeName = "MetroLite";
            this.tbBEdit.ToolTipText = null;
            // 
            // txtBEcategoryName
            // 
            this.txtBEcategoryName.AutoCompleteCustomSource = null;
            this.txtBEcategoryName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBEcategoryName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBEcategoryName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtBEcategoryName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBEcategoryName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtBEcategoryName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtBEcategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBEcategoryName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtBEcategoryName.Image = null;
            this.txtBEcategoryName.IsDerivedStyle = true;
            this.txtBEcategoryName.Lines = null;
            this.txtBEcategoryName.Location = new System.Drawing.Point(298, 35);
            this.txtBEcategoryName.MaxLength = 32767;
            this.txtBEcategoryName.Multiline = false;
            this.txtBEcategoryName.Name = "txtBEcategoryName";
            this.txtBEcategoryName.ReadOnly = false;
            this.txtBEcategoryName.Size = new System.Drawing.Size(750, 30);
            this.txtBEcategoryName.Style = MetroSet_UI.Enums.Style.Light;
            this.txtBEcategoryName.StyleManager = null;
            this.txtBEcategoryName.TabIndex = 30;
            this.txtBEcategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBEcategoryName.ThemeAuthor = "Narwin";
            this.txtBEcategoryName.ThemeName = "MetroLite";
            this.txtBEcategoryName.UseSystemPasswordChar = false;
            this.txtBEcategoryName.WatermarkText = "";
            this.txtBEcategoryName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBEcategoryName_Validating);
            this.txtBEcategoryName.Validated += new System.EventHandler(this.txtBEcategoryName_Validated);
            // 
            // lblBEcategoryName
            // 
            this.lblBEcategoryName.AutoSize = true;
            this.lblBEcategoryName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBEcategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBEcategoryName.IsDerivedStyle = true;
            this.lblBEcategoryName.Location = new System.Drawing.Point(0, 0);
            this.lblBEcategoryName.Name = "lblBEcategoryName";
            this.lblBEcategoryName.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblBEcategoryName.Size = new System.Drawing.Size(170, 65);
            this.lblBEcategoryName.Style = MetroSet_UI.Enums.Style.Light;
            this.lblBEcategoryName.StyleManager = null;
            this.lblBEcategoryName.TabIndex = 29;
            this.lblBEcategoryName.Text = "Category Name:";
            this.lblBEcategoryName.ThemeAuthor = "Narwin";
            this.lblBEcategoryName.ThemeName = "MetroLite";
            // 
            // btnBEdit
            // 
            this.btnBEdit.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBEdit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBEdit.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnBEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBEdit.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnBEdit.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnBEdit.HoverTextColor = System.Drawing.Color.White;
            this.btnBEdit.IsDerivedStyle = true;
            this.btnBEdit.Location = new System.Drawing.Point(0, 112);
            this.btnBEdit.Name = "btnBEdit";
            this.btnBEdit.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBEdit.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBEdit.NormalTextColor = System.Drawing.Color.White;
            this.btnBEdit.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnBEdit.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnBEdit.PressTextColor = System.Drawing.Color.White;
            this.btnBEdit.Size = new System.Drawing.Size(1105, 23);
            this.btnBEdit.Style = MetroSet_UI.Enums.Style.Light;
            this.btnBEdit.StyleManager = null;
            this.btnBEdit.TabIndex = 28;
            this.btnBEdit.Text = "Edit Category";
            this.btnBEdit.ThemeAuthor = "Narwin";
            this.btnBEdit.ThemeName = "MetroLite";
            this.btnBEdit.Click += new System.EventHandler(this.btnBEdit_Click);
            // 
            // tbBRemove
            // 
            this.tbBRemove.BaseColor = System.Drawing.Color.White;
            this.tbBRemove.Controls.Add(this.txtBRcategoryName);
            this.tbBRemove.Controls.Add(this.lblBRcategoryName);
            this.tbBRemove.Controls.Add(this.btnBRemove);
            this.tbBRemove.Font = null;
            this.tbBRemove.ImageIndex = 0;
            this.tbBRemove.ImageKey = null;
            this.tbBRemove.IsDerivedStyle = true;
            this.tbBRemove.Location = new System.Drawing.Point(4, 42);
            this.tbBRemove.Name = "tbBRemove";
            this.tbBRemove.Size = new System.Drawing.Size(1105, 135);
            this.tbBRemove.Style = MetroSet_UI.Enums.Style.Light;
            this.tbBRemove.StyleManager = null;
            this.tbBRemove.TabIndex = 2;
            this.tbBRemove.Text = "Remove Category";
            this.tbBRemove.ThemeAuthor = "Narwin";
            this.tbBRemove.ThemeName = "MetroLite";
            this.tbBRemove.ToolTipText = null;
            // 
            // txtBRcategoryName
            // 
            this.txtBRcategoryName.AutoCompleteCustomSource = null;
            this.txtBRcategoryName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBRcategoryName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBRcategoryName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtBRcategoryName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBRcategoryName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtBRcategoryName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtBRcategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBRcategoryName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtBRcategoryName.Image = null;
            this.txtBRcategoryName.IsDerivedStyle = true;
            this.txtBRcategoryName.Lines = null;
            this.txtBRcategoryName.Location = new System.Drawing.Point(298, 35);
            this.txtBRcategoryName.MaxLength = 32767;
            this.txtBRcategoryName.Multiline = false;
            this.txtBRcategoryName.Name = "txtBRcategoryName";
            this.txtBRcategoryName.ReadOnly = true;
            this.txtBRcategoryName.Size = new System.Drawing.Size(750, 30);
            this.txtBRcategoryName.Style = MetroSet_UI.Enums.Style.Light;
            this.txtBRcategoryName.StyleManager = null;
            this.txtBRcategoryName.TabIndex = 31;
            this.txtBRcategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBRcategoryName.ThemeAuthor = "Narwin";
            this.txtBRcategoryName.ThemeName = "MetroLite";
            this.txtBRcategoryName.UseSystemPasswordChar = false;
            this.txtBRcategoryName.WatermarkText = "";
            // 
            // lblBRcategoryName
            // 
            this.lblBRcategoryName.AutoSize = true;
            this.lblBRcategoryName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBRcategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBRcategoryName.IsDerivedStyle = true;
            this.lblBRcategoryName.Location = new System.Drawing.Point(0, 0);
            this.lblBRcategoryName.Name = "lblBRcategoryName";
            this.lblBRcategoryName.Padding = new System.Windows.Forms.Padding(15, 40, 0, 0);
            this.lblBRcategoryName.Size = new System.Drawing.Size(170, 65);
            this.lblBRcategoryName.Style = MetroSet_UI.Enums.Style.Light;
            this.lblBRcategoryName.StyleManager = null;
            this.lblBRcategoryName.TabIndex = 30;
            this.lblBRcategoryName.Text = "Category Name:";
            this.lblBRcategoryName.ThemeAuthor = "Narwin";
            this.lblBRcategoryName.ThemeName = "MetroLite";
            // 
            // btnBRemove
            // 
            this.btnBRemove.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBRemove.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBRemove.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnBRemove.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBRemove.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnBRemove.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnBRemove.HoverTextColor = System.Drawing.Color.White;
            this.btnBRemove.IsDerivedStyle = true;
            this.btnBRemove.Location = new System.Drawing.Point(0, 112);
            this.btnBRemove.Name = "btnBRemove";
            this.btnBRemove.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBRemove.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBRemove.NormalTextColor = System.Drawing.Color.White;
            this.btnBRemove.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnBRemove.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnBRemove.PressTextColor = System.Drawing.Color.White;
            this.btnBRemove.Size = new System.Drawing.Size(1105, 23);
            this.btnBRemove.Style = MetroSet_UI.Enums.Style.Light;
            this.btnBRemove.StyleManager = null;
            this.btnBRemove.TabIndex = 29;
            this.btnBRemove.Text = "Remove Category";
            this.btnBRemove.ThemeAuthor = "Narwin";
            this.btnBRemove.ThemeName = "MetroLite";
            this.btnBRemove.Click += new System.EventHandler(this.btnBRemove_Click);
            // 
            // pnlBcharts
            // 
            this.pnlBcharts.BackgroundColor = System.Drawing.Color.White;
            this.pnlBcharts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.pnlBcharts.BorderThickness = 1;
            this.pnlBcharts.Controls.Add(this.pieBCategory);
            this.pnlBcharts.Controls.Add(this.metroSetDivider2);
            this.pnlBcharts.Controls.Add(this.chtBCategory);
            this.pnlBcharts.IsDerivedStyle = true;
            this.pnlBcharts.Location = new System.Drawing.Point(55, 710);
            this.pnlBcharts.Name = "pnlBcharts";
            this.pnlBcharts.Size = new System.Drawing.Size(2426, 483);
            this.pnlBcharts.Style = MetroSet_UI.Enums.Style.Light;
            this.pnlBcharts.StyleManager = null;
            this.pnlBcharts.TabIndex = 0;
            this.pnlBcharts.ThemeAuthor = "Narwin";
            this.pnlBcharts.ThemeName = "MetroLite";
            // 
            // pieBCategory
            // 
            this.pieBCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.pieBCategory.Location = new System.Drawing.Point(0, 0);
            this.pieBCategory.Name = "pieBCategory";
            this.pieBCategory.Size = new System.Drawing.Size(585, 483);
            this.pieBCategory.TabIndex = 2;
            // 
            // metroSetDivider2
            // 
            this.metroSetDivider2.IsDerivedStyle = true;
            this.metroSetDivider2.Location = new System.Drawing.Point(624, 22);
            this.metroSetDivider2.Name = "metroSetDivider2";
            this.metroSetDivider2.Orientation = MetroSet_UI.Enums.DividerStyle.Vertical;
            this.metroSetDivider2.Size = new System.Drawing.Size(4, 448);
            this.metroSetDivider2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetDivider2.StyleManager = null;
            this.metroSetDivider2.TabIndex = 1;
            this.metroSetDivider2.Text = "metroSetDivider2";
            this.metroSetDivider2.ThemeAuthor = "Narwin";
            this.metroSetDivider2.ThemeName = "MetroLite";
            this.metroSetDivider2.Thickness = 1;
            // 
            // chtBCategory
            // 
            this.chtBCategory.Dock = System.Windows.Forms.DockStyle.Right;
            this.chtBCategory.Location = new System.Drawing.Point(716, 0);
            this.chtBCategory.Name = "chtBCategory";
            this.chtBCategory.Size = new System.Drawing.Size(1710, 483);
            this.chtBCategory.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 180);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtTSusername,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(2276, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(164, 33);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtTSusername
            // 
            this.txtTSusername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTSusername.Name = "txtTSusername";
            this.txtTSusername.Size = new System.Drawing.Size(100, 33);
            this.txtTSusername.Text = "Username";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(42, 28);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeading.Font = new System.Drawing.Font("Reem Kufi", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.Black;
            this.lblHeading.Location = new System.Drawing.Point(197, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(292, 106);
            this.lblHeading.TabIndex = 6;
            this.lblHeading.Text = "New Leaf";
            // 
            // lblSubHeading
            // 
            this.lblSubHeading.AutoSize = true;
            this.lblSubHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblSubHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubHeading.Font = new System.Drawing.Font("Reem Kufi", 14.25F);
            this.lblSubHeading.ForeColor = System.Drawing.Color.Black;
            this.lblSubHeading.Location = new System.Drawing.Point(197, 106);
            this.lblSubHeading.Name = "lblSubHeading";
            this.lblSubHeading.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.lblSubHeading.Size = new System.Drawing.Size(309, 56);
            this.lblSubHeading.TabIndex = 7;
            this.lblSubHeading.Text = "Personal Finance App";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblSubHeading);
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 180);
            this.panel1.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 50;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // Dashboard
            // 
            this.AllowResize = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(2560, 1440);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tbcMain);
            this.Controls.Add(this.metroSetControlBox1);
            this.MinimumSize = new System.Drawing.Size(2558, 1390);
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.ShowLeftRect = false;
            this.ShowTitle = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tbcMain.ResumeLayout(false);
            this.tbDash.ResumeLayout(false);
            this.pnlDGraph.ResumeLayout(false);
            this.tbcDashView.ResumeLayout(false);
            this.tbDPastTrans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDPastTrans)).EndInit();
            this.tbDFutTrans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDFutTrans)).EndInit();
            this.pnlDCharts.ResumeLayout(false);
            this.tbTrans.ResumeLayout(false);
            this.pnlTGraph.ResumeLayout(false);
            this.tbcTransView.ResumeLayout(false);
            this.tbTPastTrans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTPastTrans)).EndInit();
            this.tbTFutTrans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTFutTrans)).EndInit();
            this.tbcTrans.ResumeLayout(false);
            this.tbTAdd.ResumeLayout(false);
            this.tbTAdd.PerformLayout();
            this.tbTEdit.ResumeLayout(false);
            this.tbTEdit.PerformLayout();
            this.tbTRemove.ResumeLayout(false);
            this.tbTRemove.PerformLayout();
            this.tbLoans.ResumeLayout(false);
            this.pnlLGraph.ResumeLayout(false);
            this.tbcLoansView.ResumeLayout(false);
            this.tbLloans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdLloans)).EndInit();
            this.tbcLoans.ResumeLayout(false);
            this.tbLAdd.ResumeLayout(false);
            this.tbLAdd.PerformLayout();
            this.tbLEdit.ResumeLayout(false);
            this.tbLEdit.PerformLayout();
            this.tbLRemove.ResumeLayout(false);
            this.tbLRemove.PerformLayout();
            this.tbCalendar.ResumeLayout(false);
            this.pnlCalendar.ResumeLayout(false);
            this.pnlCalendar.PerformLayout();
            this.pnlCGraph.ResumeLayout(false);
            this.tbBudget.ResumeLayout(false);
            this.tbcBudgetView.ResumeLayout(false);
            this.tbCcategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBcategories)).EndInit();
            this.tbcBudget.ResumeLayout(false);
            this.tbBAdd.ResumeLayout(false);
            this.tbBAdd.PerformLayout();
            this.tbBEdit.ResumeLayout(false);
            this.tbBEdit.PerformLayout();
            this.tbBRemove.ResumeLayout(false);
            this.tbBRemove.PerformLayout();
            this.pnlBcharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.ImageList imageList1;
        private MetroSet_UI.Controls.MetroSetTabControl tbcMain;
        private MetroSet_UI.Child.MetroSetSetTabPage tbDash;
        private MetroSet_UI.Controls.MetroSetTabControl tbcDashView;
        private MetroSet_UI.Child.MetroSetSetTabPage tbDPastTrans;
        private System.Windows.Forms.DataGridView grdDPastTrans;
        private MetroSet_UI.Child.MetroSetSetTabPage tbDFutTrans;
        private System.Windows.Forms.DataGridView grdDFutTrans;
        private MetroSet_UI.Controls.MetroSetPanel pnlDCharts;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider1;
        private LiveCharts.WinForms.PieChart pieDCategory;
        private LiveCharts.WinForms.CartesianChart chtDTrans;
        private MetroSet_UI.Child.MetroSetSetTabPage tbTrans;
        private MetroSet_UI.Controls.MetroSetTabControl tbcTransView;
        private MetroSet_UI.Child.MetroSetSetTabPage tbTPastTrans;
        private System.Windows.Forms.DataGridView grdTPastTrans;
        private MetroSet_UI.Child.MetroSetSetTabPage tbTFutTrans;
        private System.Windows.Forms.DataGridView grdTFutTrans;
        private MetroSet_UI.Controls.MetroSetTabControl tbcTrans;
        private MetroSet_UI.Child.MetroSetSetTabPage tbTAdd;
        private MetroSet_UI.Controls.MetroSetLabel lblTAtransName;
        private MetroSet_UI.Child.MetroSetSetTabPage tbTEdit;
        private MetroSet_UI.Child.MetroSetSetTabPage tbTRemove;
        private MetroSet_UI.Child.MetroSetSetTabPage tbLoans;
        private MetroSet_UI.Child.MetroSetSetTabPage tbCalendar;
        private MetroSet_UI.Child.MetroSetSetTabPage tbBudget;
        private MetroSet_UI.Controls.MetroSetTextBox txtTAtransName;
        private MetroSet_UI.Controls.MetroSetButton btnTAdd;
        private MetroSet_UI.Controls.MetroSetLabel lblTAloanID;
        private MetroSet_UI.Controls.MetroSetLabel lblTAcategoryID;
        private MetroSet_UI.Controls.MetroSetTextBox txtTArecurIntervalDays;
        private MetroSet_UI.Controls.MetroSetLabel lblTArecurIntervalDays;
        private MetroSet_UI.Controls.MetroSetSwitch swTAisRecurring;
        private MetroSet_UI.Controls.MetroSetLabel lblTAisRecurring;
        private System.Windows.Forms.DateTimePicker dteTAdate;
        private MetroSet_UI.Controls.MetroSetLabel lblTAdate;
        private MetroSet_UI.Controls.MetroSetTextBox txtTAvalue;
        private MetroSet_UI.Controls.MetroSetLabel lblTAvalue;
        private MetroSet_UI.Controls.MetroSetButton btnTEdit;
        private MetroSet_UI.Controls.MetroSetLabel lblTEloanID;
        private MetroSet_UI.Controls.MetroSetLabel lblcategoryID;
        private MetroSet_UI.Controls.MetroSetTextBox txtTErecurIntervalDays;
        private MetroSet_UI.Controls.MetroSetLabel lblTErecurIntervalDays;
        private MetroSet_UI.Controls.MetroSetSwitch swTEisRecurring;
        private MetroSet_UI.Controls.MetroSetLabel lblTEisRecurring;
        private System.Windows.Forms.DateTimePicker dteTEdate;
        private MetroSet_UI.Controls.MetroSetLabel lblTEdate;
        private MetroSet_UI.Controls.MetroSetTextBox txtTEvalue;
        private MetroSet_UI.Controls.MetroSetLabel lblTEvalue;
        private MetroSet_UI.Controls.MetroSetTextBox txtTEtransName;
        private MetroSet_UI.Controls.MetroSetLabel lblTEtransName;
        private System.Windows.Forms.DateTimePicker dteTRdate;
        private MetroSet_UI.Controls.MetroSetLabel lblTRdate;
        private MetroSet_UI.Controls.MetroSetTextBox txtTRvalue;
        private MetroSet_UI.Controls.MetroSetLabel lblTRvalue;
        private MetroSet_UI.Controls.MetroSetTextBox txtTRtransName;
        private MetroSet_UI.Controls.MetroSetLabel lblTRtransName;
        private MetroSet_UI.Controls.MetroSetButton btnTRemove;
        private MetroSet_UI.Controls.MetroSetPanel pnlDGraph;
        private MetroSet_UI.Controls.MetroSetPanel pnlTGraph;
        private LiveCharts.WinForms.CartesianChart chtTTrans;
        private MetroSet_UI.Controls.MetroSetPanel pnlLGraph;
        private LiveCharts.WinForms.CartesianChart chtLLoans;
        private MetroSet_UI.Controls.MetroSetTabControl tbcLoansView;
        private MetroSet_UI.Child.MetroSetSetTabPage tbLloans;
        private System.Windows.Forms.DataGridView grdLloans;
        private MetroSet_UI.Controls.MetroSetTabControl tbcLoans;
        private MetroSet_UI.Child.MetroSetSetTabPage tbLAdd;
        private MetroSet_UI.Controls.MetroSetTextBox txtLApayment;
        private MetroSet_UI.Controls.MetroSetTextBox txtLAdurationMonths;
        private MetroSet_UI.Controls.MetroSetButton btnLAdd;
        private MetroSet_UI.Controls.MetroSetLabel lblLApayment;
        private MetroSet_UI.Controls.MetroSetTextBox txtLAfixedAPR;
        private MetroSet_UI.Controls.MetroSetLabel lblLAfixedAPR;
        private MetroSet_UI.Controls.MetroSetLabel lblLAdurationMonths;
        private MetroSet_UI.Controls.MetroSetTextBox txtLAbalance;
        private MetroSet_UI.Controls.MetroSetLabel lblLAbalance;
        private MetroSet_UI.Controls.MetroSetTextBox txtLAloanName;
        private MetroSet_UI.Controls.MetroSetLabel lblLAloanName;
        private MetroSet_UI.Child.MetroSetSetTabPage tbLEdit;
        private MetroSet_UI.Controls.MetroSetTextBox txtLEpayment;
        private MetroSet_UI.Controls.MetroSetTextBox txtLEdurationMonths;
        private MetroSet_UI.Controls.MetroSetLabel lblLEpayment;
        private MetroSet_UI.Controls.MetroSetTextBox txtLEfixedAPR;
        private MetroSet_UI.Controls.MetroSetLabel lblLEfixedAPR;
        private MetroSet_UI.Controls.MetroSetLabel lblLEdurationMonths;
        private MetroSet_UI.Controls.MetroSetTextBox txtLEbalance;
        private MetroSet_UI.Controls.MetroSetLabel lblLEbalance;
        private MetroSet_UI.Controls.MetroSetTextBox txtLEloanName;
        private MetroSet_UI.Controls.MetroSetLabel lblLEloanName;
        private MetroSet_UI.Controls.MetroSetButton btnLEdit;
        private MetroSet_UI.Child.MetroSetSetTabPage tbLRemove;
        private MetroSet_UI.Controls.MetroSetTextBox txtLRbalance;
        private MetroSet_UI.Controls.MetroSetLabel lblLRbalance;
        private MetroSet_UI.Controls.MetroSetTextBox txtLRloanName;
        private MetroSet_UI.Controls.MetroSetLabel lblLRloanName;
        private MetroSet_UI.Controls.MetroSetButton btnLRemove;
        private MetroSet_UI.Controls.MetroSetPanel pnlCalendar;
        private MetroSet_UI.Controls.MetroSetPanel pnlCGraph;
        private LiveCharts.WinForms.CartesianChart chtCTrans;
        private MetroSet_UI.Controls.MetroSetTabControl tbcBudgetView;
        private MetroSet_UI.Child.MetroSetSetTabPage tbCcategories;
        private System.Windows.Forms.DataGridView grdBcategories;
        private MetroSet_UI.Controls.MetroSetTabControl tbcBudget;
        private MetroSet_UI.Child.MetroSetSetTabPage tbBAdd;
        private MetroSet_UI.Controls.MetroSetButton btnBAdd;
        private MetroSet_UI.Controls.MetroSetTextBox txtBAcategoryName;
        private MetroSet_UI.Controls.MetroSetLabel lblBAcategoryName;
        private MetroSet_UI.Child.MetroSetSetTabPage tbBEdit;
        private MetroSet_UI.Controls.MetroSetTextBox txtBEcategoryName;
        private MetroSet_UI.Controls.MetroSetLabel lblBEcategoryName;
        private MetroSet_UI.Controls.MetroSetButton btnBEdit;
        private MetroSet_UI.Child.MetroSetSetTabPage tbBRemove;
        private MetroSet_UI.Controls.MetroSetTextBox txtBRcategoryName;
        private MetroSet_UI.Controls.MetroSetLabel lblBRcategoryName;
        private MetroSet_UI.Controls.MetroSetButton btnBRemove;
        private MetroSet_UI.Controls.MetroSetPanel pnlBcharts;
        private LiveCharts.WinForms.PieChart pieBCategory;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider2;
        private LiveCharts.WinForms.CartesianChart chtBCategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox txtTSusername;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblSubHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbTAcategoryID;
        private System.Windows.Forms.ComboBox cmbTAloanID;
        private System.Windows.Forms.ComboBox cmbTEloanID;
        private System.Windows.Forms.ComboBox cmbTEcategoryID;
        private LiveCharts.WinForms.CartesianChart chtDLoans;
        private MetroSet_UI.Controls.MetroSetLabel lblYear;
        private MetroSet_UI.Controls.MetroSetLabel lblMonth;
        private MetroSet_UI.Controls.MetroSetLabel lblSaturday;
        private MetroSet_UI.Controls.MetroSetLabel lblFri;
        private MetroSet_UI.Controls.MetroSetLabel lblThurs;
        private MetroSet_UI.Controls.MetroSetLabel lblWed;
        private MetroSet_UI.Controls.MetroSetLabel lblTuesday;
        private MetroSet_UI.Controls.MetroSetLabel lblMonday;
        private MetroSet_UI.Controls.MetroSetLabel lblSunday;
        private MetroSet_UI.Controls.MetroSetButton btnPrevious;
        private MetroSet_UI.Controls.MetroSetButton btnNext;
        private System.Windows.Forms.FlowLayoutPanel flwDayContainer;
    }
}