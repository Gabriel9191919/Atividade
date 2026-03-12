namespace Q3_PassagemPorDistancia
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            double d, v;
            d = Convert.ToDouble(txtD.Text);
            if (d <= 200)
            {
                v = d * 0.50;
            }
            else
            {
                v = d * 0.45;
            }

            lblR.Text = v.ToString();
        }
    }
}
