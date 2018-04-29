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
    public partial class Urunler : UserControl
    {
        //database kısımları
        OleDbConnection baglanti;
        OleDbDataAdapter da;
        string sqlsorgu = "";
        List<Urun> urunler = new List<Urun>();
        
        public Urunler()
        {
            InitializeComponent();
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }


        public void butonaTiklayinca(int cinsiyetKategori) {

            if (cinsiyetKategori == 1)
                sqlsorgu = "Select * From Kadin_Urun";
            if (cinsiyetKategori == 2)
                sqlsorgu = "Select * From Erkek_Urun";



            kategoriyeGoreUrunSorgula(cinsiyetKategori);
        }





        private void panel_MouseClick( object sender, EventArgs e)
        {

            FlowLayoutPanel panel = sender as FlowLayoutPanel;

            //panel.BackColor = System.Drawing.Color.Black;
            

        }


        private void label_MouseClick(object sender, EventArgs e)
        {
            Label lbl = sender as Label;

            urunDetay2.urunyerlestir(lbl);

        }

        private void label_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;


            urunDetay2.urunyerlestir(lbl);




        }



        private void image_MouseClick(object sender, EventArgs e)
        {

            PictureBox img = sender as PictureBox;
            Form1 form = new Form1();
            form.urungetir();
        }

        public void kategoriyeGoreUrunGetir(int cinsiyetKategori, int kategoriID)
        {


            if (cinsiyetKategori == 1)
                   sqlsorgu="Select * from Kadin_Urun where Kategori="+kategoriID;
            if (cinsiyetKategori == 2)
                   sqlsorgu = "Select * from Erkek_Urun where where Kategori_id=" + kategoriID;


            kategoriyeGoreUrunSorgula(cinsiyetKategori);
        }


        public void kategoriyeGoreUrunSorgula(int cinsiyetKategori){
            //urunler listesini doldurmak için
            urunler.Clear();

            Urun urun;

            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=SecBegen.accdb");
            baglanti.Open();
            
            da = new OleDbDataAdapter(sqlsorgu, baglanti);
            

            DataTable tablo = new DataTable();
            da.Fill(tablo);
            foreach (DataRow row in tablo.Rows)
            {
                urun=new Urun();
                 urun.cinsiyetKategori = cinsiyetKategori;
                 urun.urun_adi=(row["Urun_Adi"].ToString());
                 urun.beden=(row["Beden"].ToString());
                 urun.aciklama = (row["Aciklama"].ToString());
                 urun.renk = (int.Parse(row["Renk"].ToString()));
                 urun.fiyat= (int.Parse(row["Fiyat"].ToString()));
                 urun.resim_url = (int.Parse(row["Resim_URL"].ToString()));
                 urun.satici_id = (int.Parse(row["Satici_id"].ToString()));
                 urun.kategori = (int.Parse(row["Kategori"].ToString()));
                if(cinsiyetKategori==1)
                 urun.id = (int.Parse(row["Kadin_Urun_id"].ToString()));
                else if (cinsiyetKategori == 1)
                    urun.id = (int.Parse(row["Erkek_Urun_id"].ToString()));
                else if (cinsiyetKategori == 2)
                    urun.id = (int.Parse(row["Unisex_Urun_id"].ToString()));
                else if (cinsiyetKategori == 3)
                    urun.id = (int.Parse(row["Kadin_Genc_Urun_id"].ToString()));
                else if (cinsiyetKategori == 4)
                    urun.id = (int.Parse(row["Erkek_Genc_Urun_id"].ToString()));
                else if (cinsiyetKategori == 5)
                    urun.id = (int.Parse(row["Unisex_Genc_Urun_id"].ToString()));
                else if (cinsiyetKategori == 6)
                    urun.id = (int.Parse(row["Kadin_Cocuk_Urun_id"].ToString()));
                else if (cinsiyetKategori == 7)
                    urun.id = (int.Parse(row["Erkek_Cocuk_Urun_id"].ToString()));
                else if (cinsiyetKategori == 9)
                    urun.id = (int.Parse(row["Unisex_Cocuk_Urun_id"].ToString()));
                else if (cinsiyetKategori == 10)
                    urun.id = (int.Parse(row["Kadin_Bebek_Urun_id"].ToString()));
                else if (cinsiyetKategori == 11)
                    urun.id = (int.Parse(row["Erkek_Bebek_Urun_id"].ToString()));
                else if (cinsiyetKategori == 12)
                    urun.id = (int.Parse(row["Unisex_Bebek_Urun_id"].ToString()));
       /*cinsiyet kategori için  
       Kadın 1 
       Erkek 2
       unisex 3
        * genç kadın 4
        * genç erkek 5
         genç unisex 6
        * çocuk kadın 7
        * çocuk erkek 8
        * çocuk unisex 9
        * bebek kadın 10
        * bebek erkek 11
        * bebek unisex 12 
        */
               
                urunler.Add(urun);


            }
            baglanti.Close();

            urunleriGoruntule();
        
        }

        public void urunleriGoruntule() {

            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel1.Controls.Clear();

            CheckBox[] box = new CheckBox[10];
            for (int i = 0; i < 10; i++)
            {
                box[i] = new CheckBox();
                box[i].Text = "Btuuın" + i;
                box[i].Size = new Size(80, 30);
                box[i].Name = "buton1";

                flowLayoutPanel1.Controls.Add(box[i]);

            }



            PictureBox[] img = new PictureBox[10];
            Label[] lbl = new Label[10];
            FlowLayoutPanel[] panel = new FlowLayoutPanel[10];
            for (int i = 0; i < urunler.Count; i++)
            {
                
                //iç paneli oluşturma resim ve label koymak için
                panel[i] = new FlowLayoutPanel();
                panel[i].Size = new Size(300, 500);


                // label oluşturma
                lbl[i] = new Label();
                lbl[i].Size = new Size(300, 50);
                lbl[i].Text = urunler[i].urun_adi;


                //resim oluşturma
                img[i] = new PictureBox();
                img[i].Size = new Size(300, 400);
                //  img[i].BackgroundImage = Image.FromFile("kediler.jpg");
                img[i].BackgroundImageLayout = ImageLayout.Stretch;




                //resim ve label için margin ver (20px soldan 20px yukarıdan)
                var margin = img[i].Margin;
                margin.Left = 20;
                margin.Top = 20;
                img[i].Margin = margin;
                lbl[i].Margin = margin;


                //resim ve label ı iç panele ekleme
                panel[i].Controls.Add(img[i]);
                panel[i].Controls.Add(lbl[i]);


                lbl[i].MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseClick);
                // lbl[i].Click += new System.EventHandler(this.label_Click);
                img[i].MouseClick += new System.Windows.Forms.MouseEventHandler(this.image_MouseClick);
                panel[i].MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);

                //iç paneli ana panel içine ekleme
                flowLayoutPanel2.Controls.Add(panel[i]);

            }
            this.BringToFront();
            panel2.BringToFront();
            
        
        
        }



    }
}
