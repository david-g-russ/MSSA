using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceDll;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using MetroSet_UI.Forms;
using System.Globalization;


namespace PersonalFinanceApp
{
    public partial class Dashboard : MetroSetForm
    {
        #region Form Initialization

        FinanceDB repo; 
        string errorMsg; 
        int userID;
        SeriesCollection transCollection;
        SeriesCollection loanCollection;
        SeriesCollection catCollection;

        public Dashboard(int ID)
        {
            InitializeComponent();
            this.userID = ID;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            repo = new FinanceDB(); // initialize instance of FinanceDB class
            var user = repo.FindUser(userID);

            GetChartT(chtDTrans);
            GetChartT(chtTTrans);
            GetChartT(chtCTrans);
            GetChartT(chtBCategory);
            GetChartL(chtDLoans);
            GetChartL(chtLLoans);
            GetChartC(pieDCategory);
            GetChartC(pieBCategory);

            AutoScaleMode = AutoScaleMode.None; // pesky, meddling autoscaling disabled

            Form fCalendar = new Calendar(userID); // instantiate and open child form Calendar in the Calendar tab
            OpenChildForm(fCalendar);

            AutoValidate = AutoValidate.EnableAllowFocusChange; // allow user to exit fields that aren't validated
            
            cmbTAcategoryID.DropDownStyle = ComboBoxStyle.DropDownList; // change combobox styles to drop-down so user can only select provided options
            cmbTAloanID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTEcategoryID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTEloanID.DropDownStyle = ComboBoxStyle.DropDownList;

            txtTSusername.Text = user.username;

            RefreshCMBC();
            RefreshCMBL();

            RefreshDataT(); // run refresh data function for each grid for initial population
            RefreshDataC();
            RefreshDataL();
        }

        #endregion Form Initialization

        #region Automated Functions

            #region SUB - Refresh Functions
            private void RefreshDataT()
            {
                if (repo.PastTransactions(userID).Count > 0) // if there are past transactions, refresh their grid views and set visible
                {
                    grdTPastTrans.DataSource = null;
                    grdTPastTrans.DataSource = repo.PastTransactions(userID);
                    grdTPastTrans.Visible = true;
                    grdDPastTrans.DataSource = null;
                    grdDPastTrans.DataSource = repo.PastTransactions(userID);
                    grdDPastTrans.Visible = true;
                    OrderColumnsT(grdTPastTrans);
                    OrderColumnsT(grdDPastTrans);
                }
                else // if there are no past transactions, set them to invisible
                {
                    grdTPastTrans.Visible = false;
                    grdDPastTrans.Visible = false;
                }
                if (repo.FutureTransactions(userID).Count > 0) // if there are future transactions, refresh their grid views and set visible
                {
                    grdTFutTrans.DataSource = null;
                    grdTFutTrans.DataSource = repo.FutureTransactions(userID);
                    grdTFutTrans.Visible = true;
                    grdDFutTrans.DataSource = null;
                    grdDFutTrans.DataSource= repo.FutureTransactions(userID);
                    grdDFutTrans.Visible = true;
                    OrderColumnsT(grdTFutTrans);
                    OrderColumnsT(grdDFutTrans);
                }
                else // if there are no future transactions, set them to invisible
                {
                    grdDFutTrans.Visible = false;
                    grdTFutTrans.Visible = false;
                }
                if (repo.GetTransactions(userID).Count > 0) // if there are any transactions, allow user to edit or remove them
                {
                    btnTEdit.Enabled = true;
                    btnTRemove.Enabled = true;
                }
                else // if there are no transactions, do not allow user to try to edit or remove
                {
                    btnTEdit.Enabled= false;
                    btnTRemove.Enabled= false;
                }
            }

            private void RefreshDataL()
            {
                if (repo.GetLoans(userID).Count > 0) // if there are any loans, populate grid view and enable edit/remove buttons
                {
                    grdLloans.DataSource = null;
                    grdLloans.DataSource = repo.GetLoans(userID);
                    grdLloans.Visible = true;
                    btnLEdit.Enabled = true;
                    btnLRemove.Enabled = true;
                    OrderColumnsL(grdLloans);
                }
                else // if there are no loans, set grid view to invisible and disable edit/remove buttons
                {
                    grdLloans.Visible = false;
                    btnLEdit.Enabled = false;
                    btnLRemove.Enabled = false;
                }
            }

            private void RefreshDataC()
            {
                if (repo.GetCategories().Count > 0) // if there are any categories, populate grid view and enable edit/remove buttons
                {
                    grdBcategories.DataSource = null;
                    grdBcategories.DataSource = repo.GetCategories();
                    grdBcategories.Visible = true;
                    btnBEdit.Enabled = true;
                    btnBRemove.Enabled = true;
                    grdBcategories.Columns[2].Visible = false;
                    grdBcategories.Columns[0].HeaderText = "Category ID";
                    grdBcategories.Columns[1].HeaderText = "Category Name";
                    grdBcategories.Columns[3].HeaderText = "Spent This Month";
                    grdBcategories.Columns[3].DefaultCellStyle.Format = "C";
                }
                else // if there are no categories, set grid view to invisible and disable edit/remove buttons
                {
                    grdBcategories.Visible= false;
                    btnBEdit.Enabled= false;
                    btnBRemove.Enabled= false;
                }
            }

            private void OrderColumnsT(DataGridView grid)
            {
                grid.Columns["transName"].DisplayIndex = 0;
                grid.Columns["transName"].HeaderText = "Transaction Name";
                grid.Columns["value"].DisplayIndex = 1;
                grid.Columns["value"].HeaderText = "Value";
                grid.Columns["value"].DefaultCellStyle.Format = "c";
                grid.Columns["date"].DisplayIndex = 2;
                grid.Columns["date"].HeaderText = "Date";
                grid.Columns["date"].DefaultCellStyle.Format = "d";
                grid.Columns["CategoryName"].DisplayIndex = 3;
                grid.Columns["CategoryName"].HeaderText = "Category Name";
                grid.Columns["recurIntervalDays"].DisplayIndex = 4;
                grid.Columns["recurIntervalDays"].HeaderText = "Recur Interval (Days)";
                grid.Columns["LoanName"].DisplayIndex = 5;
                grid.Columns["LoanName"].HeaderText = "Loan Name";
                grid.Columns[2].DisplayIndex = 6;
                grid.Columns[2].Visible = false;
                grid.Columns[6].DisplayIndex = 7;
                grid.Columns[6].Visible = false;
                for (int i = 8; i <= 13; i++)
                {
                    grid.Columns[i].DisplayIndex = i;
                    grid.Columns[i].Visible = false;
                }
            }

