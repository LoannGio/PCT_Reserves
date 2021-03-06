﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Reserves_sol
{
    public partial class Accueil : Form
    {
        public mbaEntities db = new mbaEntities();

        public Accueil()
        {
            InitializeComponent();

            loadItems();
        }

        public void itemList_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Define the default color of the brush as black.
            Brush myBrush = Brushes.Black;

            // Draw the current item text based on the current Font 
            // and the custom brush settings.
            e.Graphics.DrawString(itemList.Items[e.Index].ToString(),
                e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }


        #region Boutons
        private void Create_Click(object sender, EventArgs e)
        {
            var form = new Creer(this);
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void Import_Click(object sender, EventArgs e)
        {
            var form = new Importer();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }
        #endregion

        #region Liste d'items (sondages)
        private void itemList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (itemList.SelectedItem != null)
            {
                string infoSondage = itemList.SelectedItem.ToString();
                string titreSondage = infoSondage.Split(':')[1].Split('\n')[0];
                titreSondage = titreSondage.Substring(1);
                var form = new InfoSondage(titreSondage, this);
                form.Location = this.Location;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.FormClosing += delegate { this.Show(); };
                form.Show();
                this.Hide();
            }
        }

        public void loadItems()
        {
            List<string> items = new List<string>();
            #region Chargement de la liste de sondages
            foreach (var sondage in db.sondage.ToList().OrderByDescending(x => x.en_cours))
            {
                string str_add = "";
                if (sondage.en_cours != 0)
                    str_add += "En cours : ";
                else
                    str_add += "Terminé : ";
                str_add += sondage.titre + "\n                 ";
                str_add += "Début : " + sondage.date_debut.ToShortDateString() + " - ";
                str_add += "Fin : " + sondage.date_fin.ToShortDateString();
                items.Add(str_add);
            }
            #endregion
            itemList.DataSource = items;
            itemList.DrawItem += new DrawItemEventHandler(itemList_DrawItem);
        }


        public ListBox getItemList()
        {
            return itemList;
        }

        private void itemList_MouseClick(object sender, MouseEventArgs e)
        {

        }
        #endregion
    }
}