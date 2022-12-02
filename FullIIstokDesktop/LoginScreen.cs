using FullIIstokDesktop.Data;
using FullIIstokDesktop.Model;
using System.Data;

namespace FullIIstokDesktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            
            // 1 - Conectar na DB 
            try 
            {
                User user = new User();

                user.Login = txtUser.Text;
                user.Password = txtPsw.Text;

                int result = DalHelper.Access(user.Login, user.Password);

                // 2 - Verifica se o usuário existe
                // 3 - Se cadastrado, abrir a classe MenuScreen
                if (result == 1)
                {
                    MenuScreen menu;
                    
                    menu = new MenuScreen();

                    txtUser.Text = "";
                    txtPsw.Text = "";

                    menu.Show();
                    
                }
                else
                
                // Se não estiver cadastrado, exibir mensagem 
                {
                    MessageBox.Show("Invalid username and/or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pbShow_Click(object sender, EventArgs e)
        {
            pbHide.BringToFront();
            txtPsw.PasswordChar = '\0';
        }

        private void pbHide_Click(object sender, EventArgs e)
        {
            pbShow.BringToFront();
            txtPsw.PasswordChar = '*';
        }
    }
}