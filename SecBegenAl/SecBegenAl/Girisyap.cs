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
        OleDbCommand komut;
        OleDbDataAdapter da;
        OleDbDataReader datare;
        DataSet set = new DataSet();
        string sqlsorgu="";
       
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

        private void button1_Click(object sender, EventArgs e)
        {
            /*  baglanti.Open();
              string sorgu ="Select * from Kullanici ";
              da = new OleDbDataAdapter(sorgu, baglanti);
              DataTable tablo = new DataTable();
              da.Fill(tablo);
              foreach (DataRow row in tablo.Rows)
              {
                  MessageBox.Show(row["E-posta"].ToString());
                  if (textBox1.Text==(row["E-posta"].ToString()) && textBox3.Text==(row["Parola"].ToString()))
                  {
                      MessageBox.Show("Giriş Başarılı");
                  }


              }
              MessageBox.Show("Giriş Başarısız");
              baglanti.Close();*/

            baglanti.Open();
            komut = new OleDbCommand("select * from Kullanici where E-posta='" + textBox1.Text + "' and sifre='" + textBox3.Text + "'", baglanti);
            datare = komut.ExecuteReader();

            if (datare.Read())
            {
                MessageBox.Show("asdf");
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve ya Şifre Hatalı. Doğru girdiğinizden lütfen emin olunuz.");
            }
            baglanti.Close();
        }
    }
}
