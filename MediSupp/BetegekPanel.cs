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
                        MessageBox.Show("Az adott eszköz törlésre került!", "Sikeres művelet", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button1_Click(object sender, EventArgs e)
        {
            BetegAdatlap BetegAdat = new BetegAdatlap();
            BetegAdat.Show();
        }

        private void betegadatfrissites_bt_Click(object sender, EventArgs e)
        {
            
            DataGridFeltoltes();
        }

        private void betegtorles_bt_Click(object sender, EventArgs e)
        {
            BetegTorles();
        }

        private void betegadatmodositas_bt_Click(object sender, EventArgs e)
        {
            BetegAdatlap BetegAdat = new BetegAdatlap();
            BetegAdat.Show();
        }
    }
}
