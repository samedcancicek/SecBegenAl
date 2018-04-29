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
            this.saticiGiris2 = new SecBegenAl.SaticiGiris();
            this.mainPage2 = new SecBegenAl.MainPage();
            this.KategoriPanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.saticiGiris1 = new SecBegenAl.SaticiGiris();
            this.KayıtLabel = new System.Windows.Forms.Label();
            this.GirisLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.saticiProfil2 = new SecBegenAl.SaticiProfil();
            this.categoryMenu3 = new SecBegenAl.CategoryMenu();
            this.panel1.SuspendLayout();
            this.KategoriPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.saticiGiris2);
            this.panel1.Controls.Add(this.mainPage2);
            this.panel1.Controls.Add(this.KategoriPanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.saticiProfil2);
            this.panel1.Controls.Add(this.categoryMenu3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 628);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // saticiGiris2
            // 
            this.saticiGiris2.Location = new System.Drawing.Point(263, 194);
            this.saticiGiris2.Name = "saticiGiris2";
            this.saticiGiris2.Size = new System.Drawing.Size(524, 603);
            this.saticiGiris2.TabIndex = 8;
            // 
            // mainPage2
            // 
            this.mainPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPage2.Location = new System.Drawing.Point(0, 135);
            this.mainPage2.Name = "mainPage2";
            this.mainPage2.Size = new System.Drawing.Size(1087, 493);
            this.mainPage2.TabIndex = 5;
            this.mainPage2.Load += new System.EventHandler(this.mainPage2_Load);
            // 
            // KategoriPanel
            // 
            this.KategoriPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.KategoriPanel.Controls.Add(this.button6);
            this.KategoriPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.KategoriPanel.Location = new System.Drawing.Point(0, 81);
            this.KategoriPanel.Name = "KategoriPanel";
            this.KategoriPanel.Size = new System.Drawing.Size(1087, 54);
            this.KategoriPanel.TabIndex = 4;
            this.KategoriPanel.MouseLeave += new System.EventHandler(this.KategoriPanel_MouseLeave);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(807, 7);
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
            this.panel3.Controls.Add(this.saticiGiris1);
            this.panel3.Controls.Add(this.KayıtLabel);
            this.panel3.Controls.Add(this.GirisLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1087, 44);
            this.panel3.TabIndex = 3;
            // 
            // saticiGiris1
            // 
            this.saticiGiris1.Location = new System.Drawing.Point(0, 0);
            this.saticiGiris1.Name = "saticiGiris1";
            this.saticiGiris1.Size = new System.Drawing.Size(524, 603);
            this.saticiGiris1.TabIndex = 3;
            // 
            // KayıtLabel
            // 
            this.KayıtLabel.AutoSize = true;
            this.KayıtLabel.BackColor = System.Drawing.SystemColors.Control;
            this.KayıtLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.KayıtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayıtLabel.ForeColor = System.Drawing.Color.BlueViolet;
            this.KayıtLabel.Location = new System.Drawing.Point(848, 0);
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
            this.GirisLabel.Location = new System.Drawing.Point(966, 0);
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
            this.panel2.Size = new System.Drawing.Size(1087, 37);
            this.panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(1046, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(41, 38);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saticiProfil2
            // 
            this.saticiProfil2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saticiProfil2.Location = new System.Drawing.Point(0, 0);
            this.saticiProfil2.Name = "saticiProfil2";
            this.saticiProfil2.Size = new System.Drawing.Size(1087, 628);
            this.saticiProfil2.TabIndex = 6;
            // 
            // categoryMenu3
            // 
            this.categoryMenu3.Location = new System.Drawing.Point(447, 164);
            this.categoryMenu3.Name = "categoryMenu3";
            this.categoryMenu3.Size = new System.Drawing.Size(1069, 484);
            this.categoryMenu3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 628);
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
        private CategoryMenu categoryMenu2;
        private Saticisiparisgor saticisiparisgor1;
        private SaticiProfil saticiProfil1;
        private MainPage mainPage2;
        private SaticiProfil saticiProfil2;
        private CategoryMenu categoryMenu3;
        private SaticiGiris saticiGiris2;
        private SaticiGiris saticiGiris1;
    }
}

