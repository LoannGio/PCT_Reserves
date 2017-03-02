using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserves_sol
{
    public class OeuvreSondage
    {
        public string titre;
        public string auteur;
        public string description;
        public string url_image;
        public int nbVotes;
    }

    public class Sondage
    {
        public string titre;
        public string description;
        public DateTime dateDebut;
        public DateTime dateFin;
        public List<OeuvreSondage> l_OeuvresSondages;
    }
}
