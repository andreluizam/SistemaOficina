using DGVPrinterHelper;
using ProjetoEF.Contexto;
using ProjetoEF.Pesquisa;
using System.Data;

namespace ProjetoEF.Telas_de_Cadastro
{
    public partial class Orcamento : Form
    {
        public Orcamento()
        {
            InitializeComponent();
        }

        #region Variáveis
        OrcamentosItem orcamentosItens;
        List<OrcamentosItem> lstItens;
        private int linhaSelecionada = -1;
        private decimal valorOriginal;
        int orcamentoID;
        int clienteID;
        int pecasID;
        #endregion

        #region Edita Célula e valor
        private void Orcamento_Load(object sender, EventArgs e)
        {
            lstItens = new List<OrcamentosItem>();
            DataGridViewTextBoxColumn valorColumn = new DataGridViewTextBoxColumn();
            gridItens.CellEndEdit += DataGridView1_CellEndEdit;
            btnExcluir.Enabled = false;
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex == gridItens.Columns["Valor"].Index)
            {
                DataGridViewCell cellValor = gridItens.Rows[e.RowIndex].Cells[e.ColumnIndex];
                decimal novoValor = Convert.ToDecimal(cellValor.Value);
                lstItens[e.RowIndex].Valor = novoValor;
                AtualizarCalculos();
                gridItens.Refresh();
            }
        }

        private void AtualizarCalculos()
        {
            decimal subtotal = 0;
            foreach (var item in lstItens)
            {
                subtotal += item.Quantidade * item.Valor;
                item.Subtotal = subtotal;
            }
            txtValorTotal.Text = subtotal.ToString();
        }
        #endregion

        #region LimpaCampo
        private void limpaCampos()
        {
            lblCodi.Text = "";
            txtClienteOrc.Text = "SELECIONE O CLIENTE";
            txtCarro.Clear();
            txtPeca.Clear();
            txtQtd.Clear();
            txtValor.Clear();
            txtDesconto.Text = "0";
            txtDescontoReais.Text = "0.00";
            txtValorTotal.Text = "0.00";
            maskedTextBox1.Clear();
            lstItens.Clear();
            gridItens.DataSource = lstItens.ToList();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpaCampos();
            btnAlterar.Visible = false;
            btnExcluir.Enabled = false;
        }
        #endregion

        #region Adiciona itens na lista
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                decimal valor = decimal.Parse(txtValor.Text);
                decimal qtd = decimal.Parse(txtQtd.Text);
                decimal total = valor * qtd;
                decimal subtotal = decimal.Parse(txtValorTotal.Text);
                subtotal = subtotal + total;

