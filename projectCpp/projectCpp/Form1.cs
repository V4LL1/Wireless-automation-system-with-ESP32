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
            inicio inicio = new inicio();
            inicio.Show();
        }

        private void criarBtn_Click(object sender, EventArgs e)
        {
            CriarPerfilAutenticacao criarPerfilAutenticacao = new CriarPerfilAutenticacao();
            criarPerfilAutenticacao.Show();
        }
    }
}
