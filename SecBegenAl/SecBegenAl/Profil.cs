using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SecBegenAl
{
    public partial class Profil : UserControl
    {
        OleDbCommand komut;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=SecBegen.accdb");
        OleDbDataAdapter da;
        public Profil()
        {
            InitializeComponent();
        }

        int kullanici_id;
        public void profilGoruntule(int kullanici_id) {
            this.kullanici_id = kullanici_id;
            profillGoruntule();
            this.BringToFront();
            
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void Profil_Load(object sender, EventArgs e)
        {
          
        }

        kullanici ham;
        public void profillGoruntule() {

            baglanti.Open();  //Bağlantı Açıldı
            string sorgu = "Select * from Kullanici where Kullanici_id=" + kullanici_id;
            da = new OleDbDataAdapter(sorgu, baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);

            foreach (DataRow row in tablo.Rows)//tablo satırları gezilir
            {
                ham = new kullanici();
                ham.Eposta = (row["Eposta"].ToString());
                ham.Parola = (row["Parola"].ToString());
                ham.Ad = (row["Ad"].ToString());
                ham.Soyad = (row["Soyad"].ToString());
                ham.Telefon = (row["Telefon"].ToString());
                ham.Adres = (int.Parse(row["Adres"].ToString()));
                ham.DogumTarihi = (row["DogumTarihi"].ToString());


            }

            baglanti.Close();
            verileriYerlestir();


        }


        public void verileriYerlestir() {

           
            textBox1.Text = ham.Ad;
            textBox2.Text = ham.Soyad;
            textBox3.Text = ham.Telefon;
            textBox4.Text = ham.Adres.ToString();
            textBox5.Text = ham.Eposta;
            string a= ham.DogumTarihi;
            string[] tr = a.Split('.');
           
            comboBox1.Text = (tr[0].ToString());
            comboBox2.Text = (tr[1].ToString());
            comboBox3.Text = (tr[2].ToString());
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            düzenle(kullanici_id);
        }
        public void düzenle(int kullanici_id)
        {
            baglanti.Open();
            string tarih = comboBox1.Text + '.' + comboBox2.Text + '.' + comboBox3.Text;
            string sorgu= "Update Kullanici Set Eposta ='"+textBox5.Text+"',Ad = '"+textBox1.Text+"', Soyad ='"+textBox2.Text+"', Telefon = '"+textBox3.Text+"',Adres ='"+textBox4.Text+"',DogumTarihi = '"+tarih+"' Where Kullanici_id=" + kullanici_id;
            komut = new OleDbCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Düzenleme Tamamlandı!");

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
