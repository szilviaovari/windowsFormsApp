﻿namespace WindowsFormsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.nameUpdatebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameSortbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Hugi\\Documents\\2025-2026\\project_windowsForms\\Sajat\\Ovari_Szilvia.html";
            // 
            // nameUpdatebutton
            // 
            this.nameUpdatebutton.BackColor = System.Drawing.Color.RosyBrown;
            this.nameUpdatebutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameUpdatebutton.Location = new System.Drawing.Point(50, 41);
            this.nameUpdatebutton.Margin = new System.Windows.Forms.Padding(0);
            this.nameUpdatebutton.Name = "nameUpdatebutton";
            this.nameUpdatebutton.Padding = new System.Windows.Forms.Padding(5);
            this.nameUpdatebutton.Size = new System.Drawing.Size(234, 51);
            this.nameUpdatebutton.TabIndex = 0;
            this.nameUpdatebutton.Text = "Nevek frissítése";
            this.nameUpdatebutton.UseVisualStyleBackColor = false;
            this.nameUpdatebutton.Click += new System.EventHandler(this.nameUpdatebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 54);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(70, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nevek:";
            // 
            // nameSortbutton
            // 
            this.nameSortbutton.BackColor = System.Drawing.Color.RosyBrown;
            this.nameSortbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameSortbutton.Location = new System.Drawing.Point(50, 148);
            this.nameSortbutton.Margin = new System.Windows.Forms.Padding(0);
            this.nameSortbutton.Name = "nameSortbutton";
            this.nameSortbutton.Padding = new System.Windows.Forms.Padding(5);
            this.nameSortbutton.Size = new System.Drawing.Size(234, 51);
            this.nameSortbutton.TabIndex = 2;
            this.nameSortbutton.Text = "Nevek rendezése";
            this.nameSortbutton.UseVisualStyleBackColor = false;
            this.nameSortbutton.Click += new System.EventHandler(this.nameSortbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.nameSortbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameUpdatebutton);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Hugi panel";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button nameUpdatebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nameSortbutton;
    }
}

