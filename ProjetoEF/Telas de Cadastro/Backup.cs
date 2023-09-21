using Microsoft.Data.SqlClient;

namespace ProjetoEF.Telas_de_Cadastro
{
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            RealizaBackup();
        }

        private void RealizaBackup()
        {
            string conexaoString = @"Server=DESKTOP-FD20I4Q\SQLEXPRESS;Database=OFICINA;User Id=SA;Password=001002;Integrated security=True;Encrypt=False";
            string query = "BACKUP DATABASE OFICINA TO DISK = 'C:\\Sistema\\Backup\\BackupSistema.bak' WITH FORMAT";

            try
            {
                using (SqlConnection conexao = new SqlConnection(conexaoString))
                {
                    conexao.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {
                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Backup concluído com sucesso.", "Backup concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar o backup: " + ex.Message, "Erro de Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 
    }
}
