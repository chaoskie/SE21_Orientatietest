using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_Project_Orientatietest
{
    public class Sterkedrank : Verkoop
    {
        //fields
        public override BTWTarief BTWTarief
        {
            get { return BTWTarief.Hoog; }
        }

        public override decimal Prijs
        {
            get { return (decimal)3.20; }
        }

        //constr.
        public Sterkedrank(int aantal)
            : base(aantal)
        {
            base.Bedrag = base.Aantal * Prijs; 
        }
        //methods
        public override string ToString()
        {
            decimal totaal = base.Aantal * Prijs;
            return string.Format("{0}: Sterkedrank, prijs:{1:C}, BTW %:{2} ", base.ToString(), totaal, BTWTarief);   
        }
    }
}
