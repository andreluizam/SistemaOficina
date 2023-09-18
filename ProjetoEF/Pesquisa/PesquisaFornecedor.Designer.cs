namespace ProjetoEF.Pesquisa
{
    partial class PesquisaFornecedor
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
            gridFornecedores = new DataGridView();
            txtPesquisa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridFornecedores).BeginInit();
            SuspendLayout();
            // 
            // gridFornecedores
            // 
            gridFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridFornecedores.Location = new Point(13, 64);
            gridFornecedores.Name = "gridFornecedores";
            gridFornecedores.RowTemplate.Height = 25;
            gridFornecedores.Size = new Size(915, 448);
            gridFornecedores.TabIndex = 0;
            gridFornecedores.CellDoubleClick += gridFornecedores_CellDoubleClick;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPesquisa.Location = new Point(252, 23);
            txtPesquisa.Margin = new Padding(4, 3, 4, 3);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(676, 29);
            txtPesquisa.TabIndex = 5;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(4, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(240, 25);
            label1.TabIndex = 4;
            label1.Text = "Pesquisar fornecedores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(138, 519);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(695, 25);
            label2.TabIndex = 6;
            label2.Text = "Para selecionar um fornecedor basta dar dois cliques no mesmo.";
            // 
            // PesquisaFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 550);
            Controls.Add(label2);
            Controls.Add(txtPesquisa);
            Controls.Add(label1);
            Controls.Add(gridFornecedores);
            Name = "PesquisaFornecedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pesquisar fornecedores";
            Load += PesquisaFornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)gridFornecedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridFornecedores;
        private TextBox txtPesquisa;
        private Label label1;
        private Label label2;
    }
}