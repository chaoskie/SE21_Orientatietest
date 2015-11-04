using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_Project_Orientatietest
{
    class Administratie
    {
        //fields
        List<Verkoop> verkopen;
        List<Verhuur> verhuringen;
        //constr.
        public Administratie()
        {
            this.verhuringen = new List<Verhuur>();
            this.verkopen = new List<Verkoop>();
        }
        //methods
        public void VoegToe(Verhuur verhuur)
        {
            //todo
        }
        public void VoegToe(Verkoop verkoop)
        {
            //todo
        }
    }
}
