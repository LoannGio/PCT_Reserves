using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Reserves_sol
{
    public partial class Importer : Form
    {
        public mbaEntities db = new mbaEntities();
        public Importer()
        {
            InitializeComponent();
            infosImport.Text = "En cliquant sur Importer ci-dessous, veuillez\nsélectionner un fichier XML.\n\nLa base de données d'oeuvres sera rechargée\nà partir du contenu de ce fichier.";
            infosImport.AutoSize = true;
            errorLabel.Text = "";
            errorLabel.AutoSize = true;
        }

        private void import_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string filename = fileDialog.FileName;
                if (filename.Split('.')[1] != "xml")
                {
                    Console.WriteLine("ERROR - FILE IS NOT XML: "+filename);
                    //AFFICHE MESSAGE ERREUR

                    errorLabel.Text = "Veuillez sélectionner un fichier .xml !";
                }
                else
                {
                    Console.WriteLine("OK - FILENAME: " + filename);
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

                    foreach(oeuvre o in db.oeuvre.ToList())
                    {
                        db.oeuvre.Remove(o);
                    }

                    foreach (oeuvre o in listeOeuvresAImporter)
                    {
                        db.oeuvre.Add(o);
                    }
                    db.SaveChanges();
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
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }
    }
}

