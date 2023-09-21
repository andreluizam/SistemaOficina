using ProjetoEF.Contexto;

namespace ProjetoEF
{
    public partial class TelaDeCadastroClientes : Form
    {
        public TelaDeCadastroClientes()
        {
            InitializeComponent();
            desabilitaBotao();
        }

        #region Variaveis
        int clienteID;
        #endregion

        #region Manipulacao dos campos
        private void letraMaiscula()
        {
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtCarro.CharacterCasing = CharacterCasing.Upper;
            txtCidade.CharacterCasing = CharacterCasing.Upper;
            txtEstado.CharacterCasing = CharacterCasing.Upper;
            txtBairro.CharacterCasing = CharacterCasing.Upper;
            txtPlaca.CharacterCasing = CharacterCasing.Upper;
            txtRua.CharacterCasing = CharacterCasing.Upper;
        }
        private void desabilitaBotao()
        {
            txtNome.Focus();
            btnNovo.Visible = true;
            btnCancelar.Visible = false;
            btnSalvar.Enabled = false;
            btnAlterar.Visible = false;
            btnApagar.Enabled = false;
            lblNome.Enabled = false;
            lblCpfCnpj.Enabled = false;
            lblTelefone.Enabled = false;
            lblCarro.Enabled = false;
            lblPlaca.Enabled = false;
            lblCep.Enabled = false;
            lblUf.Enabled = false;
            lblBairro.Enabled = false;
            lblRua.Enabled = false;
            txtNome.Enabled = false;
            txtCpfCnpj.Enabled = false;
            txtTelefone.Enabled = false;
            txtCarro.Enabled = false;
            txtPlaca.Enabled = false;
            txtCep.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            txtBairro.Enabled = false;
            txtRua.Enabled = false;
            lblCodigo.Enabled = false;
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
            lblCarro.Enabled = true;
            lblPlaca.Enabled = true;
            lblCep.Enabled = true;
            lblUf.Enabled = true;
            lblBairro.Enabled = true;
            lblRua.Enabled = true;
            txtNome.Enabled = true;
            txtCpfCnpj.Enabled = true;
            txtTelefone.Enabled = true;
            txtCarro.Enabled = true;
            txtPlaca.Enabled = true;
            txtCep.Enabled = true;
            txtCidade.Enabled = true;
            txtEstado.Enabled = true;
            txtBairro.Enabled = true;
            txtRua.Enabled = true;
            lblCodigo.Enabled = true;
        }
        private void limparCampos()
        {
            lblCodi.Text = "";
            txtNome.Text = "";
            txtCpfCnpj.Text = "";
            txtTelefone.Text = "";
            txtCarro.Text = "";
            txtPlaca.Text = "";
            txtCep.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtBairro.Text = "";
            txtRua.Text = "";
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            letraMaiscula();
            habilitaBotao();
            limparCampos();
            txtNome.Focus();
            btnNovo.Visible = false;
            btnCancelar.Visible = true;
            btnApagar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            letraMaiscula();
            limparCampos();
            desabilitaBotao();
            btnNovo.Visible = true;

        }
        #endregion

        #region Manipulação de dados
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" || txtNome.Text != null)
            {
                Cliente cliente;

                using (DataContext context = new DataContext())
                {
                    cliente = new Cliente();
                    cliente.Nome = txtNome.Text;
                    cliente.CpfCnpj = txtCpfCnpj.Text;
                    cliente.Telefone = txtTelefone.Text;
                    cliente.Carro = txtCarro.Text;
                    cliente.Placa = txtPlaca.Text;
                    cliente.Cep = txtCep.Text;
                    cliente.Cidade = txtCidade.Text;
                    cliente.Estado = txtEstado.Text;
                    cliente.Bairro = txtBairro.Text;
                    cliente.Rua = txtRua.Text;
                    context.Clientes.Add(cliente);
                    context.SaveChanges();

                    MessageBox.Show("Gravação Realizada com Sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                };
                limparCampos();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente cliente = null;

            using (DataContext context = new DataContext())
            {
                cliente = context.Clientes.FirstOrDefault(o => o.ID == clienteID);
                cliente.Nome = txtNome.Text;
                cliente.CpfCnpj = txtCpfCnpj.Text;
                cliente.Telefone = txtTelefone.Text;
                cliente.Carro = txtCarro.Text;
                cliente.Placa = txtPlaca.Text;
                cliente.Cep = txtCep.Text;
                cliente.Cidade = txtCidade.Text;
                cliente.Estado = txtEstado.Text;
                cliente.Bairro = txtBairro.Text;
                cliente.Rua = txtRua.Text;

                context.SaveChanges();

                MessageBox.Show("Atualização Realizada com Sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            limparCampos();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    Cliente cliente = null;
                    using (DataContext context = new DataContext())
                    {
                        cliente = context.Clientes.FirstOrDefault(o => o.ID == clienteID);
                        context.Remove(cliente);
                        context.SaveChanges();
                        MessageBox.Show("Exclusão Realizada com Sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("Clientes vinculados á orçamentos não são possíveis de excluir", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limparCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PequisaCliente pesquisa = new PequisaCliente();
            pesquisa.ShowDialog();
            if (pesquisa.ClienteSelecionado != null)
            {
                clienteID = pesquisa.ClienteSelecionado.ID;
                lblCodi.Text = clienteID.ToString();
                txtNome.Text = pesquisa.ClienteSelecionado.Nome;
                txtCpfCnpj.Text = pesquisa.ClienteSelecionado.CpfCnpj;
                txtTelefone.Text = pesquisa.ClienteSelecionado.Telefone;
                txtCarro.Text = pesquisa.ClienteSelecionado.Carro;
                txtPlaca.Text = pesquisa.ClienteSelecionado.Placa;
                txtCep.Text = pesquisa.ClienteSelecionado.Cep;
                txtCidade.Text = pesquisa.ClienteSelecionado.Cidade;
                txtEstado.Text = pesquisa.ClienteSelecionado.Estado;
                txtBairro.Text = pesquisa.ClienteSelecionado.Bairro;
                txtRua.Text = pesquisa.ClienteSelecionado.Rua;

                btnAlterar.Visible = true;
                btnApagar.Enabled = true;
                habilitaBotao();
            }
        }
        #endregion

        #region Tecla enter
        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sender == txtNome)
                {
                    txtCpfCnpj.Focus();
                }
                else if (sender == txtCpfCnpj)
                {
                    txtTelefone.Focus();
                }
                else if (sender == txtTelefone)
                {
                    txtCarro.Focus();
                }
                else if (sender == txtCarro)
                {
                    txtPlaca.Focus();
                }
                else if (sender == txtPlaca)
                {
                    txtCep.Focus();
                }
                else if (sender == txtCep)
                {
                    txtCidade.Focus();
                }
                else if (sender == txtCidade)
                {
                    txtEstado.Focus();
                }
                else if (sender == txtEstado)
                {
                    txtBairro.Focus();
                }
                else if (sender == txtBairro)
                {
                    txtRua.Focus();
                }
                else
                {
                    btnSalvar.Focus();
                }
            }
        }
        #endregion

        private void TelaDeCadastroClientes_Load(object sender, EventArgs e)
        {
            desabilitaBotao();
            btnAlterar.Visible = false;
            btnSalvar.Visible = true;
        }
    }
}