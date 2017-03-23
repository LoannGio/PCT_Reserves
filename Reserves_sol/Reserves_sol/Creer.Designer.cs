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
            this.label_title = new System.Windows.Forms.Label();
            this.label_descr = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.data_descr = new System.Windows.Forms.TextBox();
            this.label_dateDebut = new System.Windows.Forms.Label();
            this.label_dateFin = new System.Windows.Forms.Label();
            this.data_dateDebut = new System.Windows.Forms.DateTimePicker();
            this.data_DateFin = new System.Windows.Forms.DateTimePicker();
            this.label_askSelect = new System.Windows.Forms.Label();
            this.oeuvresDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_create = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.oeuvresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // returnBut
            // 
            this.returnBut.Location = new System.Drawing.Point(663, 526);
            this.returnBut.Name = "returnBut";
            this.returnBut.Size = new System.Drawing.Size(75, 23);
            this.returnBut.TabIndex = 0;
            this.returnBut.Text = "Retour";
            this.returnBut.UseVisualStyleBackColor = true;
            this.returnBut.Click += new System.EventHandler(this.returnBut_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(35, 25);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(93, 13);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Titre du sondage :";
            // 
            // label_descr
            // 
            this.label_descr.AutoSize = true;
            this.label_descr.Location = new System.Drawing.Point(62, 68);
            this.label_descr.Name = "label_descr";
            this.label_descr.Size = new System.Drawing.Size(66, 13);
            this.label_descr.TabIndex = 2;
            this.label_descr.Text = "Description :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(544, 20);
            this.textBox1.TabIndex = 3;
            // 
            // data_descr
            // 
            this.data_descr.BackColor = System.Drawing.SystemColors.Control;
            this.data_descr.Location = new System.Drawing.Point(150, 77);
            this.data_descr.Multiline = true;
            this.data_descr.Name = "data_descr";
            this.data_descr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_descr.Size = new System.Drawing.Size(544, 94);
            this.data_descr.TabIndex = 5;
            // 
            // label_dateDebut
            // 
            this.label_dateDebut.AutoSize = true;
            this.label_dateDebut.Location = new System.Drawing.Point(62, 202);
            this.label_dateDebut.Name = "label_dateDebut";
            this.label_dateDebut.Size = new System.Drawing.Size(66, 13);
            this.label_dateDebut.TabIndex = 8;
            this.label_dateDebut.Text = "Date début :";
            // 
            // label_dateFin
            // 
            this.label_dateFin.AutoSize = true;
            this.label_dateFin.Location = new System.Drawing.Point(418, 202);
            this.label_dateFin.Name = "label_dateFin";
            this.label_dateFin.Size = new System.Drawing.Size(50, 13);
            this.label_dateFin.TabIndex = 11;
            this.label_dateFin.Text = "Date fin :";
            // 
            // data_dateDebut
            // 
            this.data_dateDebut.Location = new System.Drawing.Point(150, 199);
            this.data_dateDebut.Name = "data_dateDebut";
            this.data_dateDebut.Size = new System.Drawing.Size(189, 20);
            this.data_dateDebut.TabIndex = 13;
            // 
            // data_DateFin
            // 
            this.data_DateFin.Location = new System.Drawing.Point(505, 199);
            this.data_DateFin.Name = "data_DateFin";
            this.data_DateFin.Size = new System.Drawing.Size(189, 20);
            this.data_DateFin.TabIndex = 14;
            // 
            // label_askSelect
            // 
            this.label_askSelect.AutoSize = true;
            this.label_askSelect.Location = new System.Drawing.Point(62, 238);
            this.label_askSelect.Name = "label_askSelect";
            this.label_askSelect.Size = new System.Drawing.Size(165, 13);
            this.label_askSelect.TabIndex = 15;
            this.label_askSelect.Text = "Sélectionnez une liste d\'oeuvres :";
            // 
            // oeuvresDataGridView
            // 
            this.oeuvresDataGridView.AllowUserToAddRows = false;
            this.oeuvresDataGridView.AllowUserToDeleteRows = false;
            this.oeuvresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oeuvresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Image,
            this.Titre,
            this.Auteur,
            this.Description});
            this.oeuvresDataGridView.Location = new System.Drawing.Point(12, 266);
            this.oeuvresDataGridView.Name = "oeuvresDataGridView";
            this.oeuvresDataGridView.RowTemplate.Height = 150;
            this.oeuvresDataGridView.Size = new System.Drawing.Size(760, 236);
            this.oeuvresDataGridView.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Votes";
            this.Column1.MinimumWidth = 20;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Image.HeaderText = "Image";
            this.Image.MinimumWidth = 200;
            this.Image.Name = "Image";
            this.Image.Width = 200;
            // 
            // Titre
            // 
            this.Titre.HeaderText = "Titre";
            this.Titre.MinimumWidth = 100;
            this.Titre.Name = "Titre";
            this.Titre.ReadOnly = true;
            this.Titre.Width = 200;
            // 
            // Auteur
            // 
            this.Auteur.HeaderText = "Auteur";
            this.Auteur.MinimumWidth = 100;
            this.Auteur.Name = "Auteur";
            this.Auteur.ReadOnly = true;
            this.Auteur.Width = 150;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 100;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // but_create
            // 
            this.but_create.Location = new System.Drawing.Point(357, 526);
            this.but_create.Name = "but_create";
            this.but_create.Size = new System.Drawing.Size(75, 23);
            this.but_create.TabIndex = 17;
            this.but_create.Text = "Créer";
            this.but_create.UseVisualStyleBackColor = true;
            // 
            // Creer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.but_create);
            this.Controls.Add(this.oeuvresDataGridView);
            this.Controls.Add(this.label_askSelect);
            this.Controls.Add(this.data_DateFin);
            this.Controls.Add(this.data_dateDebut);
            this.Controls.Add(this.label_dateFin);
            this.Controls.Add(this.label_dateDebut);
            this.Controls.Add(this.data_descr);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_descr);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.returnBut);
            this.Name = "Creer";
            this.Text = "Creer";
            ((System.ComponentModel.ISupportInitialize)(this.oeuvresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnBut;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_descr;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox data_descr;
        private System.Windows.Forms.Label label_dateDebut;
        private System.Windows.Forms.Label label_dateFin;
        private System.Windows.Forms.DateTimePicker data_dateDebut;
        private System.Windows.Forms.DateTimePicker data_DateFin;
        private System.Windows.Forms.Label label_askSelect;
        private System.Windows.Forms.DataGridView oeuvresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Button but_create;
    }
}