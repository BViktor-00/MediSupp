using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediSupp
{
    public partial class MainWindow : Form
    {

        
        public MainWindow()
        {
            InitializeComponent();
            foOldal1.Show();
            betegekPanel1.Hide();
            orvosok1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void orvosok_szerkesztese_bt_Click(object sender, EventArgs e)
        {
            foOldal1.Hide();
            orvosok1.Show();
            betegekPanel1.Hide();
                       

        }

        private void betegek_szerkesztese_bt_Click(object sender, EventArgs e)
        {
            foOldal1.Hide();
            orvosok1.Hide();
            betegekPanel1.Show();
        }
    }
}
