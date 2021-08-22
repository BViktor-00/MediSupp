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
    public partial class OrvosAdatlapWindow : Form
    {
        Orvosok_panel OrvosTabla = new Orvosok_panel();

        /*public void DataGridFeltoltes()
        {
            OrvosTabla.DataListOrvosok.Rows.Clear();
            doctorData.OrvosAdatAdatLekeres();
            for (int i = 0; i < doctorData.OrvosLista.Count; i++)
            {
               OrvosTabla.DataListOrvosok.Rows.Add(doctorData.OrvosLista[i].ID, doctorData.OrvosLista[i].nev, doctorData.OrvosLista[i].szakterulet, doctorData.OrvosLista[i].emailcim, doctorData.OrvosLista[i].betegek);
            }
        }*/

        public void Clear()
        {
            Orvosnev_txb.Clear();            
            emailcim_txb.Clear();
            orvosipecsetszam_txb.Clear();
           
        }

        private void SzakteruletFeltoltes()
        {
            StreamReader Olvas = new StreamReader("szakterulet.txt", Encoding.UTF8);
            while(!Olvas.EndOfStream)
            {
                szakterulet_cxb.Items.Add(Olvas.ReadLine());
            }
        }



        public OrvosAdatlapWindow()
        {
            InitializeComponent();
            SzakteruletFeltoltes();
        }


        private void OrvosokFeltoltes_bt_Click(object sender, EventArgs e)
        {
            DoctorRepository.OrvosAdatfeltoltes(Orvosnev_txb.Text, szakterulet_cxb.Text, emailcim_txb.Text,orvosipecsetszam_txb.Text);
            Clear();
            this.Close();
                             
        }

        private void orvosokkilepes_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void orvosadatmodositasvegrahajt_bt_Click(object sender, EventArgs e)
        {
          
            DoctorRepository.OrvosAdatModositas(Orvosnev_txb.Text, szakterulet_cxb.Text, emailcim_txb.Text, orvosipecsetszam_txb.Text, Convert.ToInt32(orvosid_lb.Text));
            this.Close();
        }

       
        private void orvosid_lb_Click(object sender, EventArgs e)
        {


        }

        private void OrvosAdatlapWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
