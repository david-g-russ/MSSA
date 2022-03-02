﻿namespace PersonalFinanceApp
{
    partial class UserControlDays
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
            this.lblCCbalance = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblCCNetChange = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblCCDay = new MetroSet_UI.Controls.MetroSetLabel();
            this.SuspendLayout();
            // 
            // lblCCbalance
            // 
            this.lblCCbalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCCbalance.Font = new System.Drawing.Font("Reem Kufi", 11.25F);
            this.lblCCbalance.IsDerivedStyle = true;
            this.lblCCbalance.Location = new System.Drawing.Point(0, 77);
            this.lblCCbalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCCbalance.Name = "lblCCbalance";
            this.lblCCbalance.Size = new System.Drawing.Size(341, 33);
            this.lblCCbalance.Style = MetroSet_UI.Enums.Style.Light;
            this.lblCCbalance.StyleManager = null;
            this.lblCCbalance.TabIndex = 5;
            this.lblCCbalance.Text = "Balance";
            this.lblCCbalance.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCCbalance.ThemeAuthor = "Narwin";
            this.lblCCbalance.ThemeName = "MetroLite";
            // 
            // lblCCNetChange
            // 
            this.lblCCNetChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCCNetChange.Font = new System.Drawing.Font("Reem Kufi", 11.25F);
            this.lblCCNetChange.IsDerivedStyle = true;
            this.lblCCNetChange.Location = new System.Drawing.Point(0, 29);
            this.lblCCNetChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCCNetChange.Name = "lblCCNetChange";
            this.lblCCNetChange.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblCCNetChange.Size = new System.Drawing.Size(341, 48);
            this.lblCCNetChange.Style = MetroSet_UI.Enums.Style.Light;
            this.lblCCNetChange.StyleManager = null;
            this.lblCCNetChange.TabIndex = 4;
            this.lblCCNetChange.Text = "NetChange";
            this.lblCCNetChange.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCCNetChange.ThemeAuthor = "Narwin";
            this.lblCCNetChange.ThemeName = "MetroLite";
            // 
            // lblCCDay
            // 
            this.lblCCDay.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCCDay.Font = new System.Drawing.Font("Reem Kufi", 11.25F);
            this.lblCCDay.IsDerivedStyle = true;
            this.lblCCDay.Location = new System.Drawing.Point(0, 0);
            this.lblCCDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCCDay.Name = "lblCCDay";
            this.lblCCDay.Size = new System.Drawing.Size(341, 29);
            this.lblCCDay.Style = MetroSet_UI.Enums.Style.Light;
            this.lblCCDay.StyleManager = null;
            this.lblCCDay.TabIndex = 3;
            this.lblCCDay.Text = "DayNum";
            this.lblCCDay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCCDay.ThemeAuthor = "Narwin";
            this.lblCCDay.ThemeName = "MetroLite";
            // 
            // UserControlDays
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblCCbalance);
            this.Controls.Add(this.lblCCNetChange);
            this.Controls.Add(this.lblCCDay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(341, 118);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetLabel lblCCbalance;
        private MetroSet_UI.Controls.MetroSetLabel lblCCNetChange;
        private MetroSet_UI.Controls.MetroSetLabel lblCCDay;
    }
}
