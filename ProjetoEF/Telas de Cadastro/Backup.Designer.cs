namespace ProjetoEF.Telas_de_Cadastro
{
    partial class Backup
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
            btnBackup = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnBackup
            // 
            btnBackup.Cursor = Cursors.Hand;
            btnBackup.Location = new Point(167, 75);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(174, 52);
            btnBackup.TabIndex = 0;
            btnBackup.Text = "Realizar backup";
            btnBackup.UseVisualStyleBackColor = true;
            btnBackup.Click += btnBackup_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(470, 15);
            label1.TabIndex = 1;
            label1.Text = "O backup é um ponto de restauração do seu sistema recomendado realizar diariamente.";
            // 
            // Backup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 150);
            Controls.Add(label1);
            Controls.Add(btnBackup);
            Name = "Backup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Backup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackup;
        private Label label1;
    }
}