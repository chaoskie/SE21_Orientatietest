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
        public abstract readonly BTWTarief BTWTarief = BTWTarief.Hoog;

        public decimal Prijs { get; }

        //constr.
        public Sterkedrank(int aantal)
            : base(aantal)
        {

        }
        //methods
        public override string ToString()
        {
            return string.Format("{0}: Sterkedrank, prijs:{1:c}, BTW percentage:{2} ", base.ToString(), Prijs, BTWTarief);      
        }
    }
}
