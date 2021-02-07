using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace SecBegenAl
{
    public partial class SaticiGiris : UserControl
    {
        public SaticiGiris()
        {
            InitializeComponent();
        }

        OleDbCommand komut;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=SecBegen.accdb");
        OleDbDataAdapter da;

        private void SaticiGiris_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //satıcıları veritabanına ekleme
            komut = new OleDbCommand("INSERT INTO Satici (Firma_Adi,Telefon,Satici_Adres,Eposta,Parola) values('" + textBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox8.Text + "','" + textBox6.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Oldunuz!");
            baglanti.Close();
        }
    }
}
