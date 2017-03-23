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
            #region Remplissage de la DataGridView d'oeuvres
            foreach (var o in db.oeuvre.ToList())
            {
                oeuvresDataGridView.Rows.Add(new Bitmap(LoadImage(o.url_img), new Size(200, 150)), o.titre, o.auteur, o.description);
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

        private void returnBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
