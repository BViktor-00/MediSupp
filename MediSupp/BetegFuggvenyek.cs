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

        public static void BetegAdatfeltoltes(string nev, string szulhely, string datum,int eletkor, string tajszam, string beteginformacio)
        {
            try
            {
                using (SqlConnection Csatlakozas = new SqlConnection(AdatbazisInfo.ServerInfo))
                {
                    string feltoltes = "INSERT INTO beteg VALUES (@betegneve,@betegszulhely,@betegszulido,@betegeletkor,@betegtajszam,@beteginfo)";
                    using (SqlCommand Parancs = new SqlCommand(feltoltes, Csatlakozas))
                    {
                        Parancs.Parameters.AddWithValue("@betegneve", nev);
                        Parancs.Parameters.AddWithValue("@betegszulhely", szulhely);
                        Parancs.Parameters.AddWithValue("@betegszulido", datum);
                        Parancs.Parameters.AddWithValue("@betegeletkor", eletkor);
                        Parancs.Parameters.AddWithValue("@betegtajszam", tajszam);
                        Parancs.Parameters.AddWithValue("@beteginfo", beteginformacio);                       
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

        public static void BetegAdatMegjelenites()

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
                            BetegAdatLista.Add(new BetegAdatok(Convert.ToInt32(LekerdezesParancs["Id"]), Convert.ToString(LekerdezesParancs["betegneve"]), Convert.ToString(LekerdezesParancs["betegszulhely"]), Convert.ToString(LekerdezesParancs["betegszulido"]), Convert.ToInt32(LekerdezesParancs["betegeletkor"]), Convert.ToString(LekerdezesParancs["betegtajszam"]), Convert.ToString(LekerdezesParancs["beteginfo"])));
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
