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
    public partial class Saticisiparisgor : UserControl
    {
        public Saticisiparisgor()
        {
            InitializeComponent();


            PictureBox[] img = new PictureBox[10];
            Label[] lbl = new Label[10];
            FlowLayoutPanel[] panel = new FlowLayoutPanel[10];
            for (int i = 0; i < 10; i++)
            {

                //iç paneli oluşturma resim ve label koymak için
                panel[i] = new FlowLayoutPanel();
                panel[i].Size = new Size(300, 500);


                // label oluşturma
                lbl[i] = new Label();
                lbl[i].Size = new Size(300, 50);
                lbl[i].Text = "deneme" + i;


                //resim oluşturma
                img[i] = new PictureBox();
                img[i].Size = new Size(300, 400);
                img[i].BackgroundImage = Image.FromFile("kediler.jpg");
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


                //iç paneli ana panel içine ekleme
                flowLayoutPanel1.Controls.Add(panel[i]);

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void bringtofront() {

            this.BringToFront();

        }

    }
}
