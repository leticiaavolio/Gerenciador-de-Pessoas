using PrjHelloWorld.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

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
            cbxTipoDoc.Text = ".TXT";
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
            //string conteudoArquivo = $"Nome: {this.pessoa.Nome} - Idade:{this.pessoa.getIdadeFormatada()}";

            try
            {
                if (cbxTipoDoc.Text == ".TXT")
                {
                    gerarRelatorio(SerializarParaTxt());
                }
                else
                {
                    gerarRelatorio(SerializarParaJson());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void gerarRelatorio(string conteudo)
        {
            try
            {
                File.WriteAllText("relatorio/relatorio.txt", conteudo);

                MessageBox.Show($"Relatório gerado com sucesso no formato {cbxTipoDoc.Text}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show("Houve um erro na criação do diretório. Pasta não encontrada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private string SerializarParaTxt()
        {
            Pessoa p;

            string linha = "";

            for (int i = 0; i < lstPessoas.Items.Count; i++)
            {
                p = (Pessoa)lstPessoas.Items[i];
                linha = $"{linha}" + $"{p.Nome} - {p.getIdadeFormatada()}\n";
            }

            return linha;
        }

        private string SerializarParaJson()
        {
            string linha = "";
            Pessoa pessoa;
            List<Pessoa> listaPessoas = new List<Pessoa>();

            for (int i = 0; i < lstPessoas.Items.Count; i++)
            {
                pessoa = (Pessoa)lstPessoas.Items[i];
                listaPessoas.Add(pessoa);
            }
            string json = JsonSerializer.Serialize(listaPessoas, new JsonSerializerOptions { WriteIndented = true });
            return json;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}