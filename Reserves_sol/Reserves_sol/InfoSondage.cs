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
            #endregion

            #region Remplissage de la DataGridView d'oeuvres
            foreach (var o in my_sondage.oeuvreparsondage.ToList())
            {
                oeuvresDataGridView.Rows.Add(new Bitmap(LoadImage(o.url_img), new Size(200,150)),o.titre,o.auteur,o.description);
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
            catch(System.Net.WebException we)
            {

                return new Bitmap("~/Datas/NoImageFound.png");
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
