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
    public partial class Orvosok_panel : UserControl
    {

        public void DataGridFeltoltes()
        {
            DataListOrvosok.Rows.Clear();
            OrvosFuggvenyek.OrvosLista.Clear();
            OrvosFuggvenyek.OrvosAdatAdatLekeres();
            for (int i = 0; i < OrvosFuggvenyek.OrvosLista.Count; i++)
            {
                DataListOrvosok.Rows.Add(OrvosFuggvenyek.OrvosLista[i].ID, OrvosFuggvenyek.OrvosLista[i].nev, OrvosFuggvenyek.OrvosLista[i].szakterulet, OrvosFuggvenyek.OrvosLista[i].emailcim, OrvosFuggvenyek.OrvosLista[i].betegek);
            }
        }

        private void OrvosTorles()
        {
            if (MessageBox.Show("Biztos, hogy törlöd a beteg adatait", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Végrehajtódik a törlési folyamat
                int orvosID = Convert.ToInt32(DataListOrvosok.SelectedCells[0].Value.ToString());
                DataListOrvosok.Rows.RemoveAt(DataListOrvosok.CurrentCell.RowIndex);//Adott sornak a törlése datagridview-ból
                string torlesParancs = $"DELETE FROM orvos WHERE id={orvosID}";//Adatbázis törlés parancs, az adott adatsor elemre
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

        private void DataListOrvosok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        public Orvosok_panel()
        {
            InitializeComponent();
            DataGridFeltoltes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrvosAdatlap Orvosok = new OrvosAdatlap();
            Orvosok.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            DataGridFeltoltes();

        }

        private void orvosadatfrissites_bt_Click(object sender, EventArgs e)
        {

            DataGridFeltoltes();
        }

        private void orvostorles_bt_Click(object sender, EventArgs e)
        {
            OrvosTorles();
        }

        private void orvosadatmodositas_bt_Click(object sender, EventArgs e)
        {
            OrvosAdatlap Orvosok = new OrvosAdatlap();
            Orvosok.Show();
        }
    }
}
