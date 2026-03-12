namespace Exec1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c, f;
            c = Convert.ToDouble(txtC.Text);
            f = (c * 9 / 5) + 32;
            txtF.Text = f.ToString();
        }
    }
}
