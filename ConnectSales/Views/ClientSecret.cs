using ConnectSales.Controllers;
using ConnectSales.Views.DashBoard;
using System;
using System.Windows.Forms;

namespace ConnectSales.Views
{
    public partial class ClientSecret : Form
    {
        public ClientSecret()
        {
            InitializeComponent();
        }

        private async void logar()
        {
            ValidateServer validateServer = new ValidateServer();
            validateServer.user = txt_user.Text;
            validateServer.password = txt_password.Text;
            if (await validateServer.login())
            {
                this.Hide();
                new DsBoard().Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logar();
        }


        private void txt_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logar();
            }
        }
    }
}
