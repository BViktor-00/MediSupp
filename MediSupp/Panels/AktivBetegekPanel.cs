using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace MediSupp.Panels
{

   
    public partial class AktivBetegekPanel : UserControl
    {
        DoctorData doctorData = new DoctorData();

        public void AktivBetegAdatModositas()
        {
            AktivBetegAdatFelvetel AktivBetegWindow = new AktivBetegAdatFelvetel();
            string BetegTajSzam = Convert.ToString(AktivBetegDataGrid.SelectedCells[0].Value);
            string OrvosPecsetszam = "";

            for (int i = 0; i < BetegFuggvenyek.BetegAdatLista.Count; i++)
            {
                if(BetegFuggvenyek.BetegAdatLista[i].betegtajszam == BetegTajSzam)
                {
                    OrvosPecsetszam = BetegFuggvenyek.BetegAdatLista[i].kezeloorvos;
                }
            }

            MessageBox.Show($"{BetegTajSzam},{OrvosPecsetszam}");

            AktivBetegWindow.Show();
            try
            {
                for (int i = 0; i < BetegFuggvenyek.BetegAdatLista.Count; i++)
                {
                    if (BetegFuggvenyek.BetegAdatLista[i].betegtajszam == BetegTajSzam)
                    {
                        AktivBetegWindow.AktivBetegNeve_lb.Text = BetegFuggvenyek.BetegAdatLista[i].betegneve;
                        AktivBetegWindow.AktivBetegSzulHely_lb.Text = BetegFuggvenyek.BetegAdatLista[i].betegszulhely;
                        AktivBetegWindow.AktivBetegSzulIdo_lb.Text = BetegFuggvenyek.BetegAdatLista[i].betegszulido;
                        AktivBetegWindow.AktivBetegTajszam_lb.Text = BetegFuggvenyek.BetegAdatLista[i].betegtajszam;
                        AktivBetegWindow.AktivBetegInformacio_txb.Text = BetegFuggvenyek.BetegAdatLista[i].beteginfo;
                        
                    }                                                                    

                }

                for (int i = 0; i < BetegFuggvenyek.AktivBetegSegedLista.Count; i++)
                {
                    if (BetegFuggvenyek.AktivBetegSegedLista[i].aktivbetegtajszam == BetegTajSzam)
                    {
                        AktivBetegWindow.AktivBetegPanasza_txb.Text = BetegFuggvenyek.AktivBetegSegedLista[i].betegpanasza;
                        AktivBetegWindow.AktivBetegKezeles_txb.Text = BetegFuggvenyek.AktivBetegSegedLista[i].kezeles;
                        AktivBetegWindow.FelvetelIdopontja_dt.Text = BetegFuggvenyek.AktivBetegSegedLista[i].aktivbetegfelvetelido;
                        AktivBetegWindow.ElbocsajtasIdopontja_dt.Text = "";
                    }

                }

                for (int i = 0; i < doctorData.doctorsList.Count; i++)
                {
                    if (doctorData.doctorsList[i].orvospecset == OrvosPecsetszam)
                    {
                        AktivBetegWindow.KezeloOrvos_cbx.Text = doctorData.doctorsList[i].nev;
                    }

                }


            }
            catch (Exception)
            {
                MessageBox.Show("A művelet nem végrehajtható!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AktivBetegDataGridFeltoltes()
        {
            AktivBetegDataGrid.Rows.Clear();            
            doctorData.doctorsList.Clear();
            BetegFuggvenyek.AktivBetegSegedLista.Clear();
            BetegFuggvenyek.BetegAdatLista.Clear();
            doctorData.getDoctors();         
            BetegFuggvenyek.AktivBetegAdatLekeres();
            BetegFuggvenyek.AktivBetegSegedListaFeltoltes();


            string Orvos = "";
            string FelvetelIdeje = "";
           
            
            for (int i = 0; i < BetegFuggvenyek.BetegAdatLista.Count; i++)
            {

                string KezeloOrvos = BetegFuggvenyek.BetegAdatLista[i].kezeloorvos;
                string BetegTajszama = BetegFuggvenyek.BetegAdatLista[i].betegtajszam;
                
                for(int j =0;j < doctorData.doctorsList.Count;j++)
                {
                    if(doctorData.doctorsList[j].orvospecset == KezeloOrvos)
                    {
                        Orvos = doctorData.doctorsList[j].nev;
                    }
                }
                 
                for(int a = 0; a < BetegFuggvenyek.AktivBetegSegedLista.Count;a++)
                {
                    if(BetegFuggvenyek.AktivBetegSegedLista[a].aktivbetegtajszam == BetegTajszama)
                    {
                        FelvetelIdeje = BetegFuggvenyek.AktivBetegSegedLista[a].aktivbetegfelvetelido;
                    }
                }                       
                         
                AktivBetegDataGrid.Rows.Add(BetegFuggvenyek.BetegAdatLista[i].betegtajszam, BetegFuggvenyek.BetegAdatLista[i].betegneve, Orvos, FelvetelIdeje);
            }

        }

        public AktivBetegekPanel()
        {
            InitializeComponent();
            AktivBetegDataGridFeltoltes();
        }

        private void BetegAdatFrissites_bt_Click(object sender, EventArgs e)
        {
            AktivBetegDataGridFeltoltes();
        }

        private void betegadatkereses_bt_Click(object sender, EventArgs e)
        {
           
        }

        private void UjAktivBetegFelvetele_bt_Click(object sender, EventArgs e)
        {
            AktivBetegAdatFelvetel AktivBetegWindow = new AktivBetegAdatFelvetel();
            AktivBetegWindow.Show();
        }

        private void AktivBetegAdatModositas_bt_Click(object sender, EventArgs e)
        {
            AktivBetegAdatModositas();
        }
    }
}
