using ProjetoEF.Modelo;
using ProjetoEF.Contexto;
using ProjetoEF.Pesquisa;

namespace ProjetoEF
{
    public partial class TelaDeCadastroFornecedores : Form
    {
        public TelaDeCadastroFornecedores()
        {
            InitializeComponent();
            desabilitaBotao();
            letraMaiscula();
        }
        #region Variáveis
        int fornecedorID;
        #endregion

        #region Manipulacao dos campos

        private void letraMaiscula()
        {
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtFantasia.CharacterCasing = CharacterCasing.Upper;
            txtCidade.CharacterCasing = CharacterCasing.Upper;
            txtEstado.CharacterCasing = CharacterCasing.Upper;
            txtBairro.CharacterCasing = CharacterCasing.Upper;
            txtSituacao.CharacterCasing = CharacterCasing.Upper;
            txtRua.CharacterCasing = CharacterCasing.Upper;
        }
        private void desabilitaBotao()
        {
            btnNovo.Visible = true;
            btnCancelar.Visible = false;
            btnSalvar.Enabled = false;
            btnAlterar.Visible = false;
            btnApagar.Enabled = false;
            lblCodigo.Visible = false;
            lblCodi.Visible = false;
            lblNome.Enabled = false;
            lblCpfCnpj.Enabled = false;
            lblTelefone.Enabled = false;
            lbSituacao.Enabled = false;
            lblFantasia.Enabled = false;
            lblCep.Enabled = false;
            lblUf.Enabled = false;
            lblBairro.Enabled = false;
            lblRua.Enabled = false;
            txtNome.Enabled = false;
            txtCpfCnpj.Enabled = false;
            txtTelefone.Enabled = false;
            txtSituacao.Enabled = false;
            txtFantasia.Enabled = false;
            txtCep.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            txtBairro.Enabled = false;
            txtRua.Enabled = false;
            txtData.Enabled = false;
            txtNumero.Enabled = false;
            txtEmail.Enabled = false;
            lblData.Enabled = false;
            lblNumero.Enabled = false;
            lblEmail.Enabled = false;
        }
        private void habilitaBotao()
        {
            btnNovo.Enabled = true;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = true;
            btnApagar.Enabled = true;
            btnCancelar.Visible = true;
            lblNome.Enabled = true;
            lblCpfCnpj.Enabled = true;
            lblTelefone.Enabled = true;
            lbSituacao.Enabled = true;
            lblFantasia.Enabled = true;
            lblCep.Enabled = true;
            lblUf.Enabled = true;
            lblBairro.Enabled = true;
            lblRua.Enabled = true;
            txtNome.Enabled = true;
            txtCpfCnpj.Enabled = true;
            txtTelefone.Enabled = true;
            txtSituacao.Enabled = true;
            txtFantasia.Enabled = true;
            txtCep.Enabled = true;
            txtCidade.Enabled = true;
            txtEstado.Enabled = true;
            txtBairro.Enabled = true;
            txtRua.Enabled = true;
            txtData.Enabled = true;
            txtNumero.Enabled = true;
            txtEmail.Enabled = true;
            lblData.Enabled = true;
            lblNumero.Enabled = true;
            lblEmail.Enabled = true;
            lblCodigo.Visible = true;
            lblCodi.Visible = true;
        }
        private void limparCampos()
        {
            txtNome.Clear();
            txtCpfCnpj.Clear();
            txtTelefone.Clear();
            txtSituacao.Clear();
            txtFantasia.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtBairro.Clear();
            txtRua.Clear();
            txtEmail.Clear();
            txtData.Clear();
            txtNumero.Clear();
            lblCodi.Text = "";
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaBotao();
            btnNovo.Visible = false;
            btnCancelar.Visible = true;
            txtCpfCnpj.Focus();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitaBotao();
            btnNovo.Visible = true;

        }
        #endregion

