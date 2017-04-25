using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Reserves_sol
{
    public partial class Creer : Form
    {
        public mbaEntities db = new mbaEntities();

        public Accueil formAccueil;

        public Creer(Accueil acc)
        {
            InitializeComponent();
            formAccueil = acc;

            data_selecNumber.Text = "0";
            data_dateDebut.MinDate = DateTime.Now;
            data_DateFin.MinDate = DateTime.Now.AddDays(1);

            #region Remplissage de la DataGridView d'oeuvres
            oeuvresDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            foreach (var o in db.oeuvre.ToList())
            {
                oeuvresDataGridView.Rows.Add(null, new Bitmap(LoadImage(o.url_img), new Size(200, 150)), o.titre, o.auteur, o.description);
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
                return new Bitmap(icon_path);
            }

        }

        private void oeuvresDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            senderGrid.EndEdit();

            int formerCheckedNumber = Int32.Parse(data_selecNumber.Text);
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {

                var cbxCell = (DataGridViewCheckBoxCell)senderGrid.Rows[e.RowIndex].Cells["select_cb"];
                if ((string)cbxCell.Value == "True")
                {
                    formerCheckedNumber++;
                }
                else
                {
                    formerCheckedNumber--;
                }
            }
            data_selecNumber.Text = formerCheckedNumber.ToString();
        }

        #region Buttons
        private void returnBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_create_Click(object sender, EventArgs e)
        {
            //renvoyer message erreur si titre déja utilisé ?
            //tester si les textboxes sont vides ?
            #region Test des erreurs
            if (string.IsNullOrWhiteSpace(data_title.Text))
            {
                MessageBox.Show("Veuillez donner un titre à votre sondage", "Error");
                return;
            }
            else if(Int32.Parse(data_selecNumber.Text) < 2)
            {
                MessageBox.Show("Veuillez sélectionner au moins deux oeuvres", "Error");
                return;
            }

            #endregion

            string sondageTitre = data_title.Text;

            #region Création sondage
            sondage new_sond = new sondage();
            new_sond.titre = data_title.Text;
            new_sond.description = data_descr.Text;

            new_sond.date_debut = data_dateDebut.Value;
            new_sond.date_fin = data_DateFin.Value;

            new_sond.en_cours = 1;

            db.sondage.Add(new_sond);
            db.SaveChanges();
            #endregion

            #region Création oeuvresparsondages du sondage
            int id_newSondage = db.sondage.Where(x => x.titre == sondageTitre).First().id;
            int maxRows = db.oeuvre.Count();
            List<oeuvreparsondage> listeOeuvres = new List<oeuvreparsondage>();
            for(int i = 0; i < maxRows; i++)
            {
                var cbxCell = (DataGridViewCheckBoxCell)oeuvresDataGridView.Rows[i].Cells["select_cb"];
                if ((string)cbxCell.Value == "True")
                {
                    oeuvreparsondage ops = new oeuvreparsondage();
                    var titre_o_ref = (string)((DataGridViewTextBoxCell)(oeuvresDataGridView.Rows[i].Cells["Titre"])).Value;
                    var o_ref = db.oeuvre.Where(x => x.titre == titre_o_ref).First();

                    ops.nb_votes = 0;
                    ops.sondage = db.sondage.Where(x => x.id == id_newSondage).First();
                    ops.auteur = o_ref.auteur;
                    ops.description = o_ref.description;
                    ops.titre = o_ref.titre;
                    ops.url_img = o_ref.url_img;
                    ops.sondage_id = id_newSondage;

                    listeOeuvres.Add(ops);                   
                }
            }
            
            foreach(var o in listeOeuvres)
            {
                db.oeuvreparsondage.Add(o);
            }
            db.SaveChanges();
            #endregion

            //rediriger vers l'accueil
            formAccueil.loadItems();
            this.Close();
        }
        #endregion

        private void data_dateDebut_ValueChanged(object sender, EventArgs e)
        {
            data_DateFin.MinDate = data_dateDebut.Value.AddDays(1);
            if(data_dateDebut.Value >= data_DateFin.Value)
                data_DateFin.Value = data_dateDebut.Value.AddDays(1);
        }
    }
}
