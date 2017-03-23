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
            this.SuspendLayout();
            // 
            // import
            // 
            this.import.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.import.Location = new System.Drawing.Point(456, 344);
            this.import.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(150, 50);
            this.import.TabIndex = 1;
            this.import.Text = "Importer";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // infosImport
            // 
            this.infosImport.AutoSize = true;
            this.infosImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infosImport.Location = new System.Drawing.Point(183, 61);
            this.infosImport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infosImport.Name = "infosImport";
            this.infosImport.Size = new System.Drawing.Size(107, 25);
            this.infosImport.TabIndex = 2;
            this.infosImport.Text = "infosImport";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(205, 269);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(57, 25);
            this.errorLabel.TabIndex = 3;
            this.errorLabel.Text = "error";
            // 
            // returnBut
            // 
            this.returnBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBut.Location = new System.Drawing.Point(311, 441);
            this.returnBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.returnBut.Name = "returnBut";
            this.returnBut.Size = new System.Drawing.Size(150, 50);
            this.returnBut.TabIndex = 4;
            this.returnBut.Text = "Retour";
            this.returnBut.UseVisualStyleBackColor = true;
            this.returnBut.Click += new System.EventHandler(this.returnBut_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer.Location = new System.Drawing.Point(179, 344);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(150, 50);
            this.Supprimer.TabIndex = 5;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Importer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.returnBut);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.infosImport);
            this.Controls.Add(this.import);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}