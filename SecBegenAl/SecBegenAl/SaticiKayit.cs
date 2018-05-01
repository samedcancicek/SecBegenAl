using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;


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
        string DosyaYolu, DosyaAdi = "";

        private void SaticiGiris_Load(object sender, EventArgs e)
        {
           
        }

          private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //satıcıları veritabanına ekleme
      
            if (textBox5.Text == "" || textBox6.Text == "" || textBox5.Text != textBox6.Text)
            {
                MessageBox.Show("Şifreler Farklı. Lütfen Tekrar Deneyiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox5.Text = "";
                textBox6.Text = "";
            }
            else
            {
                komut = new OleDbCommand("INSERT INTO Satici (Firma_Adi,Telefon,Satici_Adres,Eposta,Parola) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Oldunuz!");

            }
            baglanti.Close();
      

        }

        private void ekle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string i in openFileDialog1.FileName.Split('\\'))
                {
                    if (i.Contains(".jpg")) { DosyaAdi = i; }
                    else if (i.Contains(".bmp")) { DosyaAdi = i; }
                    else if (i.Contains(".png")) { DosyaAdi = i; }
                    else if (i.Contains(".gif")) { DosyaAdi = i; }
                    else { DosyaYolu += i + "\\"; }
                }
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }

            else
            {
                MessageBox.Show("Herhangibir Resim Girilmedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
