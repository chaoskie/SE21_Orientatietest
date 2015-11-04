using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_Project_Orientatietest
{
    public interface IInkomsten
    {
        Decimal Bedrag { get; }
        BTWTarief BTWTarief { get; }
        DateTime Tijdstip { get; }
    }
}
