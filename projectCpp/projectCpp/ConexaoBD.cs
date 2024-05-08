using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace projectCpp
{
    internal class ConexaoBD
    {
        private MySqlConnection conexao;
        private string stringConexao = "Server=127.0.0.1;Database=localDatabase;Uid=root;Pwd=;";

        public ConexaoBD()
        {
            conexao = new MySqlConnection(stringConexao);
        }

        public MySqlConnection AbrirConexao()
        {
            try
            {
                conexao.Open();
                Console.WriteLine("Conexão aberta com sucesso!");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erro ao abrir conexão com o banco de dados: " + ex.Message);
            }

            return conexao;
        }

        public void FecharConexao()
        {
            try
            {
                conexao.Close();
                Console.WriteLine("Conexão fechada com sucesso!");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erro ao fechar conexão com o banco de dados: " + ex.Message);
            }
        }

    }
}
