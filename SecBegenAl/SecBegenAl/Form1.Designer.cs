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
            this.button6 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.KayıtLabel = new System.Windows.Forms.Label();
            this.GirisLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.girisyap1 = new SecBegenAl.Girisyap();
            this.kayitOl1 = new SecBegenAl.KayitOl();
            this.mainPage1 = new SecBegenAl.MainPage();
            this.categoryMenu2 = new SecBegenAl.CategoryMenu();
            this.categoryMenu1 = new SecBegenAl.CategoryMenu();
            this.saticiKayit1 = new SecBegenAl.SaticiKayit();
            this.panel1.SuspendLayout();
            this.KategoriPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.KategoriPanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.girisyap1);
            this.panel1.Controls.Add(this.kayitOl1);
            this.panel1.Controls.Add(this.mainPage1);
            this.panel1.Controls.Add(this.categoryMenu2);
            this.panel1.Controls.Add(this.categoryMenu1);
            this.panel1.Controls.Add(this.saticiKayit1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 510);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // KategoriPanel
            // 
            this.KategoriPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.KategoriPanel.Controls.Add(this.button6);
            this.KategoriPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.KategoriPanel.Location = new System.Drawing.Point(0, 66);
            this.KategoriPanel.Margin = new System.Windows.Forms.Padding(2);
            this.KategoriPanel.Name = "KategoriPanel";
            this.KategoriPanel.Size = new System.Drawing.Size(815, 44);
            this.KategoriPanel.TabIndex = 4;
            this.KategoriPanel.MouseLeave += new System.EventHandler(this.KategoriPanel_MouseLeave);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(605, 6);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 36);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseLeave += new System.EventHandler(this.button6_MouseLeave);
            this.button6.MouseHover += new System.EventHandler(this.button6_MouseHover);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.KayıtLabel);
            this.panel3.Controls.Add(this.GirisLabel);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(815, 36);
            this.panel3.TabIndex = 3;
            // 
            // KayıtLabel
            // 
            this.KayıtLabel.AutoSize = true;
            this.KayıtLabel.BackColor = System.Drawing.SystemColors.Control;
            this.KayıtLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KayıtLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.KayıtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayıtLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.KayıtLabel.Location = new System.Drawing.Point(628, 0);
            this.KayıtLabel.Margin = new System.Windows.Forms.Padding(3, 2, 2, 0);
            this.KayıtLabel.Name = "KayıtLabel";
            this.KayıtLabel.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.KayıtLabel.Size = new System.Drawing.Size(93, 30);
            this.KayıtLabel.TabIndex = 2;
            this.KayıtLabel.Text = "Kayıt Ol  ";
            this.KayıtLabel.Click += new System.EventHandler(this.KayıtLabel_Click);
            // 
            // GirisLabel
            // 
            this.GirisLabel.AutoSize = true;
            this.GirisLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GirisLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.GirisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.GirisLabel.Location = new System.Drawing.Point(721, 0);
            this.GirisLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GirisLabel.Name = "GirisLabel";
            this.GirisLabel.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.GirisLabel.Size = new System.Drawing.Size(94, 30);
            this.GirisLabel.TabIndex = 1;
            this.GirisLabel.Text = "Giriş Yap";
            this.GirisLabel.Click += new System.EventHandler(this.GirisLabel_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1389, 36);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Satıcı Olmak İstiyorum";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 30);
            this.panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(784, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(31, 31);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // girisyap1
            // 
            this.girisyap1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.girisyap1.BackColor = System.Drawing.Color.Khaki;
            this.girisyap1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.girisyap1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.girisyap1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.girisyap1.Location = new System.Drawing.Point(446, 159);
            this.girisyap1.Name = "girisyap1";
            this.girisyap1.Size = new System.Drawing.Size(440, 452);
            this.girisyap1.TabIndex = 12;
            this.girisyap1.Load += new System.EventHandler(this.girisyap1_Load);
            // 
            // kayitOl1
            // 
            this.kayitOl1.BackColor = System.Drawing.Color.Khaki;
            this.kayitOl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kayitOl1.Location = new System.Drawing.Point(446, 159);
            this.kayitOl1.Name = "kayitOl1";
            this.kayitOl1.Size = new System.Drawing.Size(440, 453);
            this.kayitOl1.TabIndex = 11;
            // 
            // mainPage1
            // 
            this.mainPage1.AutoScroll = true;
            this.mainPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPage1.Location = new System.Drawing.Point(0, 0);
            this.mainPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainPage1.Name = "mainPage1";
            this.mainPage1.Size = new System.Drawing.Size(815, 510);
            this.mainPage1.TabIndex = 5;
            this.mainPage1.Load += new System.EventHandler(this.mainPage1_Load);
            this.mainPage1.Enter += new System.EventHandler(this.mainPage1_Enter);
            this.mainPage1.MouseEnter += new System.EventHandler(this.mainPage1_MouseEnter);
            this.mainPage1.MouseHover += new System.EventHandler(this.mainPage1_MouseHover);
            // 
            // categoryMenu2
            // 
            this.categoryMenu2.Location = new System.Drawing.Point(331, 146);
            this.categoryMenu2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.categoryMenu2.Name = "categoryMenu2";
            this.categoryMenu2.Size = new System.Drawing.Size(802, 393);
            this.categoryMenu2.TabIndex = 9;
            // 
            // categoryMenu1
            // 
            this.categoryMenu1.Location = new System.Drawing.Point(338, 110);
            this.categoryMenu1.Margin = new System.Windows.Forms.Padding(225, 2, 2, 2);
            this.categoryMenu1.Name = "categoryMenu1";
            this.categoryMenu1.Size = new System.Drawing.Size(832, 393);
            this.categoryMenu1.TabIndex = 6;
            this.categoryMenu1.Leave += new System.EventHandler(this.categoryMenu1_Leave);
            this.categoryMenu1.MouseLeave += new System.EventHandler(this.categoryMenu1_MouseLeave);
            // 
            // saticiKayit1
            // 
            this.saticiKayit1.BackColor = System.Drawing.Color.Khaki;
            this.saticiKayit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saticiKayit1.Location = new System.Drawing.Point(446, 159);
            this.saticiKayit1.Name = "saticiKayit1";
            this.saticiKayit1.Size = new System.Drawing.Size(440, 454);
            this.saticiKayit1.TabIndex = 13;
            this.saticiKayit1.Load += new System.EventHandler(this.saticiKayit1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 510);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.KategoriPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel KategoriPanel;
        private System.Windows.Forms.Button button6;
        private MainPage mainPage1;
        private CategoryMenu categoryMenu1;
        private Urunler urunler1;
        private CategoryMenu categoryMenu2;
        private System.Windows.Forms.Label label1;
        private KayitOl kayitOl1;
        private Girisyap girisyap1;
        private SaticiKayit saticiKayit1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label KayıtLabel;
        private System.Windows.Forms.Label GirisLabel;
    }
}

