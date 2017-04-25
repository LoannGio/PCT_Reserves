using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Reserves_sol
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitDataBase();
            Application.Run(new Accueil());
        }

        static void InitDataBase()
        {
            string conString = "metadata=res://*/mba.csdl|res://*/mba.ssdl|res://*/mba.msl;provider=MySql.Data.MySqlClient;provider connection string=\";server=127.0.0.1;user id=root;database=mba\";";

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["mbaEntities"].ConnectionString = conString;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
