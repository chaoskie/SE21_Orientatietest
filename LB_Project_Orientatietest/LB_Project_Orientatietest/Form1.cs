using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
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
        /// <summary>
        /// voegt nieuwe verhuring toe aan lijst met verhuringen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Voegt nieuwe verkoop van product toe aan lijst van verkopen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Geeft overzicht op omgekeerd chronologisch volgorde van verhuringen tussen specifieke datums
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOverzichtDatumbereik_Click(object sender, EventArgs e)
        {
            List<IInkomsten> returned = ad.Overzicht(dtpOverzichtVan.Value, dtpOverzichtTot.Value);
            decimal totaal = 0;
            List<DateTime> datums = new List<DateTime>();
            if (returned == null)
            {
                MessageBox.Show("Geen transacties gevonden voor deze periode.");
            }
            else
            {
                foreach (IInkomsten ii in returned)
                {
                    totaal += ii.Bedrag;
                    datums.Add(ii.Tijdstip);
                }
                datums.Reverse();
                string visual = string.Empty;
                foreach (DateTime d in datums)
                {
                    visual += string.Format("{0}\n", d.ToString());
                }

                MessageBox.Show(visual + Environment.NewLine + totaal.ToString("C"));
            }
        }
        /// <summary>
        /// exporteert file naar gekozen directory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOverzichtExporteer_Click(object sender, EventArgs e)
        {
            //geef een save file dialog weer
            var sfDiag = new SaveFileDialog();
            sfDiag.Filter = "*.log|*.log";
            if (sfDiag.ShowDialog() == DialogResult.OK)
            {
                //sla het bestand op
                SaveLog(sfDiag.FileName);
            }
        }
        public void SaveLog(string filename)
        {
            //sorteer de lijst
            List<IInkomsten> returned = ad.Overzicht((BTWTarief)cbOverzichtBTW.SelectedValue);

            try
            {
                //maak een stream
                var strm = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                var writer = new StreamWriter(strm);

                foreach (IInkomsten ii in returned)
                {
                    writer.WriteLine(ii.ToString());
                }
                //TODO
                /*
                 *add totaal prijs overzicht. 
                */

                //flush de buffer
                writer.Flush();
                //sluit de writer en stream
                writer.Close();
                writer.Dispose();
                strm.Close();
                strm.Dispose();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                if (FileSaved != null) FileSaved.Invoke(filename, false);
                return;
            }

            //invoke het event
            if (FileSaved != null)
            {
                FileSaved.Invoke(filename, true);
            }
        }

        /// <summary>
        /// Delegate voor als het logboek bestand opgeslagen is
        /// </summary>
        /// <param name="fileName">Het opgelagen bestand</param>
        public delegate void FileSavedDelegate(string fileName, bool succes);
        /// <summary>
        /// Als het logboek bestand opgeslagen is
        /// </summary>
        public event FileSavedDelegate FileSaved; 
    }
}
