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
    public partial class Urunler : UserControl
    {
        public Urunler()
        {
            InitializeComponent();
            

           
            
            /*for (int i = 0; i < 10; i++)
            {
                lbl[i] = new Label();
                img[i] = new PictureBox();
                //img[i].Text = "Btuuın" + i;
                lbl[i].Size = new Size(300, 50);
                lbl[i].Text = "deneme" + i;
                img[i].Size = new Size(300, 500);
                //img[i].Name = "buton1";
                img[i].BackgroundImage = Image.FromFile("kediler.jpg");
                img[i].BackgroundImageLayout = ImageLayout.Stretch;
                var margin = img[i].Margin;
                margin.Left = 20;
                margin.Top = 20;
                img[i].Margin = margin;
                //box[i].Location = new Point(50, i * 40);
                //box[i].BringToFront();
                flowLayoutPanel2.Controls.Add(img[i]);
                flowLayoutPanel2.Controls.Add(lbl[i]);
                //this.Controls.Add(box[i]);
            }*/


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
                flowLayoutPanel2.Controls.Add(panel[i]);
                
            }


            
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
