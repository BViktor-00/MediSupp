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
    public partial class AktivBetegAdatFelvetel : Form
    {

        public void Apa_Betegkeres()
        {
            bool letezik = false;

            for (int i = 0; i < BetegFuggvenyek.BetegAdatLista.Count; i++)
            {
                if (BetegFuggvenyek.BetegAdatLista[i].betegtajszam == Apa_BetegKeres_txb.Text)
                {

                    BetegFuggvenyek.BetegAdatLista.Clear();
                    BetegFuggvenyek.BetegAdatLekeres();

                    AktivBetegNeve_lb.Text = BetegFuggvenyek.BetegAdatLista[i].betegneve;
                    AktivBetegSzulHely_lb.Text = BetegFuggvenyek.BetegAdatLista[i].betegszulhely;
                    AktivBetegSzulIdo_lb.Text = BetegFuggvenyek.BetegAdatLista[i].betegszulido;
                    AktivBetegTajszam_lb.Text = BetegFuggvenyek.BetegAdatLista[i].betegtajszam;

                    AktivBetegInformacio_txb.Text = BetegFuggvenyek.BetegAdatLista[i].beteginfo;

                    letezik = true;

                }

            }
            if (letezik == false)
                MessageBox.Show("A Keresett beteg nem található!");

            Apa_BetegKeres_txb.Clear();
        }

        public void KezeloOrvosListaFeltoltes()
        {
            for (int i = 0; i < OrvosFuggvenyek.OrvosLista.Count; i++)
            {
                KezeloOrvos_cbx.Items.Add(OrvosFuggvenyek.OrvosLista[i].nev);

            }
        }

        public void AktivBetegFElvetel()
        {
            string OrvosPecset = "";

            for (int i = 0; i < OrvosFuggvenyek.OrvosLista.Count; i++)
            {
                if (OrvosFuggvenyek.OrvosLista[i].nev == KezeloOrvos_cbx.Text)
                {
                    OrvosPecset = OrvosFuggvenyek.OrvosLista[i].orvospecset;
                }
            }

            BetegFuggvenyek.AktivBetegFelvetel(AktivBetegTajszam_lb.Text, OrvosPecset, FelvetelIdopontja_dt.Text, AktivBetegPanasza_txb.Text, AktivBetegKezeles_txb.Text);

            using (SqlConnection Csatlakozas = new SqlConnection(AdatbazisInfo.ServerInfo))
            {
                string modositas = $"UPDATE beteg " +
                $"SET aktivbeteg = @aktivbeteg," +
                $"kezeloorvos = @kezeloorvos " +
                $"WHERE betegtajszam = {AktivBetegTajszam_lb.Text}";
                using (SqlCommand Parancs = new SqlCommand(modositas, Csatlakozas))
                {
                    Parancs.Parameters.AddWithValue("@aktivbeteg", "aktiv");
                    Parancs.Parameters.AddWithValue("@kezeloorvos", OrvosPecset);
                    Csatlakozas.Open();
                    Parancs.ExecuteNonQuery();

                }

            }

            this.Close();
        }

        public void AktivBetegAdatModositas(string kezeloorvosnev, string info, string panasz, string kezeles, string betegtajszam)
        {

            string kezeloorvos = "";
            for(int i = 0; i < OrvosFuggvenyek.OrvosLista.Count;i++)
            {
                if(OrvosFuggvenyek.OrvosLista[i].nev == kezeloorvosnev)
                {
                    kezeloorvos = OrvosFuggvenyek.OrvosLista[i].orvospecset;
                }
            }


            using (SqlConnection Csatlakozas = new SqlConnection(AdatbazisInfo.ServerInfo))
            {
                string modositas = $"UPDATE aktivbetegek " +
                $"SET betegpanasza = @betegpanasza," +                               
                $"kezeles = @kezeles " +
                $"WHERE betegtajszam = {betegtajszam}";
                               

                using (SqlCommand Parancs = new SqlCommand(modositas, Csatlakozas))
                {
                    Parancs.Parameters.AddWithValue("@betegpanasza", panasz);
                    Parancs.Parameters.AddWithValue("@kezeles", kezeles);           
                    Csatlakozas.Open();
                    Parancs.ExecuteNonQuery();                                      
                    
                }                                

            }

            using (SqlConnection Csatlakozas = new SqlConnection(AdatbazisInfo.ServerInfo))
            {
                
                string modositas = $"UPDATE beteg " +
                $"SET beteginfo = @beteginfo," +
                $"kezeloorvos = @kezeloorvos " +
                $"WHERE betegtajszam = {betegtajszam}";
                                

                using (SqlCommand Parancs = new SqlCommand(modositas, Csatlakozas))
                {
                    Parancs.Parameters.AddWithValue("@beteginfo", info);
                    Parancs.Parameters.AddWithValue("@kezeloorvos", kezeloorvos);
                    Csatlakozas.Open();
                    Parancs.ExecuteNonQuery();

                }

            }

            MessageBox.Show("Az adatok módosítása sikeres!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        

        public void BetegElbocsajtasa(string betegtajszam)
        {
            string MappaEleresiUtvonal = Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + "\\Korelozmeny\\" + AktivBetegTajszam_lb.Text + "_" + AktivBetegNeve_lb.Text + ".txt";
            StreamWriter Iro = new StreamWriter($"{MappaEleresiUtvonal}", true, Encoding.UTF8);

            Iro.WriteLine($"Beteg Neve: {AktivBetegNeve_lb.Text}");
            Iro.WriteLine($"Beteg Tajszáma: {AktivBetegTajszam_lb.Text}");
            Iro.WriteLine($"Kezelőorvos: {KezeloOrvos_cbx.Text}");
            Iro.WriteLine($"Felvétel időpontja: {FelvetelIdopontja_dt.Text}");
            Iro.WriteLine($"Felvétel időpontja: {ElbocsajtasIdopontja_dt.Text}");
            Iro.WriteLine($"");
            Iro.WriteLine($"Egyéb információ a betegről:");
            Iro.WriteLine($"{AktivBetegInformacio_txb.Text}");
            Iro.WriteLine($"");
            Iro.WriteLine($"Panasz");
            Iro.WriteLine($"{AktivBetegPanasza_txb.Text}");
            Iro.WriteLine($"");
            Iro.WriteLine($"Az orvos álltal felírt kezelés/vizsgálat");
            Iro.WriteLine($"{AktivBetegKezeles_txb.Text}");
            Iro.WriteLine($"");
            Iro.WriteLine($"*****************************************************************************************");

            Iro.Close();

             using (SqlConnection Csatlakozas = new SqlConnection(AdatbazisInfo.ServerInfo))
             {
                string modositas = $"DELETE FROM aktivbetegek WHERE betegtajszam = {betegtajszam}";           
                using (SqlCommand Parancs = new SqlCommand(modositas, Csatlakozas))
                 {                     
                     Csatlakozas.Open();
                     Parancs.ExecuteNonQuery();
                 }

             }

            using (SqlConnection Csatlakozas = new SqlConnection(AdatbazisInfo.ServerInfo))
            {
                string modositas = $"UPDATE beteg " +
                    $"SET kezeloorvos = @kezeloorvos," +
                    $"betegkorelozmeny = @betegkorelozmeny," +
                    $"aktivbeteg = @aktivbeteg " +
                    $"WHERE betegtajszam = {betegtajszam}";

                using (SqlCommand Parancs = new SqlCommand(modositas, Csatlakozas))
                {
                    Parancs.Parameters.AddWithValue("@kezeloorvos", "nincs");
                    Parancs.Parameters.AddWithValue("@betegkorelozmeny",MappaEleresiUtvonal );
                    Parancs.Parameters.AddWithValue("@aktivbeteg", "inaktiv");
                    Csatlakozas.Open();
                    Parancs.ExecuteNonQuery();
                }

            }
           
        }

        public AktivBetegAdatFelvetel()
        {
            InitializeComponent();
            KezeloOrvosListaFeltoltes();
            BetegFuggvenyek.BetegAdatLekeres();
        }

        private void AktivBetegAdatFelvetel_Load(object sender, EventArgs e)
        {

        }

        private void APa_BetegKeresVegrehajt_bt_Click(object sender, EventArgs e)
        {
            Apa_Betegkeres();                       
        }

        private void AktivBetegFelvetelVegrehajt_bt_Click(object sender, EventArgs e)
        {
            
            AktivBetegFElvetel();
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AktivBetegModositVegrehajt_bt_Click(object sender, EventArgs e)
        {
            AktivBetegAdatModositas(KezeloOrvos_cbx.Text, AktivBetegInformacio_txb.Text, AktivBetegPanasza_txb.Text, AktivBetegKezeles_txb.Text, AktivBetegTajszam_lb.Text);
            this.Close();
        }

        private void BetegElbocsajt_bt_Click(object sender, EventArgs e)
        {
            BetegElbocsajtasa(AktivBetegTajszam_lb.Text);
            this.Close();
        }
    }
}
