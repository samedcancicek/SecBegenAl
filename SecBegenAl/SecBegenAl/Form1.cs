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
            girisYok();
        }
        int kullanici_id;//bunu nesne yapmıcaz mı
        
        public void girisYapti(int kullanici_id)
        {
            this.kullanici_id = kullanici_id;

            GirisLabel.Hide();
            KayıtLabel.Hide();
            saticiol.Hide();
            ProfilLabel.Show();
            sepetim.Show();
           
            cikis.Show();
            analabel.Hide();
            profilY.Hide();
            
        }
        public void girisYok()
        {
            cikis.Hide();
            sepetim.Hide();
            ProfilLabel.Hide();
            GirisLabel.Show();
            KayıtLabel.Show();
            saticiol.Show();
            analabel.Hide();
         //   profil2.Hide();
            mainPage1.Show();
            sepet1.Hide();
            profilY.Hide();
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
            kayitOl1.start();
            kayitOl1.Show();
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
           
          categoryMenu1.BringToFront();
            

        }
       
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
            
        }

     
        private void mainPage1_Load(object sender, EventArgs e)
        {
        }


        private void saticiol_Click(object sender, EventArgs e)
        {
            saticiKayit1.BringToFront();
        }

        private void saticiKayit1_Load(object sender, EventArgs e)
        {

        }
       
        private void girisyap1_Load(object sender, EventArgs e)
        {
        
        }

        public void kayitGoruntule() {
            kayitOl1.BringToFront();

        }

        private void GirisLabel_Click(object sender, EventArgs e)
        {
            girisyap1.start();
            girisyap1.Show();
        }

        private void sepetim_Click(object sender, EventArgs e)
        {
      
            profil2.Hide();
            sepet1.Show();
            sepet1.sepetimiGoster(kullanici_id);//burda olması lazım +1  eegerisi sende o zaman ürünleri flowlayout ile gösterecen 
           
            categoryMenu2.Hide();
            ProfilLabel.Hide();
            analabel.Show();
            mainPage1.Hide();
            categoryMenu1.Hide();
            girisyap1.Hide();
            saticiKayit1.Hide();
            kayitOl1.Hide();
            KategoriPanel.Hide();
            sepetim.Hide();
            profilY.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Profil_Click(object sender, EventArgs e)
        {
            profil2.Show();
            profil2.profilGoruntule(kullanici_id);
            categoryMenu2.Hide();
            ProfilLabel.Hide();
            analabel.Show();
            mainPage1.Hide();
            categoryMenu1.Hide();
            girisyap1.Hide();
            saticiKayit1.Hide();
            kayitOl1.Hide();
            KategoriPanel.Hide();
            sepetim.Show();

        }

        private void analabel_Click(object sender, EventArgs e)
        {
            profil2.Hide(); 
            categoryMenu2.Show();
            ProfilLabel.Show();
            analabel.Hide();
            mainPage1.Show();
            categoryMenu1.Show();
            girisyap1.Hide();
            saticiKayit1.Hide();
            kayitOl1.Hide();
            KategoriPanel.Show();
            profilY.Hide();
            sepetim.Show();
            sepet1.Hide();
        }

  
        private void cikis_Click(object sender, EventArgs e)
        {
            girisYok();
         

        }

        private void profilY_Click(object sender, EventArgs e)
        {
            profil2.Show();
            profil2.profilGoruntule(kullanici_id);
            categoryMenu2.Hide();
            ProfilLabel.Hide();
            analabel.Show();
            mainPage1.Hide();
            categoryMenu1.Hide();
            girisyap1.Hide();
            saticiKayit1.Hide();
            kayitOl1.Hide();
            KategoriPanel.Hide();
            profilY.Hide();
            sepetim.Show();
        }

        private void mainPage1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
