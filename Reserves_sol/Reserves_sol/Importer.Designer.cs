namespace Reserves_sol
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
            this.Supprimer = new System.Windows.Forms.Button();
            this.successLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // import
            // 
            this.import.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.import.Location = new System.Drawing.Point(436, 336);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(186, 32);
            this.import.TabIndex = 1;
            this.import.Text = "Importer des oeuvres";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // infosImport
            // 
            this.infosImport.AutoSize = true;
            this.infosImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.infosImport.Location = new System.Drawing.Point(180, 92);
            this.infosImport.Name = "infosImport";
            this.infosImport.Size = new System.Drawing.Size(77, 17);
            this.infosImport.TabIndex = 2;
            this.infosImport.Text = "infosImport";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(242, 235);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(39, 17);
            this.errorLabel.TabIndex = 3;
            this.errorLabel.Text = "error";
            // 
            // returnBut
            // 
            this.returnBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.returnBut.Location = new System.Drawing.Point(341, 427);
            this.returnBut.Name = "returnBut";
            this.returnBut.Size = new System.Drawing.Size(100, 32);
            this.returnBut.TabIndex = 4;
            this.returnBut.Text = "Retour";
            this.returnBut.UseVisualStyleBackColor = true;
            this.returnBut.Click += new System.EventHandler(this.returnBut_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Supprimer.Location = new System.Drawing.Point(127, 336);
            this.Supprimer.Margin = new System.Windows.Forms.Padding(2);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(186, 32);
            this.Supprimer.TabIndex = 5;
            this.Supprimer.Text = "Supprimer une oeuvre";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.successLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.successLabel.Location = new System.Drawing.Point(242, 270);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(59, 17);
            this.successLabel.TabIndex = 6;
            this.successLabel.Text = "success";
            // 
            // Importer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.Supprimer);
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
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Label successLabel;
    }
}