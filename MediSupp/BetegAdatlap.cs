using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediSupp
{
    public partial class BetegAdatlap : Form

    {


        public BetegAdatlap()
        {
            InitializeComponent();
        }

        private void BetegFeltoltes_bt_Click(object sender, EventArgs e)
        {
            BetegFuggvenyek.BetegAdatfeltoltes(betegneve_txb.Text, beteg_szul_hely_txb.Text, beteg_szul_ido_txb.Text, Convert.ToInt32(betegeletkor_txb.Text), betegtajszam_txb.Text, beteginfo_txb.Text);
        }

        private void betegadatlapbezar_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
