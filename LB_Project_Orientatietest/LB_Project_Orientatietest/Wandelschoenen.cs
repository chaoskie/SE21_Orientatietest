using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_Project_Orientatietest
{
    class Wandelschoenen : Verhuur
    {
        //fields
     
        public override BTWTarief BTWTarief
        {
            get { return BTWTarief.Laag; }
        }

        public override decimal PrijsPerUur 
        {
            get { return (decimal)10.00; } 
        }

        //constr.
        public Wandelschoenen(DateTime tijdstip, int urenVerhuurd)
            : base(tijdstip, urenVerhuurd)
        {
            base.Bedrag = base.UrenVerhuurd * PrijsPerUur;
        }

        //methods

        public override string ToString()
        {
            decimal totaal = base.UrenVerhuurd * PrijsPerUur;
            return string.Format("{0}: Wandelschoenen, Totaal:{1:C}, BTW %:{2} ", base.ToString(), totaal, BTWTarief);
        }
    }
}
