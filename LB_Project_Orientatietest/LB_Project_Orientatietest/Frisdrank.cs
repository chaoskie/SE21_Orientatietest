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
        public abstract readonly BTWTarief BTWTarief = BTWTarief.Laag;

        public decimal Prijs { get; }

        //constr.
        public Frisdrank(int aantal)
            : base(aantal)
        {

        }
        //methods
        public override string ToString()
        {
            return string.Format("{0}: Frisdrank, prijs:{1:c}, BTW percentage:{2} ", base.ToString(), Prijs, BTWTarief);      
        }
    }
}
