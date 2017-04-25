namespace Reserves_sol
{
    partial class Supprimer
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.return_btn = new System.Windows.Forms.Button();
            this.ColumnImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAuteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(837, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnImage,
            this.ColumnTitre,
            this.ColumnAuteur,
            this.ColumnDescription});
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 150;
            this.dataGridView1.Size = new System.Drawing.Size(960, 652);
            this.dataGridView1.TabIndex = 2;
            // 
            // return_btn
            // 
            this.return_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.return_btn.Location = new System.Drawing.Point(35, 23);
            this.return_btn.Margin = new System.Windows.Forms.Padding(4);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(75, 25);
            this.return_btn.TabIndex = 3;
            this.return_btn.Text = "Retour";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // ColumnImage
            // 
            this.ColumnImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnImage.HeaderText = "Image";
            this.ColumnImage.MinimumWidth = 200;
            this.ColumnImage.Name = "ColumnImage";
            this.ColumnImage.ReadOnly = true;
            this.ColumnImage.Width = 200;
            // 
            // ColumnTitre
            // 
            this.ColumnTitre.HeaderText = "Titre";
            this.ColumnTitre.MinimumWidth = 50;
            this.ColumnTitre.Name = "ColumnTitre";
            this.ColumnTitre.Width = 250;
            // 
            // ColumnAuteur
            // 
            this.ColumnAuteur.HeaderText = "Auteur";
            this.ColumnAuteur.MinimumWidth = 50;
            this.ColumnAuteur.Name = "ColumnAuteur";
            this.ColumnAuteur.ReadOnly = true;
            this.ColumnAuteur.Width = 200;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDescription.HeaderText = "Description";
            this.ColumnDescription.MinimumWidth = 50;
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.ReadOnly = true;
            // 
            // Supprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Supprimer";
            this.Text = "Supprimer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.DataGridViewImageColumn ColumnImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
    }
}