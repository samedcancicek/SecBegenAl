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
        int satici_id;
        public void saticiProfilGoruntule(Satici satici) {
            this.satici = satici;
            
            this.BringToFront();

            label5.Text = satici.firma_adi;
            label6.Text = satici.adres;
            label7.Text = satici.telefon;
            label8.Text = satici.eposta;
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            saticiBilgiGuncelle1.saticibilgigüncelle(satici);
        }


        private void SaticiProfil_Load(object sender, EventArgs e)
        {

        }

        private void siparisgor_Click(object sender, EventArgs e)
        {
            saticisiparisgor3.siparislerimigoster(satici.satici_id);
        }
    }
}
