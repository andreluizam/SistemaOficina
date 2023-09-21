namespace ProjetoEF
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            panel1 = new Panel();
            btnBackup = new Button();
            btnConsultarOrcamentos = new Button();
            btnOrcamento = new Button();
            btnPecas = new Button();
            btnSairDoSistema = new Button();
            btnFornecedoresTelaPrincipal = new Button();
            btnClientesTelaPrincipal = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(btnBackup);
            panel1.Controls.Add(btnConsultarOrcamentos);
            panel1.Controls.Add(btnOrcamento);
            panel1.Controls.Add(btnPecas);
            panel1.Controls.Add(btnSairDoSistema);
            panel1.Controls.Add(btnFornecedoresTelaPrincipal);
            panel1.Controls.Add(btnClientesTelaPrincipal);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 727);
            panel1.TabIndex = 0;
            // 
            // btnBackup
            // 
            btnBackup.Cursor = Cursors.Hand;
            btnBackup.FlatAppearance.BorderSize = 0;
            btnBackup.FlatStyle = FlatStyle.Flat;
            btnBackup.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBackup.ForeColor = Color.White;
            btnBackup.Image = (Image)resources.GetObject("btnBackup.Image");
            btnBackup.ImageAlign = ContentAlignment.TopLeft;
            btnBackup.Location = new Point(0, 395);
            btnBackup.Margin = new Padding(4, 3, 4, 3);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(281, 86);
            btnBackup.TabIndex = 10;
            btnBackup.Text = "      Backup";
            btnBackup.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBackup.UseVisualStyleBackColor = true;
            btnBackup.Click += btnBackup_Click;
            // 
            // btnConsultarOrcamentos
            // 
            btnConsultarOrcamentos.Cursor = Cursors.Hand;
            btnConsultarOrcamentos.FlatAppearance.BorderSize = 0;
            btnConsultarOrcamentos.FlatStyle = FlatStyle.Flat;
            btnConsultarOrcamentos.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultarOrcamentos.ForeColor = Color.White;
            btnConsultarOrcamentos.Image = (Image)resources.GetObject("btnConsultarOrcamentos.Image");
            btnConsultarOrcamentos.ImageAlign = ContentAlignment.TopLeft;
            btnConsultarOrcamentos.Location = new Point(0, 318);
            btnConsultarOrcamentos.Margin = new Padding(4, 3, 4, 3);
            btnConsultarOrcamentos.Name = "btnConsultarOrcamentos";
            btnConsultarOrcamentos.Size = new Size(281, 71);
            btnConsultarOrcamentos.TabIndex = 9;
            btnConsultarOrcamentos.Text = "     Consultar             Orçamentos";
            btnConsultarOrcamentos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultarOrcamentos.UseVisualStyleBackColor = true;
            btnConsultarOrcamentos.Click += btnConsultarOrcamentos_Click;
            // 
            // btnOrcamento
            // 
            btnOrcamento.Cursor = Cursors.Hand;
            btnOrcamento.FlatAppearance.BorderSize = 0;
            btnOrcamento.FlatStyle = FlatStyle.Flat;
            btnOrcamento.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrcamento.ForeColor = Color.White;
            btnOrcamento.Image = Properties.Resources.orc__1_;
            btnOrcamento.ImageAlign = ContentAlignment.TopLeft;
            btnOrcamento.Location = new Point(3, 234);
            btnOrcamento.Margin = new Padding(4, 3, 4, 3);
            btnOrcamento.Name = "btnOrcamento";
            btnOrcamento.Size = new Size(278, 67);
            btnOrcamento.TabIndex = 8;
            btnOrcamento.Text = "     Orçamentos";
            btnOrcamento.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrcamento.UseVisualStyleBackColor = true;
            btnOrcamento.Click += btnOrcamento_Click;
            // 
            // btnPecas
            // 
            btnPecas.Cursor = Cursors.Hand;
            btnPecas.FlatAppearance.BorderSize = 0;
            btnPecas.FlatStyle = FlatStyle.Flat;
            btnPecas.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPecas.ForeColor = Color.White;
            btnPecas.Image = Properties.Resources.mecanico;
            btnPecas.ImageAlign = ContentAlignment.TopLeft;
            btnPecas.Location = new Point(3, 154);
            btnPecas.Margin = new Padding(4, 3, 4, 3);
            btnPecas.Name = "btnPecas";
            btnPecas.Size = new Size(278, 74);
            btnPecas.TabIndex = 7;
            btnPecas.Text = "      Peças";
            btnPecas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPecas.UseVisualStyleBackColor = true;
            btnPecas.Click += btnPecas_Click;
            // 
            // btnSairDoSistema
            // 
            btnSairDoSistema.Cursor = Cursors.Hand;
            btnSairDoSistema.Dock = DockStyle.Bottom;
            btnSairDoSistema.FlatAppearance.BorderSize = 0;
            btnSairDoSistema.FlatStyle = FlatStyle.Flat;
            btnSairDoSistema.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSairDoSistema.ForeColor = Color.White;
            btnSairDoSistema.Image = Properties.Resources.Sair;
            btnSairDoSistema.ImageAlign = ContentAlignment.MiddleLeft;
            btnSairDoSistema.Location = new Point(0, 630);
            btnSairDoSistema.Margin = new Padding(4, 3, 4, 3);
            btnSairDoSistema.Name = "btnSairDoSistema";
            btnSairDoSistema.Size = new Size(281, 97);
            btnSairDoSistema.TabIndex = 5;
            btnSairDoSistema.Text = "Sair";
            btnSairDoSistema.UseVisualStyleBackColor = true;
            btnSairDoSistema.Click += btnSairDoSistema_Click;
            // 
            // btnFornecedoresTelaPrincipal
            // 
            btnFornecedoresTelaPrincipal.Cursor = Cursors.Hand;
            btnFornecedoresTelaPrincipal.FlatAppearance.BorderSize = 0;
            btnFornecedoresTelaPrincipal.FlatStyle = FlatStyle.Flat;
            btnFornecedoresTelaPrincipal.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFornecedoresTelaPrincipal.ForeColor = Color.White;
            btnFornecedoresTelaPrincipal.Image = Properties.Resources.Fornecedores;
            btnFornecedoresTelaPrincipal.ImageAlign = ContentAlignment.TopLeft;
            btnFornecedoresTelaPrincipal.Location = new Point(0, 73);
            btnFornecedoresTelaPrincipal.Margin = new Padding(4, 3, 4, 3);
            btnFornecedoresTelaPrincipal.Name = "btnFornecedoresTelaPrincipal";
            btnFornecedoresTelaPrincipal.Size = new Size(277, 74);
            btnFornecedoresTelaPrincipal.TabIndex = 1;
            btnFornecedoresTelaPrincipal.Text = "      Fornecedores";
            btnFornecedoresTelaPrincipal.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFornecedoresTelaPrincipal.UseVisualStyleBackColor = true;
            btnFornecedoresTelaPrincipal.Click += btnFornecedoresTelaPrincipal_Click;
            // 
            // btnClientesTelaPrincipal
            // 
            btnClientesTelaPrincipal.Cursor = Cursors.Hand;
            btnClientesTelaPrincipal.FlatAppearance.BorderSize = 0;
            btnClientesTelaPrincipal.FlatStyle = FlatStyle.Flat;
            btnClientesTelaPrincipal.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientesTelaPrincipal.ForeColor = Color.White;
            btnClientesTelaPrincipal.Image = Properties.Resources.Cliente;
            btnClientesTelaPrincipal.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientesTelaPrincipal.Location = new Point(0, 0);
            btnClientesTelaPrincipal.Margin = new Padding(4, 3, 4, 3);
            btnClientesTelaPrincipal.Name = "btnClientesTelaPrincipal";
            btnClientesTelaPrincipal.Size = new Size(277, 73);
            btnClientesTelaPrincipal.TabIndex = 0;
            btnClientesTelaPrincipal.Text = "Clientes";
            btnClientesTelaPrincipal.UseVisualStyleBackColor = true;
            btnClientesTelaPrincipal.Click += btnClientesTelaPrincipal_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.imagem_de_fundi;
            pictureBox1.Location = new Point(281, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(877, 727);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 727);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "TelaPrincipal";
            Text = "OFICINA MECÂNICA";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSairDoSistema;
        private Button btnFornecedoresTelaPrincipal;
        private Button btnClientesTelaPrincipal;
        private PictureBox pictureBox1;
        private Button btnPecas;
        private Button btnOrcamento;
        private Button btnConsultarOrcamentos;
        private Button btnBackup;
    }
}