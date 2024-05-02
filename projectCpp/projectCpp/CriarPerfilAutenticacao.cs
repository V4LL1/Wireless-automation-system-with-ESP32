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
    public partial class CriarPerfilAutenticacao : Form
    {
        public CriarPerfilAutenticacao()
        {
            InitializeComponent();
        }

        private void CriarPerfilAutenticacao_Load(object sender, EventArgs e)
        {

        }
        private void entrarBtn_Click(object sender, EventArgs e)
        {
            string senhaAdmin = senhaAdminTxt.Text;

            if (senhaAdmin == "admin")
            {
                CriarPerfil inicio = new CriarPerfil();
                inicio.Show();
            } else
            {
                MessageBox.Show("Senha de acesso inválida!");
            }
        }
    }
}
