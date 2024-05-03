using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectCpp
{
    public partial class CriarPerfil : Form
    {
        public CriarPerfil()
        {
            InitializeComponent();
        }

        private void CriarPerfilBtn_Click(object sender, EventArgs e)
        {
            string usuario = usuarioTxt.Text;
            string senha = senhaTxt.Text;
            int nivelPermissao;

            // Verifica se o campo de usuário está preenchido
            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("Por favor, preencha o campo de usuário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se o campo de senha está preenchido
            if (string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha o campo de senha!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se o campo de nível de permissão está preenchido e é um número válido
            if (!int.TryParse(nivelPermissaoTxt.Text, out nivelPermissao))
            {
                MessageBox.Show("Por favor, insira um valor numérico válido para o nível de permissão!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tenta adicionar um novo perfil ao banco de dados
            if (AdicionarPerfil(usuario, senha, nivelPermissao))
            {
                MessageBox.Show("Perfil criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpar os campos após adicionar o perfil
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao criar perfil. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AdicionarPerfil(string usuario, string senha, int nivelPermissao)
        {
            string stringConexao = "Server=127.0.0.1;Database=localDatabase;Uid=root;Pwd=;";
            using (MySqlConnection conexao = new MySqlConnection(stringConexao))
            {
                string query = "INSERT INTO Perfil (usuario, senha, nivelPermissao) VALUES (@usuario, @senha, @nivelPermissao)";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@nivelPermissao", nivelPermissao);

                try
                {
                    conexao.Open();
                    int linhasAfetadas = cmd.ExecuteNonQuery();
                    return linhasAfetadas > 0; // Retorna verdadeiro se uma linha foi adicionada
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar perfil: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void LimparCampos()
        {
            usuarioTxt.Text = "";
            senhaTxt.Text = "";
            nivelPermissaoTxt.Text = "";
        }


    }
}
