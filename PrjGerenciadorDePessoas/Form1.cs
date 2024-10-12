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
            Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Apenas números podem ser utilizados no campo idade!!!", "Campo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Reset();

            MessageBox.Show("Pessoa adicionada com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lstPessoas_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = true;
            btnVer.Enabled = true;
            btnCriar.Enabled = false;

            if (lstPessoas.SelectedItem != null)
            {
                Pessoa p = (Pessoa)lstPessoas.SelectedItem;//casting
                txtNome.Text = p.Nome;
                txtIdade.Text = p.Idade.ToString();
            }
            else
            {
                btnSalvar.Enabled = false;
                btnExcluir.Enabled = false;
                btnVer.Enabled = false;
                btnCriar.Enabled = true;
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
            Reset();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //if (lstPessoas.SelectedItem == null)
            //{
            //    MessageBox.Show("Não há itens selecionados na lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //else
            //{
            DialogResult ExcluirPessoa = MessageBox.Show($"Tem certeza que deseja excluir {lstPessoas.SelectedItem}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (ExcluirPessoa == DialogResult.Yes)
            {
                lstPessoas.Items.Remove(lstPessoas.SelectedItem);

                Reset();
            }
            //}
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lstPessoas.SelectedItem != null)
            {
                try
                {
                    this.pessoa = (Pessoa)lstPessoas.SelectedItem;
                    this.pessoa.Nome = txtNome.Text;
                    this.pessoa.Idade = Convert.ToInt32(txtIdade.Text);
                    lstPessoas.Items[lstPessoas.SelectedIndex] = this.pessoa;

                    Reset();

                    MessageBox.Show("Dados da pessoa atualizados com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Apenas números podem ser utilizados no campo idade!!!", "Campo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Nome: {pessoa.Nome}\nIdade: {pessoa.getIdadeFormatada()}", "Detalhes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimparCaixa_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            txtNome.Clear();
            txtIdade.Clear();
            txtNome.Focus();
            lstPessoas.SelectedItem = null;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnVer.Enabled = false;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string conteudoArquivo = $"Nome: {this.pessoa.Nome} - Idade:{this.pessoa.getIdadeFormatada()}";

            try
            {
                File.WriteAllText("relatorio//relatorio.txt", conteudoArquivo);
                MessageBox.Show("Relátório gerado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            //caso tenha mais codigo após os catches é importante o uso do -----return-----
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show("Houve um erro na criação do diretório. Pasta não encontrada!","Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}