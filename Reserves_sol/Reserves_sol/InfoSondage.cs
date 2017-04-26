using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;


namespace Reserves_sol
{
    public partial class InfoSondage : Form
    {
        public mbaEntities db = new mbaEntities();
        public sondage my_sondage;
        public Accueil my_acc;

        public InfoSondage()
        {
            InitializeComponent();
        }

        public InfoSondage(string titreSondage, Accueil acc)
        {
            InitializeComponent();
            my_acc = acc;
            label_sondage_expired.Text = "";
            this.Text = titreSondage;
            my_sondage = db.sondage.FirstOrDefault(x => x.titre == titreSondage);

            #region Remplissage des TextBox avec les informations du sondage
            if(my_sondage.en_cours != 0)
            {
                data_enCours.Text = "Ce sondage est en cours.";
                data_enCours.ForeColor = Color.DarkGreen;
            }
            else
            {
                data_enCours.Text = "Ce sondage est terminé.";
                data_enCours.ForeColor = Color.Red;
                End_button.Hide();
            }
            data_titre.Text = my_sondage.titre;
            data_descr.Text = my_sondage.description;
            data_dateDebut.Text = my_sondage.date_debut.ToShortDateString();
            data_DateFin.Text = my_sondage.date_fin.ToShortDateString();

            //Si la date de fin est dépassée est que le sondage est encore en cours
            if (DateTime.Now > my_sondage.date_fin && my_sondage.en_cours != 0) 
                label_sondage_expired.Text = "La date de fin du sondage est passée !";

            int? nbVotesTotal = 0;
            foreach(var o in db.oeuvreparsondage.Where(x => x.sondage_id == my_sondage.id).ToList())
            {
                nbVotesTotal += o.nb_votes;
            }
            data_TotalVotes.Text = nbVotesTotal.ToString();

            #endregion

            #region Remplissage de la DataGridView d'oeuvres
            oeuvresDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            foreach (var o in my_sondage.oeuvreparsondage.ToList().OrderByDescending(x => x.nb_votes))
            {
                int? nbVotes = db.oeuvreparsondage.Where(x => x.sondage_id == my_sondage.id && x.titre == o.titre).First().nb_votes;
                oeuvresDataGridView.Rows.Add(nbVotes, new Bitmap(LoadImage(o.url_img), new Size(200,150)),o.titre,o.auteur,o.description);
            }
            oeuvresDataGridView.Refresh();
            #endregion
        }

        private Image LoadImage(string url)
        {
            try
            {
                System.Net.WebRequest request = System.Net.WebRequest.Create(url);

                System.Net.WebResponse response = request.GetResponse();
                System.IO.Stream responseStream = response.GetResponseStream();

                Bitmap bmp = new Bitmap(responseStream);

                responseStream.Dispose();

                return bmp;
            }
            catch
            {

                var outPutDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
                var iconPath = Path.Combine(outPutDirectory, "..\\..\\..\\Datas\\NoImageFound.png");
                string icon_path = new Uri(iconPath).LocalPath;
                Console.WriteLine(" * ****************************************" + icon_path);
                return new Bitmap(icon_path);
            }

        }

        #region Buttons
        private void returnBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void End_button_Click(object sender, EventArgs e)
        {
            var sond = db.sondage.Where(x => x.id == my_sondage.id).First();
            sond.en_cours = 0;
            db.SaveChanges();
            data_enCours.Text = "Ce sondage est terminé.";
            data_enCours.ForeColor = Color.Red;
            End_button.Hide();
            loadItemsAcc(my_acc.getItemList());
            my_acc.getItemList().Refresh();
        }
        #endregion

        public void loadItemsAcc(ListBox itemList)
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
            itemList.DrawItem += new DrawItemEventHandler(my_acc.itemList_DrawItem);
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "XML-File | *.xml";
            fileDialog.DefaultExt = ".xml";
            fileDialog.FileName = "sondage_export";
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string path = fileDialog.FileName;
                File.Create(path).Dispose();
                using (TextWriter tw = new StreamWriter(path))
                {
                    tw.WriteLine("<SONDAGE>");
                    tw.WriteLine("\t<TITRE>"+ my_sondage.titre + "</TITRE>");
                    tw.WriteLine("\t<DESCRIPTION>" + my_sondage.description + "</DESCRIPTION>");
                    tw.WriteLine("\t<DEBUT>" + my_sondage.date_debut.ToShortDateString() + "</DEBUT>");
                    tw.WriteLine("\t<FIN>" + my_sondage.date_fin.ToShortDateString() + "</FIN>");
                    string etat = "";
                    if (my_sondage.en_cours != 0)
                        etat = "En cours";
                    else
                        etat = "Terminé";
                    tw.WriteLine("\t<ETAT>"+etat+"</ETAT>");

                    tw.WriteLine("\t<OEUVRES>");
                    foreach(var o in my_sondage.oeuvreparsondage.ToList())
                    {
                        tw.WriteLine("\t\t<OEUVRE>");
                        tw.WriteLine("\t\t\t<TITREO>" + o.titre + "</TITREO>");
                        tw.WriteLine("\t\t\t<AUTEUR>" + o.auteur + "</AUTEUR>");
                        tw.WriteLine("\t\t\t<DESCR>" + o.description + "</DESCR>");
                        tw.WriteLine("\t\t\t<URL>" + o.url_img + "</URL>");
                        tw.WriteLine("\t\t\t<NBVOTES>" + o.nb_votes + "</NBVOTES>");
                        tw.WriteLine("\t\t</OEUVRE>");
                    }
                    tw.WriteLine("\t</OEUVRES>");
                    tw.WriteLine("</SONDAGE>");
                    tw.Close();
                }
            }
        }
    }
}
