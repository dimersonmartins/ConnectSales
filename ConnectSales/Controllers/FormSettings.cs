using ConnectSales.Default;
using ConnectSales.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectSales.Controllers
{
    class FormSettings
    {
        private List<string> errors = new List<string>();
        public string User {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    errors.Add(" -Usuário é obrigatoria!");                    
                }
                else
                {
                    Settings.Default["user"] = value;
                    Settings.Default.Save();
                }
            }
        }

        public string Password
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    errors.Add(" -Senha é obrigatoria!");
                }
                else
                {  
                    Settings.Default["password"] = value;
                    Settings.Default.Save();           
                }
               
            }
        }

        public bool save()
        {
            if (errors.Count == 0)
            {
                MessageBox.Show("Cadastro Efetuado Com Sucesso!", Config.AplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            string err = string.Empty;

            foreach (var error in errors)
            {
                err += error + "\r\n";
            }

            MessageBox.Show(err, Config.AplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }
    }
}