            private void OrderColumnsL(DataGridView grid)
            {
                grid.Columns[1].DisplayIndex = 0;
                grid.Columns[1].HeaderText = "Loan Name";
                grid.Columns[2].DisplayIndex = 1;
                grid.Columns[2].HeaderText = "Initial Balance";
                grid.Columns[2].DefaultCellStyle.Format = "c";
                grid.Columns[3].DisplayIndex = 2;
                grid.Columns[3].HeaderText = "Duration (Months)";
                grid.Columns[4].DisplayIndex = 3;
                grid.Columns[4].HeaderText = "Fixed APR";
                grid.Columns[4].DefaultCellStyle.Format = "0.00\\%";
                grid.Columns[5].DisplayIndex = 4;
                grid.Columns[5].HeaderText = "Payment Amount";
                grid.Columns[5].DefaultCellStyle.Format = "c";
                grid.Columns["RemainingBalance"].DisplayIndex = 5;
                grid.Columns["RemainingBalance"].HeaderText = "Remaining Balance";
                grid.Columns["RemainingBalance"].DefaultCellStyle.Format = "c";
                grid.Columns[0].DisplayIndex = 6;
                grid.Columns[0].Visible = false;
                grid.Columns[6].DisplayIndex = 7;
                grid.Columns[6].Visible = false;
                grid.Columns[7].DisplayIndex = 8;
                grid.Columns[7].Visible = false;
            }

            private void RefreshCMBC()
            {
                cmbTAcategoryID.Items.Clear();
                cmbTEcategoryID.Items.Clear();
                foreach (var c in repo.GetCategories()) // populate comboboxes from category table
                {
                    cmbTAcategoryID.Items.Add(c.categoryName);
                    cmbTEcategoryID.Items.Add(c.categoryName);
                }
            }

            private void RefreshCMBL()
            {
                cmbTAloanID.Items.Clear();
                cmbTEloanID.Items.Clear();
                foreach (var l in repo.GetLoans(userID)) // populate comboboxes from loan table
                {
                    cmbTAloanID.Items.Add(l.loanName);
                    cmbTEloanID.Items.Add(l.loanName);
                }
            }

            private void RefreshBalance()
            {
                foreach (var l in repo.GetLoans(userID))
                {
                    l.RemainingBalance = l.balance;
                    foreach (var t in repo.GetTransactions(userID))
                    {
                        if (l.loanID == t.loanID && t.date <= DateTime.Now)
                            l.RemainingBalance += t.value;
                    }
                }
            }

            #endregion SUB - Refresh Functions

            #region SUB - Clear Functions

            private void ClearT()
            {
                txtTAtransName.Text = null;
                txtTArecurIntervalDays.Text = null;
                txtTAvalue.Text = null;
                cmbTAcategoryID.SelectedIndex = -1;
                cmbTAloanID.SelectedIndex = -1;
                dteTAdate.Value = DateTime.Now;
                swTAisRecurring.Switched = false;
            }
            private void ClearL()
            {
                txtLAbalance.Text = null;
                txtLAdurationMonths.Text = null;
                txtLAfixedAPR.Text = null;
                txtLAloanName.Text = null;
                txtLApayment.Text = null;
            }

            #endregion SUB - Clear Functions

            #region SUB - Event-triggered Functions
            private void swTAisRecurring_SwitchedChanged(object sender)
            {
                if (swTAisRecurring.Switched)
                {
                    lblTArecurIntervalDays.Visible = true;
                    txtTArecurIntervalDays.Visible = true;
                }
                else
                {
                    lblTArecurIntervalDays.Visible = false;
                    txtTArecurIntervalDays.Visible = false;
                }
            }

            private void swTEisRecurring_SwitchedChanged(object sender)
            {
                if (swTEisRecurring.Switched)
                {
                    lblTErecurIntervalDays.Visible = true;
                    txtTErecurIntervalDays.Visible = true;
                }
                else
                {
                    lblTErecurIntervalDays.Visible = false;
                    txtTErecurIntervalDays.Visible = false;
                }
            }

            private void cmbTEcategoryID_SelectedValueChanged(object sender, EventArgs e)
            {
                if (cmbTEcategoryID.SelectedItem != null)
                {
                    if (cmbTEcategoryID.SelectedItem.ToString() == "Loans")
                    {
                        lblTEloanID.Visible = true;
                        cmbTEloanID.Visible = true;
                    }
                    else
                    {
                        lblTEloanID.Visible = false;
                        cmbTEloanID.Visible = false;
                    }
                }
            }

