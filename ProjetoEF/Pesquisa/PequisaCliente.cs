using ProjetoEF.Contexto;

namespace ProjetoEF
{
    public partial class PequisaCliente : Form
    {
        List<Cliente> lstClientes;
        private Cliente clienteSelecionado;

        public PequisaCliente()
        {
            InitializeComponent();
        }

        private void PequisaCliente_Load(object sender, EventArgs e)
        {
            lstClientes = new List<Cliente>();
            CarregaDados();
        }
        private void CarregaDados()
        {
            using (DataContext context = new DataContext())
            {
                lstClientes = context.Clientes.ToList();
                gridClientes.DataSource = lstClientes.ToList();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gridClientes.Rows.Count)
            {
                clienteSelecionado = new Cliente
                {
                    ID = int.Parse(gridClientes.Rows[gridClientes.CurrentRow.Index].Cells["ID"].Value.ToString()),
                    Nome = gridClientes.Rows[gridClientes.CurrentRow.Index].Cells["Nome"].Value.ToString(),
                    CpfCnpj = gridClientes.Rows[gridClientes.CurrentRow.Index].Cells["CpfCnpj"].Value.ToString(),
                    Telefone = gridClientes.Rows[gridClientes.CurrentRow.Index].Cells["Telefone"].Value.ToString(),
                    Carro = gridClientes.Rows[gridClientes.CurrentRow.Index].Cells["Carro"].Value.ToString(),
                    Placa = gridClientes.Rows[gridClientes.CurrentRow.Index].Cells["Placa"].Value.ToString(),
                    Cep = gridClientes.Rows[gridClientes.CurrentRow.Index].Cells["Cep"].Value.ToString(),
                    Cidade = gridClientes.Rows[gridClientes.CurrentRow.Index].Cells["Cidade"].Value.ToString(),
                    Estado = gridClientes.Rows[gridClientes.CurrentRow.Index].Cells["Estado"].Value.ToString(),
                    Bairro = gridClientes.Rows[gridClientes.CurrentRow.Index].Cells["Bairro"].Value.ToString(),
                    Rua = gridClientes.Rows[gridClientes.CurrentRow.Index].Cells["Rua"].Value.ToString()
                };
                this.Close();
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome != null)
            {
                string nomePesquisa = txtNome.Text.Trim();
                using (DataContext context = new DataContext())
                {
                    var resultados = context.Clientes
                        .Where(cliente => cliente.Nome.Contains(nomePesquisa))
                        .ToList();

                    gridClientes.DataSource = resultados;
                }
            }
        }

        public Cliente ClienteSelecionado
        {
            get { return clienteSelecionado; }
        }
    }
}