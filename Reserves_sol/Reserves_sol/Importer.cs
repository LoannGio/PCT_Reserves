using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reserves_sol
{
    public partial class Importer : Form
    {
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
                    errorLabel.Text = "Veuillez sélectionner un fichier .xml";
                }
                else
                {
                    Console.WriteLine("OK - FILENAME: " + filename);
                    //IMPORTE DANS LA BD
                }
            }
        }

        private void returnBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

