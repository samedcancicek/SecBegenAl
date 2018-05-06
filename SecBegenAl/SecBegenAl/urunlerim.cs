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
using System.IO;


namespace SecBegenAl
{
    public partial class urunlerim : UserControl
    {
        public urunlerim()
        {
            InitializeComponent();

        }
        OleDbCommand komut;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=SecBegen.accdb");
        OleDbDataAdapter da;
        int satici_id;
        string sorgu = "";
        public void urunlerimigoster(int satici_id)
        {
            this.satici_id = satici_id;
                        urunler.Clear();

            for (int i = 1; i <= 8; i++)
            {
                sorgu = "";

                if (i == 1)
                    sorgu = " Select * from Kadin_Urun where Satici_id = " + satici_id;

                if (i == 2)
                    sorgu = "Select * from Erkek_Urun where Satici_id=" + satici_id;

                if (i == 3)

                    sorgu = "Select * from Kadin_Genc_Urun where Satici_id=" + satici_id;

                if (i == 4)
                    sorgu = "Select * from Erkek_Genc_Urun where Satici_id=" + satici_id;

                if (i == 5)
                    sorgu = "Select * from Kadin_Cocuk_Urun where Satici_id=" + satici_id;

                if (i == 6)
                    sorgu = "Select * from Erkek_Cocuk_Urun where Satici_id=" + satici_id;

                if (i == 7)
                    sorgu = "Select * from Kadin_Bebek_Urun where Satici_id=" + satici_id;

                if (i == 8)
                    sorgu = "Select * from Erkek_Bebek_Urun where Satici_id=" + satici_id;

                urunListeEkle(sorgu);
               // urunOlustur(sorgu);
            }
            flowLayoutDoldur();

            this.BringToFront();

        }


        Urun urun = new Urun();
        List<Urun> urunler = new List<Urun>();
        Urun ur;

        public void urunListeEkle(string Sorgu)
        {
            baglanti.Open();


                da = new OleDbDataAdapter(sorgu, baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);

                foreach (DataRow row in tablo.Rows)
                {
                    ur = new Urun();

                    ur.aciklama = row["Aciklama"].ToString();
                    ur.renk = row["Renk"].ToString();
                    ur.fiyat = int.Parse(row["Fiyat"].ToString());
                    ur.resim_url = row["Resim_URL"].ToString();
                    ur.satici_id = int.Parse(row["Satici_id"].ToString());
                    ur.urun_adi = row["Urun_Adi"].ToString();
                    ur.kategori = int.Parse(row["Kategori"].ToString());
                    // ur.cinsiyetKategori = int.Parse(row["Alt_Kategori"].ToString());///hiç bi ürün tablosunda cinsiyetkategori yok
                    // ur.beden = int.Parse(row["Beden"].ToString());


                    //string sorgu2 = kategoriyeGoreUrunSorgusu(int.Parse(row["Alt_kategori"].ToString()), int.Parse(row["Satici_id"].ToString()));///olmadığı için alt kategori gönderdim ???

                    //urunOlustur(sorgu2);

                    urunler.Add(ur);

                }
                baglanti.Close();

            }

        
        public string kategoriyeGoreUrunSorgusu(int cinsiyetKategori, int satici_id)
        {

            string sorgu2 = "";

            if (cinsiyetKategori == 1)
                sorgu2 = "Select * from Kadin_Urun where Satici_id=" + satici_id;
            else if (cinsiyetKategori == 2)
                sorgu2 = "Select * from Erkek_Urun where Satici_id=" + satici_id;

            else if (cinsiyetKategori == 3)
                sorgu2 = "Select * from Kadin_Genc_Urun where Satici_id=" + satici_id;
            else if (cinsiyetKategori == 4)
                sorgu2 = "Select * from Erkek_Genc_Urun where Satici_id=" + satici_id;

            else if (cinsiyetKategori == 5)
                sorgu2 = "Select * from Kadin_Cocuk_Urun where Satici_id=" + satici_id;
            else if (cinsiyetKategori == 6)
                sorgu2 = "Select * from Erkek_Cocuk_Urun where Satici_id=" + satici_id;

            else if (cinsiyetKategori == 7)
                sorgu2 = "Select * from Kadin_Bebek_Urun where Satici_id=" + satici_id;
            else if (cinsiyetKategori == 8)
                sorgu2 = "Select * from Erkek_Bebek_Urun where Satici_id=" + satici_id;


            return sorgu2;
        }
        public void flowLayoutDoldur()
        {

            flowLayoutPanel1.Controls.Clear();


            PictureBox[] img = new PictureBox[urunler.Count];
            Label[] lbl = new Label[urunler.Count];
            Label[] lbl2 = new Label[urunler.Count];
            FlowLayoutPanel[] panel = new FlowLayoutPanel[urunler.Count];


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
            Button btn = new Button();
            var mrg = btn.Margin;
            mrg.Left = 1250;
            btn.Width = 100;
            btn.Height = 50;
            btn.Margin = mrg;
            btn.BackColor = Color.Pink;
            btn.Text = "Onayla";
            flowLayoutPanel1.Controls.Add(btn);

        }
        //public void urunOlustur(string sorgu)
        //{
        //    baglanti.Open();
        //    da = new OleDbDataAdapter(sorgu, baglanti);
        //    DataTable tablo = new DataTable();
        //    da.Fill(tablo);

        //    foreach (DataRow row in tablo.Rows)
        //    {
        //        urun = new Urun();
        //        urun.aciklama = row["Aciklama"].ToString();
        //        urun.renk = row["Renk"].ToString();
        //      //  urun.beden = int.Parse(row["Beden"].ToString());
        //        urun.fiyat = int.Parse(row["Fiyat"].ToString());
        //        urun.resim_url = row["Resim_URL"].ToString();
        //        urun.satici_id = int.Parse(row["Satici_id"].ToString());
        //        urun.urun_adi = row["Urun_Adi"].ToString();

        //        urunler.Add(urun);
        //    }
        //    baglanti.Close();

        //}



        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void bringtofront()
        {

            this.BringToFront();

        }


        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
