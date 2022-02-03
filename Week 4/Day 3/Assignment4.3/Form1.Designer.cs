namespace Assignment4._3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblCreate = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblAddr = new System.Windows.Forms.Label();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.btnCrtStud = new System.Windows.Forms.Button();
            this.lblGradeLvl = new System.Windows.Forms.Label();
            this.btnRemStud = new System.Windows.Forms.Button();
            this.grpStud = new System.Windows.Forms.GroupBox();
            this.btnGenComm = new System.Windows.Forms.Button();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblMonthAdm = new System.Windows.Forms.Label();
            this.studGrid = new System.Windows.Forms.DataGridView();
            this.cmbGradeLvl = new System.Windows.Forms.ComboBox();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.cmbMonthAdm = new System.Windows.Forms.ComboBox();
            this.btnEditStud = new System.Windows.Forms.Button();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grpStud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(330, 64);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(353, 42);
            this.txtFName.TabIndex = 0;
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.BackColor = System.Drawing.Color.Black;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.ForeColor = System.Drawing.Color.White;
            this.lblFName.Location = new System.Drawing.Point(37, 64);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(262, 36);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "Student first name:";
            this.lblFName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.BackColor = System.Drawing.Color.Transparent;
            this.lblCreate.Font = new System.Drawing.Font("Reem Kufi", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblCreate.ForeColor = System.Drawing.Color.BurlyWood;
            this.lblCreate.Location = new System.Drawing.Point(475, 53);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(859, 114);
            this.lblCreate.TabIndex = 2;
            this.lblCreate.Text = "Student Management System";
            this.lblCreate.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.BackColor = System.Drawing.Color.Black;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.ForeColor = System.Drawing.Color.White;
            this.lblLName.Location = new System.Drawing.Point(39, 139);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(260, 36);
            this.lblLName.TabIndex = 3;
            this.lblLName.Text = "Student last name:";
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(330, 139);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(353, 42);
            this.txtLName.TabIndex = 4;
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.BackColor = System.Drawing.Color.Black;
            this.lblAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddr.ForeColor = System.Drawing.Color.White;
            this.lblAddr.Location = new System.Drawing.Point(59, 206);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(240, 36);
            this.lblAddr.TabIndex = 5;
            this.lblAddr.Text = "Student address:";
            // 
            // txtAddr
            // 
            this.txtAddr.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddr.Location = new System.Drawing.Point(330, 206);
            this.txtAddr.Multiline = true;
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(353, 90);
            this.txtAddr.TabIndex = 6;
            this.txtAddr.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnCrtStud
            // 
            this.btnCrtStud.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCrtStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrtStud.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCrtStud.Location = new System.Drawing.Point(111, 910);
            this.btnCrtStud.Name = "btnCrtStud";
            this.btnCrtStud.Size = new System.Drawing.Size(170, 100);
            this.btnCrtStud.TabIndex = 9;
            this.btnCrtStud.Text = "Create Student";
            this.btnCrtStud.UseVisualStyleBackColor = false;
            this.btnCrtStud.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblGradeLvl
            // 
            this.lblGradeLvl.AutoSize = true;
            this.lblGradeLvl.BackColor = System.Drawing.Color.Black;
            this.lblGradeLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeLvl.ForeColor = System.Drawing.Color.White;
            this.lblGradeLvl.Location = new System.Drawing.Point(125, 323);
            this.lblGradeLvl.Name = "lblGradeLvl";
            this.lblGradeLvl.Size = new System.Drawing.Size(174, 36);
            this.lblGradeLvl.TabIndex = 12;
            this.lblGradeLvl.Text = "Grade level:";
            // 
            // btnRemStud
            // 
            this.btnRemStud.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRemStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemStud.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRemStud.Location = new System.Drawing.Point(463, 910);
            this.btnRemStud.Name = "btnRemStud";
            this.btnRemStud.Size = new System.Drawing.Size(170, 100);
            this.btnRemStud.TabIndex = 14;
            this.btnRemStud.Text = "Remove Student";
            this.btnRemStud.UseVisualStyleBackColor = false;
            this.btnRemStud.Click += new System.EventHandler(this.btnRemStud_Click);
            // 
            // grpStud
            // 
            this.grpStud.BackColor = System.Drawing.Color.Transparent;
            this.grpStud.Controls.Add(this.cmbMonthAdm);
            this.grpStud.Controls.Add(this.cmbGrade);
            this.grpStud.Controls.Add(this.cmbGradeLvl);
            this.grpStud.Controls.Add(this.lblMonthAdm);
            this.grpStud.Controls.Add(this.lblGrade);
            this.grpStud.Controls.Add(this.lblFName);
            this.grpStud.Controls.Add(this.txtFName);
            this.grpStud.Controls.Add(this.lblLName);
            this.grpStud.Controls.Add(this.txtLName);
            this.grpStud.Controls.Add(this.lblAddr);
            this.grpStud.Controls.Add(this.lblGradeLvl);
            this.grpStud.Controls.Add(this.txtAddr);
            this.grpStud.ForeColor = System.Drawing.Color.White;
            this.grpStud.Location = new System.Drawing.Point(106, 236);
            this.grpStud.Name = "grpStud";
            this.grpStud.Size = new System.Drawing.Size(718, 555);
            this.grpStud.TabIndex = 17;
            this.grpStud.TabStop = false;
            this.grpStud.Text = "Student Details";
            this.grpStud.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnGenComm
            // 
            this.btnGenComm.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGenComm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenComm.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGenComm.Location = new System.Drawing.Point(639, 910);
            this.btnGenComm.Name = "btnGenComm";
            this.btnGenComm.Size = new System.Drawing.Size(170, 100);
            this.btnGenComm.TabIndex = 18;
            this.btnGenComm.Text = "Generate Comment";
            this.btnGenComm.UseVisualStyleBackColor = false;
            this.btnGenComm.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.BackColor = System.Drawing.Color.Black;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.ForeColor = System.Drawing.Color.White;
            this.lblGrade.Location = new System.Drawing.Point(194, 398);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(105, 36);
            this.lblGrade.TabIndex = 17;
            this.lblGrade.Text = "Grade:";
            this.lblGrade.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblMonthAdm
            // 
            this.lblMonthAdm.AutoSize = true;
            this.lblMonthAdm.BackColor = System.Drawing.Color.Black;
            this.lblMonthAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthAdm.ForeColor = System.Drawing.Color.White;
            this.lblMonthAdm.Location = new System.Drawing.Point(17, 477);
            this.lblMonthAdm.Name = "lblMonthAdm";
            this.lblMonthAdm.Size = new System.Drawing.Size(282, 36);
            this.lblMonthAdm.TabIndex = 18;
            this.lblMonthAdm.Text = "Month of admission:";
            // 
            // studGrid
            // 
            this.studGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.studGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studGrid.Location = new System.Drawing.Point(841, 157);
            this.studGrid.Name = "studGrid";
            this.studGrid.RowHeadersWidth = 62;
            this.studGrid.RowTemplate.Height = 28;
            this.studGrid.Size = new System.Drawing.Size(917, 738);
            this.studGrid.TabIndex = 19;
            this.studGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studGrid_CellContentClick);
            // 
            // cmbGradeLvl
            // 
            this.cmbGradeLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGradeLvl.FormattingEnabled = true;
            this.cmbGradeLvl.Location = new System.Drawing.Point(330, 323);
            this.cmbGradeLvl.Name = "cmbGradeLvl";
            this.cmbGradeLvl.Size = new System.Drawing.Size(353, 44);
            this.cmbGradeLvl.TabIndex = 19;
            this.cmbGradeLvl.Text = "Select grade level";
            // 
            // cmbGrade
            // 
            this.cmbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Location = new System.Drawing.Point(330, 398);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(353, 44);
            this.cmbGrade.TabIndex = 20;
            this.cmbGrade.Text = "Select grade";
            // 
            // cmbMonthAdm
            // 
            this.cmbMonthAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonthAdm.FormattingEnabled = true;
            this.cmbMonthAdm.Location = new System.Drawing.Point(330, 477);
            this.cmbMonthAdm.Name = "cmbMonthAdm";
            this.cmbMonthAdm.Size = new System.Drawing.Size(353, 44);
            this.cmbMonthAdm.TabIndex = 21;
            this.cmbMonthAdm.Text = "Select admission month";
            // 
            // btnEditStud
            // 
            this.btnEditStud.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEditStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStud.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEditStud.Location = new System.Drawing.Point(287, 910);
            this.btnEditStud.Name = "btnEditStud";
            this.btnEditStud.Size = new System.Drawing.Size(170, 100);
            this.btnEditStud.TabIndex = 20;
            this.btnEditStud.Text = "Edit Student";
            this.btnEditStud.UseVisualStyleBackColor = false;
            this.btnEditStud.Click += new System.EventHandler(this.btnEditStud_Click);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Assignment4._3.Student);
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataSource = typeof(Assignment4._3.Student);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1869, 1179);
            this.Controls.Add(this.btnEditStud);
            this.Controls.Add(this.studGrid);
            this.Controls.Add(this.btnGenComm);
            this.Controls.Add(this.grpStud);
            this.Controls.Add(this.btnRemStud);
            this.Controls.Add(this.btnCrtStud);
            this.Controls.Add(this.lblCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpStud.ResumeLayout(false);
            this.grpStud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.Button btnCrtStud;
        private System.Windows.Forms.Label lblGradeLvl;
        private System.Windows.Forms.Button btnRemStud;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.GroupBox grpStud;
        private System.Windows.Forms.Button btnGenComm;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblMonthAdm;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private System.Windows.Forms.DataGridView studGrid;
        private System.Windows.Forms.ComboBox cmbGradeLvl;
        private System.Windows.Forms.ComboBox cmbMonthAdm;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.Button btnEditStud;
    }
}

