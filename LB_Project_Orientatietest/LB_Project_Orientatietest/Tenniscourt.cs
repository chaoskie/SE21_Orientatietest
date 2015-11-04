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
        public abstract readonly BTWTarief BTWTarief = BTWTarief.Laag;
        public decimal PrijsPerUur { get; }

        //constr.
        public Tenniscourt(DateTime tijdstip, int urenVerhuurd)
            : base(tijdstip, urenVerhuurd)
        {

        }

        //methods
        public override string ToString()
        {
            return string.Format("{0}: Tenniscourt, p/u {1:c}, BTW percentage:{2} ", base.ToString(), PrijsPerUur, BTWTarief);            
        }
    }
}
