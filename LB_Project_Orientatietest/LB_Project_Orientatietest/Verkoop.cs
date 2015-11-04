using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_Project_Orientatietest
{
    public abstract class Verkoop : IInkomsten
    {
        //fields
        public int Aantal { get; set; }
        public decimal Bedrag { get; }
        public DateTime Tijdstip { get; set; }
        public abstract BTWTarief BTWTarief { get; }
        public abstract decimal Prijs { get; }

        //constr.
        public Verkoop(int aantal)
        {
            this.Aantal = aantal;
        }

        //methods
        public override string ToString()
        {
            return "verkoop";
        }

    }
}
