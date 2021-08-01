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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kilep_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void belepes_bt_Click(object sender, EventArgs e)
        {
            
            MainWindow Form2 = new MainWindow();
            Form2.Show();

            Form1 Belepes = new Form1();
            Belepes.Hide();

            
        }
    }
}
