namespace ProjetoEF.Pesquisa
{
    partial class PesquisaNumeroOrc
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
            gridOrcamentos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            ClienteID = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            Carro = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Itens = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtCliente = new TextBox();
            label2 = new Label();
            btnPesquisaCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)gridOrcamentos).BeginInit();
            SuspendLayout();
            // 
            // gridOrcamentos
            // 
            gridOrcamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridOrcamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridOrcamentos.Columns.AddRange(new DataGridViewColumn[] { ID, ClienteID, Cliente, Data, Carro, Total, Itens });
            gridOrcamentos.Location = new Point(18, 80);
            gridOrcamentos.Margin = new Padding(4, 3, 4, 3);
            gridOrcamentos.Name = "gridOrcamentos";
            gridOrcamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridOrcamentos.Size = new Size(695, 470);
            gridOrcamentos.TabIndex = 0;
            gridOrcamentos.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID.DataPropertyName = "ID";
            ID.FillWeight = 202.567886F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 3;
            ID.Name = "ID";
            ID.Width = 60;
            // 
            // ClienteID
            // 
            ClienteID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ClienteID.DataPropertyName = "ClienteID";
            ClienteID.FillWeight = 127.065529F;
            ClienteID.HeaderText = "Código Cliente";
            ClienteID.Name = "ClienteID";
            ClienteID.Width = 300;
            // 
            // Cliente
            // 
            Cliente.DataPropertyName = "Cliente";
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            Cliente.Visible = false;
            // 
            // Data
            // 
            Data.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Data.DataPropertyName = "Data";
            Data.FillWeight = 42.367588F;
            Data.HeaderText = "Data";
            Data.Name = "Data";
            // 
            // Carro
            // 
            Carro.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Carro.DataPropertyName = "Carro";
            Carro.FillWeight = 111.675117F;
            Carro.HeaderText = "Carro";
            Carro.Name = "Carro";
            Carro.Width = 80;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            Total.FillWeight = 16.3238068F;
            Total.HeaderText = "Total";
            Total.MinimumWidth = 21;
            Total.Name = "Total";
            // 
            // Itens
            // 
            Itens.DataPropertyName = "Itens";
            Itens.HeaderText = "Itens";
            Itens.Name = "Itens";
            Itens.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 1;
            label1.Text = "Procurar por número ou cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(18, 48);
            txtCliente.Margin = new Padding(4, 3, 4, 3);
            txtCliente.MaxLength = 150;
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(695, 23);
            txtCliente.TabIndex = 2;
            txtCliente.TextChanged += txtCliente_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(61, 553);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(615, 24);
            label2.TabIndex = 3;
            label2.Text = "Para selecionar o orçamento de dois cliques em cima do mesmo";
            // 
            // btnPesquisaCliente
            // 
            btnPesquisaCliente.Location = new Point(200, 14);
            btnPesquisaCliente.Margin = new Padding(4, 3, 4, 3);
            btnPesquisaCliente.Name = "btnPesquisaCliente";
            btnPesquisaCliente.Size = new Size(26, 22);
            btnPesquisaCliente.TabIndex = 4;
            btnPesquisaCliente.UseVisualStyleBackColor = true;
            btnPesquisaCliente.Click += btnPesquisaCliente_Click;
            // 
            // PesquisaNumeroOrc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 582);
            Controls.Add(btnPesquisaCliente);
            Controls.Add(label2);
            Controls.Add(txtCliente);
            Controls.Add(label1);
            Controls.Add(gridOrcamentos);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PesquisaNumeroOrc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pesquisar orçamento por número ou cliente";
            Load += PesquisaNumeroOrc_Load;
            ((System.ComponentModel.ISupportInitialize)gridOrcamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridOrcamentos;
        private Label label1;
        private TextBox txtCliente;
        private Label label2;
        private Button btnPesquisaCliente;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ClienteID;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Carro;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Itens;
    }
}