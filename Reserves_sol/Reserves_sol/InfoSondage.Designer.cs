namespace Reserves_sol
{
    partial class InfoSondage
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
            this.data_titre = new System.Windows.Forms.TextBox();
            this.data_descr = new System.Windows.Forms.TextBox();
            this.label_titre = new System.Windows.Forms.Label();
            this.label_descr = new System.Windows.Forms.Label();
            this.label_dateDebut = new System.Windows.Forms.Label();
            this.label_dateFin = new System.Windows.Forms.Label();
            this.data_dateDebut = new System.Windows.Forms.TextBox();
            this.data_DateFin = new System.Windows.Forms.TextBox();
            this.data_enCours = new System.Windows.Forms.Label();
            this.End_button = new System.Windows.Forms.Button();
            this.oeuvresDataGridView = new System.Windows.Forms.DataGridView();
            this.label_total_votes = new System.Windows.Forms.Label();
            this.data_TotalVotes = new System.Windows.Forms.TextBox();
            this.select_cb = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.oeuvresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // returnBut
            // 
            this.returnBut.Location = new System.Drawing.Point(680, 526);
            this.returnBut.Name = "returnBut";
            this.returnBut.Size = new System.Drawing.Size(75, 23);
            this.returnBut.TabIndex = 0;
            this.returnBut.Text = "Retour";
            this.returnBut.UseVisualStyleBackColor = true;
            this.returnBut.Click += new System.EventHandler(this.returnBut_Click);
            // 
            // data_titre
            // 
            this.data_titre.Location = new System.Drawing.Point(145, 59);
            this.data_titre.Name = "data_titre";
            this.data_titre.ReadOnly = true;
            this.data_titre.Size = new System.Drawing.Size(544, 20);
            this.data_titre.TabIndex = 2;
            // 
            // data_descr
            // 
            this.data_descr.BackColor = System.Drawing.SystemColors.Control;
            this.data_descr.Location = new System.Drawing.Point(145, 96);
            this.data_descr.Multiline = true;
            this.data_descr.Name = "data_descr";
            this.data_descr.ReadOnly = true;
            this.data_descr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_descr.Size = new System.Drawing.Size(544, 94);
            this.data_descr.TabIndex = 4;
            // 
            // label_titre
            // 
            this.label_titre.AutoSize = true;
            this.label_titre.Location = new System.Drawing.Point(78, 59);
            this.label_titre.Name = "label_titre";
            this.label_titre.Size = new System.Drawing.Size(34, 13);
            this.label_titre.TabIndex = 5;
            this.label_titre.Text = "Titre :";
            // 
            // label_descr
            // 
            this.label_descr.AutoSize = true;
            this.label_descr.Location = new System.Drawing.Point(46, 96);
            this.label_descr.Name = "label_descr";
            this.label_descr.Size = new System.Drawing.Size(66, 13);
            this.label_descr.TabIndex = 6;
            this.label_descr.Text = "Description :";
            // 
            // label_dateDebut
            // 
            this.label_dateDebut.AutoSize = true;
            this.label_dateDebut.Location = new System.Drawing.Point(46, 212);
            this.label_dateDebut.Name = "label_dateDebut";
            this.label_dateDebut.Size = new System.Drawing.Size(66, 13);
            this.label_dateDebut.TabIndex = 7;
            this.label_dateDebut.Text = "Date début :";
            // 
            // label_dateFin
            // 
            this.label_dateFin.AutoSize = true;
            this.label_dateFin.Location = new System.Drawing.Point(325, 212);
            this.label_dateFin.Name = "label_dateFin";
            this.label_dateFin.Size = new System.Drawing.Size(50, 13);
            this.label_dateFin.TabIndex = 8;
            this.label_dateFin.Text = "Date fin :";
            // 
            // data_dateDebut
            // 
            this.data_dateDebut.Location = new System.Drawing.Point(145, 205);
            this.data_dateDebut.Name = "data_dateDebut";
            this.data_dateDebut.ReadOnly = true;
            this.data_dateDebut.Size = new System.Drawing.Size(76, 20);
            this.data_dateDebut.TabIndex = 9;
            // 
            // data_DateFin
            // 
            this.data_DateFin.Location = new System.Drawing.Point(401, 209);
            this.data_DateFin.Name = "data_DateFin";
            this.data_DateFin.ReadOnly = true;
            this.data_DateFin.Size = new System.Drawing.Size(76, 20);
            this.data_DateFin.TabIndex = 10;
            // 
            // data_enCours
            // 
            this.data_enCours.AutoSize = true;
            this.data_enCours.Location = new System.Drawing.Point(325, 18);
            this.data_enCours.Name = "data_enCours";
            this.data_enCours.Size = new System.Drawing.Size(0, 13);
            this.data_enCours.TabIndex = 11;
            // 
            // End_button
            // 
            this.End_button.Location = new System.Drawing.Point(680, 8);
            this.End_button.Name = "End_button";
            this.End_button.Size = new System.Drawing.Size(75, 23);
            this.End_button.TabIndex = 12;
            this.End_button.Text = "Mettre fin";
            this.End_button.UseVisualStyleBackColor = true;
            this.End_button.Click += new System.EventHandler(this.End_button_Click);
            // 
            // oeuvresDataGridView
            // 
            this.oeuvresDataGridView.AllowUserToAddRows = false;
            this.oeuvresDataGridView.AllowUserToDeleteRows = false;
            this.oeuvresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oeuvresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select_cb,
            this.Image,
            this.Titre,
            this.Auteur,
            this.Description});
            this.oeuvresDataGridView.Location = new System.Drawing.Point(12, 284);
            this.oeuvresDataGridView.Name = "oeuvresDataGridView";
            this.oeuvresDataGridView.RowTemplate.Height = 150;
            this.oeuvresDataGridView.Size = new System.Drawing.Size(760, 236);
            this.oeuvresDataGridView.TabIndex = 13;
            // 
            // label_total_votes
            // 
            this.label_total_votes.AutoSize = true;
            this.label_total_votes.Location = new System.Drawing.Point(10, 246);
            this.label_total_votes.Name = "label_total_votes";
            this.label_total_votes.Size = new System.Drawing.Size(102, 13);
            this.label_total_votes.TabIndex = 14;
            this.label_total_votes.Text = "Nombre votes total :";
            // 
            // data_TotalVotes
            // 
            this.data_TotalVotes.Location = new System.Drawing.Point(145, 243);
            this.data_TotalVotes.Name = "data_TotalVotes";
            this.data_TotalVotes.ReadOnly = true;
            this.data_TotalVotes.Size = new System.Drawing.Size(76, 20);
            this.data_TotalVotes.TabIndex = 15;
            // 
            // select_cb
            // 
            this.select_cb.HeaderText = "Sélec.";
            this.select_cb.MinimumWidth = 15;
            this.select_cb.Name = "select_cb";
            this.select_cb.Width = 50;
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
            // InfoSondage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.data_TotalVotes);
            this.Controls.Add(this.label_total_votes);
            this.Controls.Add(this.oeuvresDataGridView);
            this.Controls.Add(this.End_button);
            this.Controls.Add(this.data_enCours);
            this.Controls.Add(this.data_DateFin);
            this.Controls.Add(this.data_dateDebut);
            this.Controls.Add(this.label_dateFin);
            this.Controls.Add(this.label_dateDebut);
            this.Controls.Add(this.label_descr);
            this.Controls.Add(this.label_titre);
            this.Controls.Add(this.data_descr);
            this.Controls.Add(this.data_titre);
            this.Controls.Add(this.returnBut);
            this.Name = "InfoSondage";
            this.Text = "v";
            ((System.ComponentModel.ISupportInitialize)(this.oeuvresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnBut;
        private System.Windows.Forms.TextBox data_titre;
        private System.Windows.Forms.TextBox data_descr;
        private System.Windows.Forms.Label label_titre;
        private System.Windows.Forms.Label label_descr;
        private System.Windows.Forms.Label label_dateDebut;
        private System.Windows.Forms.Label label_dateFin;
        private System.Windows.Forms.TextBox data_dateDebut;
        private System.Windows.Forms.TextBox data_DateFin;
        private System.Windows.Forms.Label data_enCours;
        private System.Windows.Forms.Button End_button;
        private System.Windows.Forms.DataGridView oeuvresDataGridView;
        private System.Windows.Forms.Label label_total_votes;
        private System.Windows.Forms.TextBox data_TotalVotes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select_cb;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}