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
    public partial class Sepet : UserControl
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=SecBegen.accdb");
        OleDbDataAdapter da;
        OleDbCommand komut;
        OleDbCommand komut2;
        int kullanici_id;
        Button btn = new Button();


        public Sepet()
        {
            InitializeComponent();
        }
        public void sepetimiGoster(int kullanici_id)
        {
            this.kullanici_id = kullanici_id;

            urunler.Clear();
            sepetListeEkle();
            flowLayoutDoldur();

            this.BringToFront();
        }

        List<Sepettekiler> sepettekiler = new List<Sepettekiler>();
        Urun urun = new Urun();
        List<Urun> urunler = new List<Urun>();//ürünlerin ekleneceği liste
        Sepettekiler se;


        public void sepetListeEkle()
        {
            baglanti.Open();  //Bağlantı Açıldı
            string sorgu = "Select * from Sepetim where Kullanici_id=" + kullanici_id;//bu sınıfa kullancıı id yi göndermen lazım giriş yaptıktan sonra falan gönderecez her yere
            da = new OleDbDataAdapter(sorgu, baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);

            foreach (DataRow row in tablo.Rows)//tablo satırları gezilir
            {
                se = new Sepettekiler();
                se.Kullanici_id = int.Parse(row["Kullanici_id"].ToString());
                se.Satici_id = int.Parse(row["Satici_id"].ToString());
                se.Urun_id = int.Parse(row["Urun_id"].ToString());
                se.Cinsiyet_kat = int.Parse(row["CinsiyetKategori"].ToString());

                string sorgu2 = kategoriyeGoreUrunSorgusu(int.Parse(row["CinsiyetKategori"].ToString()), int.Parse(row["Urun_id"].ToString()));
                urunOlustur(sorgu2);



            }

            //döngü bitince ,yani bütün üreünelri listeye ekleyince
            if (urunler.Count == 0)
            {
                MessageBox.Show("Sepet Boş, Git Bişeyler Al Kanke");
                btn.Hide();
            }
            else
            {
                se.urunler = urunler;

            }
            //sepetteki ürünler listemizi   burada oluşturduğumuz ürünler listei ile değiştirdik şuan sepette ürünlerin hepsi bulunuyo

            baglanti.Close();//unutma şunu


            //başka bişi kalmadı sanırım flowlayouta falan aktaracan sırada
        }

        public void urunOlustur(string sorgu)
        {

            //ürünü listeye eklicez burda

            // baglanti.Open();  //Bağlantı Açıldı

            da = new OleDbDataAdapter(sorgu, baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);

            foreach (DataRow row in tablo.Rows)//tablo satırları gezilir
            {
                urun = new Urun();
                urun.aciklama = row["Aciklama"].ToString();
                urun.renk = int.Parse(row["Renk"].ToString());
                urun.beden = int.Parse(row["Beden"].ToString());
                urun.fiyat = int.Parse(row["Fiyat"].ToString());
                urun.resim_url = row["Resim_URL"].ToString();
                urun.satici_id = int.Parse(row["Satici_id"].ToString());
                urun.urun_adi = row["Urun_Adi"].ToString();




                urunler.Add(urun);//urunler listesine ürünü ekledik bu olay her sorguda çalışacak sepetteki her ürün listeye ekelencek

            }


            //  baglanti.Close();//unutma şunu
            //bulamadım hata bi parametre eksik ya da tabloda dolu değil bi daha bakam

        }


        public string kategoriyeGoreUrunSorgusu(int cinsiyetKategori, int urun_id)
        {
            //sorguyu ayarlıcaaz
            string sorgu2 = "";

            if (cinsiyetKategori == 1)
                sorgu2 = "Select * from Kadin_Urun where Kadin_Urun_id=" + urun_id;//tablonun adı kadin_urun idi sanırım emin değilim bakarsın
            else if (cinsiyetKategori == 2)
                sorgu2 = "Select * from Erkek_Urun where Erkek_Urun_id=" + urun_id;//anladın mı hatayı diğerlerini de düzeltirsin sonra deneyek şimdi?Evet

            else if (cinsiyetKategori == 3)
                sorgu2 = "Select * from Kadin_Genc_Urun where Kadin_Genc_Urun_id=" + urun_id;
            else if (cinsiyetKategori == 4)
                sorgu2 = "Select * from Erkek_Genc_Urun where Erkek_Genc_Urun_id=" + urun_id;

            else if (cinsiyetKategori == 5)
                sorgu2 = "Select * from Kadin_Cocuk_Urun where Kadin_Cocuk_Urun_id=" + urun_id;
            else if (cinsiyetKategori == 6)
                sorgu2 = "Select * from Erkek_Cocuk_Urun where Erkek_Cocuk_Urun_id=" + urun_id;

            else if (cinsiyetKategori == 7)
                sorgu2 = "Select * from Kadin_Bebek_Urun where Kadin_Bebek_Urun_id=" + urun_id;
            else if (cinsiyetKategori == 8)
                sorgu2 = "Select * from Erkek_Bebek_Urun where Erkek_Bebek_Urun_id=" + urun_id;

            //bu şekilde 8 tane sorgu olcak birini döndürcek


            return sorgu2;
        }



        public void flowLayoutDoldur()
        {

            flowLayoutPanel1.Controls.Clear();
            //  flowLayoutPanel2.Controls.Clear();

            PictureBox[] img = new PictureBox[urunler.Count];
            Label[] lbl = new Label[urunler.Count];
            Label[] lbl2 = new Label[urunler.Count];
            FlowLayoutPanel[] panel = new FlowLayoutPanel[urunler.Count];

            //gerisini panllerle falan ekelterk yaparsın burda 
            //tamam
            //bye


            for (int i = 0; i < urunler.Count; i++)
            {

                panel[i] = new FlowLayoutPanel();
                panel[i].Size = new Size(1400, 200);
                panel[i].BackColor = Color.Red;

                lbl[i] = new Label();
                lbl[i].Size = new Size(300, 50);
                lbl[i].Text = urunler[i].urun_adi;


                lbl2[i] = new Label();
                lbl2[i].Size = new Size(300, 50);
                lbl2[i].Text = urunler[i].aciklama;

                img[i] = new PictureBox();
                img[i].Size = new Size(300, 50);
                img[i].BackgroundImageLayout = ImageLayout.Stretch;

                var margin = img[i].Margin;
                margin.Left = 20;
                margin.Top = 20;
                img[i].Margin = margin;
                lbl[i].Margin = margin;

                panel[i].Controls.Add(img[i]);
                panel[i].Controls.Add(lbl[i]);
                panel[i].Controls.Add(lbl2[i]);

                flowLayoutPanel1.Controls.Add(panel[i]);
            }
            var mrg = btn.Margin;
            mrg.Left = 1250;
            btn.Width = 100;
            btn.Height = 50;
            btn.Margin = mrg;
            btn.BackColor = Color.Pink;
            btn.Text = "Onayla";
            btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            flowLayoutPanel1.Controls.Add(btn);

        }
        DateTime bugun = DateTime.Now;

        public void btn_MouseClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            baglanti.Open();  //Bağlantı Açıldı
            string sorgu = "Insert into Siparis (Satici_id,Kullanici_id,Urun_Turu,Urun_id,Siparis_Tarih) Values ('" + se.Satici_id + "','" + se.Kullanici_id + "'," + 1 + ",'" + se.Urun_id + "','" + bugun + "')";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            string sorgu2 = "Delete from Sepetim where  kullanici_id=" + kullanici_id;
            komut2 = new OleDbCommand(sorgu2, baglanti);

            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Onaylandı");

            sepetimiGoster(kullanici_id);


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sepet_Load(object sender, EventArgs e)
        {

        }



    }
}
