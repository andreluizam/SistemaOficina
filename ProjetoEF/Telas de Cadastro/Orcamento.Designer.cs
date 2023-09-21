namespace ProjetoEF.Telas_de_Cadastro
{
    partial class Orcamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orcamento));
            txtPeca = new TextBox();
            btnRemover = new Button();
            btnAdd = new Button();
            gridItens = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            OrcamentosID = new DataGridViewTextBoxColumn();
            Orcamentos = new DataGridViewTextBoxColumn();
            PecaID = new DataGridViewTextBoxColumn();
            Pecas = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            txtValor = new TextBox();
            txtQtd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblTotal = new Label();
            txtValorTotal = new TextBox();
            btnPesquisarProd = new Button();
            txtClienteOrc = new TextBox();
            btnPesquisarCli = new Button();
            label5 = new Label();
            label6 = new Label();
            txtDesconto = new TextBox();
            btnFinalizar = new Button();
            txtCarro = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtData = new TextBox();
            lblCodi = new Label();
            maskedTextBox1 = new MaskedTextBox();
            txtDescontoReais = new TextBox();
            label7 = new Label();
            label4 = new Label();
            checkBoxImprimir = new CheckBox();
            label11 = new Label();
            txtTelefone = new TextBox();
            btnAlterar = new Button();
            btnNovo = new Button();
            btnExcluir = new Button();
            PesquisaOrc = new Button();
            ((System.ComponentModel.ISupportInitialize)gridItens).BeginInit();
            SuspendLayout();
            // 
            // txtPeca
            // 
            txtPeca.Enabled = false;
            txtPeca.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPeca.Location = new Point(17, 296);
            txtPeca.Margin = new Padding(4, 3, 4, 3);
            txtPeca.Name = "txtPeca";
            txtPeca.Size = new Size(639, 31);
            txtPeca.TabIndex = 0;
            // 
            // btnRemover
            // 
            btnRemover.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemover.Location = new Point(660, 367);
            btnRemover.Margin = new Padding(4, 3, 4, 3);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(131, 36);
            btnRemover.TabIndex = 1;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(525, 367);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 36);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // gridItens
            // 
            gridItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridItens.Columns.AddRange(new DataGridViewColumn[] { ID, OrcamentosID, Orcamentos, PecaID, Pecas, Descricao, Quantidade, Valor, Subtotal });
            gridItens.Location = new Point(21, 416);
            gridItens.Margin = new Padding(4, 3, 4, 3);
            gridItens.Name = "gridItens";
            gridItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridItens.Size = new Size(767, 262);
            gridItens.TabIndex = 3;
            gridItens.CellClick += gridItens_CellClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
            ID.Width = 43;
            // 
            // OrcamentosID
            // 
            OrcamentosID.DataPropertyName = "OrcamentoID";
            OrcamentosID.HeaderText = "OrcamentosID";
            OrcamentosID.Name = "OrcamentosID";
            OrcamentosID.Visible = false;
            OrcamentosID.Width = 108;
            // 
            // Orcamentos
            // 
            Orcamentos.DataPropertyName = "Orcamento";
            Orcamentos.HeaderText = "Orcamentos";
            Orcamentos.Name = "Orcamentos";
            Orcamentos.Visible = false;
            Orcamentos.Width = 97;
            // 
            // PecaID
            // 
            PecaID.DataPropertyName = "PecasID";
            PecaID.FillWeight = 30.45685F;
            PecaID.HeaderText = "Código";
            PecaID.Name = "PecaID";
            PecaID.Width = 71;
            // 
            // Pecas
            // 
            Pecas.DataPropertyName = "Pecas";
            Pecas.HeaderText = "Pecas";
            Pecas.Name = "Pecas";
            Pecas.Visible = false;
            Pecas.Width = 62;
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "Descricao";
            Descricao.FillWeight = 301.348633F;
            Descricao.HeaderText = "Produto";
            Descricao.Name = "Descricao";
            Descricao.Width = 400;
            // 
            // Quantidade
            // 
            Quantidade.DataPropertyName = "Quantidade";
            Quantidade.FillWeight = 32.2946F;
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            Quantidade.Width = 94;
            // 
            // Valor
            // 
            Valor.DataPropertyName = "Valor";
            Valor.FillWeight = 35.8998871F;
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.Width = 58;
            // 
            // Subtotal
            // 
            Subtotal.DataPropertyName = "Subtotal";
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor.Location = new Point(194, 372);
            txtValor.Margin = new Padding(4, 3, 4, 3);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(159, 31);
            txtValor.TabIndex = 4;
            txtValor.Text = "0.00";
            txtValor.KeyDown += txtValor_KeyDown;
            // 
            // txtQtd
            // 
            txtQtd.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtQtd.Location = new Point(21, 372);
            txtQtd.Margin = new Padding(4, 3, 4, 3);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(153, 31);
            txtQtd.TabIndex = 5;
            txtQtd.Text = "0";
            txtQtd.KeyDown += txtQtd_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 345);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 6;
            label1.Text = "Quantidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(189, 345);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 7;
            label2.Text = "Valor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 268);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 8;
            label3.Text = "Peça";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(941, 705);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 20);
            lblTotal.TabIndex = 9;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Enabled = false;
            txtValorTotal.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorTotal.Location = new Point(466, 712);
            txtValorTotal.Margin = new Padding(4, 3, 4, 3);
            txtValorTotal.MaxLength = 10;
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.ReadOnly = true;
            txtValorTotal.Size = new Size(113, 31);
            txtValorTotal.TabIndex = 10;
            txtValorTotal.Text = "0.00";
            // 
            // btnPesquisarProd
            // 
            btnPesquisarProd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisarProd.Location = new Point(660, 296);
            btnPesquisarProd.Margin = new Padding(4, 3, 4, 3);
            btnPesquisarProd.Name = "btnPesquisarProd";
            btnPesquisarProd.Size = new Size(131, 31);
            btnPesquisarProd.TabIndex = 11;
            btnPesquisarProd.Text = "Pesquisar";
            btnPesquisarProd.UseVisualStyleBackColor = true;
            btnPesquisarProd.Click += btnPesquisar_Click;
            // 
            // txtClienteOrc
            // 
            txtClienteOrc.Enabled = false;
            txtClienteOrc.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteOrc.Location = new Point(17, 131);
            txtClienteOrc.Margin = new Padding(4, 3, 4, 3);
            txtClienteOrc.MaxLength = 60;
            txtClienteOrc.Name = "txtClienteOrc";
            txtClienteOrc.Size = new Size(639, 31);
            txtClienteOrc.TabIndex = 12;
            txtClienteOrc.Text = "SELECIONE O CLIENTE";
            // 
            // btnPesquisarCli
            // 
            btnPesquisarCli.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisarCli.Location = new Point(660, 131);
            btnPesquisarCli.Margin = new Padding(4, 3, 4, 3);
            btnPesquisarCli.Name = "btnPesquisarCli";
            btnPesquisarCli.Size = new Size(131, 31);
            btnPesquisarCli.TabIndex = 13;
            btnPesquisarCli.Text = "Pesquisar";
            btnPesquisarCli.UseVisualStyleBackColor = true;
            btnPesquisarCli.Click += btnPesquisarCli_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 103);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 15;
            label5.Text = "Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(325, 692);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 16);
            label6.TabIndex = 21;
            label6.Text = "Desconto ( % )";
            // 
            // txtDesconto
            // 
            txtDesconto.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDesconto.Location = new Point(325, 711);
            txtDesconto.Margin = new Padding(4, 3, 4, 3);
            txtDesconto.MaxLength = 3;
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(87, 31);
            txtDesconto.TabIndex = 20;
            txtDesconto.Text = "0";
            txtDesconto.KeyDown += txtDesconto_KeyDown;
            txtDesconto.Leave += txtDesconto_Leave;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinalizar.Location = new Point(676, 703);
            btnFinalizar.Margin = new Padding(4, 3, 4, 3);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(111, 39);
            btnFinalizar.TabIndex = 23;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // txtCarro
            // 
            txtCarro.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCarro.Location = new Point(17, 200);
            txtCarro.Margin = new Padding(4, 3, 4, 3);
            txtCarro.Name = "txtCarro";
            txtCarro.Size = new Size(437, 31);
            txtCarro.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 173);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(65, 25);
            label8.TabIndex = 25;
            label8.Text = "Carro";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(19, 19);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(35, 25);
            label9.TabIndex = 28;
            label9.Text = "Nº";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(609, 17);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(57, 25);
            label10.TabIndex = 30;
            label10.Text = "Data";
            // 
            // txtData
            // 
            txtData.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtData.Location = new Point(680, 9);
            txtData.Margin = new Padding(4, 3, 4, 3);
            txtData.Name = "txtData";
            txtData.Size = new Size(117, 31);
            txtData.TabIndex = 29;
            // 
            // lblCodi
            // 
            lblCodi.AutoSize = true;
            lblCodi.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodi.Location = new Point(79, 20);
            lblCodi.Margin = new Padding(4, 0, 4, 0);
            lblCodi.Name = "lblCodi";
            lblCodi.Size = new Size(0, 25);
            lblCodi.TabIndex = 31;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(680, 9);
            maskedTextBox1.Margin = new Padding(4, 3, 4, 3);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(117, 31);
            maskedTextBox1.TabIndex = 32;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // txtDescontoReais
            // 
            txtDescontoReais.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescontoReais.Location = new Point(219, 711);
            txtDescontoReais.Margin = new Padding(4, 3, 4, 3);
            txtDescontoReais.MaxLength = 3;
            txtDescontoReais.Name = "txtDescontoReais";
            txtDescontoReais.Size = new Size(94, 31);
            txtDescontoReais.TabIndex = 33;
            txtDescontoReais.Text = "0";
            txtDescontoReais.KeyDown += txtDescontoReais_KeyDown;
            txtDescontoReais.Leave += txtDescontoReais_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(219, 692);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(99, 16);
            label7.TabIndex = 34;
            label7.Text = "Desconto ( R$ )";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(461, 693);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 16);
            label4.TabIndex = 35;
            label4.Text = "Total";
            // 
            // checkBoxImprimir
            // 
            checkBoxImprimir.AutoSize = true;
            checkBoxImprimir.Checked = true;
            checkBoxImprimir.CheckState = CheckState.Checked;
            checkBoxImprimir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxImprimir.Location = new Point(588, 713);
            checkBoxImprimir.Margin = new Padding(4, 3, 4, 3);
            checkBoxImprimir.Name = "checkBoxImprimir";
            checkBoxImprimir.Size = new Size(84, 24);
            checkBoxImprimir.TabIndex = 36;
            checkBoxImprimir.Text = "Imprimir";
            checkBoxImprimir.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(466, 171);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(96, 25);
            label11.TabIndex = 38;
            label11.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefone.Location = new Point(471, 200);
            txtTelefone.Margin = new Padding(4, 3, 4, 3);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(320, 31);
            txtTelefone.TabIndex = 37;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlterar.Location = new Point(677, 703);
            btnAlterar.Margin = new Padding(4, 3, 4, 3);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(111, 39);
            btnAlterar.TabIndex = 39;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Visible = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNovo.Location = new Point(21, 707);
            btnNovo.Margin = new Padding(4, 3, 4, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(89, 36);
            btnNovo.TabIndex = 41;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluir.Location = new Point(120, 707);
            btnExcluir.Margin = new Padding(4, 3, 4, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(89, 36);
            btnExcluir.TabIndex = 40;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // PesquisaOrc
            // 
            PesquisaOrc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PesquisaOrc.Image = (Image)resources.GetObject("PesquisaOrc.Image");
            PesquisaOrc.Location = new Point(162, 10);
            PesquisaOrc.Margin = new Padding(4, 3, 4, 3);
            PesquisaOrc.Name = "PesquisaOrc";
            PesquisaOrc.Size = new Size(109, 36);
            PesquisaOrc.TabIndex = 27;
            PesquisaOrc.Text = "Pesquisar";
            PesquisaOrc.TextAlign = ContentAlignment.MiddleRight;
            PesquisaOrc.TextImageRelation = TextImageRelation.TextBeforeImage;
            PesquisaOrc.UseVisualStyleBackColor = true;
            PesquisaOrc.Click += PesquisaOrc_Click;
            // 
            // Orcamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 758);
            Controls.Add(btnNovo);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(label11);
            Controls.Add(txtTelefone);
            Controls.Add(checkBoxImprimir);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(txtDescontoReais);
            Controls.Add(maskedTextBox1);
            Controls.Add(lblCodi);
            Controls.Add(label10);
            Controls.Add(txtData);
            Controls.Add(label9);
            Controls.Add(PesquisaOrc);
            Controls.Add(label8);
            Controls.Add(txtCarro);
            Controls.Add(btnFinalizar);
            Controls.Add(label6);
            Controls.Add(txtDesconto);
            Controls.Add(label5);
            Controls.Add(btnPesquisarCli);
            Controls.Add(txtClienteOrc);
            Controls.Add(btnPesquisarProd);
            Controls.Add(txtValorTotal);
            Controls.Add(lblTotal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtQtd);
            Controls.Add(txtValor);
            Controls.Add(gridItens);
            Controls.Add(btnAdd);
            Controls.Add(btnRemover);
            Controls.Add(txtPeca);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Orcamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orçamentos";
            Load += Orcamento_Load;
            ((System.ComponentModel.ISupportInitialize)gridItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPeca;
        private Button btnRemover;
        private Button btnAdd;
        private DataGridView gridItens;
        private TextBox txtValor;
        private TextBox txtQtd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblTotal;
        private TextBox txtValorTotal;
        private Button btnPesquisarProd;
        private TextBox txtClienteOrc;
        private Button btnPesquisarCli;
        private Label label5;
        private Label label6;
        private TextBox txtDesconto;
        private Button btnFinalizar;
        private TextBox txtCarro;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtData;
        private Label lblCodi;
        private MaskedTextBox maskedTextBox1;
        private TextBox txtDescontoReais;
        private Label label7;
        private Label label4;
        private CheckBox checkBoxImprimir;
        private Label label11;
        private TextBox txtTelefone;
        private Button btnAlterar;
        private Button btnNovo;
        private Button btnExcluir;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn OrcamentosID;
        private DataGridViewTextBoxColumn Orcamentos;
        private DataGridViewTextBoxColumn PecaID;
        private DataGridViewTextBoxColumn Pecas;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Subtotal;
        private Button PesquisaOrc;
    }
}