namespace Reserves_sol
{
    partial class Creer
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
            this.returnBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // returnBut
            // 
            this.returnBut.Location = new System.Drawing.Point(88, 44);
            this.returnBut.Name = "returnBut";
            this.returnBut.Size = new System.Drawing.Size(75, 23);
            this.returnBut.TabIndex = 0;
            this.returnBut.Text = "Retour";
            this.returnBut.UseVisualStyleBackColor = true;
            this.returnBut.Click += new System.EventHandler(this.returnBut_Click);
            // 
            // Creer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 321);
            this.Controls.Add(this.returnBut);
            this.Name = "Creer";
            this.Text = "Creer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returnBut;
    }
}