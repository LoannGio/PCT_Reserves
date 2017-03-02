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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
            

            List<Sondage> db_sondages = new List<Sondage>();
            Sondage son = new Sondage();
            son.titre = "Sondage 1";
            son.description = "Je suis un sondage";
            son.dateDebut = DateTime.Now.Date;
            son.dateFin = DateTime.Now.Date.AddDays(3);
            db_sondages.Add(son);

            Sondage so = new Sondage();
            so.titre = "Sondage 2";
            so.description = "Lorem ipsum dolor sit amet...";
            so.dateDebut = DateTime.Now.Date;
            so.dateFin = DateTime.Now.Date.AddDays(3);
            db_sondages.Add(so);

            Sondage s = new Sondage();
            s.titre = "Sondage 3";
            s.description = "Yet Another Sondage Sondage";
            s.dateDebut = DateTime.Now.Date;
            s.dateFin = DateTime.Now.Date.AddDays(3);
            db_sondages.Add(s);
        }

        private void Create_Click(object sender, EventArgs e)
        {
            var form = new Creer();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void Import_Click(object sender, EventArgs e)
        {
            var form = new Importer();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void itemList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var form = new InfoSondage();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }
    }
}