            private void cmbTAcategoryID_SelectedValueChanged(object sender, EventArgs e)
            {
                if (cmbTAcategoryID.SelectedItem != null && repo.FindCategory(cmbTAcategoryID.SelectedItem.ToString()).categoryName == "Loans")
                {
                    lblTAloanID.Visible = true;
                    cmbTAloanID.Visible = true;
                }
                else
                {
                    lblTAloanID.Visible = false;
                    cmbTAloanID.Visible = false;
                }
            }
            private void grdTPastTrans_SelectionChanged(object sender, EventArgs e)
            {
                if (grdTPastTrans.CurrentRow != null)
                {
                    int id = Int32.Parse(grdTPastTrans.CurrentRow.Cells[2].Value.ToString());
                    if (repo.FindTransaction(id) != null)
                    {
                        var uTrans = repo.FindTransaction(id);
                        txtTEtransName.Text = uTrans.transName;
                        txtTEvalue.Text = uTrans.value.ToString();
                        dteTEdate.Value = uTrans.date;
                        swTEisRecurring.Switched = uTrans.isRecurring;
                        txtTErecurIntervalDays.Text = uTrans.recurIntervalDays.ToString();
                        cmbTEcategoryID.SelectedItem = uTrans.CategoryName;
                        cmbTEloanID.SelectedItem = uTrans.LoanName;

                        errorProvider1.SetError(txtTEtransName, "");
                        errorProvider1.SetError(txtTEvalue, "");
                        errorProvider1.SetError(dteTEdate, "");
                        errorProvider1.SetError(txtTErecurIntervalDays, "");
                        errorProvider1.SetError(cmbTEcategoryID, "");
                        errorProvider1.SetError(cmbTEloanID, "");

                        txtTRtransName.Text = uTrans.transName;
                        txtTRvalue.Text = uTrans.value.ToString();
                        dteTRdate.Value = uTrans.date;
                    }
                }
                else
                {
                    txtTRtransName.Text = "No transactions to remove.";
                    txtTRvalue.Text = null;
                    dteTRdate.Value = DateTime.Now;
                    ClearT();
                }
            }

            private void grdTFutTrans_SelectionChanged(object sender, EventArgs e)
            {
                if (grdTFutTrans.CurrentRow != null)
                {
                    int id = Int32.Parse(grdTFutTrans.CurrentRow.Cells[2].Value.ToString());
                    if (repo.FindTransaction(id) != null)
                    {
                        var uTrans = repo.FindTransaction(id);
                        txtTEtransName.Text = uTrans.transName;
                        txtTEvalue.Text = uTrans.value.ToString();
                        dteTEdate.Value = uTrans.date;
                        swTEisRecurring.Switched = uTrans.isRecurring;
                        txtTErecurIntervalDays.Text = uTrans.recurIntervalDays.ToString();
                        cmbTEcategoryID.SelectedItem = uTrans.CategoryName;
                        cmbTEloanID.SelectedItem = uTrans.LoanName;

                        errorProvider1.SetError(txtTEtransName, "");
                        errorProvider1.SetError(txtTEvalue, "");
                        errorProvider1.SetError(dteTEdate, "");
                        errorProvider1.SetError(txtTErecurIntervalDays, "");
                        errorProvider1.SetError(cmbTEcategoryID, "");
                        errorProvider1.SetError(cmbTEloanID, "");

                        txtTRtransName.Text = uTrans.transName;
                        txtTRvalue.Text = uTrans.value.ToString();
                        dteTRdate.Value = uTrans.date;
                    }
                }
                else
                {
                    txtTRtransName.Text = "No transactions to remove.";
                    txtTRvalue.Text = null;
                    dteTRdate.Value = DateTime.Now;
                    ClearT();
                }
            }

            private void grdLloans_SelectionChanged(object sender, EventArgs e)
            {
                if (grdLloans.CurrentRow != null)
                {
                    int id = Int32.Parse(grdLloans.CurrentRow.Cells[0].Value.ToString());
                    if (repo.FindLoan(id) != null)
                    {
                        var uLoan = repo.FindLoan(id);
                        txtLEloanName.Text = uLoan.loanName;
                        txtLEbalance.Text = uLoan.balance.ToString();
                        txtLEdurationMonths.Text = uLoan.durationMonths.ToString();
                        txtLEfixedAPR.Text = uLoan.fixedAPR.ToString();
                        txtLEpayment.Text = uLoan.payment.ToString();

                        errorProvider1.SetError(txtLEloanName, "");
                        errorProvider1.SetError(txtLEbalance, "");
                        errorProvider1.SetError(txtLEdurationMonths, "");
                        errorProvider1.SetError(txtLEfixedAPR, "");
                        errorProvider1.SetError(txtLEpayment, "");

                        txtLRloanName.Text = uLoan.loanName;
                        txtLRbalance.Text = uLoan.balance.ToString();
                    }
                }
                else
                {
                    txtLRloanName.Text = "No loans to remove.";
                    txtLRbalance.Text = null;
                    ClearL();
                }
            }

            private void grdBcategories_SelectionChanged(object sender, EventArgs e)
            {
                if (grdBcategories.CurrentRow != null)
                {
                    int id = Int32.Parse(grdBcategories.CurrentRow.Cells[0].Value.ToString());
                    if (repo.FindCategory(id) != null)
                    {
                        var uCategory = repo.FindCategory(id);
                        txtBEcategoryName.Text = uCategory.categoryName;

                        errorProvider1.SetError(txtBEcategoryName, "");

                        txtBRcategoryName.Text = uCategory.categoryName;
                    }
                }
                else
                {
                    txtBRcategoryName.Text = "No categories to remove.";
                    txtBEcategoryName.Text = "No categories to edit.";
                }
            }

        #endregion SUB - Event-triggered Functions

            #region SUB - Component Automation
            private void OpenChildForm(Form childForm)
            {
                childForm.TopLevel = false;
                pnlCalendar.Controls.Add(childForm);
                childForm.Show();
            }

            private void GetChartT(LiveCharts.WinForms.CartesianChart chart)
            {
                DateTime startDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                int numDays = DateTime.DaysInMonth(startDay.Year, startDay.Month);
                double[] transArray = new double[numDays];
                string[] labels = new string[numDays];
                double today = startDay.Day - 1;

                for (int i = 0; i < numDays; i++)
                {
                    DateTime date = startDay.AddDays(i);
                
                    double balance = (double)repo.SumPastTransactions(userID, date);
                    transArray[i] = balance;
                    labels[i] = (i + 1).ToString();    
                }

                Axis xAxis = new Axis();
                xAxis.Title = DateTimeFormatInfo.CurrentInfo.MonthNames[DateTime.Now.Month - 1] + " " + DateTime.Now.Year;
                //AxisSection section = new AxisSection()
                //{
                //    Stroke = System.Windows.Media.Brushes.Black,
                //    StrokeThickness = 2,
                //    Value = today,
                //};
                //SectionsCollection sections = new SectionsCollection() { section };
                xAxis.Labels = labels;
                //xAxis.Sections = sections;

                Axis yAxis = new Axis();
                Func<double, string> yFormatter = value => value.ToString("C");
                yAxis.Title = "Balance";
                yAxis.LabelFormatter = yFormatter;
           

                ChartValues<double> transValues = new ChartValues<double>();
                foreach (double value in transArray)
                    transValues.Add(value);

                LineSeries transSeries = new LineSeries() { Values = transValues};
            
                transCollection = new SeriesCollection() { transSeries };

                chart.Series = transCollection;
                chart.AxisX.Add(xAxis);         
                chart.AxisY.Add(yAxis);
            }

