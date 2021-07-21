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
    public partial class BetegAdatlapWindow : Form

    {
        private void BetegAdatkereses()
        {
            /*BetegFuggvenyek.BetegAdatLekeres();
            bool letezik = false;
            for(int i =0;i < BetegFuggvenyek.BetegAdatLista.Count;i++)
            {
               if(BetegFuggvenyek.BetegAdatLista[i].betegtajszam == betegtajkeres_txb.Text)
                {
                    betegneve_txb.Text = BetegFuggvenyek.BetegAdatLista[i].betegneve;
                    beteg_szul_hely_txb.Text = BetegFuggvenyek.BetegAdatLista[i].betegszulhely;
                    beteg_szul_ido_txb.Text = BetegFuggvenyek.BetegAdatLista[i].betegszulido;
                    betegeletkor_txb.Text = Convert.ToString(BetegFuggvenyek.BetegAdatLista[i].betegeletkor);
                    betegtajszam_txb.Text = Convert.ToString(BetegFuggvenyek.BetegAdatLista[i].betegtajszam);
                    beteginfo_txb.Text = BetegFuggvenyek.BetegAdatLista[i].beteginfo;
                    keresettbetegid_lb.Text= $"{BetegFuggvenyek.BetegAdatLista[i].id}";
                    letezik = true;
                }
            }
           
            if(letezik == false)
            {
                MessageBox.Show("A Keresett beteg nem szerepel a listában!");
            }*/
        }

        private void Clear()
        {
            betegneve_txb.Clear();
            beteg_szul_hely_txb.Clear();
            beteg_szul_ido_txb.Clear();
            betegeletkor_txb.Clear();
            betegtajszam_txb.Clear();
            beteginfo_txb.Clear();
           // betegtajkeres_txb.Clear();
            

        }



        

            public BetegAdatlapWindow()
        {
            InitializeComponent();
        }

        private void BetegFeltoltes_bt_Click(object sender, EventArgs e)
        {
            BetegFuggvenyek.BetegAdatfeltoltes(betegneve_txb.Text, beteg_szul_hely_txb.Text, beteg_szul_ido_txb.Text, Convert.ToInt32(betegeletkor_txb.Text), betegtajszam_txb.Text, beteginfo_txb.Text);
            Clear();
            keresettbetegid_lb.Text = "";
            this.Close();
        }

        private void betegadatlapbezar_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void betegadatkereses_bt_Click(object sender, EventArgs e)
        {

            BetegAdatkereses();
            //betegtajkeres_txb.Clear();
            
        }

        private void betegadatmodositas_vegrehajt_bt_Click(object sender, EventArgs e)
        {
            BetegFuggvenyek.BetegAdatModositas(betegneve_txb.Text, beteg_szul_hely_txb.Text, beteg_szul_ido_txb.Text, Convert.ToInt32(betegeletkor_txb.Text), betegtajszam_txb.Text, beteginfo_txb.Text, Convert.ToInt32(keresettbetegid_lb.Text));
            
            this.Close();
        }
    }
}
