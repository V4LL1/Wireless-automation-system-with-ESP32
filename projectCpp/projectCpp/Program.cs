using System;
using System.IO.Ports;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projectCpp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            Console.WriteLine("Teste saída console!");

            /*
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
            


            //serial
            string[] portasDisponiveis = SerialPort.GetPortNames();

            if (portasDisponiveis.Length == 0)
            {
                MessageBox.Show("Nenhuma porta serial disponível.");
                return;
            }

            MessageBox.Show("Portas seriais disponíveis:");
            foreach (string porta in portasDisponiveis)
            {
                Console.WriteLine(porta);
            }

            MessageBox.Show("Digite o nome da porta serial que deseja usar (ex: COM1):");
            string nomePorta = Console.ReadLine();

            if (!Array.Exists(portasDisponiveis, p => p == nomePorta))
            {
                Console.WriteLine($"A porta {nomePorta} não está disponível.");
                return;
            }

            */


            // Iniciar o aplicativo Windows Forms
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
