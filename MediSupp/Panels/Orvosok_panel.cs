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
                DataListOrvosok.Rows.Add(OrvosFuggvenyek.OrvosLista[i].ID, OrvosFuggvenyek.OrvosLista[i].nev, OrvosFuggvenyek.OrvosLista[i].szakterulet, OrvosFuggvenyek.OrvosLista[i].emailcim,OrvosFuggvenyek.OrvosLista[i].orvospecset, OrvosFuggvenyek.OrvosLista[i].betegek);
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
             
               

        private void orvosadatfrissites_bt_Click(object sender, EventArgs e)
        {

            DataGridFeltoltes();
        }

               

        private void orvoskeresvegrehajt_bt_Click(object sender, EventArgs e)
        {
            bool letezik = false;

            for (int i = 0; i < OrvosFuggvenyek.OrvosLista.Count; i++)
            {
                if (OrvosFuggvenyek.OrvosLista[i].orvospecset == keresettorvos_txb.Text)
                {
                    DataListOrvosok.Rows.Clear();
                    OrvosFuggvenyek.OrvosLista.Clear();
                    OrvosFuggvenyek.OrvosAdatAdatLekeres();
                    
                    DataListOrvosok.Rows.Add(OrvosFuggvenyek.OrvosLista[i].ID, OrvosFuggvenyek.OrvosLista[i].nev, OrvosFuggvenyek.OrvosLista[i].szakterulet, OrvosFuggvenyek.OrvosLista[i].emailcim, OrvosFuggvenyek.OrvosLista[i].orvospecset, OrvosFuggvenyek.OrvosLista[i].betegek);
                    
                    letezik = true;

                }
                                
            }
            if (letezik == false)
                MessageBox.Show("A Keresett orvos nem található!");

            keresettorvos_txb.Clear();
        }

        private void AdatokFrissitese_bt_Click(object sender, EventArgs e)
        {
            DataGridFeltoltes();
        }

        private void UjOrvos_bt_Click(object sender, EventArgs e)
        {
            OrvosAdatlapWindow Orvosok = new OrvosAdatlapWindow();
            Orvosok.Show();
        }

        private void OrvosTorlese_bt_Click(object sender, EventArgs e)
        {
            OrvosTorles();
        }

        private void OrvosAdatModositas_bt_Click_1(object sender, EventArgs e)
        {
             string orvosPecset = Convert.ToString(DataListOrvosok.SelectedCells[4].Value);
            OrvosAdatlapWindow Orvosok = new OrvosAdatlapWindow();
            Orvosok.Show();
             for(int i =0; i <OrvosFuggvenyek.OrvosLista.Count;i++ )
             {
                 if(OrvosFuggvenyek.OrvosLista[i].orvospecset == orvosPecset)
                 {
                    Orvosok.Orvosnev_txb.Text = OrvosFuggvenyek.OrvosLista[i].nev;
                    Orvosok.szakterulet_cxb.Text = OrvosFuggvenyek.OrvosLista[i].szakterulet;
                    Orvosok.emailcim_txb.Text = OrvosFuggvenyek.OrvosLista[i].emailcim;
                    Orvosok.orvosipecsetszam_txb.Text = OrvosFuggvenyek.OrvosLista[i].orvospecset;
                    Orvosok.orvosid_lb.Text = Convert.ToString(OrvosFuggvenyek.OrvosLista[i].ID);
                 }
             }

        }
    }
}
