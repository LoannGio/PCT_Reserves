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
        public InfoSondage()
        {
            InitializeComponent();
            //Initialiser le nom du Form au titre du sondage sélectionné ? (aux X premiers carac du titre)
        }

        private void returnBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
