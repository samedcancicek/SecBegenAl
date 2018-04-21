using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecBegenAl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            mainPage1.BringToFront();
            label1.Visible = false;

        }
        public Form1(int id)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            mainPage1.BringToFront();



        }
        



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KayıtLabel_Click(object sender, EventArgs e)
        {
            kayitOl1.BringToFront();
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
           
                //categoryMenu1.BringToFront();
           // categoryMenu1.menugoster(6);

        }
        bool kategorimenu = false;
        bool kategorimenu2 = false;
        private void button6_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void categoryMenu1_MouseLeave(object sender, EventArgs e)
        {
            mainPage1.BringToFront();
        }

        private void KategoriPanel_MouseLeave(object sender, EventArgs e)
        {
          
               
        }

        private void mainPage1_MouseHover(object sender, EventArgs e)
        {
            mainPage1.BringToFront();
        }

        private void mainPage1_MouseEnter(object sender, EventArgs e)
        {
            mainPage1.BringToFront();
        }

        private void categoryMenu1_Leave(object sender, EventArgs e)
        {
            //if ((categoryMenu1.Location.Y > Cursor.Position.Y && categoryMenu1.Location.Y + categoryMenu1.Width < Cursor.Position.Y) && (categoryMenu1.Location.X > Cursor.Position.X && categoryMenu1.Location.X + categoryMenu1.Width < Cursor.Position.X))
                  mainPage1.BringToFront();
            
            
            
        }

        private void mainPage1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {


            urunEkle1.urunEkleSayfaAc();
           // urunler3.BringToFront();
            //urunler3.butonaTiklayinca(1);
        }



        public void urunleriGoster(int cinsiyetKategori, int kategoriID)
        {
            urunler3.kategoriyeGoreUrunGetir(cinsiyetKategori, kategoriID);
        
        
        }



        public void urungetir()
        {
 
            urunDetay1.BringToFront();

        }
        public void urungetir(PictureBox img) {


            urunDetay1.urunyerlestir(img);
            urunDetay1.BringToFront();

        
        }
        public void urungetir(Label lbl)
        {

            
            urunDetay1.urunyerlestir(lbl);
            urunDetay1.BringToFront();


        }

        private void categoryMenu1_MouseHover(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Profil
            GirisLabel.Visible = false;
            KayıtLabel.Visible = false;

        }

        private void GirisLabel_Click(object sender, EventArgs e)
        {

            label1.Visible = true;
            GirisLabel.Visible = false;
            KayıtLabel.Visible = false;

        }

        private void categoryMenu1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void btnKadin_MouseHover(object sender, EventArgs e)
        {
            categoryMenu1.menugoster(1);
            


        }

        private void btnErkek_MouseHover(object sender, EventArgs e)
        {
           // categoryMenu1.menugoster(2);
        }

        private void btnCocuk_MouseHover(object sender, EventArgs e)
        {
           // categoryMenu1.menugoster(3);
        }

        private void btnBebek_MouseHover(object sender, EventArgs e)
        {
           // categoryMenu1.menugoster(4);
            
        }
        
        private void mainPage1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnKadin_Click(object sender, EventArgs e)
        {
            urunler3.butonaTiklayinca(1);
        }

        private void btnErkek_Click(object sender, EventArgs e)
        {
            urunler3.butonaTiklayinca(2);
        }

      


        

    }
}
