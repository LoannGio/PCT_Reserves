using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic.FileIO;

namespace Reserves_sol
{
    public partial class Importer : Form
    {
        public mbaEntities db = new mbaEntities();

        public Importer()
        {
            InitializeComponent();
            infosImport.Text = "En cliquant sur Importer ci-dessous, veuillez sélectionner un fichier XML.\n\n\n\nLa base de données d'oeuvres sera rechargée à partir du contenu de ce fichier.";
            infosImport.AutoSize = true;
            errorLabel.Text = "";
            successLabel.Text = "";
            errorLabel.AutoSize = true;
        }

        #region Boutons
        private void import_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string filename = fileDialog.FileName;
                if (filename.Split('.')[1] == "xml")
                {
                    #region traitement XML
                    //IMPORTE DANS LA BD
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(filename);

                    List<oeuvre> listeOeuvresAImporter = new List<oeuvre>();

                    // Get elements
                    XmlNodeList oeuvreNodes = xmlDoc.GetElementsByTagName("OEUVRE");
                    XmlNodeList titre = xmlDoc.GetElementsByTagName("titre");
                    XmlNodeList auteur = xmlDoc.GetElementsByTagName("auteur");
                    XmlNodeList description = xmlDoc.GetElementsByTagName("description");
                    XmlNodeList url_img = xmlDoc.GetElementsByTagName("url_img");

                    for (int i = 0; i < oeuvreNodes.Count; i++)
                    {
                        oeuvre nouvelleOeuvre = new oeuvre();
                        nouvelleOeuvre.titre = titre[i].InnerText;
                        nouvelleOeuvre.auteur = auteur[i].InnerText;
                        nouvelleOeuvre.description = description[i].InnerText;
                        nouvelleOeuvre.url_img = url_img[i].InnerText;

                        listeOeuvresAImporter.Add(nouvelleOeuvre);
                    }
                    //Supprime les anciennes oeuvres
                    foreach (oeuvre o in db.oeuvre.ToList())
                    {
                        db.oeuvre.Remove(o);
                    }
                    //Ajoute les nouvelles oeuvres
                    foreach (oeuvre o in listeOeuvresAImporter)
                    {
                        db.oeuvre.Add(o);
                    }
                    db.SaveChanges();
                    successLabel.Text = "Import réussi.";
                    #endregion
                }
                else if (filename.Split('.')[1] == "csv")
                {
                    #region traitement CSV
                    //IMPORTE DANS LA BD
                    using (TextFieldParser parser = new TextFieldParser(filename))
                    {
                        List<oeuvre> listeOeuvresAImporter2 = new List<oeuvre>();
                        parser.TextFieldType = FieldType.Delimited;
                        parser.SetDelimiters(",");
                        while (!parser.EndOfData)
                        {
                            //Pour chaque ligne du csv on recupere les infos
                            string[] fields = parser.ReadFields();
                            oeuvre nouvelleOeuvre = new oeuvre();
                            nouvelleOeuvre.titre = fields[0];
                            nouvelleOeuvre.auteur = fields[1];
                            nouvelleOeuvre.description = fields[2];
                            nouvelleOeuvre.url_img = fields[3];
                            listeOeuvresAImporter2.Add(nouvelleOeuvre);
                        }
                        //Supprime les anciennes oeuvres
                        foreach (oeuvre o in db.oeuvre.ToList())
                        {
                            db.oeuvre.Remove(o);
                        }
                        //Ajoute les nouvelles oeuvres
                        foreach (oeuvre o in listeOeuvresAImporter2)
                        {
                            db.oeuvre.Add(o);
                        }
                        db.SaveChanges();
                    }
                    successLabel.Text = "Import réussi.";
                    #endregion
                }
                else
                {
                    errorLabel.Text = "Veuillez sélectionner un fichier .xml !";
                }
            }
        }

        private void returnBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            var form = new Supprimer();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }
        #endregion
    }
}

