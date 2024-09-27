using PrjHelloWorld.Models;

namespace PrjGerenciadorDePessoas
{
    public partial class Form1 : Form
    {
        private Pessoa pessoa;// declarar

        private List<Pessoa> pessoas = new List<Pessoa>();

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

        private void btnCriar_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = String.Empty;
            try
            {
                string Nome = txtNome.Text;
                int Idade = Convert.ToInt32(txtIdade.Text);//pode lançar exception

                this.pessoa = new Pessoa(Nome, Idade);//atribuir
                //List<Pessoa> pessoas = new List<Pessoa>();//declarando a variavel e criando o objeto lista de pessoas
                //List<Pessoa> pessoas;//declarando a variavel //criando o objeto lista de pessoas
                pessoas.Add(pessoa);//Adicionando a pessoa criada na lista
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }

            txtNome.Clear();
            txtIdade.Clear();
            txtNome.Focus();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            //lblMensagem.Text = $"{pessoa.Nome} - {pessoa.getIdadeFormatada()}";
            //lblMensagem.Text = pessoa.exibirDadosPessoa();
            //for (int contador = 0; contador < this.pessoas.Count; contador++)
            //{
            //    lblMensagem.Text = $"{lblMensagem.Text}{this.pessoas[contador].Nome}\n";
            //}
            foreach (var pessoa in pessoas)
            {
                lblMensagem.Text = $"{lblMensagem.Text}{pessoa.Nome}\n";
            }

        }
    }
}