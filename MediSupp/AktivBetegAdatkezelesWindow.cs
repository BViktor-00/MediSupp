using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediSupp.Windows
{
    public partial class AktivBetegAdatkezelesWindow : Form
    {
        public AktivBetegAdatkezelesWindow()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void APa_BetegKeresVegrehajt_bt_Click(object sender, EventArgs e)
        {
            bool letezik = false;

            for (int i = 0; i < BetegFuggvenyek.BetegAdatLista.Count; i++)
            {
                if (BetegFuggvenyek.BetegAdatLista[i].betegtajszam == APa_BetegKeres_txb.Text)
                {


                    BetegFuggvenyek.BetegAdatLista.Clear();
                    BetegFuggvenyek.BetegAdatLekeres();

                    AktivBetegNeve_lb.Text = BetegFuggvenyek.BetegAdatLista[i].betegneve;
                    AktivBetegSzulHely_lb.Text = BetegFuggvenyek.BetegAdatLista[i].betegszulhely;
                    AktivBetegSzulIdo_lb.Text = BetegFuggvenyek.BetegAdatLista[i].betegszulido;
                    AktivBetegTajszam_lb.Text = BetegFuggvenyek.BetegAdatLista[i].betegtajszam;

                    letezik = true;

                }

            }
            if (letezik == false)
                MessageBox.Show("A Keresett beteg nem található!");

            APa_BetegKeres_txb.Clear();
        }
    }
}
