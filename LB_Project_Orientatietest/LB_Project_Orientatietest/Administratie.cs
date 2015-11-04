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
        public List<Verkoop> verkopen;
        public List<Verhuur> verhuringen;
        //constr.
        public Administratie()
        {
            this.verhuringen = new List<Verhuur>();
            this.verkopen = new List<Verkoop>();
        }
        //methods
        public void VoegToe(Verhuur verhuur)
        {
            bool found = false;
            foreach (Verhuur v in verhuringen)
            {
                if (verhuur == v)
                {
                    found = true;
                }
            }
            if (found)
            {
                System.Windows.Forms.MessageBox.Show("Deze verhuring is identiek aan een bestaande vehuring.");
            }
            else
            {
                verhuringen.Add(verhuur);
            }
        }
        public void VoegToe(Verkoop verkoop)
        {
            verkopen.Add(verkoop);
        }
    }
}
