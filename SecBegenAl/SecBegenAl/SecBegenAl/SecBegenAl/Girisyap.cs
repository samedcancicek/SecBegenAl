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
    
    public partial class Girisyap : UserControl
    {
        OleDbConnection baglanti  = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=SecBegen.accdb");
        OleDbDataAdapter da;
        kullanici ham;
        public int a = 0;

        public Girisyap()
        {
            InitializeComponent();
        }

        public void start()
        {
            this.BringToFront();
        }
        private void Emailal_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.kayitGoruntule();
            form.Show();
            this.ParentForm.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Giriş Yapılma
        {
            int a = 0;
        
              baglanti.Open();  //Bağlantı Açıldı
              string sorgu ="Select * from Kullanici ";  //Bütün kullanıcıları gezmesi için sorgu
              da = new OleDbDataAdapter(sorgu, baglanti); 
              DataTable tablo = new DataTable();
              da.Fill(tablo);
              foreach (DataRow row in tablo.Rows)//tablo satırları gezilir
              {
                 
                  if (textBox1.Text==(row["Eposta"].ToString()) && textBox3.Text==(row["Parola"].ToString()))
                  {
                    Form1 f = new Form1();
                    f.Show();
                    f.girisYapti(int.Parse(row["Kullanici_id"].ToString()));
                    this.ParentForm.Hide();
                    a = 1;


                    ham = new kullanici();
                    ham.Eposta = (row["Eposta"].ToString());
                    ham.Parola = (row["Parola"].ToString());
                    ham.Ad = (row["Ad"].ToString());
                    ham.Soyad = (row["Soyad"].ToString());
                    ham.Telefon = (row["Telefon"].ToString());
                    ham.Adres = (int.Parse(row["Adres"].ToString()));
                    ham.DogumTarihi = (row["DogumTarihi"].ToString());
                }
                      
              }
            if (a==0)
            {
                
                MessageBox.Show("Giriş Başarısız");
                
                
            }
              baglanti.Close();
              
        }
    }
}
