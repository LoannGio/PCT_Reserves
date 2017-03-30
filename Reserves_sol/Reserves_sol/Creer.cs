using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Reserves_sol
{
    public partial class Creer : Form
    {
        public mbaEntities db = new mbaEntities();

        public Creer()
        {
            InitializeComponent();

            data_selecNumber.Text = "0";
            data_dateDebut.MinDate = DateTime.Now;
            data_DateFin.MinDate = DateTime.Now.AddDays(1);

            #region Remplissage de la DataGridView d'oeuvres
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
                    //var o_ref = (DataGridViewTextBoxCell)oeuvresDataGridView.Rows[i].Cells["Title"].Value..
                }
            }
            
            foreach(var o in listeOeuvres)
            {
                db.oeuvreparsondage.Add(o);
            }
            db.SaveChanges();
            #endregion


        }
        #endregion
    }
}
