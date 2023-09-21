using ProjetoEF.Contexto;
using System.Windows.Forms;

namespace ProjetoEF.Pesquisa
{
    public partial class PesquisaPec : Form
    {
        public PesquisaPec()
        {
            InitializeComponent();
        }

        List<Pecas> lstPecas;
        private Pecas pecasSelecionada;

        private void PesquisaPec_Load(object sender, EventArgs e)
        {
            lstPecas = new List<Pecas>();
            CarregaDados();
            txtPesquisa.Focus();
        }
        private void CarregaDados()
        {
            using (DataContext context = new DataContext())
            {
                lstPecas = context.Pecas.ToList();
                gridPecas.DataSource = lstPecas.ToList();
            }
        }
        #region Seleciona peça
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gridPecas.Rows.Count)
            {
                pecasSelecionada = new Pecas
                {
                    ID = int.Parse(gridPecas.Rows[e.RowIndex].Cells["ID"].Value.ToString()),
                    Nome = gridPecas.Rows[gridPecas.CurrentRow.Index].Cells["Nome"].Value.ToString(),
                    Valor = decimal.Parse(gridPecas.Rows[gridPecas.CurrentRow.Index].Cells["Valor"].Value.ToString()),
                    Estoque = decimal.Parse(gridPecas.Rows[gridPecas.CurrentRow.Index].Cells["Estoque"].Value.ToString())
                };
                this.Close();
            }
        }

        #endregion

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa != null)
            {
                string nomePesquisa = txtPesquisa.Text.Trim();
                using (DataContext context = new DataContext())
                {
                    var resultados = context.Pecas
                        .Where(peca => peca.Nome.Contains(nomePesquisa))
                        .ToList();

                    gridPecas.DataSource = resultados;
                }
            }
        }
        public Pecas PecaSelecionada
        {
            get { return pecasSelecionada; }
        }
    }
}
