using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Reserves_sol
{
    public partial class Supprimer : Form
    {
        public mbaEntities db = new mbaEntities();
        public BindingList<oeuvre> data = new BindingList<oeuvre>();

        public Supprimer()
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (var o in db.oeuvre.ToList())
            {
                Image img = LoadImage(o.url_img);
                dataGridView1.Rows.Add(new Bitmap(LoadImage(o.url_img), new Size(200, 150)), o.titre, o.auteur, o.description);
            }
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
            catch
            {

                var outPutDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
                var iconPath = Path.Combine(outPutDirectory, "..\\..\\..\\Datas\\NoImageFound.png");
                string icon_path = new Uri(iconPath).LocalPath;
                Console.WriteLine(" * ****************************************" + icon_path);
                return new Bitmap(icon_path);
            }

        }

        #region Boutons
        private void return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                int columnindex = 1;
                string titreOeuvreAsupprimer = dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString();
                oeuvre oeuvreAsupprimer = db.oeuvre.Where(o => o.titre == titreOeuvreAsupprimer).First();
                db.oeuvre.Remove(oeuvreAsupprimer);
                int res = db.SaveChanges();
                if (res != 0)
                {
                    dataGridView1.Rows.RemoveAt(rowindex);
                    dataGridView1.Refresh();
                }
            }
        }
        #endregion
    }
}
