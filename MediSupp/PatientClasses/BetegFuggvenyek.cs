using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace MediSupp
{
    class BetegFuggvenyek
    {

        public static List<BetegAdatok> BetegAdatLista = new List<BetegAdatok>();
        public static List<AktivBetegFelvetelIdeje> AktivBetegSegedLista = new List<AktivBetegFelvetelIdeje>();
       
        public static void BetegAdatfeltoltes(string nev, string szulhely, string datum,int eletkor, string tajszam, string beteginformacio)
        {        

            try
            {
                using (SqlConnection Csatlakozas = new SqlConnection(AdatbazisInfo.ServerInfo))
                {
                    string feltoltes = "INSERT INTO beteg VALUES (@betegneve,@betegszulhely,@betegszulido,@betegeletkor,@betegtajszam,@beteginfo,@betegkorelozmeny,@aktivbeteg,@kezeloorvos)";
                    using (SqlCommand Parancs = new SqlCommand(feltoltes, Csatlakozas))
                    {
                        Parancs.Parameters.AddWithValue("@betegneve", nev);
                        Parancs.Parameters.AddWithValue("@betegszulhely", szulhely);
                        Parancs.Parameters.AddWithValue("@betegszulido", datum);
                        Parancs.Parameters.AddWithValue("@betegeletkor", eletkor);
                        Parancs.Parameters.AddWithValue("@betegtajszam", tajszam);
                        Parancs.Parameters.AddWithValue("@beteginfo", beteginformacio);
                        Parancs.Parameters.AddWithValue("@betegkorelozmeny", "nincs");
                        Parancs.Parameters.AddWithValue("@aktivbeteg", "nem_aktiv");
                        Parancs.Parameters.AddWithValue("@kezeloorvos", "nincs");
                        Csatlakozas.Open();
                        Parancs.ExecuteNonQuery();

                        MessageBox.Show("Az adatok feltöltése sikeres!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba a feltöltés közben!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void AktivBetegFelvetel(string betegtajszam,string orvosipecsetszam,string betegfelvetelideje, string panasz,string kezeles)
        {               
            
                using (SqlConnection Csatlakozas = new SqlConnection(AdatbazisInfo.ServerInfo))
                {
                    string feltoltes = "INSERT INTO aktivbetegek VALUES (@betegtajszam,@orvosipecsetszam,@felvetelideje,@betegpanasza,@kezeles)";
                    using (SqlCommand Parancs = new SqlCommand(feltoltes, Csatlakozas))
                    {
                        Parancs.Parameters.AddWithValue("@betegtajszam", betegtajszam);
                        Parancs.Parameters.AddWithValue("@orvosipecsetszam", orvosipecsetszam);                        
                        Parancs.Parameters.AddWithValue("@felvetelideje", betegfelvetelideje);
                        Parancs.Parameters.AddWithValue("@betegpanasza",panasz);
                        Parancs.Parameters.AddWithValue("@kezeles",kezeles);
                       
                        Csatlakozas.Open();
                        Parancs.ExecuteNonQuery();

                        MessageBox.Show("Az adatok feltöltése sikeres!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                       

        }

        public static void BetegAdatLekeres()

        {
            try
            {
                using (SqlConnection Csatlakozas = new SqlConnection(AdatbazisInfo.ServerInfo))
                {
                    string lekerdezes = "SELECT * FROM beteg";
                    using (SqlCommand Parancs = new SqlCommand(lekerdezes, Csatlakozas))
                    {
                        Csatlakozas.Open();
                        SqlDataReader LekerdezesParancs = Parancs.ExecuteReader();
                        while (LekerdezesParancs.Read())
                        {
                            BetegAdatLista.Add(new BetegAdatok(Convert.ToInt32(LekerdezesParancs["Id"]), Convert.ToString(LekerdezesParancs["betegneve"]), Convert.ToString(LekerdezesParancs["betegszulhely"]), Convert.ToString(LekerdezesParancs["betegszulido"]), Convert.ToInt32(LekerdezesParancs["betegeletkor"]), Convert.ToString(LekerdezesParancs["betegtajszam"]), Convert.ToString(LekerdezesParancs["beteginfo"]), Convert.ToString(LekerdezesParancs["betegkorelozmeny"]), Convert.ToString(LekerdezesParancs["aktivbeteg"]), Convert.ToString(LekerdezesParancs["kezeloorvos"])));
                        }
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba a kiolvasás során!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        public static void AktivBetegAdatLekeres()

        {
            
            try
            {
                using (SqlConnection Csatlakozas = new SqlConnection(AdatbazisInfo.ServerInfo))
                {
                    string lekerdezes = "SELECT * FROM beteg WHERE aktivbeteg='aktiv'";
                    using (SqlCommand Parancs = new SqlCommand(lekerdezes, Csatlakozas))
                    {
                        Csatlakozas.Open();
                        SqlDataReader LekerdezesParancs = Parancs.ExecuteReader();
                        while (LekerdezesParancs.Read())
                        {
                            
                            BetegAdatLista.Add(new BetegAdatok(Convert.ToInt32(LekerdezesParancs["Id"]), Convert.ToString(LekerdezesParancs["betegneve"]), Convert.ToString(LekerdezesParancs["betegszulhely"]), Convert.ToString(LekerdezesParancs["betegszulido"]), Convert.ToInt32(LekerdezesParancs["betegeletkor"]), Convert.ToString(LekerdezesParancs["betegtajszam"]), Convert.ToString(LekerdezesParancs["beteginfo"]), Convert.ToString(LekerdezesParancs["betegkorelozmeny"]), Convert.ToString(LekerdezesParancs["aktivbeteg"]), Convert.ToString(LekerdezesParancs["kezeloorvos"])));
                        }
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba a kiolvasás során!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public static void AktivBetegSegedListaFeltoltes()
        {
            try
            {
                using (SqlConnection Csatlakozas = new SqlConnection(AdatbazisInfo.ServerInfo))
                {
                    string lekerdezes = "SELECT * FROM aktivbetegek";
                    using (SqlCommand Parancs = new SqlCommand(lekerdezes, Csatlakozas))
                    {
                        Csatlakozas.Open();
                        SqlDataReader LekerdezesParancs = Parancs.ExecuteReader();
                        while (LekerdezesParancs.Read())
                        {
                            AktivBetegSegedLista.Add(new AktivBetegFelvetelIdeje(Convert.ToString(LekerdezesParancs["betegtajszam"]), Convert.ToString(LekerdezesParancs["felvetelideje"])));
                        }
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba a kiolvasás során!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void BetegAdatModositas(string nev, string szulhely, string datum, int eletkor, string tajszam, string beteginformacio,int betegid)
        {
           
                
                using (SqlConnection Csatlakozas = new SqlConnection(AdatbazisInfo.ServerInfo))
                {
                    string modositas = $"UPDATE beteg " +
                    $"SET betegneve = @betegneve," +
                    $"betegszulhely = @betegszulhely," +
                    $"betegszulido = @betegszulido," +
                    $"betegeletkor = @betegeletkor," +
                    $"betegtajszam = @betegtajszam," +
                    $"beteginfo = @beteginfo " +
                    $"WHERE id = {betegid}";
                    using (SqlCommand Parancs = new SqlCommand(modositas, Csatlakozas))
                    {
                        Parancs.Parameters.AddWithValue("@betegneve", nev);
                        Parancs.Parameters.AddWithValue("@betegszulhely", szulhely);
                        Parancs.Parameters.AddWithValue("@betegszulido", datum);
                        Parancs.Parameters.AddWithValue("@betegeletkor", eletkor);
                        Parancs.Parameters.AddWithValue("@betegtajszam", tajszam);
                        Parancs.Parameters.AddWithValue("@beteginfo", beteginformacio);                       
                        Csatlakozas.Open();
                        Parancs.ExecuteNonQuery();

                        MessageBox.Show("Az adatok módosítása sikeres!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                    
        }

        public static void Apa_BetegKereses()
        {
            

            AktivBetegAdatFelvetel AktivBetegWindow = new AktivBetegAdatFelvetel();
                  
                      
            bool letezik = false;

            for (int i = 0; i < BetegAdatLista.Count; i++)
            {
                if (BetegAdatLista[i].betegtajszam == AktivBetegWindow.Apa_BetegKeres_txb.Text)
                {
                   
                    BetegAdatLista.Clear();
                    BetegAdatLekeres();

                    AktivBetegWindow.AktivBetegNeve_lb.Text = BetegAdatLista[i].betegneve;
                    AktivBetegWindow.AktivBetegSzulHely_lb.Text = BetegAdatLista[i].betegszulhely;
                    AktivBetegWindow.AktivBetegSzulIdo_lb.Text = BetegAdatLista[i].betegszulido;
                    AktivBetegWindow.AktivBetegTajszam_lb.Text = BetegAdatLista[i].betegtajszam;

                    AktivBetegWindow.AktivBetegInformacio_txb.Text = BetegAdatLista[i].beteginfo;

                    letezik = true;
                                        
                }

            }
            if (letezik == false)
                MessageBox.Show("A Keresett beteg nem található!");

            AktivBetegWindow.Apa_BetegKeres_txb.Clear();

                     

        }
        
    }
}
