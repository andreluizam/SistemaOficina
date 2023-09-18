using ProjetoEF.Contexto;
using ProjetoEF.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEF.Pesquisa
{
    public partial class PesquisaFornecedor : Form
    {
        List<Fornecedores> lstFornecedor;
        private Fornecedores fornecedorSelecionado;

        public PesquisaFornecedor()
        {
            InitializeComponent();
        }

        private void PesquisaFornecedor_Load(object sender, EventArgs e)
        {
            lstFornecedor = new List<Fornecedores>();
            CarregaDados();
        }

        private void CarregaDados()
        {
            using (DataContext context = new DataContext())
            {
                lstFornecedor = context.Fornecedores.ToList();
                gridFornecedores.DataSource = lstFornecedor.ToList();
            }
        }

        private void gridFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gridFornecedores.Rows.Count)
            {
                fornecedorSelecionado = new Fornecedores
                {
                    ID = int.Parse(gridFornecedores.Rows[gridFornecedores.CurrentRow.Index].Cells["ID"].Value.ToString()),
                    Nome = gridFornecedores.Rows[gridFornecedores.CurrentRow.Index].Cells["Nome"].Value.ToString(),
                    Fantasia = gridFornecedores.Rows[gridFornecedores.CurrentRow.Index].Cells["Fantasia"].Value.ToString(),
                    CpfCnpj = gridFornecedores.Rows[gridFornecedores.CurrentRow.Index].Cells["CpfCnpj"].Value.ToString(),
                    Telefone = gridFornecedores.Rows[gridFornecedores.CurrentRow.Index].Cells["Telefone"].Value.ToString(),
                    Situacao = gridFornecedores.Rows[gridFornecedores.CurrentRow.Index].Cells["Situacao"].Value.ToString(),
                    DataCriacao = gridFornecedores.Rows[gridFornecedores.CurrentRow.Index].Cells["DataCriacao"].Value.ToString(),
                    Cep = gridFornecedores.Rows[gridFornecedores.CurrentRow.Index].Cells["Cep"].Value.ToString(),
                    Cidade = gridFornecedores.Rows[gridFornecedores.CurrentRow.Index].Cells["Cidade"].Value.ToString(),
                    Estado = gridFornecedores.Rows[gridFornecedores.CurrentRow.Index].Cells["Estado"].Value.ToString(),
                    Bairro = gridFornecedores.Rows[gridFornecedores.CurrentRow.Index].Cells["Bairro"].Value.ToString(),
                    Rua = gridFornecedores.Rows[gridFornecedores.CurrentRow.Index].Cells["Rua"].Value.ToString(),
                    Numero = gridFornecedores.Rows[gridFornecedores.CurrentRow.Index].Cells["Numero"].Value.ToString(),
                    Email = gridFornecedores.Rows[gridFornecedores.CurrentRow.Index].Cells["Email"].Value.ToString(),
                };
                this.Close();
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa != null)
            {
                string nomePesquisa = txtPesquisa.Text.Trim();
                using (DataContext context = new DataContext())
                {
                    var resultados = context.Fornecedores
                        .Where(fornecedor => fornecedor.Nome.Contains(nomePesquisa))
                        .ToList();

                    gridFornecedores.DataSource = resultados;
                }
            }
        }

        public Fornecedores FornecedorSelecionado
        {
            get { return fornecedorSelecionado; }
        }
    }
}
