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


//ürün kategor ve alt kategori yapılacak sorguya eklenecek
//urun_id yapılacak
//satıcı id  satıcıya göre değişecek

namespace SecBegenAl
{
    public partial class UrunEkle : UserControl
    {
        OleDbConnection baglanti=new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=SecBegen.accdb");
        OleDbDataAdapter da;
        OleDbCommand komut;
        
        List<CheckBox> CBler=new List<CheckBox>();
        List<int> eklenecekBedenCBler = new List<int>();
        
        int cinsiyetKategori;
        int urun_id=1;

        public UrunEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void urunEkleSayfaAc() {

            CBekle();
            this.BringToFront();
        
        }

      
        

        private void button16_Click(object sender, EventArgs e)
        {
            
            urunVeriTabaninaEkle();
            BedenVeritabaninaEkle(urun_id, cinsiyetKontrol());
            MessageBox.Show("Ürününüz Eklenmiştir");
        }




        public void urunVeriTabaninaEkle()
        {

            baglanti.Open();

            komut = new OleDbCommand(sorguDuzenle(), baglanti);

            komut.ExecuteNonQuery();

            baglanti.Close();


        }



        public void BedenVeritabaninaEkle(int urun_id,int cinsiyetKategori) {
            bedenCbKontrol();

            baglanti.Open();

            



            for (int i = 0; i < eklenecekBedenCBler.Count;i++)
            {
                string sorgu="Insert into Beden_Urun_AraTablo (Beden_id,Urun_id,CinsiyetKategori) values (" + eklenecekBedenCBler[i] + "," + urun_id + "," + cinsiyetKategori + ")";
                
                komut = new OleDbCommand(sorgu, baglanti);

                komut.ExecuteNonQuery();

            }
            baglanti.Close();
        
        }


        public void bedenCbKontrol()
        {
            eklenecekBedenCBler.Clear();
            if (checkBox1.Checked) eklenecekBedenCBler.Add(1);
            if (checkBox2.Checked) eklenecekBedenCBler.Add(2);
            if (checkBox3.Checked) eklenecekBedenCBler.Add(3);
            if (checkBox4.Checked) eklenecekBedenCBler.Add(4);
            if (checkBox5.Checked) eklenecekBedenCBler.Add(5);
            if (checkBox6.Checked) eklenecekBedenCBler.Add(6);
            if (checkBox7.Checked) eklenecekBedenCBler.Add(7);
            if (checkBox8.Checked) eklenecekBedenCBler.Add(8);
            if (checkBox9.Checked) eklenecekBedenCBler.Add(9);
            if (checkBox10.Checked) eklenecekBedenCBler.Add(10);
            if (checkBox11.Checked) eklenecekBedenCBler.Add(11);
            if (checkBox12.Checked) eklenecekBedenCBler.Add(12);
            if (checkBox13.Checked) eklenecekBedenCBler.Add(13);
            if (checkBox14.Checked) eklenecekBedenCBler.Add(14);
            if (checkBox15.Checked) eklenecekBedenCBler.Add(15);
            if (checkBox16.Checked) eklenecekBedenCBler.Add(16);
            if (checkBox17.Checked) eklenecekBedenCBler.Add(17);
            if (checkBox18.Checked) eklenecekBedenCBler.Add(18);
            if (checkBox19.Checked) eklenecekBedenCBler.Add(19);
            if (checkBox20.Checked) eklenecekBedenCBler.Add(20);
            if (checkBox21.Checked) eklenecekBedenCBler.Add(21);
            if (checkBox22.Checked) eklenecekBedenCBler.Add(22);
            if (checkBox23.Checked) eklenecekBedenCBler.Add(23);
            if (checkBox24.Checked) eklenecekBedenCBler.Add(24);
            if (checkBox25.Checked) eklenecekBedenCBler.Add(25);
            if (checkBox26.Checked) eklenecekBedenCBler.Add(26);
            if (checkBox27.Checked) eklenecekBedenCBler.Add(27);
            if (checkBox28.Checked) eklenecekBedenCBler.Add(28);
            if (checkBox29.Checked) eklenecekBedenCBler.Add(29);
            if (checkBox30.Checked) eklenecekBedenCBler.Add(30);
            if (checkBox31.Checked) eklenecekBedenCBler.Add(31);
            if (checkBox32.Checked) eklenecekBedenCBler.Add(32);
            if (checkBox33.Checked) eklenecekBedenCBler.Add(33);
            if (checkBox34.Checked) eklenecekBedenCBler.Add(34);
            if (checkBox35.Checked) eklenecekBedenCBler.Add(35);
            if (checkBox36.Checked) eklenecekBedenCBler.Add(36);
            if (checkBox37.Checked) eklenecekBedenCBler.Add(37);
            if (checkBox38.Checked) eklenecekBedenCBler.Add(38);
            if (checkBox39.Checked) eklenecekBedenCBler.Add(39);
            if (checkBox40.Checked) eklenecekBedenCBler.Add(40);
            if (checkBox41.Checked) eklenecekBedenCBler.Add(41);
            if (checkBox42.Checked) eklenecekBedenCBler.Add(42);
            if (checkBox43.Checked) eklenecekBedenCBler.Add(43);
            if (checkBox44.Checked) eklenecekBedenCBler.Add(44);
            if (checkBox45.Checked) eklenecekBedenCBler.Add(45);





        }

