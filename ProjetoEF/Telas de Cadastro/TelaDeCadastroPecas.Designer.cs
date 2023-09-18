namespace ProjetoEF.Telas_de_Cadastro
{
    partial class TelaDeCadastroPecas
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
            txtNome = new TextBox();
            lblNome = new Label();
            txtValor = new TextBox();
            label1 = new Label();
            txtQtd = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lblCodi = new Label();
            btnCancelar = new Button();
            btnApagar = new Button();
            btnAlterar = new Button();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnPesquisar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(149, 196);
            txtNome.Margin = new Padding(4, 3, 4, 3);
            txtNome.MaxLength = 60;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(723, 26);
            txtNome.TabIndex = 99;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.ForeColor = Color.FromArgb(64, 64, 64);
            lblNome.Location = new Point(49, 195);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(86, 24);
            lblNome.TabIndex = 98;
            lblNome.Text = "Nome :";
            // 
            // txtValor
            // 
            txtValor.BackColor = Color.White;
            txtValor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor.Location = new Point(149, 230);
            txtValor.Margin = new Padding(4, 3, 4, 3);
            txtValor.MaxLength = 60;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(123, 26);
            txtValor.TabIndex = 102;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(53, 231);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 24);
            label1.TabIndex = 101;
            label1.Text = "Valor :";
            // 
            // txtQtd
            // 
            txtQtd.BackColor = Color.White;
            txtQtd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQtd.Location = new Point(203, 265);
            txtQtd.Margin = new Padding(4, 3, 4, 3);
            txtQtd.MaxLength = 60;
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(68, 26);
            txtQtd.TabIndex = 105;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(52, 265);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 24);
            label2.TabIndex = 104;
            label2.Text = "Em estoque :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(53, 321);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(149, 24);
            label3.TabIndex = 107;
            label3.Text = "Código Prod :";
            // 
            // lblCodi
            // 
            lblCodi.AutoSize = true;
            lblCodi.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodi.ForeColor = Color.FromArgb(64, 64, 64);
            lblCodi.Location = new Point(227, 321);
            lblCodi.Margin = new Padding(4, 0, 4, 0);
            lblCodi.Name = "lblCodi";
            lblCodi.Size = new Size(0, 24);
            lblCodi.TabIndex = 113;
            lblCodi.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnCancelar.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(99, 38);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(183, 83);
            btnCancelar.TabIndex = 119;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnApagar
            // 
            btnApagar.Cursor = Cursors.Hand;
            btnApagar.FlatAppearance.BorderSize = 0;
            btnApagar.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnApagar.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnApagar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnApagar.Location = new Point(668, 39);
            btnApagar.Margin = new Padding(4, 3, 4, 3);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(181, 82);
            btnApagar.TabIndex = 118;
            btnApagar.Text = "Excluir";
            btnApagar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Cursor = Cursors.Hand;
            btnAlterar.FlatAppearance.BorderSize = 0;
            btnAlterar.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnAlterar.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnAlterar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlterar.Location = new Point(289, 39);
            btnAlterar.Margin = new Padding(4, 3, 4, 3);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(183, 83);
            btnAlterar.TabIndex = 117;
            btnAlterar.Text = "Alterar";
            btnAlterar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Cursor = Cursors.Hand;
            btnNovo.FlatAppearance.BorderSize = 0;
            btnNovo.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnNovo.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnNovo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNovo.Location = new Point(101, 38);
            btnNovo.Margin = new Padding(4, 3, 4, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(181, 83);
            btnNovo.TabIndex = 116;
            btnNovo.Text = "Novo";
            btnNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click_1;
            // 
            // btnSalvar
            // 
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnSalvar.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnSalvar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Location = new Point(290, 39);
            btnSalvar.Margin = new Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(183, 82);
            btnSalvar.TabIndex = 115;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnPesquisar.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisar.Location = new Point(479, 38);
            btnPesquisar.Margin = new Padding(4, 3, 4, 3);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(181, 83);
            btnPesquisar.TabIndex = 120;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // TelaDeCadastroPecas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 497);
            Controls.Add(btnPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnApagar);
            Controls.Add(btnAlterar);
            Controls.Add(btnNovo);
            Controls.Add(btnSalvar);
            Controls.Add(lblCodi);
            Controls.Add(label3);
            Controls.Add(txtQtd);
            Controls.Add(label2);
            Controls.Add(txtValor);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "TelaDeCadastroPecas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de peças";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtValor;
        private Label label1;
        private TextBox txtQtd;
        private Label label2;
        private Label label3;
        private Label lblCodi;
        private Button btnCancelar;
        private Button btnApagar;
        private Button btnAlterar;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnPesquisar;
    }
}