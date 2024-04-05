using Microsoft.VisualBasic;
using System.Threading.Tasks;

namespace ciftlik4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<PictureBox> tavukPictureBoxes = new List<PictureBox>();
        List<GroupBox> tavukGroupBoxes = new List<GroupBox>();

        private List<PictureBox> ordekPictureBoxes = new List<PictureBox>();
        List<GroupBox> ordekGroupBoxes = new List<GroupBox>();

        private List<PictureBox> ýnekPictureBoxes = new List<PictureBox>();
        List<GroupBox> ýnekGroupBoxes = new List<GroupBox>();

        private List<PictureBox> keciPictureBoxes = new List<PictureBox>();
        List<GroupBox> keciGroupBoxes = new List<GroupBox>();
        private int ordek;

        private void btnTavukEkle_Click(object sender, EventArgs e)
        {
            string isim = Interaction.InputBox("Tavuk Ýsmi:", "Tavuk Bilgisi", "");
            int yas = Convert.ToInt32(Interaction.InputBox("Tavuk Yaþý:", "Tavuk Bilgisi", ""));

            int kasaDegeri = Convert.ToInt32(lblKasa.Text);
            kasaDegeri -= 100;
            lblKasa.Text = kasaDegeri.ToString();

            PictureBox pictureBox = new PictureBox
            {
                Image = Properties.Resources.Tavuk,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(50, 75),
                Location = new Point(10, 20)
            };

            Label labelIsim = new Label
            {
                Text = "Ýsim: " + isim,
                Location = new Point(pictureBox.Right + 5, pictureBox.Top + 5)
            };

            Label labelYas = new Label
            {
                Text = "Yaþ: " + yas,
                Location = new Point(pictureBox.Right + 5, labelIsim.Bottom + 5)
            };

            ProgressBar progressBar = new ProgressBar
            {
                Minimum = 0,
                Maximum = 100,
                Value = 0,
                Width = 150,
                Height = 20,
                Location = new Point(pictureBox.Right + 5, labelYas.Bottom + 10)
            };

            Button buttonBesle = new Button
            {
                Text = "Besle",
                Location = new Point(pictureBox.Left, pictureBox.Bottom + 20)
            };

            buttonBesle.Click += (sender, ev) =>
            {
                progressBar.Value += 50;

                if (progressBar.Value >= 100)
                {

                    int tavuk = Convert.ToInt32(lblTavuk.Text);
                    tavuk += 1;
                    lblTavuk.Text = tavuk.ToString();
                    progressBar.Value = 0;
                }
            };

            GroupBox groupBox = new GroupBox
            {
                Text = "Tavuk Üretimi",
                Width = 800,
                Height = pictureBox.Height + labelIsim.Height + labelYas.Height + progressBar.Height + buttonBesle.Height + btnTavukSat.Height + 60 // Toplam yükseklik
            };

            groupBox.Controls.AddRange(new Control[] { pictureBox, labelIsim, labelYas, progressBar, buttonBesle });

            tavukGroupBoxes.Add(groupBox);
            groupBoxTavuk.Controls.Add(groupBox);
        }

        private void btnTavukSat_Click(object sender, EventArgs e)
        {
            int kasaDegeri = Convert.ToInt32(lblKasa.Text);
            kasaDegeri += 15;
            lblKasa.Text = kasaDegeri.ToString();

            int tavukSayisi = Convert.ToInt32(lblTavuk.Text);
            tavukSayisi -= 1;
            lblTavuk.Text = tavukSayisi.ToString();

        }

        private void btnOrdekEkle_Click(object sender, EventArgs e)
        {
            string isim = Interaction.InputBox("Ordek Ýsmi:", "Ordek Bilgisi", "");
            int yas = Convert.ToInt32(Interaction.InputBox("Ordek Yaþý:", "Ordek Bilgisi", ""));

            int kasaDegeri = Convert.ToInt32(lblKasa.Text);
            kasaDegeri -= 250;
            lblKasa.Text = kasaDegeri.ToString();

            PictureBox pictureBox = new PictureBox
            {
                Image = Properties.Resources.Ordek,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(50, 75),
                Location = new Point(10, 20)
            };

            Label labelIsim = new Label
            {
                Text = "Ýsim: " + isim,
                Location = new Point(pictureBox.Right + 5, pictureBox.Top + 5)
            };

            Label labelYas = new Label
            {
                Text = "Yaþ: " + yas,
                Location = new Point(pictureBox.Right + 5, labelIsim.Bottom + 5)
            };

            ProgressBar progressBar = new ProgressBar
            {
                Minimum = 0,
                Maximum = 100,
                Value = 0,
                Width = 150,
                Height = 20,
                Location = new Point(pictureBox.Right + 5, labelYas.Bottom + 10)
            };

            Button buttonBesle = new Button
            {
                Text = "Besle",
                Location = new Point(pictureBox.Left, pictureBox.Bottom + 20)
            };

            buttonBesle.Click += (sender, ev) =>
            {
                progressBar.Value += 50;

                if (progressBar.Value >= 100)
                {

                    int tavuk = Convert.ToInt32(lblOrdek.Text);
                    ordek += 1;
                    lblOrdek.Text = ordek.ToString();
                    progressBar.Value = 0;
                }
            };

            GroupBox groupBox = new GroupBox
            {
                Text = "Ordek Üretimi",
                Width = 800,
                Height = pictureBox.Height + labelIsim.Height + labelYas.Height + progressBar.Height + buttonBesle.Height + btnTavukSat.Height + 60 // Toplam yükseklik
            };

            groupBox.Controls.AddRange(new Control[] { pictureBox, labelIsim, labelYas, progressBar, buttonBesle });

            ordekGroupBoxes.Add(groupBox);
            groupBoxOrdek.Controls.Add(groupBox);
        }

        private void btnOrdekSat_Click(object sender, EventArgs e)
        {
            int kasaDegeri = Convert.ToInt32(lblKasa.Text);
            kasaDegeri += 35;
            lblKasa.Text = kasaDegeri.ToString();

            int tavukSayisi = Convert.ToInt32(lblOrdek.Text);
            tavukSayisi -= 1;
            lblOrdek.Text = tavukSayisi.ToString();
        }

        private void btnInekEkle_Click(object sender, EventArgs e)
        {
            string isim = Interaction.InputBox("Inek Ýsmi:", "Inek Bilgisi", "");
            int yas = Convert.ToInt32(Interaction.InputBox("Inek Yaþý:", "Inek Bilgisi", ""));

            int kasaDegeri = Convert.ToInt32(lblKasa.Text);
            kasaDegeri -= 700;
            lblKasa.Text = kasaDegeri.ToString();

            PictureBox pictureBox = new PictureBox
            {
                Image = Properties.Resources.Inek,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(50, 75),
                Location = new Point(10, 20)
            };

            Label labelIsim = new Label
            {
                Text = "Ýsim: " + isim,
                Location = new Point(pictureBox.Right + 5, pictureBox.Top + 5)
            };

            Label labelYas = new Label
            {
                Text = "Yaþ: " + yas,
                Location = new Point(pictureBox.Right + 5, labelIsim.Bottom + 5)
            };

            ProgressBar progressBar = new ProgressBar
            {
                Minimum = 0,
                Maximum = 100,
                Value = 0,
                Width = 150,
                Height = 20,
                Location = new Point(pictureBox.Right + 5, labelYas.Bottom + 10)
            };

            Button buttonBesle = new Button
            {
                Text = "Besle",
                Location = new Point(pictureBox.Left, pictureBox.Bottom + 20)
            };

            buttonBesle.Click += (sender, ev) =>
            {
                progressBar.Value += 50;

                if (progressBar.Value >= 100)
                {

                    int Inek = Convert.ToInt32(lblInek.Text);
                    Inek += 1;
                    lblInek.Text = Inek.ToString();
                    progressBar.Value = 0;
                }
            };

            GroupBox groupBox = new GroupBox
            {
                Text = "Inek Üretimi",
                Width = 800,
                Height = pictureBox.Height + labelIsim.Height + labelYas.Height + progressBar.Height + buttonBesle.Height + btnTavukSat.Height + 60 // Toplam yükseklik
            };

            groupBox.Controls.AddRange(new Control[] { pictureBox, labelIsim, labelYas, progressBar, buttonBesle });

            ýnekGroupBoxes.Add(groupBox);
            groupBoxInek.Controls.Add(groupBox);
        }

        private void btnInekSat_Click(object sender, EventArgs e)
        {
            int kasaDegeri = Convert.ToInt32(lblKasa.Text);
            kasaDegeri += 40;
            lblKasa.Text = kasaDegeri.ToString();

            int tavukSayisi = Convert.ToInt32(lblInek.Text);
            tavukSayisi -= 1;
            lblInek.Text = tavukSayisi.ToString();
        }

        private void btnKeciEkle_Click(object sender, EventArgs e)
        {
            string isim = Interaction.InputBox("Keci Ýsmi:", "Keci Bilgisi", "");
            int yas = Convert.ToInt32(Interaction.InputBox("Keci Yaþý:", "Keci Bilgisi", ""));

            int kasaDegeri = Convert.ToInt32(lblKasa.Text);
            kasaDegeri -= 500;
            lblKasa.Text = kasaDegeri.ToString();

            PictureBox pictureBox = new PictureBox
            {
                Image = Properties.Resources.Keci,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(50, 75),
                Location = new Point(10, 20)
            };

            Label labelIsim = new Label
            {
                Text = "Ýsim: " + isim,
                Location = new Point(pictureBox.Right + 5, pictureBox.Top + 5)
            };

            Label labelYas = new Label
            {
                Text = "Yaþ: " + yas,
                Location = new Point(pictureBox.Right + 5, labelIsim.Bottom + 5)
            };

            ProgressBar progressBar = new ProgressBar
            {
                Minimum = 0,
                Maximum = 100,
                Value = 0,
                Width = 150,
                Height = 20,
                Location = new Point(pictureBox.Right + 5, labelYas.Bottom + 10)
            };

            Button buttonBesle = new Button
            {
                Text = "Besle",
                Location = new Point(pictureBox.Left, pictureBox.Bottom + 20)
            };

            buttonBesle.Click += (sender, ev) =>
            {
                progressBar.Value += 50;

                if (progressBar.Value >= 100)
                {

                    int keci = Convert.ToInt32(lblKeci.Text);
                    keci += 1;
                    lblKeci.Text = keci.ToString();
                    progressBar.Value = 0;
                }
            };

            GroupBox groupBox = new GroupBox
            {
                Text = "Keci Üretimi",
                Width = 800,
                Height = pictureBox.Height + labelIsim.Height + labelYas.Height + progressBar.Height + buttonBesle.Height + btnTavukSat.Height + 60 // Toplam yükseklik
            };

            groupBox.Controls.AddRange(new Control[] { pictureBox, labelIsim, labelYas, progressBar, buttonBesle });

            keciGroupBoxes.Add(groupBox);
            groupBoxKeci.Controls.Add(groupBox);
        }

        private void btnKeciSat_Click(object sender, EventArgs e)
        {
            int kasaDegeri = Convert.ToInt32(lblKasa.Text);
            kasaDegeri += 15;
            lblKasa.Text = kasaDegeri.ToString();

            int tavukSayisi = Convert.ToInt32(lblKeci.Text);
            tavukSayisi -= 1;
            lblKeci.Text = tavukSayisi.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {

        }
    }
}