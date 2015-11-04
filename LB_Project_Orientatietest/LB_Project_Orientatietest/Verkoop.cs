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
        public decimal Bedrag { get; private set; }
        public DateTime Tijdstip { get; set; }
        public abstract BTWTarief BTWTarief { get; }
        public abstract decimal Prijs { get; }

        //constr.
        public Verkoop(int aantal)
        {
            this.Aantal = aantal;
            Tijdstip = DateTime.Now;
        }

        //methods
        public override string ToString()
        {
            return string.Format("{0}| {1} stuks",this.Tijdstip.ToString("dd/MM/yyyy"), this.Aantal);
        }

    }
}
