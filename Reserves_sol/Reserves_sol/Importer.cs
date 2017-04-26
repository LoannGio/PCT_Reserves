using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic.FileIO;
using System.IO;

namespace Reserves_sol
{
    public partial class Importer : Form
    {
        public mbaEntities db = new mbaEntities();

        public Importer()
        {
            InitializeComponent();
            infosImport.Text = "En cliquant sur Importer ci-dessous, veuillez sélectionner un fichier XML ou CSV.\n\n\n\nLa base de données d'oeuvres sera écrasée à partir du contenu de ce fichier.";
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
                    Console.WriteLine("OK - FILENAME: " + filename);
                    //IMPORTE DANS LA BD
                    XmlDocument xmlDoc = new XmlDocument();



                    string content = File.ReadAllText(filename);
                    //escape all invalids characters.
                    content = content.Replace("&", "&amp;");
                    content = content.Replace("'", "&apos;");
                    content = content.Replace("\"", "&quot;");
                    File.WriteAllText(filename, content);

                    try
                    {
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

                        Console.WriteLine("Apresif");
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
                        successLabel.Text = "Importation réussie !";
                    }
                    catch (Exception ex)
                    {
                        errorLabel.Text = "Erreur format XML. Verifiez les balises.";
                    }
                }
                else if (filename.Split('.')[1] == "csv")
                {
                    #region traitement CSV
                    //IMPORTE DANS LA BD
                    List<oeuvre> listeOeuvresAImporter2 = new List<oeuvre>();
                    using (var fs = File.OpenRead(filename))
                    using (var reader = new StreamReader(fs))
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(',');

                            oeuvre nouvelleOeuvre = new oeuvre();
                            nouvelleOeuvre.titre = values[0];
                            nouvelleOeuvre.auteur = values[1];
                            nouvelleOeuvre.description = values[2];
                            nouvelleOeuvre.url_img = values[3];
                            listeOeuvresAImporter2.Add(nouvelleOeuvre);
                        }
                    }
                    listeOeuvresAImporter2.RemoveAt(0);
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
            errorLabel.Text = "";
            successLabel.Text = "";
        }
        #endregion
    }
}

