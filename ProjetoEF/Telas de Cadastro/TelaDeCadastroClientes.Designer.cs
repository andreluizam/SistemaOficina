namespace ProjetoEF
{
    partial class TelaDeCadastroClientes
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
            lblCodigo = new Label();
            lblUf = new Label();
            txtCidade = new TextBox();
            txtCep = new TextBox();
            lblCep = new Label();
            txtEstado = new TextBox();
            btnConsultarCEP = new Button();
            lblBairro = new Label();
            lblRua = new Label();
            txtBairro = new TextBox();
            txtRua = new TextBox();
            btnSalvar = new Button();
            btnNovo = new Button();
            btnAlterar = new Button();
            lblPlaca = new Label();
            lblCarro = new Label();
            lblTelefone = new Label();
            btnApagar = new Button();
            lblCpfCnpj = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            txtCpfCnpj = new TextBox();
            txtTelefone = new TextBox();
            txtCarro = new TextBox();
            txtPlaca = new TextBox();
            btnCancelar = new Button();
            lblCodi = new Label();
            panel8 = new Panel();
            btnPesquisar = new Button();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodigo.ForeColor = Color.FromArgb(64, 64, 64);
            lblCodigo.Location = new Point(33, 409);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(97, 24);
            lblCodigo.TabIndex = 49;
            lblCodigo.Text = "Código :";
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUf.ForeColor = Color.FromArgb(64, 64, 64);
            lblUf.Location = new Point(526, 283);
            lblUf.Margin = new Padding(4, 0, 4, 0);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(44, 24);
            lblUf.TabIndex = 11;
            lblUf.Text = "UF :";
            // 
            // txtCidade
            // 
            txtCidade.BackColor = Color.White;
            txtCidade.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.Location = new Point(614, 280);
            txtCidade.Margin = new Padding(4, 3, 4, 3);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(204, 26);
            txtCidade.TabIndex = 14;
            txtCidade.KeyDown += txtNome_KeyDown;
            // 
            // txtCep
            // 
            txtCep.BackColor = Color.White;
            txtCep.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCep.Location = new Point(614, 240);
            txtCep.Margin = new Padding(4, 3, 4, 3);
            txtCep.MaxLength = 8;
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(254, 26);
            txtCep.TabIndex = 12;
            txtCep.KeyDown += txtNome_KeyDown;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCep.ForeColor = Color.FromArgb(64, 64, 64);
            lblCep.Location = new Point(526, 246);
            lblCep.Margin = new Padding(4, 0, 4, 0);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(61, 24);
            lblCep.TabIndex = 5;
            lblCep.Text = "CEP :";
            // 
            // txtEstado
            // 
            txtEstado.BackColor = Color.White;
            txtEstado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEstado.Location = new Point(829, 279);
            txtEstado.Margin = new Padding(4, 3, 4, 3);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(39, 26);
            txtEstado.TabIndex = 16;
            txtEstado.KeyDown += txtNome_KeyDown;
            // 
            // btnConsultarCEP
            // 
            btnConsultarCEP.BackgroundImageLayout = ImageLayout.Center;
            btnConsultarCEP.Cursor = Cursors.Hand;
            btnConsultarCEP.FlatAppearance.BorderSize = 0;
            btnConsultarCEP.FlatStyle = FlatStyle.Flat;
            btnConsultarCEP.Location = new Point(876, 244);
            btnConsultarCEP.Margin = new Padding(4, 3, 4, 3);
            btnConsultarCEP.Name = "btnConsultarCEP";
            btnConsultarCEP.Size = new Size(30, 24);
            btnConsultarCEP.TabIndex = 17;
            btnConsultarCEP.UseVisualStyleBackColor = true;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBairro.ForeColor = Color.FromArgb(64, 64, 64);
            lblBairro.Location = new Point(525, 317);
            lblBairro.Margin = new Padding(4, 0, 4, 0);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(70, 24);
            lblBairro.TabIndex = 8;
            lblBairro.Text = "Bairro:";
            // 
            // lblRua
            // 
            lblRua.AutoSize = true;
            lblRua.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRua.ForeColor = Color.FromArgb(64, 64, 64);
            lblRua.Location = new Point(526, 355);
            lblRua.Margin = new Padding(4, 0, 4, 0);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(61, 24);
            lblRua.TabIndex = 6;
            lblRua.Text = "Rua :";
            // 
            // txtBairro
            // 
            txtBairro.BackColor = Color.White;
            txtBairro.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBairro.Location = new Point(614, 317);
            txtBairro.Margin = new Padding(4, 3, 4, 3);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(255, 26);
            txtBairro.TabIndex = 15;
            txtBairro.KeyDown += txtNome_KeyDown;
            // 
            // txtRua
            // 
            txtRua.BackColor = Color.White;
            txtRua.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRua.Location = new Point(614, 353);
            txtRua.Margin = new Padding(4, 3, 4, 3);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(255, 26);
            txtRua.TabIndex = 13;
            txtRua.KeyDown += txtNome_KeyDown;
            // 
            // btnSalvar
            // 
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnSalvar.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnSalvar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Location = new Point(321, 44);
            btnSalvar.Margin = new Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(145, 72);
            btnSalvar.TabIndex = 22;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Cursor = Cursors.Hand;
            btnNovo.FlatAppearance.BorderSize = 0;
            btnNovo.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnNovo.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnNovo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNovo.Location = new Point(170, 43);
            btnNovo.Margin = new Padding(4, 3, 4, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(143, 73);
            btnNovo.TabIndex = 23;
            btnNovo.Text = "Novo";
            btnNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Cursor = Cursors.Hand;
            btnAlterar.FlatAppearance.BorderSize = 0;
            btnAlterar.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnAlterar.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnAlterar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlterar.Location = new Point(318, 42);
            btnAlterar.Margin = new Padding(4, 3, 4, 3);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(148, 74);
            btnAlterar.TabIndex = 24;
            btnAlterar.Text = "Alterar";
            btnAlterar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // lblPlaca
            // 
            lblPlaca.AccessibleRole = AccessibleRole.ScrollBar;
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlaca.ForeColor = Color.FromArgb(64, 64, 64);
            lblPlaca.Location = new Point(33, 355);
            lblPlaca.Margin = new Padding(4, 0, 4, 0);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(80, 24);
            lblPlaca.TabIndex = 4;
            lblPlaca.Text = "Placa :";
            // 
            // lblCarro
            // 
            lblCarro.AutoSize = true;
            lblCarro.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCarro.ForeColor = Color.FromArgb(64, 64, 64);
            lblCarro.Location = new Point(35, 317);
            lblCarro.Margin = new Padding(4, 0, 4, 0);
            lblCarro.Name = "lblCarro";
            lblCarro.Size = new Size(78, 24);
            lblCarro.TabIndex = 3;
            lblCarro.Text = "Carro :";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefone.ForeColor = Color.FromArgb(64, 64, 64);
            lblTelefone.Location = new Point(33, 279);
            lblTelefone.Margin = new Padding(4, 0, 4, 0);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(110, 24);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "Telefone :";
            // 
            // btnApagar
            // 
            btnApagar.Cursor = Cursors.Hand;
            btnApagar.FlatAppearance.BorderSize = 0;
            btnApagar.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnApagar.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnApagar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnApagar.Location = new Point(616, 42);
            btnApagar.Margin = new Padding(4, 3, 4, 3);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(145, 74);
            btnApagar.TabIndex = 25;
            btnApagar.Text = "Excluir";
            btnApagar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // lblCpfCnpj
            // 
            lblCpfCnpj.AutoSize = true;
            lblCpfCnpj.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCpfCnpj.ForeColor = Color.FromArgb(64, 64, 64);
            lblCpfCnpj.Location = new Point(33, 240);
            lblCpfCnpj.Margin = new Padding(4, 0, 4, 0);
            lblCpfCnpj.Name = "lblCpfCnpj";
            lblCpfCnpj.Size = new Size(124, 24);
            lblCpfCnpj.TabIndex = 10;
            lblCpfCnpj.Text = "CPF/CNPJ :";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.ForeColor = Color.FromArgb(64, 64, 64);
            lblNome.Location = new Point(35, 169);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(86, 24);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome :";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(136, 167);
            txtNome.Margin = new Padding(4, 3, 4, 3);
            txtNome.MaxLength = 60;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(732, 26);
            txtNome.TabIndex = 30;
            txtNome.KeyDown += txtNome_KeyDown;
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.BackColor = Color.White;
            txtCpfCnpj.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpfCnpj.Location = new Point(180, 240);
            txtCpfCnpj.Margin = new Padding(4, 3, 4, 3);
            txtCpfCnpj.Name = "txtCpfCnpj";
            txtCpfCnpj.Size = new Size(327, 26);
            txtCpfCnpj.TabIndex = 31;
            txtCpfCnpj.KeyDown += txtNome_KeyDown;
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = Color.White;
            txtTelefone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefone.Location = new Point(168, 279);
            txtTelefone.Margin = new Padding(4, 3, 4, 3);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(340, 26);
            txtTelefone.TabIndex = 32;
            txtTelefone.KeyDown += txtNome_KeyDown;
            // 
            // txtCarro
            // 
            txtCarro.BackColor = Color.White;
            txtCarro.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCarro.Location = new Point(138, 316);
            txtCarro.Margin = new Padding(4, 3, 4, 3);
            txtCarro.Name = "txtCarro";
            txtCarro.Size = new Size(370, 26);
            txtCarro.TabIndex = 33;
            txtCarro.KeyDown += txtNome_KeyDown;
            // 
            // txtPlaca
            // 
            txtPlaca.BackColor = Color.White;
            txtPlaca.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPlaca.Location = new Point(138, 353);
            txtPlaca.Margin = new Padding(4, 3, 4, 3);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(370, 26);
            txtPlaca.TabIndex = 34;
            txtPlaca.KeyDown += txtNome_KeyDown;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnCancelar.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(170, 42);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(145, 74);
            btnCancelar.TabIndex = 47;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblCodi
            // 
            lblCodi.AutoSize = true;
            lblCodi.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodi.ForeColor = Color.FromArgb(64, 64, 64);
            lblCodi.Location = new Point(146, 409);
            lblCodi.Margin = new Padding(4, 0, 4, 0);
            lblCodi.Name = "lblCodi";
            lblCodi.Size = new Size(0, 24);
            lblCodi.TabIndex = 48;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnPesquisar);
            panel8.Controls.Add(btnCancelar);
            panel8.Controls.Add(txtPlaca);
            panel8.Controls.Add(txtCarro);
            panel8.Controls.Add(txtTelefone);
            panel8.Controls.Add(txtCpfCnpj);
            panel8.Controls.Add(txtNome);
            panel8.Controls.Add(lblNome);
            panel8.Controls.Add(lblCpfCnpj);
            panel8.Controls.Add(btnApagar);
            panel8.Controls.Add(lblTelefone);
            panel8.Controls.Add(lblCarro);
            panel8.Controls.Add(lblPlaca);
            panel8.Controls.Add(btnAlterar);
            panel8.Controls.Add(btnNovo);
            panel8.Controls.Add(btnSalvar);
            panel8.Controls.Add(txtRua);
            panel8.Controls.Add(txtBairro);
            panel8.Controls.Add(lblRua);
            panel8.Controls.Add(lblBairro);
            panel8.Controls.Add(btnConsultarCEP);
            panel8.Controls.Add(txtEstado);
            panel8.Controls.Add(lblCep);
            panel8.Controls.Add(txtCep);
            panel8.Controls.Add(txtCidade);
            panel8.Controls.Add(lblUf);
            panel8.Controls.Add(lblCodigo);
            panel8.Controls.Add(lblCodi);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(4, 3, 4, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(922, 479);
            panel8.TabIndex = 20;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnPesquisar.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisar.Location = new Point(469, 42);
            btnPesquisar.Margin = new Padding(4, 3, 4, 3);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(145, 74);
            btnPesquisar.TabIndex = 50;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // TelaDeCadastroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 479);
            Controls.Add(panel8);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "TelaDeCadastroClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de clientes";
            Load += TelaDeCadastroClientes_Load;
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblCodigo;
        private Label lblUf;
        private TextBox txtCidade;
        private TextBox txtCep;
        private Label lblCep;
        private TextBox txtEstado;
        private Button btnConsultarCEP;
        private Label lblBairro;
        private Label lblRua;
        private TextBox txtBairro;
        private TextBox txtRua;
        private Button btnSalvar;
        private Button btnNovo;
        private Button btnAlterar;
        private Label lblPlaca;
        private Label lblCarro;
        private Label lblTelefone;
        private Button btnApagar;
        private Label lblCpfCnpj;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtCpfCnpj;
        private TextBox txtTelefone;
        private TextBox txtCarro;
        private TextBox txtPlaca;
        private Button btnCancelar;
        private Label lblCodi;
        private Panel panel8;
        private Button btnPesquisar;
    }
}