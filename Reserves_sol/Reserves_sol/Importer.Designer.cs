﻿namespace Reserves_sol
{
    partial class Importer
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
            this.import = new System.Windows.Forms.Button();
            this.infosImport = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.returnBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(92, 300);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(75, 23);
            this.import.TabIndex = 1;
            this.import.Text = "Importer";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // infosImport
            // 
            this.infosImport.AutoSize = true;
            this.infosImport.Location = new System.Drawing.Point(12, 120);
            this.infosImport.Name = "infosImport";
            this.infosImport.Size = new System.Drawing.Size(58, 13);
            this.infosImport.TabIndex = 2;
            this.infosImport.Text = "infosImport";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(42, 264);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(28, 13);
            this.errorLabel.TabIndex = 3;
            this.errorLabel.Text = "error";
            // 
            // returnBut
            // 
            this.returnBut.Location = new System.Drawing.Point(92, 352);
            this.returnBut.Name = "returnBut";
            this.returnBut.Size = new System.Drawing.Size(75, 23);
            this.returnBut.TabIndex = 4;
            this.returnBut.Text = "Retour";
            this.returnBut.UseVisualStyleBackColor = true;
            this.returnBut.Click += new System.EventHandler(this.returnBut_Click);
            // 
            // Importer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 431);
            this.Controls.Add(this.returnBut);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.infosImport);
            this.Controls.Add(this.import);
            this.Name = "Importer";
            this.Text = "Importer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Label infosImport;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button returnBut;
    }
}