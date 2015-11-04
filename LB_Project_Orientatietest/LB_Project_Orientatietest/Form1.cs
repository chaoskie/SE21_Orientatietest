using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB_Project_Orientatietest
{
    public partial class Form1 : Form
    {
        Administratie ad;
        public Form1()
        {
            InitializeComponent();
            ad = new Administratie();
        }

        private void btnNieuweVerhuringToevoegen_Click(object sender, EventArgs e)
        {
            if (cbNieuweVerhuring.Text != string.Empty)
            {
                string verhuurItem = cbNieuweVerhuring.Text;

                switch (verhuurItem)
                {
                    case "Tenniscourt":
                        var x = new Tenniscourt(dtpNieuweVerhuringTijdstip.Value, (int)nudNieuweVerhuringUren.Value);
                        ad.VoegToe(x);
                        goto default;

                    case "Wandelschoenen":
                        var y = new Wandelschoenen(dtpNieuweVerhuringTijdstip.Value, (int)nudNieuweVerhuringUren.Value);
                        ad.VoegToe(y);
                        goto default;

                    case "Feestzaal":
                        var z = new Feestzaal(dtpNieuweVerhuringTijdstip.Value, (int)nudNieuweVerhuringUren.Value);
                        ad.VoegToe(z);
                        goto default;

                    default:
                        lbVerhuringen.Items.Clear();
                        lbVerhuringen.Items.AddRange(ad.verhuringen.ToArray());
                        break;
                }
            }
            else
            {
                MessageBox.Show("Selecteer een verhuur item aub!");
            }

        }

        private void btnNieuweVerkoopToevoegen_Click(object sender, EventArgs e)
        {
            if (cbNieuweVerkoop.Text != string.Empty)
            {
                string verkoopItem = cbNieuweVerkoop.Text;

                switch (verkoopItem)
                {
                    case "Frisdrank":
                        var x = new Frisdrank((int)nudNieuweVerkoopAantal.Value);
                        ad.VoegToe(x);
                        goto default;

                    case "Sterkedrank":
                        var y = new Sterkedrank((int)nudNieuweVerkoopAantal.Value);
                        ad.VoegToe(y);
                        goto default;

                    case "Warmedrank":
                        var z = new Warmedrank((int)nudNieuweVerkoopAantal.Value);
                        ad.VoegToe(z);
                        goto default;

                    default:
                        lbVerkopen.Items.Clear();
                        lbVerkopen.Items.AddRange(ad.verkopen.ToArray());
                        break;
                }
            }
            else
            {
                MessageBox.Show("Selecteer een koopwaar aub!");
            }
        }
    }
}