        #region Manipulação de dados
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Fornecedores fornecedor;
            using (DataContext context = new DataContext())
            {
                fornecedor = new Fornecedores();
                fornecedor.Nome = txtNome.Text;
                fornecedor.Fantasia = txtFantasia.Text;
                fornecedor.CpfCnpj = txtCpfCnpj.Text;
                fornecedor.Telefone = txtTelefone.Text;
                fornecedor.Situacao = txtSituacao.Text;
                fornecedor.Cep = txtCep.Text;
                fornecedor.DataCriacao = txtData.Text;
                fornecedor.Email = txtEmail.Text;
                fornecedor.Bairro = txtBairro.Text;
                fornecedor.Cidade = txtCidade.Text;
                fornecedor.Numero = txtNumero.Text;
                fornecedor.Estado = txtEstado.Text;
                fornecedor.Rua = txtRua.Text;
                context.Add(fornecedor);
                context.SaveChanges();

                MessageBox.Show("Gravação realizada com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limparCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Fornecedores fornecedor;
            using (DataContext context = new DataContext())
            {
                fornecedor = context.Fornecedores.FirstOrDefault(o => o.ID == fornecedorID);
                fornecedor.Nome = txtNome.Text;
                fornecedor.Fantasia = txtFantasia.Text;
                fornecedor.CpfCnpj = txtCpfCnpj.Text;
                fornecedor.Telefone = txtTelefone.Text;
                fornecedor.Situacao = txtSituacao.Text;
                fornecedor.Cep = txtCep.Text;
                fornecedor.DataCriacao = txtData.Text;
                fornecedor.Email = txtEmail.Text;
                fornecedor.Bairro = txtBairro.Text;
                fornecedor.Cidade = txtCidade.Text;
                fornecedor.Numero = txtNumero.Text;
                fornecedor.Estado = txtEstado.Text;
                context.SaveChanges();
                MessageBox.Show("Alteração salva com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limparCampos();
        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            Fornecedores fornecedor;
            using (DataContext context = new DataContext())
            {
                fornecedor = context.Fornecedores.FirstOrDefault(o => o.ID == fornecedorID);
                context.Remove(fornecedor);
                context.SaveChanges();
                MessageBox.Show("Exclusão realizada com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limparCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisaFornecedor pesquisa = new PesquisaFornecedor();
            pesquisa.ShowDialog();
            if (pesquisa.FornecedorSelecionado != null)
            {
                fornecedorID = pesquisa.FornecedorSelecionado.ID;
                lblCodi.Text = fornecedorID.ToString();
                txtNome.Text = pesquisa.FornecedorSelecionado.Nome;
                txtFantasia.Text = pesquisa.FornecedorSelecionado.Fantasia;
                txtCpfCnpj.Text = pesquisa.FornecedorSelecionado.CpfCnpj;
                txtTelefone.Text = pesquisa.FornecedorSelecionado.Telefone;
                txtSituacao.Text = pesquisa.FornecedorSelecionado.Situacao;
                txtData.Text = pesquisa.FornecedorSelecionado.DataCriacao;
                txtCep.Text = pesquisa.FornecedorSelecionado.Cep;
                txtCidade.Text = pesquisa.FornecedorSelecionado.Cidade;
                txtEstado.Text = pesquisa.FornecedorSelecionado.Estado;
                txtBairro.Text = pesquisa.FornecedorSelecionado.Bairro;
                txtRua.Text = pesquisa.FornecedorSelecionado.Rua;
                txtNumero.Text = pesquisa.FornecedorSelecionado.Numero;
                txtEmail.Text = pesquisa.FornecedorSelecionado.Email;

                btnAlterar.Visible = true;
                btnApagar.Enabled = true;
                habilitaBotao();
            }
        }
        #endregion

        #region Obter Cnpj
        private void ObterCnpj()
        {
            var cnpj = Empresa.ObterByCnpj(txtCpfCnpj.Text);
            if (cnpj != null)
            {
                txtNome.Text = cnpj.nome;
                txtBairro.Text = cnpj.bairro;
                txtCep.Text = cnpj.cep;
                txtEstado.Text = cnpj.uf;
                txtCidade.Text = cnpj.municipio;
                txtRua.Text = cnpj.logradouro;
                txtTelefone.Text = cnpj.telefone;
                txtSituacao.Text = cnpj.situacao;
                txtFantasia.Text = cnpj.fantasia;
                txtData.Text = cnpj.abertura;
                txtNumero.Text = cnpj.numero;
                txtEmail.Text = cnpj.email;
            }
        }

        private void txtCpfCnpj_Leave(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Consultar esse CNPJ na receita federal ?", "Aviso do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                ObterCnpj();
            }
        }
        #endregion

    }
}