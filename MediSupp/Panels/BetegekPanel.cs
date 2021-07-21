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
    public partial class BetegekPanel : UserControl
    {

        
        public void DataGridFeltoltes()
        {
            BetegDataList.Rows.Clear();
            BetegFuggvenyek.BetegAdatLista.Clear();
            BetegFuggvenyek.BetegAdatLekeres();
            for (int i = 0; i < BetegFuggvenyek.BetegAdatLista.Count; i++)
            {
                BetegDataList.Rows.Add(BetegFuggvenyek.BetegAdatLista[i].id, BetegFuggvenyek.BetegAdatLista[i].betegneve, BetegFuggvenyek.BetegAdatLista[i].betegszulhely, BetegFuggvenyek.BetegAdatLista[i].betegszulido, BetegFuggvenyek.BetegAdatLista[i].betegtajszam);
            }
        }
              

        private void BetegTorles()
        {
            if (MessageBox.Show("Biztos, hogy törlöd a beteg adatait", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Végrehajtódik a törlési folyamat
                int betegID = Convert.ToInt32(BetegDataList.SelectedCells[0].Value.ToString());
                BetegDataList.Rows.RemoveAt(BetegDataList.CurrentCell.RowIndex);//Adott sornak a törlése datagridview-ból
                string torlesParancs = $"DELETE FROM beteg WHERE id={betegID}";//Adatbázis törlés parancs, az adott adatsor elemre
                using (SqlConnection Csatlakozas = new SqlConnection(AdatbazisInfo.ServerInfo))
                {
                    using (SqlCommand Parancs = new SqlCommand(torlesParancs, Csatlakozas))
                    {
                        Csatlakozas.Open();
                        Parancs.ExecuteNonQuery();
                        
                    }
                }
                BetegFuggvenyek.BetegAdatLekeres();
            }
            else
            {
                //nem csinálunk semmit 
            }
        }


        public BetegekPanel()
        {
            InitializeComponent();
            DataGridFeltoltes();
        }
                             
               
        
        private void BetegAdatFrissites_bt_Click_1(object sender, EventArgs e)
        {
            DataGridFeltoltes();
        }

        private void UjBetegFelvetele_bt_Click(object sender, EventArgs e)
        {
            BetegAdatlapWindow BetegAdatokAblak = new BetegAdatlapWindow();
            BetegAdatokAblak.Show();
        }

        private void BetegTorlese_bt_Click(object sender, EventArgs e)
        {
            BetegTorles();
        }

        private void BetegAdatModositas_bt_Click_1(object sender, EventArgs e)
        {
            string BetegTajSzam = Convert.ToString(BetegDataList.SelectedCells[4].Value);
            BetegAdatlapWindow BetegAdatokAblak = new BetegAdatlapWindow();
            BetegAdatokAblak.Show();
            try
            {
                for (int i = 0; i < BetegFuggvenyek.BetegAdatLista.Count; i++)
                {
                    if (BetegFuggvenyek.BetegAdatLista[i].betegtajszam == BetegTajSzam)
                    {
                        BetegAdatokAblak.betegneve_txb.Text = BetegFuggvenyek.BetegAdatLista[i].betegneve;
                        BetegAdatokAblak.beteg_szul_hely_txb.Text = BetegFuggvenyek.BetegAdatLista[i].betegszulhely;
                        BetegAdatokAblak.beteg_szul_ido_txb.Text = BetegFuggvenyek.BetegAdatLista[i].betegszulido;
                        BetegAdatokAblak.betegeletkor_txb.Text = Convert.ToString(BetegFuggvenyek.BetegAdatLista[i].betegeletkor);
                        BetegAdatokAblak.betegtajszam_txb.Text = BetegFuggvenyek.BetegAdatLista[i].betegtajszam;
                        BetegAdatokAblak.beteginfo_txb.Text = BetegFuggvenyek.BetegAdatLista[i].beteginfo;
                        BetegAdatokAblak.keresettbetegid_lb.Text = Convert.ToString(BetegFuggvenyek.BetegAdatLista[i].id);

                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("A művelet nem végrehajtható!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void betegadatkereses_bt_Click(object sender, EventArgs e)
        {
            bool letezik = false;

            for (int i = 0; i < BetegFuggvenyek.BetegAdatLista.Count; i++)
            {
                if (BetegFuggvenyek.BetegAdatLista[i].betegtajszam == betegtajkeres_txb.Text)
                {
                    BetegDataList.Rows.Clear();
                    BetegFuggvenyek.BetegAdatLista.Clear();
                    BetegFuggvenyek.BetegAdatLekeres();

                    BetegDataList.Rows.Add(BetegFuggvenyek.BetegAdatLista[i].id, BetegFuggvenyek.BetegAdatLista[i].betegneve, BetegFuggvenyek.BetegAdatLista[i].betegszulhely, BetegFuggvenyek.BetegAdatLista[i].betegszulido, BetegFuggvenyek.BetegAdatLista[i].betegtajszam);
                    letezik = true;

                }

            }
            if (letezik == false)
                MessageBox.Show("A Keresett orvos nem található!");

            betegtajkeres_txb.Clear();
        }
    }
}
