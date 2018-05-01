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

namespace SecBegenAl
{
    public partial class KayitOl : UserControl
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=SecBegen.accdb");
        OleDbCommand komut;
       public  string[] aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
  
        public int ay;
        public string tarih;
        public void comboboxDoldur()//comboBoxları doldurdum
        {
            
            DateTime buGun = DateTime.Today;
            for (int i = 1; i <= 31; i++)
            {
                comboBox1.Items.Add(" " + i);
            }

            for (int i = 0; i < aylar.Length; i++)
            {
                comboBox2.Items.Add(" " + aylar[i]);
            }
            for (int i = buGun.Year; i >= 1936; i--)
            {
                comboBox3.Items.Add(" " + i);
            }
        }
        public   void Dtarih() //Doğum tarihini birleştirdim
        {
            for (int i = 0; i < aylar.Length; i++)
            {
                if (comboBox2.Text == aylar[i])
                {
                    ay = i + 1;
                    break;
                }
            }
           
            tarih = (comboBox1.Text + "." + ay + "." + comboBox3.Text);
        }

        public KayitOl()
        {
            InitializeComponent();
        }
        public void start()
        {
            this.BringToFront();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (ad.Text != "" && soyad.Text != "" && email.Text != "" && sifre.Text != "" && sifretekrar.Text != "" && telefon.Text != "" && sözlesme.Checked!= false ) 
            {
                MessageBox.Show(comboBox1.Text);
                if (sifre.Text == sifretekrar.Text)
                {
                    baglanti.Open();  //Bağlantı Açıldı
                    string sorgu = "Insert into Kullanici (Eposta,Parola,Ad,Soyad,Telefon,Adres,DogumTarihi) Values ('" + email.Text + "','" + sifre.Text + "','" + ad.Text + "','" + soyad.Text + "','" + telefon.Text + "'," + 1 + ",'"+tarih+"')";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Tamamlandı!");
                }
                else
                {
                    MessageBox.Show("Şifrenizi aynı girmediniz.");
                }

            }
            else
            {
                MessageBox.Show("Boş alan geçmeyiniz!");
            }
        }

        private void KayitOl_Load(object sender, EventArgs e)//Kayıt olma sayfası yüklenirken
        {
            comboboxDoldur();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
