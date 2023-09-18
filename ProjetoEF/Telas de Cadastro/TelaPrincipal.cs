using ProjetoEF.Pesquisa;
using ProjetoEF.Telas_de_Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            telaDeCadastroClientes.Show();
        }
        private void btnFornecedoresTelaPrincipal_Click(object sender, EventArgs e)
        {
            TelaDeCadastroFornecedores telaDeCadastroFornecedores = new TelaDeCadastroFornecedores();
            telaDeCadastroFornecedores.Show();
        }
        private void btnPecas_Click(object sender, EventArgs e)
        {
            TelaDeCadastroPecas telaDeCadastroPecas = new TelaDeCadastroPecas();
            telaDeCadastroPecas.Show();
        }

        private void btnOrcamento_Click(object sender, EventArgs e)
        {
            Orcamento orc = new Orcamento();
            orc.Show();
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