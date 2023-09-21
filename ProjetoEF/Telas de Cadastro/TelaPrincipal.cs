using ProjetoEF.Pesquisa;
using ProjetoEF.Telas_de_Cadastro;

namespace ProjetoEF
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }
        private void btnClientesTelaPrincipal_Click(object sender, EventArgs e)
        {
            TelaDeCadastroClientes telaDeCadastroClientes = new TelaDeCadastroClientes();
            telaDeCadastroClientes.ShowDialog();
        }
        private void btnFornecedoresTelaPrincipal_Click(object sender, EventArgs e)
        {
            TelaDeCadastroFornecedores telaDeCadastroFornecedores = new TelaDeCadastroFornecedores();
            telaDeCadastroFornecedores.ShowDialog();
        }
        private void btnPecas_Click(object sender, EventArgs e)
        {
            TelaDeCadastroPecas telaDeCadastroPecas = new TelaDeCadastroPecas();
            telaDeCadastroPecas.ShowDialog();
        }

        private void btnOrcamento_Click(object sender, EventArgs e)
        {
            Orcamento orc = new Orcamento();
            orc.ShowDialog();
        }
        private void btnConsultarOrcamentos_Click(object sender, EventArgs e)
        {
            PesquisaNumeroOrc pesquisa = new PesquisaNumeroOrc();
            pesquisa.ShowDialog();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup();
            backup.ShowDialog();
        }

        private void btnSairDoSistema_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja sair do sistema ?", "Pergunta do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}