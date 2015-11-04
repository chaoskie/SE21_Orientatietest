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
        public abstract readonly BTWTarief BTWTarief = BTWTarief.Hoog;
        public decimal PrijsPerUur { get; }

        //constr.
        public Feestzaal(DateTime tijdstip, int urenVerhuurd)
            : base(tijdstip, urenVerhuurd)
        {

        }

        //methods
        public override string ToString()
        {
            return string.Format("{0}: Feestzaal, p/u {1:c}, BTW percentage:{2} ", base.ToString(), PrijsPerUur, BTWTarief);      
        }
    }
}
