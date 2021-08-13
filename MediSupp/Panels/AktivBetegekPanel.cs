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

   

        public void AktivBetegDataGridFeltoltes()
        {
            AktivBetegDataGrid.Rows.Clear();
            BetegFuggvenyek.BetegAdatLista.Clear();
            OrvosFuggvenyek.OrvosLista.Clear();
            OrvosFuggvenyek.OrvosAdatAdatLekeres();
            BetegFuggvenyek.AktivBetegAdatLekeres();
            BetegFuggvenyek.AktivBetegSegedListaFeltoltes();

            string Orvos = "";
            string FelvetelIdeje = "";

            
            

            for (int i = 0; i < BetegFuggvenyek.BetegAdatLista.Count; i++)
            {

                string KezeloOrvos = BetegFuggvenyek.BetegAdatLista[i].kezeloorvos;
                string BetegTajszama = BetegFuggvenyek.BetegAdatLista[i].betegtajszam;
                
                for(int j =0;j < OrvosFuggvenyek.OrvosLista.Count;j++)
                {
                    if(OrvosFuggvenyek.OrvosLista[j].orvospecset == KezeloOrvos)
                    {
                        Orvos = OrvosFuggvenyek.OrvosLista[j].nev;
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
    }
}
