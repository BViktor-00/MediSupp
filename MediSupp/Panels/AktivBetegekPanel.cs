using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediSupp.Panels
{
    public partial class AktivBetegekPanel : UserControl
    {
        public AktivBetegekPanel()
        {
            InitializeComponent();
        }

        private void BetegAdatFrissites_bt_Click(object sender, EventArgs e)
        {

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
