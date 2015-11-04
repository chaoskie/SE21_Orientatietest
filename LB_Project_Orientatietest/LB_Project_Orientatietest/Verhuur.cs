using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_Project_Orientatietest
{
    public abstract class Verhuur : IInkomsten
    {
        //fields
        public int UrenVerhuurd { get; set; }
        public decimal Bedrag { get; set; }
        public DateTime Tijdstip { get; set; }
        public abstract BTWTarief BTWTarief {get;}
        public abstract decimal PrijsPerUur { get; }

        //constr.
        public Verhuur(DateTime tijdstip, int urenVerhuurd)
        {
            this.Tijdstip = tijdstip;
            this.UrenVerhuurd = urenVerhuurd;
            
        }
        //methods
        public override string ToString()
        {
            return Tijdstip.ToString("dd/MM/yyyy");
        }
    }
}
