namespace ciftlik4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBoxTavuk = new PictureBox();
            btnTavukSat = new Button();
            lblTavuk = new Label();
            btnTavukEkle = new Button();
            groupBoxTavuk = new GroupBox();
            lblKasa = new Label();
            label2 = new Label();
            timerPictureBoxSil = new System.Windows.Forms.Timer(components);
            groupBoxOrdek = new GroupBox();
            btnOrdekSat = new Button();
            lblOrdek = new Label();
            btnOrdekEkle = new Button();
            pictureBoxOrdek = new PictureBox();
            groupBoxInek = new GroupBox();
            btnInekSat = new Button();
            lblInek = new Label();
            btnInekEkle = new Button();
            pictureBoxInek = new PictureBox();
            groupBoxKeci = new GroupBox();
            btnKeciSat = new Button();
            lblKeci = new Label();
            btnKeciEkle = new Button();
            pictureBoxKeci = new PictureBox();
            groupBoxHayvanlar = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTavuk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOrdek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKeci).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxTavuk
            // 
            pictureBoxTavuk.Image = Properties.Resources.Tavuk;
            pictureBoxTavuk.Location = new Point(74, 42);
            pictureBoxTavuk.Name = "pictureBoxTavuk";
            pictureBoxTavuk.Size = new Size(147, 158);
            pictureBoxTavuk.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTavuk.TabIndex = 1;
            pictureBoxTavuk.TabStop = false;
            // 
            // btnTavukSat
            // 
            btnTavukSat.Location = new Point(74, 246);
            btnTavukSat.Name = "btnTavukSat";
            btnTavukSat.Size = new Size(125, 34);
            btnTavukSat.TabIndex = 19;
            btnTavukSat.Text = "Yumurta Sat";
            btnTavukSat.UseVisualStyleBackColor = true;
            btnTavukSat.Click += btnTavukSat_Click;
            // 
            // lblTavuk
            // 
            lblTavuk.AutoSize = true;
            lblTavuk.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTavuk.Location = new Point(205, 246);
            lblTavuk.Name = "lblTavuk";
            lblTavuk.Size = new Size(29, 35);
            lblTavuk.TabIndex = 18;
            lblTavuk.Text = "0";
            // 
            // btnTavukEkle
            // 
            btnTavukEkle.Location = new Point(74, 206);
            btnTavukEkle.Name = "btnTavukEkle";
            btnTavukEkle.Size = new Size(147, 34);
            btnTavukEkle.TabIndex = 17;
            btnTavukEkle.Text = "Tavuk Ekle";
            btnTavukEkle.UseVisualStyleBackColor = true;
            btnTavukEkle.Click += btnTavukEkle_Click;
            // 
            // groupBoxTavuk
            // 
            groupBoxTavuk.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBoxTavuk.Location = new Point(74, 296);
            groupBoxTavuk.Name = "groupBoxTavuk";
            groupBoxTavuk.Size = new Size(236, 463);
            groupBoxTavuk.TabIndex = 20;
            groupBoxTavuk.TabStop = false;
            groupBoxTavuk.Text = "Hayvan Üretim";
            // 
            // lblKasa
            // 
            lblKasa.AutoSize = true;
            lblKasa.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblKasa.Location = new Point(1197, 119);
            lblKasa.Name = "lblKasa";
            lblKasa.Size = new Size(39, 21);
            lblKasa.TabIndex = 22;
            lblKasa.Text = "500";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(1173, 86);
            label2.Name = "label2";
            label2.Size = new Size(86, 33);
            label2.TabIndex = 21;
            label2.Text = "KASA";
            // 
            // timerPictureBoxSil
            // 
            timerPictureBoxSil.Tick += Timer_Tick;
            // 
            // groupBoxOrdek
            // 
            groupBoxOrdek.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBoxOrdek.Location = new Point(355, 296);
            groupBoxOrdek.Name = "groupBoxOrdek";
            groupBoxOrdek.Size = new Size(236, 463);
            groupBoxOrdek.TabIndex = 27;
            groupBoxOrdek.TabStop = false;
            groupBoxOrdek.Text = "Hayvan Üretim";
            // 
            // btnOrdekSat
            // 
            btnOrdekSat.Location = new Point(355, 246);
            btnOrdekSat.Name = "btnOrdekSat";
            btnOrdekSat.Size = new Size(125, 34);
            btnOrdekSat.TabIndex = 26;
            btnOrdekSat.Text = "Yumurta Sat";
            btnOrdekSat.UseVisualStyleBackColor = true;
            btnOrdekSat.Click += btnOrdekSat_Click;
            // 
            // lblOrdek
            // 
            lblOrdek.AutoSize = true;
            lblOrdek.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblOrdek.Location = new Point(486, 246);
            lblOrdek.Name = "lblOrdek";
            lblOrdek.Size = new Size(29, 35);
            lblOrdek.TabIndex = 25;
            lblOrdek.Text = "0";
            // 
            // btnOrdekEkle
            // 
            btnOrdekEkle.Location = new Point(355, 206);
            btnOrdekEkle.Name = "btnOrdekEkle";
            btnOrdekEkle.Size = new Size(147, 34);
            btnOrdekEkle.TabIndex = 24;
            btnOrdekEkle.Text = "Ordek Ekle";
            btnOrdekEkle.UseVisualStyleBackColor = true;
            btnOrdekEkle.Click += btnOrdekEkle_Click;
            // 
            // pictureBoxOrdek
            // 
            pictureBoxOrdek.Image = (Image)resources.GetObject("pictureBoxOrdek.Image");
            pictureBoxOrdek.Location = new Point(355, 42);
            pictureBoxOrdek.Name = "pictureBoxOrdek";
            pictureBoxOrdek.Size = new Size(147, 158);
            pictureBoxOrdek.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxOrdek.TabIndex = 23;
            pictureBoxOrdek.TabStop = false;
            // 
            // groupBoxInek
            // 
            groupBoxInek.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBoxInek.Location = new Point(635, 296);
            groupBoxInek.Name = "groupBoxInek";
            groupBoxInek.Size = new Size(236, 463);
            groupBoxInek.TabIndex = 32;
            groupBoxInek.TabStop = false;
            groupBoxInek.Text = "Hayvan Üretim";
            // 
            // btnInekSat
            // 
            btnInekSat.Location = new Point(635, 246);
            btnInekSat.Name = "btnInekSat";
            btnInekSat.Size = new Size(125, 34);
            btnInekSat.TabIndex = 31;
            btnInekSat.Text = "Sut Sat";
            btnInekSat.UseVisualStyleBackColor = true;
            btnInekSat.Click += btnInekSat_Click;
            // 
            // lblInek
            // 
            lblInek.AutoSize = true;
            lblInek.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInek.Location = new Point(766, 246);
            lblInek.Name = "lblInek";
            lblInek.Size = new Size(29, 35);
            lblInek.TabIndex = 30;
            lblInek.Text = "0";
            // 
            // btnInekEkle
            // 
            btnInekEkle.Location = new Point(635, 206);
            btnInekEkle.Name = "btnInekEkle";
            btnInekEkle.Size = new Size(147, 34);
            btnInekEkle.TabIndex = 29;
            btnInekEkle.Text = "Inek Ekle";
            btnInekEkle.UseVisualStyleBackColor = true;
            btnInekEkle.Click += btnInekEkle_Click;
            // 
            // pictureBoxInek
            // 
            pictureBoxInek.Image = (Image)resources.GetObject("pictureBoxInek.Image");
            pictureBoxInek.Location = new Point(635, 42);
            pictureBoxInek.Name = "pictureBoxInek";
            pictureBoxInek.Size = new Size(147, 158);
            pictureBoxInek.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxInek.TabIndex = 28;
            pictureBoxInek.TabStop = false;
            // 
            // groupBoxKeci
            // 
            groupBoxKeci.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBoxKeci.Location = new Point(915, 296);
            groupBoxKeci.Name = "groupBoxKeci";
            groupBoxKeci.Size = new Size(236, 463);
            groupBoxKeci.TabIndex = 37;
            groupBoxKeci.TabStop = false;
            groupBoxKeci.Text = "Hayvan Üretim";
            // 
            // btnKeciSat
            // 
            btnKeciSat.Location = new Point(915, 246);
            btnKeciSat.Name = "btnKeciSat";
            btnKeciSat.Size = new Size(125, 34);
            btnKeciSat.TabIndex = 36;
            btnKeciSat.Text = "Sut Sat";
            btnKeciSat.UseVisualStyleBackColor = true;
            btnKeciSat.Click += btnKeciSat_Click;
            // 
            // lblKeci
            // 
            lblKeci.AutoSize = true;
            lblKeci.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblKeci.Location = new Point(1046, 246);
            lblKeci.Name = "lblKeci";
            lblKeci.Size = new Size(29, 35);
            lblKeci.TabIndex = 35;
            lblKeci.Text = "0";
            // 
            // btnKeciEkle
            // 
            btnKeciEkle.Location = new Point(915, 206);
            btnKeciEkle.Name = "btnKeciEkle";
            btnKeciEkle.Size = new Size(147, 34);
            btnKeciEkle.TabIndex = 34;
            btnKeciEkle.Text = "Keci Ekle";
            btnKeciEkle.UseVisualStyleBackColor = true;
            btnKeciEkle.Click += btnKeciEkle_Click;
            // 
            // pictureBoxKeci
            // 
            pictureBoxKeci.Image = (Image)resources.GetObject("pictureBoxKeci.Image");
            pictureBoxKeci.Location = new Point(915, 42);
            pictureBoxKeci.Name = "pictureBoxKeci";
            pictureBoxKeci.Size = new Size(147, 158);
            pictureBoxKeci.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxKeci.TabIndex = 33;
            pictureBoxKeci.TabStop = false;
            // 
            // groupBoxHayvanlar
            // 
            groupBoxHayvanlar.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBoxHayvanlar.Location = new Point(43, 12);
            groupBoxHayvanlar.Name = "groupBoxHayvanlar";
            groupBoxHayvanlar.Size = new Size(1108, 278);
            groupBoxHayvanlar.TabIndex = 38;
            groupBoxHayvanlar.TabStop = false;
            groupBoxHayvanlar.Text = "Ciftlikte Yasayan Hayvanlar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 559);
            Controls.Add(groupBoxKeci);
            Controls.Add(btnKeciSat);
            Controls.Add(lblKeci);
            Controls.Add(btnKeciEkle);
            Controls.Add(pictureBoxKeci);
            Controls.Add(groupBoxInek);
            Controls.Add(btnInekSat);
            Controls.Add(lblInek);
            Controls.Add(btnInekEkle);
            Controls.Add(pictureBoxInek);
            Controls.Add(groupBoxOrdek);
            Controls.Add(btnOrdekSat);
            Controls.Add(lblOrdek);
            Controls.Add(btnOrdekEkle);
            Controls.Add(pictureBoxOrdek);
            Controls.Add(lblKasa);
            Controls.Add(label2);
            Controls.Add(groupBoxTavuk);
            Controls.Add(btnTavukSat);
            Controls.Add(lblTavuk);
            Controls.Add(btnTavukEkle);
            Controls.Add(pictureBoxTavuk);
            Controls.Add(groupBoxHayvanlar);
            Name = "Form1";
            Text = "Ciftlik";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxTavuk).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOrdek).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInek).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKeci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxTavuk;
        private Button btnTavukSat;
        private Label lblTavuk;
        private Button btnTavukEkle;
        private GroupBox groupBoxTavuk;
        private Label lblKasa;
        private Label label2;
        private System.Windows.Forms.Timer timerPictureBoxSil;
        private GroupBox groupBoxOrdek;
        private Button btnOrdekSat;
        private Label lblOrdek;
        private Button btnOrdekEkle;
        private PictureBox pictureBoxOrdek;
        private GroupBox groupBoxInek;
        private Button btnInekSat;
        private Label lblInek;
        private Button btnInekEkle;
        private PictureBox pictureBoxInek;
        private GroupBox groupBoxKeci;
        private Button btnKeciSat;
        private Label lblKeci;
        private Button btnKeciEkle;
        private PictureBox pictureBoxKeci;
        private GroupBox groupBoxHayvanlar;
    }
}