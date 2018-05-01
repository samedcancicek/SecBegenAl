using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace SecBegenAl
{
    public partial class SaticiBilgiGuncelle : UserControl
    {
        public SaticiBilgiGuncelle()
        {
            InitializeComponent();
        }

        OleDbCommand komut;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=SecBegen.accdb");
        OleDbDataAdapter da;
        string DosyaYolu, DosyaAdi = "";


        Satici satici = new Satici();
        public void saticibilgigüncelle(Satici satici)
        {
            textBox5.Text = satici.firma_adi;
            textBox6.Text = satici.eposta;
            textBox7.Text = satici.telefon;
            textBox8.Text = satici.adres;
            textBox9.Text = satici.parola;
            this.BringToFront();
            this.satici = satici;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SaticiBilgiGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();

            string sorgu = "Update Satici Set Firma_Adi=@firmaadi,Telefon=@telefon,Satici_Adres=@adres,Eposta=@eposta,Parola=@parola Where  Satici_id =" + satici.satici_id + "";
            komut = new OleDbCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@firmaadi", textBox5.Text);
            komut.Parameters.AddWithValue("@telefon", textBox6.Text);
            komut.Parameters.AddWithValue("@adres", textBox7.Text);
            komut.Parameters.AddWithValue("@eposta", textBox8.Text);
            komut.Parameters.AddWithValue("@parola", textBox9.Text);

            MessageBox.Show("Güncelleme Yapıldı");
                                   
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

         private void button1_Click_1(object sender, EventArgs e)
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
                //pictureBox1.ImageLocation = openFileDialog1.FileName;
                //cmd = new OleDbCommand("inser into tablom (ResimAdi,DosyaYolu,DosyaAdi) values ('TEST',"+
                //MessageBox.Show(DosyaAc.FileName.Split(@"\"));
            }
            else
            {
                MessageBox.Show("Herhangibir Resim Girilmedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
     
    }
}
