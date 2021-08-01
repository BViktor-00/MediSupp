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

namespace MediSupp
{
    public partial class AktivBetegAdatFelvetel : Form
    {

        public void Apa_Betegkeres()
        {
            bool letezik = false;

            for (int i = 0; i < BetegFuggvenyek.BetegAdatLista.Count; i++)
            {
                if (BetegFuggvenyek.BetegAdatLista[i].betegtajszam == Apa_BetegKeres_txb.Text)
                {

                    BetegFuggvenyek.BetegAdatLista.Clear();
                    BetegFuggvenyek.BetegAdatLekeres();

                    AktivBetegNeve_lb.Text = BetegFuggvenyek.BetegAdatLista[i].betegneve;
                    AktivBetegSzulHely_lb.Text = BetegFuggvenyek.BetegAdatLista[i].betegszulhely;
                    AktivBetegSzulIdo_lb.Text = BetegFuggvenyek.BetegAdatLista[i].betegszulido;
                    AktivBetegTajszam_lb.Text = BetegFuggvenyek.BetegAdatLista[i].betegtajszam;

                    AktivBetegInformacio_txb.Text = BetegFuggvenyek.BetegAdatLista[i].beteginfo;

                    letezik = true;

                }

            }
            if (letezik == false)
                MessageBox.Show("A Keresett beteg nem található!");

            Apa_BetegKeres_txb.Clear();
        }

        public void KezeloOrvosListaFeltoltes()
        {
            for (int i = 0; i < OrvosFuggvenyek.OrvosLista.Count; i++)
            {
                KezeloOrvos_cbx.Items.Add(OrvosFuggvenyek.OrvosLista[i].nev);

            }
        }


        public AktivBetegAdatFelvetel()
        {
            InitializeComponent();
            KezeloOrvosListaFeltoltes();
        }

        private void AktivBetegAdatFelvetel_Load(object sender, EventArgs e)
        {


        }

        private void APa_BetegKeresVegrehajt_bt_Click(object sender, EventArgs e)
        {
            Apa_Betegkeres();
                       
        }

        private void AktivBetegFelvetelVegrehajt_bt_Click(object sender, EventArgs e)
        {
           string OrvosPecset="";

            for(int i =0;i< OrvosFuggvenyek.OrvosLista.Count;i++)
            {
                if(OrvosFuggvenyek.OrvosLista[i].nev == KezeloOrvos_cbx.Text)
                {
                    OrvosPecset = OrvosFuggvenyek.OrvosLista[i].orvospecset;
                }
            }

            BetegFuggvenyek.AktivBetegFelvetel(AktivBetegNeve_lb.Text,OrvosPecset, FelvetelIdopontja_dt.Text,AktivBetegPanasza_txb.Text,AktivBetegKezeles_txb.Text);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
