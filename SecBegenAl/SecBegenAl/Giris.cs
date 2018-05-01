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
    public partial class Giris : UserControl
    {
        public Giris()
        {
            InitializeComponent();
        }
        OleDbCommand komut;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=SecBegen.accdb");
        OleDbDataAdapter da;

        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Satici satici=new Satici();


            baglanti.Open();
            string ad = textBox1.Text;
            string sifre = textBox2.Text;
            OleDbCommand kaydetcmd = new OleDbCommand("SELECT * From Satici WHERE Firma_Adi = '" + textBox1.Text + "' AND Parola = '" + textBox2.Text + "'", baglanti);

            OleDbDataReader oku = kaydetcmd.ExecuteReader();
            if (oku.Read())
            {
             
                this.Hide();

                da = new OleDbDataAdapter("SELECT * From Satici WHERE Firma_Adi = '" + textBox1.Text + "' AND Parola = '" + textBox2.Text + "'", baglanti);


                DataTable tablo = new DataTable();
                da.Fill(tablo);
                foreach (DataRow row in tablo.Rows)
                {

                    satici.firma_adi = row["Firma_Adi"].ToString();
                    satici.eposta = row["Eposta"].ToString();
                    satici.telefon = row["Telefon"].ToString();
                    satici.parola = row["Parola"].ToString();
                    satici.satici_id = int.Parse(row["Satici_id"].ToString());
                    satici.dosyaadi = row["dosyaAdi"].ToString();
                    satici.adres = row["Satici_Adres"].ToString();

                    

                }







                    Form1 form1 = new Form1();
                form1.saticiGirisYapildi(satici);


                this.ParentForm.Hide();
                form1.Show();


                MessageBox.Show("Girisyapıldı");
              
                    }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı Alanı Boş Bırakılamaz", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Parola Alanı Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Parola Yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
