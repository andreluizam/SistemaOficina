namespace ProjetoEF.Pesquisa
{
    partial class PesquisaPec
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
            gridPecas = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            txtPesquisa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridPecas).BeginInit();
            SuspendLayout();
            // 
            // gridPecas
            // 
            gridPecas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridPecas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPecas.Columns.AddRange(new DataGridViewColumn[] { ID });
            gridPecas.Location = new Point(14, 70);
            gridPecas.Margin = new Padding(4, 3, 4, 3);
            gridPecas.Name = "gridPecas";
            gridPecas.ReadOnly = true;
            gridPecas.ScrollBars = ScrollBars.Vertical;
            gridPecas.Size = new Size(1077, 414);
            gridPecas.TabIndex = 0;
            gridPecas.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPesquisa.Location = new Point(225, 24);
            txtPesquisa.Margin = new Padding(4, 3, 4, 3);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(865, 29);
            txtPesquisa.TabIndex = 5;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 4;
            label1.Text = "Pesquisar peça";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(176, 492);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(656, 25);
            label2.TabIndex = 6;
            label2.Text = "Para selecionar o a peça de dois cliques em cima da mesma.";
            // 
            // PesquisaPec
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 528);
            Controls.Add(label2);
            Controls.Add(txtPesquisa);
            Controls.Add(label1);
            Controls.Add(gridPecas);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "PesquisaPec";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pesquisar peças";
            Load += PesquisaPec_Load;
            ((System.ComponentModel.ISupportInitialize)gridPecas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridPecas;
        private TextBox txtPesquisa;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn ID;
    }
}