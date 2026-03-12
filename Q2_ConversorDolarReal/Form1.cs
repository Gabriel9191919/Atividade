namespace Q2_ConversorDolarReal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double d, r, c;

            c = Convert.ToDouble(txtC.Text);
            d = Convert.ToDouble(txtD.Text);
            r = d * c;
            txtRes.Text = ($"O valor em Reais é:{r.ToString()} ");
        }
    }
}
