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
            btnVer.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMensagem.Text = string.Empty;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = String.Empty;
            try
            {
                string Nome = txtNome.Text;
                pessoas.Add(pessoa);
                int Idade = Convert.ToInt32(txtIdade.Text);//pode lançar exception

                this.pessoa = new Pessoa(Nome, Idade);//atribuir
                lstPessoas.Items.Add(pessoa);//adicionando a pessoa criada na listbox
            }
            catch (FormatException)
            {
                lblMensagem.Text = "Apenas números podem ser utilizados no campo idade!!!";
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }

            txtNome.Clear();
            txtIdade.Clear();
            txtNome.Focus();

            MessageBox.Show("Pessoa adicionada com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSalvar.Enabled = true;
            btnVer.Enabled = true;
        }

        private void lstPessoas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPessoas.SelectedItem != null)
            {
                Pessoa p = (Pessoa)lstPessoas.SelectedItem;//casting
                txtNome.Text = p.Nome;
                txtIdade.Text = p.Idade.ToString();

                btnSalvar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            else
            {
                btnSalvar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            DialogResult ApagarLista = MessageBox.Show("Tem certeza que deseja excluir a lista de pessoas?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (ApagarLista == DialogResult.Yes)
            {
                lstPessoas.Items.Clear();

                txtIdade.Clear();
                txtNome.Clear();
                txtNome.Focus();
            }
            btnSalvar.Enabled = false;
            btnVer.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lstPessoas.SelectedItem == null)
            {
                MessageBox.Show("Não há itens selecionados na lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult ExcluirPessoa = MessageBox.Show($"Tem certeza que deseja excluir {lstPessoas.SelectedItem}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if (ExcluirPessoa == DialogResult.Yes)
                {
                    lstPessoas.Items.Remove(lstPessoas.SelectedItem);
                    pessoas.Remove((Pessoa)lstPessoas.SelectedItem);
                    btnSalvar.Enabled = false;
                    btnExcluir.Enabled = false;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (pessoa != null)
            {
                try
                {
                    pessoa.Nome = txtNome.Text;
                    pessoa.Idade = Convert.ToInt32(txtIdade.Text);

                    int selectedIndex = lstPessoas.SelectedIndex;
                    lstPessoas.Items[selectedIndex] = pessoa;

                    MessageBox.Show("Dados da pessoa atualizados com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException)
                {
                    lblMensagem.Text = "Apenas números podem ser utilizados no campo idade!!!";
                }
                catch (Exception ex)
                {
                    lblMensagem.Text = ex.Message;
                }
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Nome: {pessoa.Nome}\nIdade: {pessoa.getIdadeFormatada()}", "Detalhes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}