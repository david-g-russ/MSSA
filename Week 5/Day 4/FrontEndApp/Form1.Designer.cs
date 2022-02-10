namespace FrontEndApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grdBooks = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dtePublished = new System.Windows.Forms.DateTimePicker();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblPublished = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.pnlExitSubMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Label();
            this.pnlRemoveSubMenu = new System.Windows.Forms.Panel();
            this.txtConfirmation = new System.Windows.Forms.TextBox();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.lblRemoveSubMenu = new System.Windows.Forms.Label();
            this.pnlNewSubMenu = new System.Windows.Forms.Panel();
            this.lblNewSubMenu = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlSideMenu.SuspendLayout();
            this.pnlExitSubMenu.SuspendLayout();
            this.pnlRemoveSubMenu.SuspendLayout();
            this.pnlNewSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBooks
            // 
            this.grdBooks.AllowUserToOrderColumns = true;
            this.grdBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdBooks.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("David CLM", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("David CLM", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdBooks.EnableHeadersVisualStyles = false;
            this.grdBooks.GridColor = System.Drawing.Color.DimGray;
            this.grdBooks.Location = new System.Drawing.Point(944, 302);
            this.grdBooks.Name = "grdBooks";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdBooks.RowHeadersWidth = 62;
            this.grdBooks.RowTemplate.Height = 28;
            this.grdBooks.Size = new System.Drawing.Size(1232, 773);
            this.grdBooks.TabIndex = 0;
            this.grdBooks.SelectionChanged += new System.EventHandler(this.grdBooks_SelectionChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("David CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAdd.Location = new System.Drawing.Point(0, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(538, 65);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Book";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DarkGray;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("David CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRemove.Location = new System.Drawing.Point(0, 82);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(538, 65);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove Book";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dtePublished
            // 
            this.dtePublished.Location = new System.Drawing.Point(223, 179);
            this.dtePublished.Name = "dtePublished";
            this.dtePublished.Size = new System.Drawing.Size(292, 26);
            this.dtePublished.TabIndex = 3;
            this.dtePublished.Validating += new System.ComponentModel.CancelEventHandler(this.dtePublished_Validating);
            this.dtePublished.Validated += new System.EventHandler(this.dtePublished_Validated);
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(223, 122);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(292, 28);
            this.cmbGenre.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(223, 14);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(292, 26);
            this.txtTitle.TabIndex = 5;
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitle_Validating);
            this.txtTitle.Validated += new System.EventHandler(this.txtTitle_Validated);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(223, 69);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(292, 26);
            this.txtAuthor.TabIndex = 6;
            this.txtAuthor.Validating += new System.ComponentModel.CancelEventHandler(this.txtAuthor_Validating);
            this.txtAuthor.Validated += new System.EventHandler(this.txtAuthor_Validated);
            // 
            // lblPublished
            // 
            this.lblPublished.AutoSize = true;
            this.lblPublished.BackColor = System.Drawing.Color.Transparent;
            this.lblPublished.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPublished.Font = new System.Drawing.Font("David CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPublished.Location = new System.Drawing.Point(0, 150);
            this.lblPublished.Name = "lblPublished";
            this.lblPublished.Padding = new System.Windows.Forms.Padding(15, 30, 0, 0);
            this.lblPublished.Size = new System.Drawing.Size(175, 55);
            this.lblPublished.TabIndex = 7;
            this.lblPublished.Text = "Date Published:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.Transparent;
            this.lblGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGenre.Font = new System.Drawing.Font("David CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblGenre.Location = new System.Drawing.Point(0, 95);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Padding = new System.Windows.Forms.Padding(15, 30, 0, 0);
            this.lblGenre.Size = new System.Drawing.Size(88, 55);
            this.lblGenre.TabIndex = 8;
            this.lblGenre.Text = "Genre:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAuthor.Font = new System.Drawing.Font("David CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAuthor.Location = new System.Drawing.Point(0, 40);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Padding = new System.Windows.Forms.Padding(15, 30, 0, 0);
            this.lblAuthor.Size = new System.Drawing.Size(98, 55);
            this.lblAuthor.TabIndex = 9;
            this.lblAuthor.Text = "Author:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("David CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(75, 40);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Title:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.DimGray;
            this.pnlSideMenu.Controls.Add(this.pnlExitSubMenu);
            this.pnlSideMenu.Controls.Add(this.lblExit);
            this.pnlSideMenu.Controls.Add(this.pnlRemoveSubMenu);
            this.pnlSideMenu.Controls.Add(this.lblRemoveSubMenu);
            this.pnlSideMenu.Controls.Add(this.pnlNewSubMenu);
            this.pnlSideMenu.Controls.Add(this.lblNewSubMenu);
            this.pnlSideMenu.Controls.Add(this.lblHeading);
            this.pnlSideMenu.Controls.Add(this.pictureBox1);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(538, 1384);
            this.pnlSideMenu.TabIndex = 8;
            // 
            // pnlExitSubMenu
            // 
            this.pnlExitSubMenu.BackColor = System.Drawing.Color.Gray;
            this.pnlExitSubMenu.Controls.Add(this.label2);
            this.pnlExitSubMenu.Controls.Add(this.btnExit);
            this.pnlExitSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExitSubMenu.Location = new System.Drawing.Point(0, 778);
            this.pnlExitSubMenu.Name = "pnlExitSubMenu";
            this.pnlExitSubMenu.Size = new System.Drawing.Size(538, 125);
            this.pnlExitSubMenu.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("David CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.label2.Size = new System.Drawing.Size(317, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm that you wish to exit.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkGray;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("David CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnExit.Location = new System.Drawing.Point(0, 60);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(538, 65);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit Application";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblExit
            // 
            this.lblExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblExit.Font = new System.Drawing.Font("David CLM", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblExit.Location = new System.Drawing.Point(0, 737);
            this.lblExit.Name = "lblExit";
            this.lblExit.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblExit.Size = new System.Drawing.Size(538, 41);
            this.lblExit.TabIndex = 15;
            this.lblExit.Text = "Exit Application";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // pnlRemoveSubMenu
            // 
            this.pnlRemoveSubMenu.BackColor = System.Drawing.Color.Gray;
            this.pnlRemoveSubMenu.Controls.Add(this.txtConfirmation);
            this.pnlRemoveSubMenu.Controls.Add(this.btnRemove);
            this.pnlRemoveSubMenu.Controls.Add(this.lblConfirmation);
            this.pnlRemoveSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRemoveSubMenu.Location = new System.Drawing.Point(0, 590);
            this.pnlRemoveSubMenu.Name = "pnlRemoveSubMenu";
            this.pnlRemoveSubMenu.Size = new System.Drawing.Size(538, 147);
            this.pnlRemoveSubMenu.TabIndex = 14;
            // 
            // txtConfirmation
            // 
            this.txtConfirmation.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtConfirmation.Location = new System.Drawing.Point(0, 46);
            this.txtConfirmation.Name = "txtConfirmation";
            this.txtConfirmation.Size = new System.Drawing.Size(538, 26);
            this.txtConfirmation.TabIndex = 1;
            this.txtConfirmation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblConfirmation.Font = new System.Drawing.Font("David CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblConfirmation.Location = new System.Drawing.Point(0, 0);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.lblConfirmation.Size = new System.Drawing.Size(538, 46);
            this.lblConfirmation.TabIndex = 0;
            this.lblConfirmation.Text = "Book that will be removed:";
            // 
            // lblRemoveSubMenu
            // 
            this.lblRemoveSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRemoveSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRemoveSubMenu.Font = new System.Drawing.Font("David CLM", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRemoveSubMenu.Location = new System.Drawing.Point(0, 549);
            this.lblRemoveSubMenu.Name = "lblRemoveSubMenu";
            this.lblRemoveSubMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblRemoveSubMenu.Size = new System.Drawing.Size(538, 41);
            this.lblRemoveSubMenu.TabIndex = 13;
            this.lblRemoveSubMenu.Text = "Remove Existing Book";
            this.lblRemoveSubMenu.Click += new System.EventHandler(this.lblRemoveSubMenu_Click);
            // 
            // pnlNewSubMenu
            // 
            this.pnlNewSubMenu.BackColor = System.Drawing.Color.Gray;
            this.pnlNewSubMenu.Controls.Add(this.dtePublished);
            this.pnlNewSubMenu.Controls.Add(this.lblPublished);
            this.pnlNewSubMenu.Controls.Add(this.btnAdd);
            this.pnlNewSubMenu.Controls.Add(this.lblGenre);
            this.pnlNewSubMenu.Controls.Add(this.lblAuthor);
            this.pnlNewSubMenu.Controls.Add(this.cmbGenre);
            this.pnlNewSubMenu.Controls.Add(this.lblTitle);
            this.pnlNewSubMenu.Controls.Add(this.txtTitle);
            this.pnlNewSubMenu.Controls.Add(this.txtAuthor);
            this.pnlNewSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNewSubMenu.Location = new System.Drawing.Point(0, 267);
            this.pnlNewSubMenu.Name = "pnlNewSubMenu";
            this.pnlNewSubMenu.Size = new System.Drawing.Size(538, 282);
            this.pnlNewSubMenu.TabIndex = 12;
            // 
            // lblNewSubMenu
            // 
            this.lblNewSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNewSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNewSubMenu.Font = new System.Drawing.Font("David CLM", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNewSubMenu.Location = new System.Drawing.Point(0, 226);
            this.lblNewSubMenu.Name = "lblNewSubMenu";
            this.lblNewSubMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblNewSubMenu.Size = new System.Drawing.Size(538, 41);
            this.lblNewSubMenu.TabIndex = 11;
            this.lblNewSubMenu.Text = "Add New Book";
            this.lblNewSubMenu.Click += new System.EventHandler(this.lblNewSubMenu_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeading.Font = new System.Drawing.Font("David CLM", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHeading.Location = new System.Drawing.Point(0, 135);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(538, 91);
            this.lblHeading.TabIndex = 10;
            this.lblHeading.Text = "Book Management System";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(538, 135);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2538, 1384);
            this.Controls.Add(this.pnlSideMenu);
            this.Controls.Add(this.grdBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlExitSubMenu.ResumeLayout(false);
            this.pnlExitSubMenu.PerformLayout();
            this.pnlRemoveSubMenu.ResumeLayout(false);
            this.pnlRemoveSubMenu.PerformLayout();
            this.pnlNewSubMenu.ResumeLayout(false);
            this.pnlNewSubMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBooks;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DateTimePicker dtePublished;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblPublished;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlNewSubMenu;
        private System.Windows.Forms.Label lblNewSubMenu;
        private System.Windows.Forms.Panel pnlRemoveSubMenu;
        private System.Windows.Forms.TextBox txtConfirmation;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.Label lblRemoveSubMenu;
        private System.Windows.Forms.Panel pnlExitSubMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblExit;
    }
}

