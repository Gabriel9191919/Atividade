namespace Q5_CadastroSimples
{
    public partial class Form1 : Form
    {

        Pessoa p = new Pessoa();
        Repositorio r = new Repositorio();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            p.nome = txtNome.Text;
            p.idade = Convert.ToInt32(txtIdade.Text);

            r.


            lic.Items.Add(p.nome);
            lic.Items.Add(p.idade);
        }
    }
}