        public void CBekle()
        {
            CBler.Clear();
            CBler.Add(checkBox1);
            CBler.Add(checkBox2);
            CBler.Add(checkBox3);
            CBler.Add(checkBox4);
            CBler.Add(checkBox5);
            CBler.Add(checkBox6);
            CBler.Add(checkBox7);
            CBler.Add(checkBox8);
            CBler.Add(checkBox9);
            CBler.Add(checkBox10);
            CBler.Add(checkBox11);
            CBler.Add(checkBox12);
            CBler.Add(checkBox13);
            CBler.Add(checkBox14);
            CBler.Add(checkBox15);
            CBler.Add(checkBox16);
            CBler.Add(checkBox17);
            CBler.Add(checkBox18);
            CBler.Add(checkBox19);
            CBler.Add(checkBox20);
            CBler.Add(checkBox21);
            CBler.Add(checkBox22);
            CBler.Add(checkBox23);
            CBler.Add(checkBox24);
            CBler.Add(checkBox25);
            CBler.Add(checkBox26);
            CBler.Add(checkBox27);
            CBler.Add(checkBox28);
            CBler.Add(checkBox29);
            CBler.Add(checkBox30);
            CBler.Add(checkBox31);
            CBler.Add(checkBox32);
            CBler.Add(checkBox33);
            CBler.Add(checkBox34);
            CBler.Add(checkBox35);
            CBler.Add(checkBox36);
            CBler.Add(checkBox37);
            CBler.Add(checkBox38);
            CBler.Add(checkBox39);
            CBler.Add(checkBox40);
            CBler.Add(checkBox41);
            CBler.Add(checkBox42);
            CBler.Add(checkBox43);
            CBler.Add(checkBox44);
            CBler.Add(checkBox45);

            
            baglanti.Open();
            
            da = new OleDbDataAdapter("Select Beden From Beden", baglanti);
            
            int i=0;
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            foreach (DataRow row in tablo.Rows)
            {

                CBler[i].Text = (row["Beden"].ToString());

                i++;
            }
            baglanti.Close();

        }

        public int cinsiyetKontrol()
        {
            int cinsiyet=0;
            if (kadinCB.Checked)
                cinsiyet=1;//kadın
            if (erkekCB.Checked)
                cinsiyet=2;//erkek
            if (erkekCB.Checked && kadinCB.Checked)
                cinsiyet = 3;//unisex

            return cinsiyet;
        }

        public int yasGrubuKontrol()
        {
            int yas = 0;
            if (yetiskinCB.Checked)
                yas = 1;//yetişkin
            else if (gencCB.Checked)
                yas = 2;//genç
            else if (cocukCB.Checked)
                yas = 3;//çocuk
            else
                yas = 4;//bebek

            return yas;
        }

        public string sorguDuzenle()
        {
            string cinsiyet = "";
            string yasGrubu = "";
            string tabloAdi = "";


            if (cinsiyetKontrol() == 1)
                cinsiyet = "Kadin";
            else if (cinsiyetKontrol() == 1)
                cinsiyet = "Erkek";
            else
                cinsiyet = "Unisex";

            if (yasGrubuKontrol() == 1)
                yasGrubu = "";
            else if (yasGrubuKontrol() == 2)
                yasGrubu = "_Genc";
            else if (yasGrubuKontrol() == 3)
                yasGrubu = "_Cocuk";
            else
                yasGrubu = "_Bebek";

            tabloAdi = cinsiyet + yasGrubu;

            


            string sorgu = "Insert into "+tabloAdi+"_Urun (Aciklama,Renk,Fiyat,Resim_URL,Satici_id,Urun_Adi,Kategori,Alt_Kategori) values ('"+aciklamaTextBox.Text+"','"+"renk"+"',"+int.Parse(fiyatTextBox.Text)+",'"+"resım"+"',"+3+",'"+urunAdiTextBox.Text+"',"+urunTipiComboBox.SelectedIndex+","+urunKategoriComboBox.SelectedIndex+")";

            return sorgu;
        }


    }
}