            private void GetChartL(LiveCharts.WinForms.CartesianChart chart)
            {
                var loanList = repo.GetLoans(userID);
                string[] labels = new string[loanList.Count];
                double[] balance = new double[loanList.Count];
                ChartValues<double> bValues = new ChartValues<double>();
                double[] rembalance = new double[loanList.Count];
                ChartValues<double> rValues = new ChartValues<double>();
                int i = 0;
                foreach( var loan in loanList)
                {
                    labels[i] = loan.loanName;
                    rembalance[i] = (double)loan.RemainingBalance;
                    rValues.Add(rembalance[i]);
                    balance[i] = (double)loan.balance - rembalance[i];
                    bValues.Add(balance[i]);
                    i++;
                }

                Axis yAxis = new Axis();
                yAxis.Title = "Loans";
                yAxis.Labels = labels;

                Axis xAxis = new Axis();
                Func<double, string> xFormatter = value => value.ToString("C");
                xAxis.Title = "Balance";
                xAxis.LabelFormatter = xFormatter;

                loanCollection = new SeriesCollection()
                {
                    new StackedRowSeries()
                    {
                        Values = bValues,
                        DataLabels = true,
                        Title = "Balance Paid Off",  
                    },
                    new StackedRowSeries()
                    {
                        Values = rValues,
                        DataLabels = true,
                        Title = "Balance Remaining"
                    }
                };

                chart.Series = loanCollection;
                chart.AxisX.Add(xAxis);
                chart.AxisY.Add(yAxis);
                chart.LegendLocation = LegendLocation.Bottom;

            }

        private void GetChartC(LiveCharts.WinForms.PieChart chart)
        {
            catCollection = new SeriesCollection();
            DateTime today = DateTime.Now;
            var catList = repo.MonthCategories(userID, today);
            Func<ChartPoint, string> pointLabel = chartPoint => String.Format("{0:C} ({1:P1})", chartPoint.Y, chartPoint.Participation);
            foreach (var cat in catList)
            {
                if (cat.MonthValue > 0)
                {
                    PieSeries series = new PieSeries()
                    {
                        Values = new ChartValues<double> { (double)cat.MonthValue },
                        Title = cat.categoryName,
                        DataLabels = true,
                        LabelPoint = pointLabel
                    };
                    catCollection.Add(series);
                }
            }

            chart.Series = catCollection;
            chart.LegendLocation= LegendLocation.Bottom;
        }

            #endregion SUB - Component Automation

        #endregion Automated Functions

        #region Validation

        #region SUB - Bool Checks

        private bool TAValid()
            {
                if (errorProvider1.GetError(txtTAtransName) == "" && errorProvider1.GetError(txtTAvalue) == "" &&
                    errorProvider1.GetError(cmbTAcategoryID) == "" && errorProvider1.GetError(dteTAdate) == "" &&
                    (txtTArecurIntervalDays.Visible && errorProvider1.GetError(txtTArecurIntervalDays) == "" || !txtTArecurIntervalDays.Visible) &&
                    (cmbTAloanID.Visible && errorProvider1.GetError(cmbTAloanID) == "" || !cmbTAloanID.Visible))
                    return true;
                else
                    return false;
            }

            private bool TEValid()
            {
                if (errorProvider1.GetError(txtTEtransName) == "" && errorProvider1.GetError(txtTEvalue) == "" &&
                    errorProvider1.GetError(cmbTEcategoryID) == "" && errorProvider1.GetError(dteTEdate) == "" &&
                    (txtTErecurIntervalDays.Visible && errorProvider1.GetError(txtTErecurIntervalDays) == "" || !txtTErecurIntervalDays.Visible) &&
                    (cmbTEloanID.Visible && errorProvider1.GetError(cmbTEloanID) == "" || !cmbTEloanID.Visible))
                    return true;
                else
                    return false;
            }

            private bool LAValid()
            {
                if (errorProvider1.GetError(txtLAbalance) == "" && errorProvider1.GetError(txtLAdurationMonths) == "" &&
                    errorProvider1.GetError(txtLAfixedAPR) == "" && errorProvider1.GetError(txtLAloanName) == "" &&
                    errorProvider1.GetError(txtLApayment) == "")
                    return true;
                else
                    return false;
            }

            private bool LEValid()
            {
                if (errorProvider1.GetError(txtLEbalance) == "" && errorProvider1.GetError(txtLEdurationMonths) == "" &&
                    errorProvider1.GetError(txtLEfixedAPR) == "" && errorProvider1.GetError(txtLEloanName) == "" &&
                    errorProvider1.GetError(txtLEpayment) == "")
                    return true;
                else
                    return false;
            }

            private bool BAValid()
            {
                if (errorProvider1.GetError(txtBAcategoryName) == "")
                    return true;
                else
                    return false;
            }

            private bool BEValid()
            {
                if (errorProvider1.GetError(txtBEcategoryName) == "")
                    return true;
                else
                    return false;
            }

            #endregion SUB - Bool Checks

            #region SUB - Input Validation

            // Validation for Transaction Addition ---------------------------------------------------------------
            private void txtTAtransName_Validating(object sender, CancelEventArgs e)
            {
                if (txtTAtransName.Text.Length > 50)
                    errorMsg = "Please enter a name less than 50 characters.";
                else if (txtTAtransName.Text.Length == 0)
                    errorMsg = "Please enter a transaction name.";
                else
                    return;
                e.Cancel = true;
                txtTAtransName.Select(0, txtTAtransName.Text.Length);
                this.errorProvider1.SetError(txtTAtransName, errorMsg);
            }

