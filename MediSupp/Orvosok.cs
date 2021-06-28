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
    public partial class Orvosok : UserControl
    {

        public void DataGridFeltoltes()
        {
            DataListOrvosok.Rows.Clear();
            OrvosFuggvenyek.OrvosAdatMegjelenites();
            for (int i = 0; i < OrvosFuggvenyek.OrvosLista.Count; i++)
            {
                DataListOrvosok.Rows.Add(OrvosFuggvenyek.OrvosLista[i].ID, OrvosFuggvenyek.OrvosLista[i].nev, OrvosFuggvenyek.OrvosLista[i].szakterulet, OrvosFuggvenyek.OrvosLista[i].emailcim, OrvosFuggvenyek.OrvosLista[i].betegek);
            }
        }

        private void DataListOrvosok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        public Orvosok()
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
    }
}
