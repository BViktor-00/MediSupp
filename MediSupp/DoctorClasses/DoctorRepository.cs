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

    
    public class DoctorRepository
    {
       
        
        public static void OrvosAdatfeltoltes(string nev, string szakterulet, string emailcim,string pecsetszam)
        {
            try
            {
                using (SqlConnection Csatlakozas = new SqlConnection(AdatbazisInfo.ServerInfo))
                {
                    string feltoltes = "INSERT INTO orvos VALUES (@orvosneve,@szakterulet,@emailcim,@pecsetszam,@betegek)";
                    using (SqlCommand Parancs = new SqlCommand(feltoltes, Csatlakozas))
                    {
                        Parancs.Parameters.AddWithValue("@orvosneve", nev);
                        Parancs.Parameters.AddWithValue("@szakterulet", szakterulet);
                        Parancs.Parameters.AddWithValue("@emailcim", emailcim);
                        Parancs.Parameters.AddWithValue("@pecsetszam", pecsetszam);
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

        //change name to getDoctors
        public List<Doctor> OrvosAdatAdatLekeres()

        {
            List<Doctor> orvosLista = new List<Doctor>();
            using (SqlConnection Csatlakozas = new SqlConnection(AdatbazisInfo.ServerInfo))
                {
                    string lekerdezes = "SELECT * FROM orvos";
                    using (SqlCommand Parancs = new SqlCommand(lekerdezes, Csatlakozas))
                    {
                        Csatlakozas.Open();
                        SqlDataReader LekerdezesParancs = Parancs.ExecuteReader();
                        
                        while (LekerdezesParancs.Read())
                        {
                           orvosLista.Add(new Doctor(Convert.ToInt32(LekerdezesParancs["Id"]), Convert.ToString(LekerdezesParancs["orvosneve"]), Convert.ToString(LekerdezesParancs["szakterulet"]), Convert.ToString(LekerdezesParancs["emailcim"]),Convert.ToString(LekerdezesParancs["pecsetszam"]), Convert.ToString(LekerdezesParancs["betegek"])));
                        }
                    }

                }
            return orvosLista;
        }

        public static void OrvosAdatModositas(string nev, string szakterulet, string emailcim, string pecsetszam,int orvosid)
        {


            using (SqlConnection Csatlakozas = new SqlConnection(AdatbazisInfo.ServerInfo))
            {
                string modositas = $"UPDATE orvos " +
                $"SET orvosneve = @orvosneve," +
                $"szakterulet = @szakterulet," +
                $"emailcim  = @emailcim," +
                $"pecsetszam = @pecsetszam " +         
                $"WHERE id = {orvosid}";
                using (SqlCommand Parancs = new SqlCommand(modositas, Csatlakozas))
                {
                    Parancs.Parameters.AddWithValue("@orvosneve", nev);
                    Parancs.Parameters.AddWithValue("@szakterulet", szakterulet);
                    Parancs.Parameters.AddWithValue("@emailcim", emailcim);
                    Parancs.Parameters.AddWithValue("@pecsetszam", pecsetszam);                                                   
                    Csatlakozas.Open();
                    Parancs.ExecuteNonQuery();

                    MessageBox.Show("Az adatok módosítása sikeres!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

        }
                

    }
}
