namespace Q4_TabuadaTradicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, r;
            n = Convert.ToInt32(txtn.Text);

            for(int i = 1; i <= 10; i++)
            {
                r = n * i;
                lstt.Items.Add(($"{n} x {i} = {r}"));
            }


        }

        private void lstt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
