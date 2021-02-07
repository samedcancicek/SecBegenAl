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
    public partial class UrunDetay : UserControl
    {

        
        
        
        
        public UrunDetay()
        {
            InitializeComponent();
            
        }



        public void urunyerlestir(PictureBox img) {


            pictureBox1 = img;

            this.BringToFront();
        }

        public void urunyerlestir(Label lbl)
        {


            label1.Text = lbl.Text;

            this.BringToFront();
        }
    }
}
