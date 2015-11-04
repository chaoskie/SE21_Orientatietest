using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_Project_Orientatietest
{
    class Feestzaal : Verhuur
    {
        //fields
        public override BTWTarief BTWTarief
        {
            get { return BTWTarief.Hoog; }
        }

        public override decimal PrijsPerUur
        {
            get { return (decimal)75.00; }
        }

        //constr.
        public Feestzaal(DateTime tijdstip, int urenVerhuurd)
            : base(tijdstip, urenVerhuurd)
        {

        }

        //methods
        public override string ToString()
        {
            decimal totaal = base.UrenVerhuurd * PrijsPerUur;
            return string.Format("{0}: Feestzaal, Totaal:{1:C}, BTW %:{2} ", base.ToString(), totaal, BTWTarief);      
        }
    }
}