                if (txtPeca.Text == "" || txtPeca.Text == null)
                {
                    MessageBox.Show("Necessário preencher nome do produto", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                orcamentosItens = new OrcamentosItem();
                orcamentosItens.Descricao = txtPeca.Text;
                orcamentosItens.PecasID = pecasID;
                orcamentosItens.Quantidade = Convert.ToDecimal(txtQtd.Text);
                orcamentosItens.Valor = Convert.ToDecimal(txtValor.Text);
                orcamentosItens.Subtotal = total;

                lstItens.Add(orcamentosItens);
                gridItens.DataSource = lstItens.ToList();
                gridItens.Refresh();

                txtValorTotal.Text = subtotal.ToString("N2");
                txtPeca.Clear();
                txtQtd.Clear();
                txtValor.Clear();
                txtPeca.Focus();
                btnPesquisarProd.Focus();

                valorOriginal = subtotal; // armazena o valor do subtotal para usar no desconto
            }
            catch (Exception)
            {
                MessageBox.Show("Insira valores válidos", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                linhaSelecionada = e.RowIndex;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                decimal subtotal = orcamentosItens.Valor * orcamentosItens.Quantidade;
                if (linhaSelecionada >= 0 && linhaSelecionada < lstItens.Count)
                {
                    lstItens.Remove(orcamentosItens);
                    gridItens.DataSource = lstItens.ToList();
                    valorOriginal = valorOriginal - subtotal;
                    txtValorTotal.Text = valorOriginal.ToString();
                    gridItens.Refresh();
                }
                else
                {
                    MessageBox.Show("Escolha pelo menos um item para remover", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não é possível retirar itens de um orçamento já finalizado", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Pesquisas
        private void PesquisaOrc_Click(object sender, EventArgs e)
        {
            OrcamentosItem orcamentosItem;
            PesquisaNumeroOrc pesquisa = new PesquisaNumeroOrc();

            pesquisa.ShowDialog();

            if (pesquisa.OrcamentoSelecionado != null)
            {
                lblCodi.Text = pesquisa.OrcamentoSelecionado.ID.ToString();
                orcamentoID = pesquisa.OrcamentoSelecionado.ID;
                clienteID = pesquisa.OrcamentoSelecionado.ClienteID;
                maskedTextBox1.Text = pesquisa.OrcamentoSelecionado.Data.ToString();
                txtClienteOrc.Text = pesquisa.OrcamentoSelecionado.ID.ToString();
                txtCarro.Text = pesquisa.OrcamentoSelecionado.Carro.ToString();
                txtValorTotal.Text = pesquisa.OrcamentoSelecionado.Total.ToString();
            }

            using (DataContext context = new DataContext())
            {
                lstItens = context.OrcamentosItem.Where(o => o.OrcamentoID == orcamentoID).ToList();
                gridItens.DataSource = lstItens.ToList();
            }
            txtCarro.Enabled = false;
            btnAlterar.Visible = true;
            btnExcluir.Enabled = true;
        }

        private void btnPesquisarCli_Click(object sender, EventArgs e)
        {
            PequisaCliente pesquisa = new PequisaCliente();
            pesquisa.ShowDialog();

            if (pesquisa.ClienteSelecionado != null)
            {
                clienteID = pesquisa.ClienteSelecionado.ID;
                txtClienteOrc.Text = pesquisa.ClienteSelecionado.Nome;
                txtCarro.Text = pesquisa.ClienteSelecionado.Carro;
                txtTelefone.Text = pesquisa.ClienteSelecionado.Telefone;
            }
            txtPeca.Focus();
            txtClienteOrc.Enabled = false;
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisaPec pesquisa = new PesquisaPec();
            pesquisa.ShowDialog();

            if (pesquisa.PecaSelecionada != null)
            {
                pecasID = pesquisa.PecaSelecionada.ID;
                txtPeca.Text = pesquisa.PecaSelecionada.Nome;
            }
            txtQtd.Focus();
        }
        #endregion 

        #region Desconto

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            calculaDesconto();
        }

        private void txtDescontoReais_Leave(object sender, EventArgs e)
        {
            calculaDescontoReais();
        }

        private void calculaDescontoReais()
        {
            try
            {
                decimal descontoReais = decimal.Parse(txtDescontoReais.Text);
                decimal descontoPercentual = (descontoReais / valorOriginal) * 100;
                decimal totalGeral = descontoReais - valorOriginal;

                if (descontoReais > valorOriginal)
                {
                    MessageBox.Show("Não é possível dar um desconto maior que o valor total.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                txtValorTotal.Text = Math.Abs(totalGeral).ToString("0.00");
                txtDesconto.Text = descontoPercentual.ToString("0");
            }
            catch (FormatException)
            {
                MessageBox.Show("Os valores inseridos não são válidos.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescontoReais.Text = "0";
                txtDesconto.Text = "0.00";
                txtValorTotal.Text = valorOriginal.ToString();
            }
        }
        private void calculaDesconto()
        {
            try
            {
                decimal descontoPercentual = decimal.Parse(txtDesconto.Text);
                decimal descontoReais = (descontoPercentual / 100) * valorOriginal;
                decimal totalGeral = ((100 - descontoPercentual) / 100) * valorOriginal;

                if (totalGeral > valorOriginal)
                {
                    MessageBox.Show("Não é possível dar um desconto maior que o valor total.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }

                txtValorTotal.Text = totalGeral.ToString("0.00");
                txtDescontoReais.Text = descontoReais.ToString("0.00");
            }
            catch (FormatException)
            {
                MessageBox.Show("Os valores inseridos não são válidos.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtDesconto.Text = "0";
                txtDescontoReais.Text = "0";
                txtValorTotal.Text = valorOriginal.ToString();
            }
        }

        #endregion

        #region Manipulação de dados
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Orcamentos orcamento;

            try
            {
                using (DataContext context = new DataContext())
                {
                    orcamento = new Orcamentos();
                    orcamento.ClienteID = clienteID;
                    orcamento.Carro = txtCarro.Text;
                    orcamento.Data = DateTime.Now;
                    orcamento.Total = Convert.ToDecimal(txtValorTotal.Text);
                    context.Add(orcamento);
                    context.SaveChanges();
                    orcamentoID = orcamento.ID;
                }

                using (DataContext context = new DataContext())
                {
                    foreach (var item in lstItens)
                    {
                        OrcamentosItem orcamentosItens = new OrcamentosItem();
                        Pecas peca = new Pecas();

                        orcamentosItens.OrcamentoID = orcamentoID;
                        orcamentosItens.PecasID = item.PecasID;
                        orcamentosItens.Descricao = item.Descricao;
                        orcamentosItens.Quantidade = item.Quantidade;
                        orcamentosItens.Valor = item.Valor;
                        orcamentosItens.Subtotal = item.Subtotal;
                        context.Add(orcamentosItens);
                    }
                    if (pecasID == 0)
                    {
                        Pecas peca = new Pecas();
                        peca.Nome = txtPeca.Text;
                        context.Add(peca);
                        context.SaveChanges();
                    }
                    if (clienteID == 0)
                    {
                        Cliente cliente = new Cliente();
                        cliente.Nome = txtClienteOrc.Text;
                        context.Add(cliente);
                        context.SaveChanges();
                    }
                    context.SaveChanges();
                }
                MessageBox.Show("Orçamento gravado com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AlteraEstoque();
                ImprimeOrcamento();
                limpaCampos();
            }
            catch (Exception)
            {

                MessageBox.Show("Necessário selecionar um cliente para finalizar o orçamento", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Orcamentos orcamento = null;
            OrcamentosItem orcamentosItem = null;

            using (DataContext context = new DataContext())
            {
                orcamento = context.Orcamentos.FirstOrDefault(o => o.ID == orcamentoID);

                orcamento.ClienteID = clienteID;
                orcamento.Carro = txtCarro.Text;
                orcamento.Data = DateTime.Now;
                orcamento.Total = Convert.ToDecimal(txtValorTotal.Text);
                context.SaveChanges();
            }

            using (DataContext context = new DataContext())
            {
                orcamentosItem = context.OrcamentosItem.FirstOrDefault(o => o.ID == orcamentoID);

                foreach (var item in lstItens)
                {
                    OrcamentosItem orcamentosItens = new OrcamentosItem();

                    orcamentosItens.OrcamentoID = orcamentoID;
                    orcamentosItens.PecasID = pecasID;
                    orcamentosItens.Descricao = item.Descricao;
                    orcamentosItens.Quantidade = item.Quantidade;
                    orcamentosItens.Valor = item.Valor;
                    context.SaveChanges();
                }
                ImprimeOrcamento();
            }
            MessageBox.Show("Alteração realizada com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpaCampos();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Orcamentos orcamento = null;
            OrcamentosItem orcamentoItem = null;

            var resultado = MessageBox.Show("Deseja realmente excluir esse orçamento ?", "Pergunta do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                using (DataContext context = new DataContext())
                {
                    var orcamentosItems = context.OrcamentosItem.Where(o => o.OrcamentoID == orcamentoID);
                    context.RemoveRange(orcamentosItems);
                    context.SaveChanges();
                }

                using (DataContext context = new DataContext())
                {
                    orcamento = context.Orcamentos.FirstOrDefault(o => o.ID == orcamentoID);
                    context.Remove(orcamento);
                    context.SaveChanges();
                }
                MessageBox.Show("Exclusão realizada com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpaCampos();
            }
        }
        #endregion

        #region Altera estoque
        private void AlteraEstoque()
        {
            using (DataContext context = new DataContext())
            {
                Pecas peca = context.Pecas.FirstOrDefault(o => o.ID == pecasID);
                peca.Estoque -= orcamentosItens.Quantidade;
                context.SaveChanges();
            }
        }
        #endregion

        #region Impressão
        private void ImprimeOrcamento()
        {
            if (checkBoxImprimir.Checked)
            {
                DGVPrinter printer = new DGVPrinter();
                printer.TitleFont = new Font("Arial", 12, FontStyle.Bold);
                printer.SubTitleFont = new Font("Arial", 10, FontStyle.Bold);
                printer.FooterFont = new Font("Arial", 8);

                printer.Title = "ORÇAMENTO N° " + orcamentoID + "   AUTO MECÂNICA SÃO LÁZARO  3253-3320  " + DateTime.Now;
                printer.SubTitle = "CLIENTE : " + txtClienteOrc.Text + " | CARRO : " + txtCarro.Text + "\n\n";
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = false;
                printer.HeaderCellAlignment = StringAlignment.Far;
                printer.Footer = "SUBTOTAL  " + valorOriginal + "   DESCONTOS R$" + txtDescontoReais.Text + "  DESCONTO    " + txtDesconto.Text + "%  VALOR TOTAL R$" + txtValorTotal.Text;
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(gridItens);
            }
        }
        #endregion

        #region Teclas

        private void txtQtd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtValor.Focus();
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAdd.Focus();
        }

        private void txtDescontoReais_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                calculaDescontoReais();
        }
        private void txtDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                calculaDesconto();
        }
        #endregion
    }
}