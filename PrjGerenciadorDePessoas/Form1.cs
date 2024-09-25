using PrjHelloWorld.Models;

namespace PrjGerenciadorDePessoas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text;
            int Idade = Convert.ToInt32(txtIdade.Text);

            Pessoa p = new Pessoa(Nome,Idade);
        }
    }
}