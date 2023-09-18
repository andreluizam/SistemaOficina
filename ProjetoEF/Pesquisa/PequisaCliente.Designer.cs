namespace ProjetoEF
{
    partial class PequisaCliente
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
            gridClientes = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            CpfCnpj = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Carro = new DataGridViewTextBoxColumn();
            Placa = new DataGridViewTextBoxColumn();
            Cep = new DataGridViewTextBoxColumn();
            Cidade = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Bairro = new DataGridViewTextBoxColumn();
            Rua = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            SuspendLayout();
            // 
            // gridClientes
            // 
            gridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, CpfCnpj, Telefone, Carro, Placa, Cep, Cidade, Estado, Bairro, Rua });
            gridClientes.Location = new Point(9, 76);
            gridClientes.Margin = new Padding(4, 3, 4, 3);
            gridClientes.Name = "gridClientes";
            gridClientes.ReadOnly = true;
            gridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridClientes.Size = new Size(920, 487);
            gridClientes.TabIndex = 0;
            gridClientes.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 400;
            // 
            // CpfCnpj
            // 
            CpfCnpj.DataPropertyName = "CpfCnpj";
            CpfCnpj.HeaderText = "CPF/CNPJ";
            CpfCnpj.Name = "CpfCnpj";
            CpfCnpj.ReadOnly = true;
            CpfCnpj.Visible = false;
            // 
            // Telefone
            // 
            Telefone.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Telefone.DataPropertyName = "Telefone";
            Telefone.HeaderText = "Telefone";
            Telefone.Name = "Telefone";
            Telefone.ReadOnly = true;
            Telefone.Width = 200;
            // 
            // Carro
            // 
            Carro.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Carro.DataPropertyName = "Carro";
            Carro.HeaderText = "Carro";
            Carro.Name = "Carro";
            Carro.ReadOnly = true;
            Carro.Width = 150;
            // 
            // Placa
            // 
            Placa.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Placa.DataPropertyName = "Placa";
            Placa.HeaderText = "Placa";
            Placa.Name = "Placa";
            Placa.ReadOnly = true;
            Placa.Width = 150;
            // 
            // Cep
            // 
            Cep.DataPropertyName = "Cep";
            Cep.HeaderText = "CEP";
            Cep.Name = "Cep";
            Cep.ReadOnly = true;
            Cep.Visible = false;
            // 
            // Cidade
            // 
            Cidade.DataPropertyName = "Cidade";
            Cidade.HeaderText = "Cidade";
            Cidade.Name = "Cidade";
            Cidade.ReadOnly = true;
            Cidade.Visible = false;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Visible = false;
            // 
            // Bairro
            // 
            Bairro.DataPropertyName = "Bairro";
            Bairro.HeaderText = "Bairro";
            Bairro.Name = "Bairro";
            Bairro.ReadOnly = true;
            Bairro.Visible = false;
            // 
            // Rua
            // 
            Rua.DataPropertyName = "Rua";
            Rua.HeaderText = "Rua";
            Rua.Name = "Rua";
            Rua.ReadOnly = true;
            Rua.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 1;
            label1.Text = "Pesquisar cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(140, 571);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(655, 25);
            label2.TabIndex = 2;
            label2.Text = "Para selecionar o cliente de dois cliques em cima do mesmo.";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(199, 31);
            txtNome.Margin = new Padding(4, 3, 4, 3);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(730, 29);
            txtNome.TabIndex = 3;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // PequisaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 605);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gridClientes);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "PequisaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pesquisar Cliente";
            Load += PequisaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView gridClientes;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn CpfCnpj;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Carro;
        private DataGridViewTextBoxColumn Placa;
        private DataGridViewTextBoxColumn Cep;
        private DataGridViewTextBoxColumn Cidade;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Bairro;
        private DataGridViewTextBoxColumn Rua;
    }
}