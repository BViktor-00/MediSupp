using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MediSupp
{
    class AdatbazisInfo
    {

        static string FileUtvonal = Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + "\\MediSuppData.mdf";
        public static string ServerInfo = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + FileUtvonal + ";Integrated Security = True";

       
    }
}
