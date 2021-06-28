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

    
    public class OrvosFuggvenyek
    {
       

        public static List<OrvosAdatok> OrvosLista = new List<OrvosAdatok>();

        public static void OrvosAdatfeltoltes(string nev, string szakterulet, string emailcim)
        {
            try
            {
                using (SqlConnection Csatlakozas = new SqlConnection(AdatbazisInfo.ServerInfo))
                {
                    string feltoltes = "INSERT INTO Orvos VALUES (@orvosneve,@szakterulet,@emailcim,@betegek)";
                    using (SqlCommand Parancs = new SqlCommand(feltoltes, Csatlakozas))
                    {
                        Parancs.Parameters.AddWithValue("@orvosneve", nev);
                        Parancs.Parameters.AddWithValue("@szakterulet", szakterulet);
                        Parancs.Parameters.AddWithValue("@emailcim", emailcim);
                        Parancs.Parameters.AddWithValue("@betegek", "nincs");
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

        public static void OrvosAdatMegjelenites()

        {
            try
            {
                using (SqlConnection Csatlakozas = new SqlConnection(AdatbazisInfo.ServerInfo))
                {
                    string lekerdezes = "SELECT * FROM Orvos";
                    using (SqlCommand Parancs = new SqlCommand(lekerdezes, Csatlakozas))
                    {
                        Csatlakozas.Open();
                        SqlDataReader LekerdezesParancs = Parancs.ExecuteReader();
                        while (LekerdezesParancs.Read())
                        {
                           OrvosLista.Add(new OrvosAdatok(Convert.ToInt32(LekerdezesParancs["Id"]), Convert.ToString(LekerdezesParancs["orvosneve"]), Convert.ToString(LekerdezesParancs["szakterulet"]), Convert.ToString(LekerdezesParancs["emailcim"]), Convert.ToString(LekerdezesParancs["betegek"])));
                        }
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba a kiolvasás során!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        
    }
}
