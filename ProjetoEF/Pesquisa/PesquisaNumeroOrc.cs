using ProjetoEF.Contexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEF.Pesquisa
{
    public partial class PesquisaNumeroOrc : Form
    {
        public PesquisaNumeroOrc()
        {
            InitializeComponent();
        }

        private Orcamentos orcamentoSelecionado;
        List<Orcamentos> lstOrcamentos;

        private void PesquisaNumeroOrc_Load(object sender, EventArgs e)
        {
            lstOrcamentos = new List<Orcamentos>();
            CarregaDados();
        }

        private void CarregaDados()
        {
            OrcamentosItem orcamento;
            using (DataContext context = new DataContext())
            {
                lstOrcamentos = context.Orcamentos.ToList();
                gridOrcamentos.DataSource = lstOrcamentos.ToList();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente cliente = null;
            using (DataContext context = new DataContext())
            {
                if (e.RowIndex >= 0 && e.RowIndex < gridOrcamentos.Rows.Count)
                {
                    orcamentoSelecionado = new Orcamentos
                    {
                        ID = int.Parse(gridOrcamentos.Rows[gridOrcamentos.CurrentRow.Index].Cells["ID"].Value.ToString()),
                        ClienteID = int.Parse(gridOrcamentos.Rows[gridOrcamentos.CurrentRow.Index].Cells["ClienteID"].Value.ToString()),
                        Data = Convert.ToDateTime(gridOrcamentos.Rows[gridOrcamentos.CurrentRow.Index].Cells["Data"].Value.ToString()),
                        Carro = gridOrcamentos.Rows[gridOrcamentos.CurrentRow.Index].Cells["Carro"].Value.ToString(),
                        Total = Convert.ToDecimal(gridOrcamentos.Rows[gridOrcamentos.CurrentRow.Index].Cells["Total"].Value.ToString()),
                    };
                }
                this.Close();
            }
        }

        public Orcamentos OrcamentoSelecionado
        {
            get { return orcamentoSelecionado; }
        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            PequisaCliente pesquisa = new PequisaCliente();
            pesquisa.ShowDialog();
            if (pesquisa.ClienteSelecionado != null)
            {
                txtCliente.Text = pesquisa.ClienteSelecionado.Nome;
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtCliente != null)
            {
                int nomePesquisa = Convert.ToInt16(txtCliente.Text);

                using (DataContext context = new DataContext())
                {
                    var resultados = context.Orcamentos
                        .Where(orcamentos => orcamentos.ClienteID.Equals(nomePesquisa))
                        .ToList();

                    gridOrcamentos.DataSource = resultados;
                }
            }
        }
    }
}
