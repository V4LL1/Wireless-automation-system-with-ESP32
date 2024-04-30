using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projectCpp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Tente abrir a conexão com o banco de dados
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection conexao = conexaoBD.AbrirConexao();

            // Verifique se a conexão foi aberta com sucesso
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Conexão com o banco de dados estabelecida com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao estabelecer conexão com o banco de dados.");
            }

            // Feche a conexão com o banco de dados
            conexaoBD.FecharConexao();

            // Iniciar o aplicativo Windows Forms
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
