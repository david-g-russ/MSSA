namespace Assignment4._4
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBeverages = new System.Windows.Forms.Button();
            this.btnBank = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(888, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(843, 159);
            this.label1.TabIndex = 0;
            this.label1.Text = "And Also Bank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Reem Kufi", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(557, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(910, 61);
            this.label2.TabIndex = 1;
            this.label2.Text = "Where you can apply for a loan while drinking artisan coffee";
            // 
            // btnBeverages
            // 
            this.btnBeverages.BackColor = System.Drawing.Color.Transparent;
            this.btnBeverages.Font = new System.Drawing.Font("Reem Kufi", 15F);
            this.btnBeverages.Location = new System.Drawing.Point(286, 658);
            this.btnBeverages.Name = "btnBeverages";
            this.btnBeverages.Size = new System.Drawing.Size(275, 190);
            this.btnBeverages.TabIndex = 2;
            this.btnBeverages.Text = "Enter Beverage Management System";
            this.btnBeverages.UseVisualStyleBackColor = false;
            this.btnBeverages.Click += new System.EventHandler(this.btnBeverages_Click);
            // 
            // btnBank
            // 
            this.btnBank.BackColor = System.Drawing.Color.Transparent;
            this.btnBank.Font = new System.Drawing.Font("Reem Kufi", 15F);
            this.btnBank.Location = new System.Drawing.Point(795, 658);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(275, 190);
            this.btnBank.TabIndex = 3;
            this.btnBank.Text = "Enter Bank Management System";
            this.btnBank.UseVisualStyleBackColor = false;
            this.btnBank.Click += new System.EventHandler(this.btnBank_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkGray;
            this.btnExit.Font = new System.Drawing.Font("Reem Kufi", 15F);
            this.btnExit.Location = new System.Drawing.Point(1593, 949);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 63);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBank);
            this.Controls.Add(this.btnBeverages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBeverages;
        private System.Windows.Forms.Button btnBank;
        private System.Windows.Forms.Button btnExit;
    }
}