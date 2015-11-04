using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_Project_Orientatietest
{
    public interface IInkomsten
    {
        public Decimal Bedrag { get; }
        public BTWTarief BTWTarief { get; }
        public DateTime Tijdstip { get; }
    }
}
