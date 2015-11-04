using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_Project_Orientatietest
{
    class Frisdrank : Verkoop
    {
        //fields
        public override BTWTarief BTWTarief
        {
            get { return BTWTarief.Laag; }
        }

        public override decimal Prijs
        {
            get { return (decimal)1.20; }
        }

        //constr.
        public Frisdrank(int aantal)
            : base(aantal)
        {
            base.Bedrag = base.Aantal * Prijs; 
        }
        //methods
        public override string ToString()
        {
            decimal totaal = base.Aantal * Prijs;
            return string.Format("{0}: Frisdrank, prijs:{1:C}, BTW %:{2} ", base.ToString(), totaal, BTWTarief);     
        }
    }
}
