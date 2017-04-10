using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Reserves_sol
{
    public partial class InfoSondage : Form
    {
        public mbaEntities db = new mbaEntities();
        public sondage my_sondage;

        public InfoSondage()
        {
            InitializeComponent();
        }

        public InfoSondage(string titreSondage)
        {
            InitializeComponent();
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
                System.Net.WebRequest request =
                System.Net.WebRequest.Create(url);

                System.Net.WebResponse response = request.GetResponse();
                System.IO.Stream responseStream =
                    response.GetResponseStream();

                Bitmap bmp = new Bitmap(responseStream);

                responseStream.Dispose();

                return bmp;
            }
            catch (System.Net.WebException we)
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
        }
        #endregion
    }
}
