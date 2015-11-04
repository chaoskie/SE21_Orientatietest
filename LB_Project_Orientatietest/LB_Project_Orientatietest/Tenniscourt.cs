using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_Project_Orientatietest
{
    class Tenniscourt : Verhuur
    {
        //fields
        public override BTWTarief BTWTarief
        {
            get { return BTWTarief.Laag; }
        }

        public override decimal PrijsPerUur
        {
            get { return (decimal)35.00; }
        }

        //constr.
        public Tenniscourt(DateTime tijdstip, int urenVerhuurd)
            : base(tijdstip, urenVerhuurd)
        {
            base.Bedrag = base.UrenVerhuurd * PrijsPerUur;
        }

        //methods
        public override string ToString()
        {
            decimal totaal = base.UrenVerhuurd * PrijsPerUur;
            return string.Format("{0}: Tenniscourt, Totaal:{1:C}, BTW %:{2} ", base.ToString(), totaal, BTWTarief);
        }
    }
}
