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

namespace MediSupp
{
    public partial class BetegAdatlapWindow : Form

    {
       
        private void Clear()
        {
            betegneve_txb.Clear();
            beteg_szul_hely_txb.Clear();
            beteg_szul_ido_txb.Clear();
            betegeletkor_txb.Clear();
            betegtajszam_txb.Clear();
            beteginfo_txb.Clear();
      

        }

        public void KorElozmenyLetrehozas()
        {
            string MappaEleresiUtvonal = Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + "\\Korelozmeny\\" + betegtajszam_txb.Text + "_" + betegneve_txb.Text + ".txt";
            StreamWriter Iro = new StreamWriter($"{MappaEleresiUtvonal}", true, Encoding.UTF8);

            Iro.WriteLine("-KORTÖRTÉNET-");
            Iro.WriteLine("");

            Iro.Close();
        }

        public BetegAdatlapWindow()
        {
            InitializeComponent();
        }

        private void BetegFeltoltes_bt_Click(object sender, EventArgs e)
        {
            KorElozmenyLetrehozas();
            BetegFuggvenyek.BetegAdatfeltoltes(betegneve_txb.Text, beteg_szul_hely_txb.Text, beteg_szul_ido_txb.Text, Convert.ToInt32(betegeletkor_txb.Text), betegtajszam_txb.Text, beteginfo_txb.Text);
            Clear();
            keresettbetegid_lb.Text = "";
            this.Close();
        }

        private void betegadatlapbezar_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void betegadatmodositas_vegrehajt_bt_Click(object sender, EventArgs e)
        {
            BetegFuggvenyek.BetegAdatModositas(betegneve_txb.Text, beteg_szul_hely_txb.Text, beteg_szul_ido_txb.Text, Convert.ToInt32(betegeletkor_txb.Text), betegtajszam_txb.Text, beteginfo_txb.Text, Convert.ToInt32(keresettbetegid_lb.Text));
            
            this.Close();
        }

        private void betegneve_txb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
