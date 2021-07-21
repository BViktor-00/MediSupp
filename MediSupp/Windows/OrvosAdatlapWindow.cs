﻿using System;
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
            orvosipecsetszam_txb.Clear();
           
        }



        public OrvosAdatlapWindow()
        {
            InitializeComponent();
        }


        private void OrvosokFeltoltes_bt_Click(object sender, EventArgs e)
        {
            OrvosFuggvenyek.OrvosAdatfeltoltes(Orvosnev_txb.Text, szakterulet_txb.Text, emailcim_txb.Text,orvosipecsetszam_txb.Text);
            Clear();
            this.Close();
            Orvosok_panel OrvosPanel = new Orvosok_panel();
            OrvosPanel.DataGridFeltoltes();                       
        }

        private void orvosokkilepes_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void orvosadatmodositasvegrahajt_bt_Click(object sender, EventArgs e)
        {
          
            OrvosFuggvenyek.OrvosAdatModositas(Orvosnev_txb.Text, szakterulet_txb.Text, emailcim_txb.Text, orvosipecsetszam_txb.Text, Convert.ToInt32(orvosid_lb.Text));
            this.Close();
        }

       
        private void orvosid_lb_Click(object sender, EventArgs e)
        {


        }
    }
}