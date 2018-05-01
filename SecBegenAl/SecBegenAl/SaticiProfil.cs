using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecBegenAl
{
    public partial class SaticiProfil : UserControl
    {
        public SaticiProfil()
        {
            InitializeComponent();


        }




        Satici satici = new Satici();


        public void saticiProfilGoruntule(Satici satici) {
            this.satici = satici;

            this.BringToFront();

            label5.Text = satici.firma_adi;
            label6.Text = satici.adres;
            label7.Text = satici.telefon;
            label8.Text = satici.eposta;




        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           // saticisiparisgor1.BringToFront();
           saticisiparisgor1.bringtofront();

        }

        private void saticisiparisgor2_Load(object sender, EventArgs e)
        {
           // saticisiparisgor2.SendToBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void urunlerim1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void saticisiparisgor2_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saticiBilgiGuncelle1.saticibilgigüncelle(satici);
        }

        private void saticiBilgiGuncelle1_Load(object sender, EventArgs e)
        {

        }
    }
}