            private void txtTAtransName_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(txtTAtransName, "");
            }

            private void txtTAvalue_Validating(object sender, CancelEventArgs e)
            {
                if (!Decimal.TryParse(txtTAvalue.Text, out decimal value))
                    errorMsg = "Please enter a valid decimal number.";
                else if (Decimal.Compare(Decimal.Parse(txtTAvalue.Text), 10000000m) > 0)
                    errorMsg = "Please enter a decimal value less than $ 10 million.";
                else if (Decimal.Compare(Decimal.Parse(txtTAvalue.Text), -10000000m) < 0)
                    errorMsg = "Please enter a decimal value greater than -$10 million.";
                else
                    return;
                e.Cancel = true;
                txtTAvalue.Select(0, txtTAvalue.Text.Length);
                this.errorProvider1.SetError(txtTAvalue, errorMsg);
            }

            private void txtTAvalue_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(txtTAvalue, "");
            }

            private void dteTAdate_Validating(object sender, CancelEventArgs e)
            {
                if (dteTAdate.Value.Year < 1950)
                    errorMsg = "Please enter a date after 1950.";
                else if (dteTAdate.Value.Year > DateTime.Now.Year + 2)
                    errorMsg = "Please enter a date less than 2 years from now.";
                else
                    return;
                e.Cancel = true;
                dteTAdate.Select();
                this.errorProvider1.SetError(dteTAdate, errorMsg);
            }

            private void dteTAdate_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(dteTAdate, "");
            }

            private void txtTArecurIntervalDays_Validating(object sender, CancelEventArgs e)
            {
                if (!Int32.TryParse(txtTArecurIntervalDays.Text, out int value))
                    errorMsg = "Please enter a valid whole number.";
                else if (Int32.Parse(txtTArecurIntervalDays.Text) > 365)
                    errorMsg = "Please enter a whole number less than 365 days.";
                else if (Int32.Parse(txtTArecurIntervalDays.Text) <= 0)
                    errorMsg = "Please enter a whole number greater than 0 days.";
                else
                    return;
                e.Cancel = true;
                txtTArecurIntervalDays.Select(0, txtTArecurIntervalDays.Text.Length);
                this.errorProvider1.SetError(txtTArecurIntervalDays, errorMsg);
            }

            private void txtTArecurIntervalDays_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(txtTArecurIntervalDays, "");
            }

            private void cmbTAcategoryID_Validating(object sender, CancelEventArgs e)
            {
                if (cmbTAcategoryID.SelectedIndex == -1)
                {
                    errorMsg = "You need to select an option.";
                    e.Cancel = true;
                    this.errorProvider1.SetError(cmbTAcategoryID, errorMsg);
                }
            }

            private void cmbTAcategoryID_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(cmbTAcategoryID, "");
            }

            private void cmbTAloanID_Validating(object sender, CancelEventArgs e)
            {
                if (cmbTAloanID.SelectedIndex == -1)
                {
                    errorMsg = "You need to select an option.";
                    e.Cancel = true;
                    this.errorProvider1.SetError(cmbTAloanID, errorMsg);
                }
            }

            private void cmbTAloanID_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(cmbTAloanID, "");
            }

            // Validation for Transaction Editing ---------------------------------------------------------------

            private void txtTEtransName_Validating(object sender, CancelEventArgs e)
            {
                if (txtTEtransName.Text.Length > 50)
                    errorMsg = "Please enter a name less than 50 characters.";
                else if (txtTEtransName.Text.Length == 0)
                    errorMsg = "Please enter a transaction name.";
                else
                    return;
                e.Cancel = true;
                txtTEtransName.Select(0, txtTEtransName.Text.Length);
                this.errorProvider1.SetError(txtTEtransName, errorMsg);
            }

            private void txtTEtransName_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(txtTEtransName, "");
            }

            private void txtTEvalue_Validating(object sender, CancelEventArgs e)
            {
                if (!Decimal.TryParse(txtTEvalue.Text, out decimal value))
                    errorMsg = "Please enter a valid decimal number.";
                else if (Decimal.Compare(Decimal.Parse(txtTEvalue.Text), 10000000m) > 0)
                    errorMsg = "Please enter a decimal value less than $ 10 million.";
                else if (Decimal.Compare(Decimal.Parse(txtTEvalue.Text), -10000000m) < 0)
                    errorMsg = "Please enter a decimal value greater than - $ 10 million.";
                else
                    return;
                e.Cancel = true;
                txtTEvalue.Select(0, txtTEvalue.Text.Length);
                this.errorProvider1.SetError(txtTEvalue, errorMsg);
            }

            private void txtTEvalue_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(txtTEvalue, "");
            }

            private void dteTEdate_Validating(object sender, CancelEventArgs e)
            {
                if (dteTEdate.Value.Year < 1950)
                    errorMsg = "Please enter a date after 1950.";
                else if (dteTEdate.Value.Year > DateTime.Now.Year + 2)
                    errorMsg = "Please enter a date less than 2 years from now.";
                else
                    return;
                e.Cancel = true;
                dteTEdate.Select();
                this.errorProvider1.SetError(dteTEdate, errorMsg);
            }

            private void dteTEdate_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(dteTEdate, "");
            }

            private void txtTErecurIntervalDays_Validating(object sender, CancelEventArgs e)
            {
                if (!Int32.TryParse(txtTErecurIntervalDays.Text, out int value))
                    errorMsg = "Please enter a valid whole number.";
                else if (Int32.Parse(txtTErecurIntervalDays.Text) > 365)
                    errorMsg = "Please enter a whole number less than 365 days.";
                else if (Int32.Parse(txtTErecurIntervalDays.Text) <= 0)
                    errorMsg = "Please enter a whole number greater than 0 days.";
                else
                    return;
                e.Cancel = true;
                txtTErecurIntervalDays.Select(0, txtTErecurIntervalDays.Text.Length);
                this.errorProvider1.SetError(txtTErecurIntervalDays, errorMsg);
            }

            private void txtTErecurIntervalDays_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(txtTErecurIntervalDays, "");
            }

            private void cmbTEcategoryID_Validating(object sender, CancelEventArgs e)
            {
                if (cmbTEcategoryID.SelectedIndex == -1)
                {
                    errorMsg = "You need to select an option.";
                    e.Cancel = true;
                    this.errorProvider1.SetError(cmbTEcategoryID, errorMsg);
                }
            }

            private void cmbTEcategoryID_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(cmbTEcategoryID, "");
            }

            private void cmbTEloanID_Validating(object sender, CancelEventArgs e)
            {
                if (cmbTEloanID.SelectedIndex == -1)
                {
                    errorMsg = "You need to select an option.";
                    e.Cancel = true;
                    this.errorProvider1.SetError(cmbTEloanID, errorMsg);
                }
            }

            private void cmbTEloanID_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(cmbTEloanID, "");
            }
        
            private void txtLAloanName_Validating(object sender, CancelEventArgs e)
            {
                if (txtLAloanName.Text.Length > 50)
                    errorMsg = "Please enter a name less than 50 characters.";
                else if (txtLAloanName.Text.Length == 0)
                    errorMsg = "Please enter a loan name.";
                else
                    return;
                e.Cancel = true;
                txtLAloanName.Select(0, txtLAloanName.Text.Length);
                this.errorProvider1.SetError(txtLAloanName, errorMsg);
            }

            // Validation for Loan Addition ---------------------------------------------------------------    

            private void txtLAloanName_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(txtLAloanName, "");

            }

            private void txtLAbalance_Validating(object sender, CancelEventArgs e)
            {
                if (!Decimal.TryParse(txtLAbalance.Text, out decimal value))
                    errorMsg = "Please enter a valid decimal number.";
                else if (Decimal.Compare(Decimal.Parse(txtLAbalance.Text), 10000000m) > 0)
                    errorMsg = "Please enter a decimal value less than $ 10 million.";
                else if (Decimal.Compare(Decimal.Parse(txtLAbalance.Text), 0) < 0)
                    errorMsg = "Please enter a decimal value greater than $ 0.";
                else
                    return;
                e.Cancel = true;
                txtLAbalance.Select(0, txtLAbalance.Text.Length);
                this.errorProvider1.SetError(txtLAbalance, errorMsg);
            }

            private void txtLAbalance_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(txtLAbalance, "");
            }

            private void txtLAdurationMonths_Validating(object sender, CancelEventArgs e)
            {
                if (!Int32.TryParse(txtLAdurationMonths.Text, out int value))
                    errorMsg = "Please enter a valid whole number.";
                else if (Int32.Parse(txtLAdurationMonths.Text) > 360)
                    errorMsg = "Please enter a whole number less than 360 months (30 years).";
                else if (Int32.Parse(txtLAdurationMonths.Text) <= 0)
                    errorMsg = "Please enter a whole number greater than 0 months.";
                else
                    return;
                e.Cancel = true;
                txtLAdurationMonths.Select(0, txtLAdurationMonths.Text.Length);
                this.errorProvider1.SetError(txtLAdurationMonths, errorMsg);
            }

            private void txtLAdurationMonths_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(txtLAdurationMonths, "");
            }

            private void txtLAfixedAPR_Validating(object sender, CancelEventArgs e)
            {
                if (!Decimal.TryParse(txtLAfixedAPR.Text, out decimal value))
                    errorMsg = "Please enter a valid decimal number.";
                else if (Decimal.Compare(Decimal.Parse(txtLAfixedAPR.Text), 100m) > 0)
                    errorMsg = "Please enter a decimal value less than 100 %.";
                else if (Decimal.Compare(Decimal.Parse(txtLAfixedAPR.Text), 0) < 0)
                    errorMsg = "Please enter a decimal value greater than 0 %.";
                else
                    return;
                e.Cancel = true;
                txtLAfixedAPR.Select(0, txtLAfixedAPR.Text.Length);
                this.errorProvider1.SetError(txtLAfixedAPR, errorMsg);
            }

            private void txtLAfixedAPR_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(txtLAfixedAPR, "");
            }

            private void txtLApayment_Validating(object sender, CancelEventArgs e)
            {
                if (!Decimal.TryParse(txtLApayment.Text, out decimal value))
                    errorMsg = "Please enter a valid decimal number.";
                else if (Decimal.Compare(Decimal.Parse(txtLApayment.Text), 1000000m) > 0)
                    errorMsg = "Please enter a decimal value less than $ 1 million.";
                else if (Decimal.Compare(Decimal.Parse(txtLApayment.Text), 0) < 0)
                    errorMsg = "Please enter a decimal value greater than $ 0.";
                else
                    return;
                e.Cancel = true;
                txtLApayment.Select(0, txtLApayment.Text.Length);
                this.errorProvider1.SetError(txtLApayment, errorMsg);
            }

            private void txtLApayment_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(txtLApayment, "");
            }

            // Validation for Loan Editing ---------------------------------------------------------------

            private void txtLEloanName_Validating(object sender, CancelEventArgs e)
            {
                if (txtLEloanName.Text.Length > 50)
                    errorMsg = "Please enter a name less than 50 characters.";
                else if (txtLEloanName.Text.Length == 0)
                    errorMsg = "Please enter a loan name.";
                else
                    return;
                e.Cancel = true;
                txtLEloanName.Select(0, txtLEloanName.Text.Length);
                this.errorProvider1.SetError(txtLEloanName, errorMsg);
            }

            private void txtLEloanName_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(txtLEloanName, "");
            }

            private void txtLEbalance_Validating(object sender, CancelEventArgs e)
            {
                if (!Decimal.TryParse(txtLEbalance.Text, out decimal value))
                    errorMsg = "Please enter a valid decimal number.";
                else if (Decimal.Compare(Decimal.Parse(txtLEbalance.Text), 10000000m) > 0)
                    errorMsg = "Please enter a decimal value less than $ 10 million.";
                else if (Decimal.Compare(Decimal.Parse(txtLEbalance.Text), 0) < 0)
                    errorMsg = "Please enter a decimal value greater than $ 0.";
                else
                    return;
                e.Cancel = true;
                txtLEbalance.Select(0, txtLEbalance.Text.Length);
                this.errorProvider1.SetError(txtLEbalance, errorMsg);
            }

            private void txtLEbalance_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(txtLEbalance, "");
            }

            private void txtLEdurationMonths_Validating(object sender, CancelEventArgs e)
            {
                if (!Int32.TryParse(txtLEdurationMonths.Text, out int value))
                    errorMsg = "Please enter a valid whole number.";
                else if (Int32.Parse(txtLEdurationMonths.Text) > 360)
                    errorMsg = "Please enter a whole number less than 360 months (30 years).";
                else if (Int32.Parse(txtLEdurationMonths.Text) <= 0)
                    errorMsg = "Please enter a whole number greater than 0 months.";
                else
                    return;
                e.Cancel = true;
                txtLEdurationMonths.Select(0, txtLEdurationMonths.Text.Length);
                this.errorProvider1.SetError(txtLEdurationMonths, errorMsg);
            }

            private void txtLEdurationMonths_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(txtLEdurationMonths, "");
            }

            private void txtLEfixedAPR_Validating(object sender, CancelEventArgs e)
            {
                if (!Decimal.TryParse(txtLEfixedAPR.Text, out decimal value))
                    errorMsg = "Please enter a valid decimal number.";
                else if (Decimal.Compare(Decimal.Parse(txtLEfixedAPR.Text), 100m) > 0)
                    errorMsg = "Please enter a decimal value less than 100 %.";
                else if (Decimal.Compare(Decimal.Parse(txtLEfixedAPR.Text), 0) < 0)
                    errorMsg = "Please enter a decimal value greater than 0 %.";
                else
                    return;
                e.Cancel = true;
                txtLEfixedAPR.Select(0, txtLEfixedAPR.Text.Length);
                this.errorProvider1.SetError(txtLEfixedAPR, errorMsg);
            }

            private void txtLEfixedAPR_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(txtLEfixedAPR, "");
            }

            private void txtLEpayment_Validating(object sender, CancelEventArgs e)
            {
                if (!Decimal.TryParse(txtLEpayment.Text, out decimal value))
                    errorMsg = "Please enter a valid decimal number.";
                else if (Decimal.Compare(Decimal.Parse(txtLEpayment.Text), 1000000m) > 0)
                    errorMsg = "Please enter a decimal value less than $ 1 million.";
                else if (Decimal.Compare(Decimal.Parse(txtLEpayment.Text), 0) < 0)
                    errorMsg = "Please enter a decimal value greater than $ 0.";
                else
                    return;
                e.Cancel = true;
                txtLEpayment.Select(0, txtLEpayment.Text.Length);
                this.errorProvider1.SetError(txtLEpayment, errorMsg);
            }

            private void txtLEpayment_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(txtLEpayment, "");
            }

            // Validation for Budget Addition ---------------------------------------------------------------

            private void txtBAcategoryName_Validating(object sender, CancelEventArgs e)
            {
                if (txtBAcategoryName.Text.Length > 50)
                    errorMsg = "Please enter a name less than 50 characters.";
                else if (txtBAcategoryName.Text.Length == 0)
                    errorMsg = "Please enter a category name.";
                else
                    return;
                e.Cancel = true;
                txtBAcategoryName.Select(0, txtBAcategoryName.Text.Length);
                this.errorProvider1.SetError(txtBAcategoryName, errorMsg);
            }

            private void txtBAcategoryName_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(txtBAcategoryName, "");
            }

            // Validation for Budget Editing ---------------------------------------------------------------

            private void txtBEcategoryName_Validating(object sender, CancelEventArgs e)
            {
                if (txtBEcategoryName.Text.Length > 50)
                    errorMsg = "Please enter a name less than 50 characters.";
                else if (txtBEcategoryName.Text.Length == 0)
                    errorMsg = "Please enter a category name.";
                else
                    return;
                e.Cancel = true;
                txtBEcategoryName.Select(0, txtBEcategoryName.Text.Length);
                this.errorProvider1.SetError(txtBEcategoryName, errorMsg);
            }

            private void txtBEcategoryName_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(txtBEcategoryName, "");
            }

            #endregion SUB - Input Validation

        #endregion Validation

        #region Button Handling

        private void btnTAdd_Click(object sender, EventArgs e)
        {
            ValidateChildren(ValidationConstraints.Visible);
            if (TAValid())
            {
                var newTrans = new FinanceDll.Transaction();
                newTrans.transName = txtTAtransName.Text;
                newTrans.value = Decimal.Parse(txtTAvalue.Text);
                newTrans.date = dteTAdate.Value;
                newTrans.isRecurring = swTAisRecurring.Switched;
                newTrans.categoryID = repo.FindCategory(cmbTAcategoryID.SelectedItem.ToString()).categoryID;
                newTrans.userID = userID;
                if (cmbTAloanID.Visible)
                    newTrans.loanID = repo.FindLoan(cmbTAloanID.SelectedItem.ToString()).loanID;
                if (!swTAisRecurring.Switched)
                {
                    repo.AddTransaction(newTrans);
                    RefreshDataT();
                    RefreshDataL();
                    RefreshBalance();
                    ClearT();
                }
                else if (swTAisRecurring.Switched)
                {
                    newTrans.recurIntervalDays = Int32.Parse(txtTArecurIntervalDays.Text);
                    repo.AddTransaction(newTrans);
                    repo.AddRecur(newTrans);
                    RefreshDataT();
                    RefreshDataL();
                    RefreshBalance();
                    ClearT();
                }
                if (newTrans.loanID != null)
                    RefreshBalance();
            }
        }

        private void btnTEdit_Click(object sender, EventArgs e)
        {
            this.ValidateChildren(ValidationConstraints.Visible);
            if (TEValid())
            {
                if (grdTPastTrans.CurrentRow != null || grdTFutTrans.CurrentRow != null)
                {
                    int id;
                    if (tbcTransView.SelectedTab == tbTPastTrans)
                        id = Int32.Parse(grdTPastTrans.CurrentRow.Cells[2].Value.ToString());
                    else
                        id = Int32.Parse(grdTFutTrans.CurrentRow.Cells[2].Value.ToString());
                    //var uTrans = repo.FindTransaction(id);
                    FinanceDll.Transaction uTrans = new FinanceDll.Transaction();
                    uTrans.transName = txtTEtransName.Text;
                    uTrans.value = Decimal.Parse(txtTEvalue.Text);
                    uTrans.date = dteTEdate.Value;
                    uTrans.isRecurring = swTEisRecurring.Switched;
                    uTrans.categoryID = repo.FindCategory(cmbTEcategoryID.SelectedItem.ToString()).categoryID;
                    uTrans.userID = userID;
                    if (txtTErecurIntervalDays.Visible)
                        uTrans.recurIntervalDays = Int32.Parse(txtTErecurIntervalDays.Text);
                    else
                        uTrans.recurIntervalDays = null;
                    if (cmbTEloanID.Visible)
                        uTrans.loanID = repo.FindLoan(cmbTEloanID.SelectedItem.ToString()).loanID;
                    else
                        uTrans.loanID = null;
                    repo.UpdateTransaction(id, uTrans);
                    RefreshDataT();
                    if (uTrans.loanID != null)
                        RefreshBalance();
                }
                else
                    MessageBox.Show("Please select a transaction to edit from one of the tabs on the right.");
            }
        }

        private void btnTRemove_Click(object sender, EventArgs e)
        {
            int id;
            if (tbcTransView.SelectedTab == tbTPastTrans)
                id = Int32.Parse(grdTPastTrans.CurrentRow.Cells[2].Value.ToString());
            else
                id = Int32.Parse(grdTFutTrans.CurrentRow.Cells[2].Value.ToString());
            var dTrans = repo.FindTransaction(id);
            if(dTrans.isRecurring)
                repo.DeleteRecur(dTrans);
            else
                repo.DeleteTransaction(dTrans);
            MessageBox.Show($"Transaction '{dTrans.transName}' has been deleted.");
            RefreshDataT();
        }

        private void btnLAdd_Click(object sender, EventArgs e)
        {
            ValidateChildren(ValidationConstraints.Visible);
            if (LAValid())
            {
                var newLoan = new FinanceDll.Loan();
                newLoan.loanName = txtLAloanName.Text;
                newLoan.balance = Decimal.Parse(txtLAbalance.Text);
                newLoan.durationMonths = Int32.Parse(txtLAdurationMonths.Text);
                newLoan.fixedAPR = Decimal.Parse(txtLAfixedAPR.Text);
                newLoan.payment = Int32.Parse(txtLApayment.Text);
                newLoan.userID = userID;
                repo.AddLoan(newLoan);
                RefreshDataT();
                RefreshDataL();
                ClearL();
                RefreshCMBL();
                RefreshBalance();
            }
        }

        private void btnLEdit_Click(object sender, EventArgs e)
        {
            ValidateChildren(ValidationConstraints.Visible);
            if (LEValid())
            {
                if (grdLloans.CurrentRow != null)
                {
                    int id = Int32.Parse(grdLloans.CurrentRow.Cells[0].Value.ToString());
                    var uLoan = repo.FindLoan(id);
                    uLoan.loanName = txtLEloanName.Text;
                    uLoan.balance = Decimal.Parse(txtLEbalance.Text);
                    uLoan.durationMonths = Int32.Parse(txtLEdurationMonths.Text);
                    uLoan.fixedAPR = Decimal.Parse(txtLEfixedAPR.Text);
                    uLoan.payment = Decimal.Parse(txtLEpayment.Text);
                    repo.UpdateLoan(id, uLoan);
                    RefreshDataL();
                    RefreshDataT();
                    RefreshCMBL();
                    RefreshBalance();
                }
                else
                    MessageBox.Show("Please select a loan to edit from the panel on the right.");
            }
        }

        private void btnLRemove_Click(object sender, EventArgs e)
        {
            if (grdLloans.CurrentRow != null)
            {
                int id = Int32.Parse(grdLloans.CurrentRow.Cells[0].Value.ToString());
                var dLoan = repo.FindLoan(id);
                repo.DeleteLoan(dLoan);
                MessageBox.Show($"Loan '{dLoan.loanName}' has been deleted.");
                RefreshDataL();
                RefreshDataT();
                RefreshCMBL();
            }
            else
                MessageBox.Show("There are no loans to remove.");
        }

        private void btnBAdd_Click(object sender, EventArgs e)
        {
            ValidateChildren(ValidationConstraints.Visible);
            if (BAValid())
            {
                var newCategory = new FinanceDll.Category();
                newCategory.categoryName = txtBAcategoryName.Text;
                repo.AddCategory(newCategory);
                RefreshDataC();
                txtBAcategoryName.Text = null;
                RefreshCMBC();
            }
        }

        private void btnBEdit_Click(object sender, EventArgs e)
        {
            ValidateChildren(ValidationConstraints.Visible);
            if (BEValid())
            {
                int id = Int32.Parse(grdBcategories.CurrentRow.Cells[0].Value.ToString());
                var uCategory = repo.FindCategory(id);
                uCategory.categoryName = txtBEcategoryName.Text;
                repo.UpdateCategory(id, uCategory);
                RefreshDataC();
                RefreshDataT();
                RefreshCMBC();
            }
        }

        private void btnBRemove_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(grdBcategories.CurrentRow.Cells[0].Value.ToString());
            var dCategory = repo.FindCategory(id);
            repo.DeleteCategory(dCategory);
            MessageBox.Show($"Category '{dCategory.categoryName}' has been deleted.");
            RefreshDataC();
            RefreshDataT();
            RefreshCMBC();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(userID);
            changePassword.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            LogInPage logInPage = new LogInPage();
            logInPage.Show();
        }

        #endregion Button Handling

    }
}