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
    public partial class BetegekPanel : UserControl
    {
        public void DataGridFeltoltes()
        {
            BetegDataList.Rows.Clear();
            BetegFuggvenyek.BetegAdatMegjelenites();
            for (int i = 0; i < BetegFuggvenyek.BetegAdatLista.Count; i++)
            {
                BetegDataList.Rows.Add(BetegFuggvenyek.BetegAdatLista[i].id, BetegFuggvenyek.BetegAdatLista[i].betegneve, BetegFuggvenyek.BetegAdatLista[i].betegszulhely, BetegFuggvenyek.BetegAdatLista[i].betegszulido, BetegFuggvenyek.BetegAdatLista[i].betegtajszam);
            }
        }


        public BetegekPanel()
        {
            InitializeComponent();
            DataGridFeltoltes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BetegAdatlap BetegAdat = new BetegAdatlap();
            BetegAdat.Show();
        }
    }
}
