namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sayi1;
        double sayi2;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnart�_Click(object sender, EventArgs e)
        {
            sayi1=double.Parse(textBox1.Text);
            sayi2=double.Parse(textBox2.Text);


            double sonuc = sayi1 + sayi2;
            lblsonuc.Text=sonuc.ToString();
        }

        private void btneksi_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            sayi2 = double.Parse(textBox2.Text);
            double sonuc = sayi1 - sayi2;
            lblsonuc.Text = sonuc.ToString();
        }

        private void btn�arp_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            sayi2 = double.Parse(textBox2.Text);
            double sonuc = sayi1 * sayi2;
            lblsonuc.Text = sonuc.ToString();
        }

        private void btnb�l_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            sayi2 = double.Parse(textBox2.Text);
            double sonuc = sayi1 / sayi2;
            lblsonuc.Text = sonuc.ToString();
        }
    }
}