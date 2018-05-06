using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace SecBegenAl
{
    public partial class Dolabim : UserControl
    {
        public Dolabim()
        {
            InitializeComponent();
            
        }


        OleDbCommand komut;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=SecBegen.accdb");
        OleDbDataAdapter da;

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
