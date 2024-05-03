using MySql.Data.MySqlClient;

namespace projectCpp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void entrarBtn_Click(object sender, EventArgs e)
        {

            string usuario = usuarioTxt.Text;
            string senha = senhaTxt.Text;

            // Verifica se o usuário está autenticado
            if (AutenticarUsuario(usuario, senha))
            {
                MessageBox.Show("Autenticação bem-sucedida! Bem-vindo, " + usuario + "!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PaginaInicial paginaInicial = new PaginaInicial();
                paginaInicial.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void criarBtn_Click(object sender, EventArgs e)
        {
            CriarPerfilAutenticacao criarPerfilAutenticacao = new CriarPerfilAutenticacao();
            criarPerfilAutenticacao.Show();
        }

        private bool AutenticarUsuario(string usuario, string senha)
        {
            string stringConexao = "Server=127.0.0.1;Database=localDatabase;Uid=root;Pwd=;";
            using (MySqlConnection conexao = new MySqlConnection(stringConexao))
            {
                // Consulta SQL para verificar se as credenciais existem no banco de dados
                string query = "SELECT COUNT(*) FROM Perfil WHERE usuario = @usuario AND senha = @senha";

                // Prepara a consulta com parâmetros para evitar injeção de SQL
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);

                try
                {
                    conexao.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // Retorna verdadeiro se encontrou uma correspondência
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao autenticar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


    }
}
