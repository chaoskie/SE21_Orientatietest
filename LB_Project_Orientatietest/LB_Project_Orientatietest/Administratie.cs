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

        public List<IInkomsten> Overzicht(DateTime van, DateTime tot)
        {
            List<Verhuur> sortedList = verhuringen;
            sortedList.Sort((x, y) => x.Tijdstip.CompareTo(y.Tijdstip));
            sortedList.Reverse();
            List<IInkomsten> LijstVanTot = new List<IInkomsten>();
            foreach (Verhuur v in sortedList)
            {
                if ((v.Tijdstip < tot) && (van < v.Tijdstip))
                {
                    LijstVanTot.Add((IInkomsten)v);
                }
            }
            return LijstVanTot;
        }
        public List<IInkomsten> Overzicht(BTWTarief tarief)
        {
            List<IInkomsten> LijstTarieven = new List<IInkomsten>();
            List<Verkoop> sortedList = verkopen;

            switch (tarief)
            {
                case BTWTarief.Ongespecificeerd:
                    sortedList.Sort((x, y) => x.Tijdstip.CompareTo(y.Tijdstip));
                    sortedList.Reverse();
                    foreach (Verkoop v in sortedList)
                    {
                        LijstTarieven.Add((IInkomsten)v);
                    }
                    goto default;
                case BTWTarief.Laag:
                    sortedList.Sort((x, y) => x.Tijdstip.CompareTo(y.Tijdstip));
                    sortedList.Reverse();
                    foreach (Verkoop v in sortedList)
                    {
                        if (v.BTWTarief == BTWTarief.Laag)
                            LijstTarieven.Add((IInkomsten)v);
                    }
                    goto default;
                case BTWTarief.Hoog:
                    sortedList.Sort((x, y) => x.Tijdstip.CompareTo(y.Tijdstip));
                    sortedList.Reverse();
                    foreach (Verkoop v in sortedList)
                    {
                        if (v.BTWTarief == BTWTarief.Hoog)
                            LijstTarieven.Add((IInkomsten)v);
                    }
                    goto default;
                default:
                    return LijstTarieven;
            }
        }
    }
}
