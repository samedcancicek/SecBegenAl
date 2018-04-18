namespace SecBegenAl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.KategoriPanel = new System.Windows.Forms.Panel();
            this.btnBebek = new System.Windows.Forms.Button();
            this.btnCocuk = new System.Windows.Forms.Button();
            this.btnErkek = new System.Windows.Forms.Button();
            this.btnKadin = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.KayıtLabel = new System.Windows.Forms.Label();
            this.GirisLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.categoryMenu1 = new SecBegenAl.CategoryMenu();
            this.mainPage1 = new SecBegenAl.MainPage();
            this.kayitOl1 = new SecBegenAl.KayitOl();
            this.urunDetay1 = new SecBegenAl.UrunDetay();
            this.urunler3 = new SecBegenAl.Urunler();
            this.panel1.SuspendLayout();
            this.KategoriPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.KategoriPanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.categoryMenu1);
            this.panel1.Controls.Add(this.mainPage1);
            this.panel1.Controls.Add(this.kayitOl1);
            this.panel1.Controls.Add(this.urunDetay1);
            this.panel1.Controls.Add(this.urunler3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1587, 628);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // KategoriPanel
            // 
            this.KategoriPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.KategoriPanel.Controls.Add(this.btnBebek);
            this.KategoriPanel.Controls.Add(this.btnCocuk);
            this.KategoriPanel.Controls.Add(this.btnErkek);
            this.KategoriPanel.Controls.Add(this.btnKadin);
            this.KategoriPanel.Controls.Add(this.button6);
            this.KategoriPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.KategoriPanel.Location = new System.Drawing.Point(0, 81);
            this.KategoriPanel.Name = "KategoriPanel";
            this.KategoriPanel.Size = new System.Drawing.Size(1587, 54);
            this.KategoriPanel.TabIndex = 4;
            this.KategoriPanel.MouseLeave += new System.EventHandler(this.KategoriPanel_MouseLeave);
            // 
            // btnBebek
            // 
            this.btnBebek.Location = new System.Drawing.Point(1129, 5);
            this.btnBebek.Name = "btnBebek";
            this.btnBebek.Size = new System.Drawing.Size(111, 44);
            this.btnBebek.TabIndex = 9;
            this.btnBebek.Text = "Bebek";
            this.btnBebek.UseVisualStyleBackColor = true;
            this.btnBebek.MouseHover += new System.EventHandler(this.btnBebek_MouseHover);
            // 
            // btnCocuk
            // 
            this.btnCocuk.Location = new System.Drawing.Point(1012, 6);
            this.btnCocuk.Name = "btnCocuk";
            this.btnCocuk.Size = new System.Drawing.Size(111, 44);
            this.btnCocuk.TabIndex = 8;
            this.btnCocuk.Text = "Çocuk";
            this.btnCocuk.UseVisualStyleBackColor = true;
            this.btnCocuk.MouseHover += new System.EventHandler(this.btnCocuk_MouseHover);
            // 
            // btnErkek
            // 
            this.btnErkek.Location = new System.Drawing.Point(895, 6);
            this.btnErkek.Name = "btnErkek";
            this.btnErkek.Size = new System.Drawing.Size(111, 44);
            this.btnErkek.TabIndex = 7;
            this.btnErkek.Text = "Erkek";
            this.btnErkek.UseVisualStyleBackColor = true;
            this.btnErkek.Click += new System.EventHandler(this.btnErkek_Click);
            this.btnErkek.MouseHover += new System.EventHandler(this.btnErkek_MouseHover);
            // 
            // btnKadin
            // 
            this.btnKadin.Location = new System.Drawing.Point(778, 6);
            this.btnKadin.Name = "btnKadin";
            this.btnKadin.Size = new System.Drawing.Size(111, 44);
            this.btnKadin.TabIndex = 6;
            this.btnKadin.Text = "Kadın";
            this.btnKadin.UseVisualStyleBackColor = true;
            this.btnKadin.Click += new System.EventHandler(this.btnKadin_Click);
            this.btnKadin.MouseHover += new System.EventHandler(this.btnKadin_MouseHover);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(331, 7);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 44);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseLeave += new System.EventHandler(this.button6_MouseLeave);
            this.button6.MouseHover += new System.EventHandler(this.button6_MouseHover);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.KayıtLabel);
            this.panel3.Controls.Add(this.GirisLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1587, 44);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(1273, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Profil";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // KayıtLabel
            // 
            this.KayıtLabel.AutoSize = true;
            this.KayıtLabel.BackColor = System.Drawing.SystemColors.Control;
            this.KayıtLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.KayıtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayıtLabel.ForeColor = System.Drawing.Color.BlueViolet;
            this.KayıtLabel.Location = new System.Drawing.Point(1348, 0);
            this.KayıtLabel.Name = "KayıtLabel";
            this.KayıtLabel.Size = new System.Drawing.Size(118, 29);
            this.KayıtLabel.TabIndex = 2;
            this.KayıtLabel.Text = "Kayıt Ol  ";
            this.KayıtLabel.Click += new System.EventHandler(this.KayıtLabel_Click);
            // 
            // GirisLabel
            // 
            this.GirisLabel.AutoSize = true;
            this.GirisLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.GirisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisLabel.ForeColor = System.Drawing.Color.BlueViolet;
            this.GirisLabel.Location = new System.Drawing.Point(1466, 0);
            this.GirisLabel.Name = "GirisLabel";
            this.GirisLabel.Size = new System.Drawing.Size(121, 29);
            this.GirisLabel.TabIndex = 1;
            this.GirisLabel.Text = "Giriş Yap";
            this.GirisLabel.Click += new System.EventHandler(this.GirisLabel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1587, 37);
            this.panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(1546, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(41, 38);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // categoryMenu1
            // 
            this.categoryMenu1.BackColor = System.Drawing.Color.Transparent;
            this.categoryMenu1.Location = new System.Drawing.Point(450, 138);
            this.categoryMenu1.Margin = new System.Windows.Forms.Padding(300, 3, 3, 3);
            this.categoryMenu1.Name = "categoryMenu1";
            this.categoryMenu1.Size = new System.Drawing.Size(1042, 442);
            this.categoryMenu1.TabIndex = 6;
            this.categoryMenu1.Leave += new System.EventHandler(this.categoryMenu1_Leave);
            this.categoryMenu1.MouseEnter += new System.EventHandler(this.categoryMenu1_MouseEnter);
            this.categoryMenu1.MouseLeave += new System.EventHandler(this.categoryMenu1_MouseLeave);
            this.categoryMenu1.MouseHover += new System.EventHandler(this.categoryMenu1_MouseHover);
            // 
            // mainPage1
            // 
            this.mainPage1.AutoScroll = true;
            this.mainPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPage1.Location = new System.Drawing.Point(0, 0);
            this.mainPage1.Name = "mainPage1";
            this.mainPage1.Size = new System.Drawing.Size(1587, 628);
            this.mainPage1.TabIndex = 5;
            this.mainPage1.Load += new System.EventHandler(this.mainPage1_Load);
            this.mainPage1.Enter += new System.EventHandler(this.mainPage1_Enter);
            this.mainPage1.MouseEnter += new System.EventHandler(this.mainPage1_MouseEnter);
            this.mainPage1.MouseHover += new System.EventHandler(this.mainPage1_MouseHover);
            // 
            // kayitOl1
            // 
            this.kayitOl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kayitOl1.Location = new System.Drawing.Point(0, 0);
            this.kayitOl1.Name = "kayitOl1";
            this.kayitOl1.Size = new System.Drawing.Size(1587, 628);
            this.kayitOl1.TabIndex = 7;
            // 
            // urunDetay1
            // 
            this.urunDetay1.BackColor = System.Drawing.Color.IndianRed;
            this.urunDetay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urunDetay1.Location = new System.Drawing.Point(0, 0);
            this.urunDetay1.Name = "urunDetay1";
            this.urunDetay1.Size = new System.Drawing.Size(1587, 628);
            this.urunDetay1.TabIndex = 10;
            // 
            // urunler3
            // 
            this.urunler3.BackColor = System.Drawing.Color.PeachPuff;
            this.urunler3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urunler3.Location = new System.Drawing.Point(0, 0);
            this.urunler3.Name = "urunler3";
            this.urunler3.Size = new System.Drawing.Size(1587, 628);
            this.urunler3.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1587, 628);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.KategoriPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label KayıtLabel;
        private System.Windows.Forms.Label GirisLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel KategoriPanel;
        private System.Windows.Forms.Button button6;
        private MainPage mainPage1;
        private CategoryMenu categoryMenu1;
        private KayitOl kayitOl1;
        private Urunler urunler1;
        private UrunDetay urunDetay1;
        private Urunler urunler2;
        private Urunler urunler3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBebek;
        private System.Windows.Forms.Button btnCocuk;
        private System.Windows.Forms.Button btnErkek;
        private System.Windows.Forms.Button btnKadin;
    }
}

