//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Reserves_sol
{
    using System;
    using System.Collections.Generic;
    
    public partial class oeuvreparsondage
    {
        public int id { get; set; }
        public string titre { get; set; }
        public string auteur { get; set; }
        public string description { get; set; }
        public string url_img { get; set; }
        public int sondage_id { get; set; }
        public Nullable<int> nb_votes { get; set; }
    
        public virtual sondage sondage { get; set; }
    }
}
