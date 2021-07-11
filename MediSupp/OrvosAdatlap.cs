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
    public partial class OrvosAdatlap : Form
    {
        Orvosok_panel OrvosTabla = new Orvosok_panel();

        public void DataGridFeltoltes()
        {
            OrvosTabla.DataListOrvosok.Rows.Clear();
            OrvosFuggvenyek.OrvosAdatAdatLekeres();
            for (int i = 0; i < OrvosFuggvenyek.OrvosLista.Count; i++)
            {
               OrvosTabla.DataListOrvosok.Rows.Add(OrvosFuggvenyek.OrvosLista[i].ID, OrvosFuggvenyek.OrvosLista[i].nev, OrvosFuggvenyek.OrvosLista[i].szakterulet, OrvosFuggvenyek.OrvosLista[i].emailcim, OrvosFuggvenyek.OrvosLista[i].betegek);
            }
        }

        public void Clear()
        {
            Orvosnev_txb.Clear();
            szakterulet_txb.Clear();
            emailcim_txb.Clear();
        }



        public OrvosAdatlap()
        {
            InitializeComponent();
        }


        private void OrvosokFeltoltes_bt_Click(object sender, EventArgs e)
        {
            OrvosFuggvenyek.OrvosAdatfeltoltes(Orvosnev_txb.Text, szakterulet_txb.Text, emailcim_txb.Text,orvosipecsetszam_txb.Text);
            Clear();
            DataGridFeltoltes();                       
        }

        private void orvosokkilepes_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void orvosadatmodositasvegrahajt_bt_Click(object sender, EventArgs e)
        {
          
            OrvosFuggvenyek.OrvosAdatModositas(Orvosnev_txb.Text, szakterulet_txb.Text, emailcim_txb.Text, orvosipecsetszam_txb.Text, Convert.ToInt32(orvosid_lb.Text));
            
        }

        private void orvoskeresvegrehajt_bt_Click(object sender, EventArgs e)
        {
            bool letezik = false;
            
            for(int i =0; i < OrvosFuggvenyek.OrvosLista.Count;i++)
            {
                if(OrvosFuggvenyek.OrvosLista[i].orvospecset == keresettorvos_txb.Text)
                {
                    orvosid_lb.Text = Convert.ToString(OrvosFuggvenyek.OrvosLista[i].ID);
                    Orvosnev_txb.Text = OrvosFuggvenyek.OrvosLista[i].nev;
                    szakterulet_txb.Text = OrvosFuggvenyek.OrvosLista[i].szakterulet;
                    emailcim_txb.Text = OrvosFuggvenyek.OrvosLista[i].emailcim;
                    orvosipecsetszam_txb.Text = OrvosFuggvenyek.OrvosLista[i].orvospecset;
                    letezik = true;

                }

                if (letezik == false)
                    MessageBox.Show("A Keresett orvos nem található!");
            }
        }

        private void orvosid_lb_Click(object sender, EventArgs e)
        {


        }
    }
}
