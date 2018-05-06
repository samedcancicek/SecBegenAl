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
            mainPage2.BringToFront();
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KayıtLabel_Click(object sender, EventArgs e)
        {
            saticiGiris1.BringToFront();
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
           
               
            categoryMenu3.BringToFront();

        }
        bool kategorimenu = false;
        bool kategorimenu2 = false;
        private void button6_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void categoryMenu1_MouseLeave(object sender, EventArgs e)
        {
            
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
            if ((categoryMenu1.Location.Y > Cursor.Position.Y && categoryMenu1.Location.Y + categoryMenu1.Width < Cursor.Position.Y) && (categoryMenu1.Location.X > Cursor.Position.X && categoryMenu1.Location.X + categoryMenu1.Width < Cursor.Position.X))
                  mainPage1.BringToFront();
            
            
            
        }

        private void mainPage1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            urunler1.BringToFront();
        }

        private void GirisLabel_Click(object sender, EventArgs e)
        {
          giris1.BringToFront();
            
        }

        private void mainPage2_Load(object sender, EventArgs e)
        {

        }

        Satici satici = new Satici();
        public void saticiGirisYapildi(Satici satici) {

            this.satici = satici;

            saticiProfil2.saticiProfilGoruntule(satici);


            
        }

        private void saticiBilgiGuncelle1_Load(object sender, EventArgs e)
        {

        }
    }
}
