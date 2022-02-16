using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6._2
{
    public partial class Form1 : Form
    {
        #region Form Intialization

        // initialize repository and errorhandling string
        CarRepository repository;
        string errorMsg;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pnlNewSubMenu.Visible = false;
            pnlSubMenuUpdate.Visible = false;
            pnlRemoveSubMenu.Visible = false;
            pnlExitSubMenu.Visible = false;
            txtConfirmation.ReadOnly = true;
            lblMaximize.Visible = false;

            AutoValidate = AutoValidate.EnableAllowFocusChange;

            cmbCylinders.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCylindersu.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCylindersu.Items.AddRange(new string[] { "0", "2", "4", "6", "8", "10", "12", "14" });
            cmbCylinders.Items.AddRange(new string[] { "0", "2", "4", "6", "8", "10", "12", "14" });

            dteYear.Format = DateTimePickerFormat.Custom;
            dteYear.CustomFormat = "yyyy";
            dteYear.ShowUpDown = true;
            dteYearu.Format = DateTimePickerFormat.Custom;
            dteYearu.CustomFormat = "yyyy";
            dteYearu.ShowUpDown = true;

            repository = new CarRepository();
            RefreshData();
        }

        #endregion

        #region Menu Handling
        private void lblNewSubMenu_Click(object sender, EventArgs e)
        {
            if (pnlNewSubMenu.Visible == true)
                pnlNewSubMenu.Visible = false;
            else
            {
                pnlRemoveSubMenu.Visible = false;
                pnlExitSubMenu.Visible = false;
                pnlSubMenuUpdate.Visible = false;
                pnlNewSubMenu.Visible = true;
                Clear();
                txtVIN.Text = repository.GenerateVIN();
                txtVIN.ReadOnly = true;
            }
        }
        private void lblUpdate_Click(object sender, EventArgs e)
        {
            if (pnlSubMenuUpdate.Visible == true)
                pnlSubMenuUpdate.Visible = false;
            else
            {
                pnlRemoveSubMenu.Visible = false;
                pnlExitSubMenu.Visible = false;
                pnlNewSubMenu.Visible = false;
                pnlSubMenuUpdate.Visible = true;
                var vin = grdCars.CurrentRow.Cells[0].Value.ToString();
                var cartoupdate = repository.FindCar(vin);
                txtVINu.Text = cartoupdate.VIN;
                txtVINu.ReadOnly = true;
                txtMakeu.Text = cartoupdate.Make;
                txtModelu.Text = cartoupdate.Model;
                txtDisplacementu.Text = cartoupdate.EngineDisplacement.ToString();
                txtPriceu.Text = cartoupdate.Price.ToString();
                dteYearu.Value = DateTime.Parse("1/" + cartoupdate.Year.ToString());
                cmbCylindersu.SelectedIndex = (int)(cartoupdate.Cylinders / 2);
            }
        }
        private void lblRemoveSubMenu_Click(object sender, EventArgs e)
        {
            if (pnlRemoveSubMenu.Visible == true)
                pnlRemoveSubMenu.Visible = false;
            else
            {
                pnlRemoveSubMenu.Visible = true;
                pnlExitSubMenu.Visible = false;
                pnlSubMenuUpdate.Visible = false;
                pnlNewSubMenu.Visible = false;
            }
        }
        private void lblExit_Click(object sender, EventArgs e)
        {
            if (pnlExitSubMenu.Visible == true)
                pnlExitSubMenu.Visible = false;
            else
            {
                pnlRemoveSubMenu.Visible = false;
                pnlExitSubMenu.Visible = true;
                pnlSubMenuUpdate.Visible = false;
                pnlNewSubMenu.Visible = false;
            }
        }
        private void lblMinimize_Click(object sender, EventArgs e)
        {
            pnlSideMenu.Visible = false;
            lblMinimize.Visible = false;
            lblMaximize.Visible = true;
        }
        private void lblMaximize_Click(object sender, EventArgs e)
        {
            pnlSideMenu.Visible = true;
            lblMaximize.Visible = false;
            lblMinimize.Visible = true;
        }

        #endregion

        #region Button Behavior

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ValidateChildren(ValidationConstraints.Visible);
            if (errorProvider1.GetError(txtVIN) == "" && errorProvider1.GetError(txtDisplacement) == "" &&
                errorProvider1.GetError(dteYear) == "" && errorProvider1.GetError(txtMake) == "" &&
                errorProvider1.GetError(txtModel) == "" && errorProvider1.GetError(txtPrice) == "" &&
                errorProvider1.GetError(cmbCylinders) == "" && errorProvider1.GetError(cmbCylinders) == "")
            {
                var newCar = new Car();
                newCar.VIN = txtVIN.Text;
                newCar.Make = txtMake.Text;
                newCar.Model = txtModel.Text;
                newCar.Year = (short?)dteYear.Value.Year;
                newCar.Cylinders = (short?)(cmbCylinders.SelectedIndex * 2);
                newCar.EngineDisplacement = Decimal.Parse(txtDisplacement.Text);
                newCar.Price = Decimal.Parse(txtPrice.Text);
                repository.AddRecord(newCar);
                RefreshData();
                Clear();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ValidateChildren(ValidationConstraints.Visible);
            if (errorProvider1.GetError(txtVINu) == "" && errorProvider1.GetError(txtDisplacementu) == "" &&
                errorProvider1.GetError(dteYearu) == "" && errorProvider1.GetError(txtMakeu) == "" &&
                errorProvider1.GetError(txtModelu) == "" && errorProvider1.GetError(txtPriceu) == "" &&
                errorProvider1.GetError(cmbCylindersu) == "")
            {
                var vin = txtVINu.Text;
                var cartoupdate = repository.FindCar(vin);
                cartoupdate.VIN = txtVINu.Text;
                cartoupdate.Make = txtMakeu.Text;
                cartoupdate.Model = txtModelu.Text;
                cartoupdate.Cylinders = (short?)((cmbCylindersu.SelectedIndex + 1) * 2);
                cartoupdate.EngineDisplacement = Decimal.Parse(txtDisplacementu.Text);
                cartoupdate.Price = Decimal.Parse(txtPriceu.Text);
                cartoupdate.Year = (short?)dteYear.Value.Year;
                repository.UpdateRecord(vin, cartoupdate);
                RefreshData();
                pnlSubMenuUpdate.Visible = false;
            }

        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            var vin = grdCars.CurrentRow.Cells[0].Value.ToString();
            var cartodel = repository.FindCar(vin);
            repository.DeleteRecord(cartodel);
            MessageBox.Show($"{cartodel.Year} {cartodel.Make} {cartodel.Model} has been totalled.");
            RefreshData();
        }
        private void btnExit_MouseClick(object sender, MouseEventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            Application.Exit();
        }
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e) // click add button if enter is pressed while in Price textbox
        {
            if (e.KeyChar == (char)13)
            {
                btnAdd.PerformClick();
                this.AutoValidate = AutoValidate.Disable;
                btnAdd.Focus();
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                errorProvider1.SetError(txtPrice, "");
            }

        }
        private void txtPriceu_KeyPress(object sender, KeyPressEventArgs e) // click add button if enter is pressed while in Priceu textbox
        {
            if (e.KeyChar == (char)13)
            {
                btnUpdate.PerformClick();
                this.AutoValidate = AutoValidate.Disable;
                btnUpdate.Focus();
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                errorProvider1.SetError(txtPriceu, "");
            }
        }

        #endregion

        #region Input Validation

        private void txtMake_Validating(object sender, CancelEventArgs e)
        {
            if (txtMake.Text.Length > 50)
                errorMsg = "No sane person would name a make that long.";
            else if (txtMake.Text.Length == 0)
                errorMsg = "You need to enter a make.";
            else
                return;
            e.Cancel = true;
            txtMake.Select(0, txtMake.Text.Length);
            this.errorProvider1.SetError(txtMake, errorMsg);
        }
        private void txtMake_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMake, "");
        }
        private void txtModel_Validating(object sender, CancelEventArgs e)
        {
            if (txtModel.Text.Length > 50)
                errorMsg = "No sane person would name a model that long.";
            else if (txtModel.Text.Length == 0)
                errorMsg = "You need to enter a model.";
            else
                return;
            e.Cancel = true;
            txtModel.Select(0, txtMake.Text.Length);
            this.errorProvider1.SetError(txtModel, errorMsg);
        }
        private void txtModel_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtModel, "");
        }
        private void dteYear_Validating(object sender, CancelEventArgs e)
        {
            if (dteYear.Value.Year < 1886)
                errorMsg = "Carl Benz created the first car in 1886, silly.";
            else if (dteYear.Value.Year > DateTime.Now.Year + 5)
                errorMsg = "What, do you have a time machine?";
            else
                return;
            e.Cancel = true;
            dteYear.Select();
            this.errorProvider1.SetError(dteYear, errorMsg);
        }
        private void dteYear_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dteYear, "");
        }
        private void txtDisplacement_Validating(object sender, CancelEventArgs e)
        {
            if (!Decimal.TryParse(txtDisplacement.Text, out var displacement))
                errorMsg = "Not a valid decimal number.";
            else if (Decimal.Compare(Decimal.Parse(txtDisplacement.Text), 28.5m) > 0)
                errorMsg = "The largest displacement engine ever built was 28.5L, silly.";
            else if (Decimal.Compare(Decimal.Parse(txtDisplacement.Text), 0) < 0)
                errorMsg = "You can't have a negative displacement engine... can you?";
            else
                return;
            e.Cancel = true;
            txtDisplacement.Select(0, txtDisplacement.Text.Length);
            this.errorProvider1.SetError(txtDisplacement, errorMsg);
        }
        private void txtDisplacement_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDisplacement, "");
        }
        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            if (!Decimal.TryParse(txtPrice.Text, out var price))
                errorMsg = "Not a valid decimal number.";
            else if (Decimal.Compare(Decimal.Parse(txtPrice.Text), 70000000m) > 0)
                errorMsg = "The most a car ever sold for was $70,000,000, crazy.";
            else if (Decimal.Compare(Decimal.Parse(txtPrice.Text), 0) < 0)
                errorMsg = "What, is someone paying you to take this car?";
            else
                return;
            e.Cancel = true;
            txtDisplacement.Select(0, txtPrice.Text.Length);
            this.errorProvider1.SetError(txtPrice, errorMsg);
        }
        private void txtPrice_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPrice, "");
        }
        private void txtMakeu_Validating(object sender, CancelEventArgs e)
        {
            if (txtMakeu.Text.Length > 50)
                errorMsg = "No sane person would name a make that long.";
            else if (txtMakeu.Text.Length == 0)
                errorMsg = "You need to enter a make.";
            else
                return;
            e.Cancel = true;
            txtMakeu.Select(0, txtMakeu.Text.Length);
            this.errorProvider1.SetError(txtMakeu, errorMsg);
        }
        private void txtMakeu_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMakeu, "");
        }
        private void txtModelu_Validating(object sender, CancelEventArgs e)
        {
            if (txtModelu.Text.Length > 50)
                errorMsg = "No sane person would name a model that long.";
            else if (txtModelu.Text.Length == 0)
                errorMsg = "You need to enter a model.";
            else
                return;
            e.Cancel = true;
            txtModelu.Select(0, txtModelu.Text.Length);
            this.errorProvider1.SetError(txtModelu, errorMsg);
        }
        private void txtModelu_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtModelu, "");
        }
        private void dteYearu_Validating(object sender, CancelEventArgs e)
        {
            if (dteYearu.Value.Year < 1886)
                errorMsg = "Carl Benz created the first car in 1886, silly.";
            else if (dteYearu.Value.Year > DateTime.Now.Year + 5)
                errorMsg = "What, do you have a time machine?";
            else
                return;
            e.Cancel = true;
            dteYearu.Select();
            this.errorProvider1.SetError(dteYearu, errorMsg);
        }
        private void dteYearu_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dteYearu, "");
        }
        private void txtDisplacementu_Validating(object sender, CancelEventArgs e)
        {
            if (!Decimal.TryParse(txtDisplacementu.Text, out var displacement))
                errorMsg = "Not a valid decimal number.";
            else if (Decimal.Compare(Decimal.Parse(txtDisplacementu.Text), 28.5m) > 0)
                errorMsg = "The largest displacement engine ever built was 28.5L, silly.";
            else if (Decimal.Compare(Decimal.Parse(txtDisplacementu.Text), 0) < 0)
                errorMsg = "You can't have a negative displacement engine... can you?";
            else
                return;
            e.Cancel = true;
            txtDisplacement.Select(0, txtDisplacementu.Text.Length);
            this.errorProvider1.SetError(txtDisplacementu, errorMsg);
        }
        private void txtDisplacementu_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDisplacementu, "");
        }
        private void txtPriceu_Validating(object sender, CancelEventArgs e)
        {
            if (!Decimal.TryParse(txtPriceu.Text, out var price))
                errorMsg = "Not a valid decimal number.";
            else if (Decimal.Compare(Decimal.Parse(txtPriceu.Text), 70000000m) > 0)
                errorMsg = "The most a car ever sold for was $70,000,000, crazy.";
            else if (Decimal.Compare(Decimal.Parse(txtPriceu.Text), 0) < 0)
                errorMsg = "What, is someone paying you to take this car?";
            else
                return;
            e.Cancel = true;
            txtDisplacement.Select(0, txtPriceu.Text.Length);
            this.errorProvider1.SetError(txtPriceu, errorMsg);
        }
        private void txtPriceu_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPriceu, "");
        }
        private void cmbCylinders_Validating(object sender, CancelEventArgs e)
        {
            if (cmbCylinders.SelectedIndex == -1)
            {
                errorMsg = "You need to select an option.";
                e.Cancel = true;
                this.errorProvider1.SetError(cmbCylinders, errorMsg);
            }
        }
        private void cmbCylinders_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cmbCylinders, "");
        }

        private void cmbCylindersu_Validating(object sender, CancelEventArgs e)
        {
            if (cmbCylindersu.SelectedIndex == -1)
            {
                errorMsg = "You need to select an option.";
                e.Cancel = true;
                this.errorProvider1.SetError(cmbCylindersu, errorMsg);
            }
        }
        private void cmbCylindersu_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cmbCylindersu, "");
        }

        #endregion

        #region Automated Functions
        private void RefreshData()
        {
            if (repository.GetCars().Count > 0)
            {
                grdCars.DataSource = null;
                grdCars.DataSource = repository.GetCars();
                grdCars.Visible = true;
                lblRemoveSubMenu.Visible = true;
                lblUpdate.Visible = true;
                SetGridHeightWidth(grdCars, 1400);
                grdCars.Columns[4].DefaultCellStyle.Format = "c";
                grdCars.Columns[5].HeaderText = "Displacement(L)";
                grdCars.Columns[0].Width = 175;
                grdCars.Columns[3].Width = 50;
                grdCars.Columns[5].Width = 120;
                grdCars.Columns[6].Width = 80;
            }
            else
            {
                grdCars.Visible = false;
                pnlRemoveSubMenu.Visible = false;
                pnlSubMenuUpdate.Visible = false;
                lblRemoveSubMenu.Visible = false;
                lblUpdate.Visible = false;
            }
        }
        private void Clear()
        {
            txtVIN.Text = repository.GenerateVIN();
            txtMake.Clear();
            txtModel.Clear();
            txtDisplacement.Clear();
            cmbCylinders.SelectedIndex = -1;
            txtPrice.Clear();
            dteYear.Value = DateTime.Now;
        }
        private void grdCars_SelectionChanged(object sender, EventArgs e)
        {
            if (grdCars.CurrentRow.Cells[0].Value != null)
            {
                var vin = grdCars.CurrentRow.Cells[0].Value.ToString();
                if (repository.FindCar(vin) != null)
                {
                    var cartoupdate = repository.FindCar(vin);
                    txtVINu.Text = cartoupdate.VIN;
                    txtVINu.ReadOnly = true;
                    txtMakeu.Text = cartoupdate.Make;
                    txtModelu.Text = cartoupdate.Model;
                    txtDisplacementu.Text = cartoupdate.EngineDisplacement.ToString();
                    txtPriceu.Text = cartoupdate.Price.ToString();
                    cmbCylindersu.SelectedIndex = ((int)cartoupdate.Cylinders / 2);
                    dteYearu.Value = DateTime.Parse("1/" + cartoupdate.Year.ToString());

                    errorProvider1.SetError(txtMakeu, "");
                    errorProvider1.SetError(txtModelu, "");
                    errorProvider1.SetError(dteYear, "");
                    errorProvider1.SetError(cmbCylindersu, "");
                    errorProvider1.SetError(txtDisplacementu, "");
                    errorProvider1.SetError(txtPriceu, "");

                    txtConfirmation.Text = $"{cartoupdate.Year} {cartoupdate.Make} {cartoupdate.Model}";
                }
            }
            else
                txtConfirmation.Text = "There are no cars left, you crashed them all.";
        }
        public static void SetGridHeightWidth(DataGridView grd, int maxHeight)
        {
            var height = 40;
            foreach (DataGridViewRow row in grd.Rows)
            {
                if (row.Visible)
                    height += row.Height;
            }

            if (height > maxHeight)
                height = maxHeight;

            grd.Height = height;
        }

        #endregion

      
    }
}