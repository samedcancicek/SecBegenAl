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

            
           //urunDetay2.SendToBack();
            
            
           // panel1.BringToFront();
            

            
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }


        public void urunpaneliac() {

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
    }
}
