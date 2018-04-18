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
    public partial class CategoryMenu : UserControl
    {

        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter da;
        string[] listeEleman= new string[30];
        List<string> kategori=new List<string>();

        
        public CategoryMenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CategoryMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void CategoryMenu_MouseHover(object sender, EventArgs e)
        {
            
        }

        
        public void menugoster(int KategoriNumarasi) {
            
            menuListele(KategoriNumarasi);

            labelOlustur();

            this.Show();
            this.BringToFront();
           

        }

        
        bool tutenter = false;
        private void panel1_MouseLeave(object sender, EventArgs e)
        {
           /* if (tutenter)
            {
                tutenter = false;
                this.Hide();
            }*/
        
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            this.Hide();
        }



        public void menuListele(int KategoriNumarasi) { 
         
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=SecBegen.accdb");
            baglanti.Open();
            if (KategoriNumarasi==1)
                da = new OleDbDataAdapter("Select * From Kadin_Kategori", baglanti);
            else if(KategoriNumarasi==2)
                da = new OleDbDataAdapter("Select * From Kadin_Kategori", baglanti);
            else if(KategoriNumarasi==3)
                da = new OleDbDataAdapter("Select * From Kadin_Kategori", baglanti);
            else
                da = new OleDbDataAdapter("Select * From Kadin_Kategori", baglanti);


            
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            foreach (DataRow row in tablo.Rows)
            {
                kategori.Add(row["Kategori_Adi"].ToString());

            }
            baglanti.Close();
            
             
        
        }



        public void labelOlustur() {
            flowLayoutPanel1.Controls.Clear();
            Label[] lbl = new Label[kategori.Count];
            for (int i = 0; i < kategori.Count; i++)
            {

                lbl[i] = new Label();
                lbl[i].Size = new Size(300, 50);
                lbl[i].Text = kategori[i];
                lbl[i].MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseClick);

                flowLayoutPanel1.Controls.Add(lbl[i]);

            }
        
        
        }

        
        private void label_MouseClick(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            
            if (lbl.Text.Equals("Elbise"))
            {
                Form1 f = new Form1();
                f.Show();
                f.urunleriGoster(1,1);
                this.ParentForm.Hide();
            }
                
                


        }


    }
}
