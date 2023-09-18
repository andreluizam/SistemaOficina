using ProjetoEF.Contexto;
using ProjetoEF.Pesquisa;

namespace ProjetoEF.Telas_de_Cadastro
{
    public partial class TelaDeCadastroPecas : Form
    {
        public TelaDeCadastroPecas()
        {
            InitializeComponent();
            desabilitaBotao();
            letraMaiscula();
        }

        #region Varíaveis
        int pecasID;
        #endregion

        #region Manipulacao dos campos
        private void letraMaiscula()
        {
            txtNome.CharacterCasing = CharacterCasing.Upper;
        }
        private void desabilitaBotao()
        {
            txtNome.Focus();
            btnNovo.Visible = true;
            btnCancelar.Visible = false;
            btnSalvar.Enabled = false;
            btnAlterar.Visible = false;
            btnApagar.Enabled = false;
        }
        private void habilitaBotao()
        {
            txtNome.Enabled = true;
            txtValor.Enabled = true;
            txtQtd.Enabled = true;
            btnNovo.Enabled = true;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = true;
            btnApagar.Enabled = true;
            btnCancelar.Visible = true;
        }
        private void limparCampos()
        {
            txtNome.Text = "";
            lblCodi.Text = "";
            txtNome.Clear();
            txtValor.Clear();
            txtQtd.Clear();
        }
        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            letraMaiscula();
            habilitaBotao();
            limparCampos();
            btnNovo.Visible = false;
            btnCancelar.Visible = true;
            btnApagar.Enabled = false;
            txtNome.Focus();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNovo.Visible = true;
            desabilitaBotao();
        }
        #endregion

        #region Manipulação de dados
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo nome.", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }
            if (txtValor.Text == "")
            {
                MessageBox.Show("Obrigatório informar o valor do produto.", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValor.Focus();
            }
            else if (txtQtd.Text == "")
            {
                MessageBox.Show("Obrigatório informar a quantidade em estoque", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtd.Focus();
            }
            Pecas pecas = null;

            using (DataContext context = new DataContext())
            {
                pecas = new Pecas();
                pecas.Nome = txtNome.Text;
                pecas.Valor = Convert.ToDecimal(txtValor.Text);
                pecas.Estoque = Convert.ToDecimal(txtQtd.Text);
                context.Add(pecas);
                context.SaveChanges();
                MessageBox.Show("Gravação realizada com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limparCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Pecas pecas = null;
            using (DataContext context = new DataContext())
            {
                pecas = context.Pecas.FirstOrDefault(o => o.ID == pecasID);
                pecas.Nome = txtNome.Text;
                pecas.Valor = Convert.ToDecimal(txtValor.Text);
                pecas.Estoque = Convert.ToDecimal(txtQtd.Text);
                context.SaveChanges();
                MessageBox.Show("Alteração realizada com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limparCampos();
        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            Pecas pecas;
            using (DataContext context = new DataContext())
            {
                try
                {
                    pecas = context.Pecas.FirstOrDefault(o => o.ID == pecasID);
                    context.Remove(pecas);
                    context.SaveChanges();
                    MessageBox.Show("Exclusão realizada com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Peça utilizada em orçamento, não é possível excluir", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            limparCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisaPec pesquisa = new PesquisaPec();
            pesquisa.ShowDialog();

            if (pesquisa.PecaSelecionada != null)
            {
                lblCodi.Text = pesquisa.PecaSelecionada.ID.ToString();
                pecasID = pesquisa.PecaSelecionada.ID;
                txtNome.Text = pesquisa.PecaSelecionada.Nome;
                txtValor.Text = pesquisa.PecaSelecionada.Valor.ToString();
                txtQtd.Text = pesquisa.PecaSelecionada.Estoque.ToString();

                btnAlterar.Visible = true;
                btnApagar.Enabled = true;
            }
        }

        private void panelRadio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioOutros_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    #endregion
}