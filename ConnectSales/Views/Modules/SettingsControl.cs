using ConnectSales.Controllers;
using ConnectSales.Properties;
using DataServer;
using HttpNtConnect.Default;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConnectSales.Views.Modules
{
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default["paramDb2"] = ((KeyValuePair<string, string>)selectCidade.SelectedItem).Value;
                Settings.Default["dbaseState2"] = ((KeyValuePair<string, string>)selectEstado.SelectedItem).Key;
                Settings.Default["dbaseCity2"] = ((KeyValuePair<string, string>)selectCidade.SelectedItem).Key;
                Settings.Default.Save();

                string base_operadora = Settings.Default["paramDb2"].ToString();
                string[] baseConfig = base_operadora.Split('~');

                Config.BASE_OPERADORA2 = baseConfig[1].ToString();
                Config.COD_ESTADO_OPERADORA2 = baseConfig[0].ToString();
                Config.CIDADE_OPERADORA2 = Settings.Default["dbaseCity2"].ToString();
                Config.ESTADO_OPERADORA2 = Settings.Default["dbaseState2"].ToString();

                lblSetState2.Text = Config.ESTADO_OPERADORA2;
                lblSetCity2.Text = Config.CIDADE_OPERADORA2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SettingsControl_Load(object sender, EventArgs e)
        {
            lblSetState1.Text  = Settings.Default["dbaseState1"].ToString();
            lblSetCity1.Text   = Settings.Default["dbaseCity1"].ToString();

            lblSetState2.Text = Settings.Default["dbaseState2"].ToString();
            lblSetCity2.Text = Settings.Default["dbaseCity2"].ToString();

            lblSetState3.Text = Settings.Default["dbaseState3"].ToString();
            lblSetCity3.Text = Settings.Default["dbaseCity3"].ToString();

            Servers servers = new Servers();
            selectEstado.DataSource = new BindingSource(servers.Estatos(), null);
            selectEstado.DisplayMember = "Value";
            selectEstado.ValueMember = "Key";

            selectCidade.DataSource = new BindingSource(servers.Cidades(), null);
            selectCidade.DisplayMember = "Key";
            selectCidade.ValueMember = "Value";
        }

        private void changeUser_CheckedChanged(object sender, EventArgs e)
        {
            if (changeUser.Checked)
            {
                groupBox3.Visible = true;
            }
            else
            {
                groupBox3.Visible = false;
            }
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            FormSettings settings = new FormSettings();
            settings.User = txt_user.Text;
            settings.Password = txt_password.Text;
            settings.save();
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default["paramDb1"] = ((KeyValuePair<string, string>)selectCidade.SelectedItem).Value;
                Settings.Default["dbaseState1"] = ((KeyValuePair<string, string>)selectEstado.SelectedItem).Key;
                Settings.Default["dbaseCity1"] = ((KeyValuePair<string, string>)selectCidade.SelectedItem).Key;
               
                Settings.Default.Save();

                string base_operadora = Settings.Default["paramDb1"].ToString();
                string[] baseConfig = base_operadora.Split('~');

                Config.BASE_OPERADORA1 = baseConfig[1].ToString();
                Config.COD_ESTADO_OPERADORA1 = baseConfig[0].ToString();
                Config.CIDADE_OPERADORA1 = Settings.Default["dbaseCity1"].ToString();
                Config.ESTADO_OPERADORA1 = Settings.Default["dbaseState1"].ToString();

                lblSetState1.Text = Config.ESTADO_OPERADORA1;
                lblSetCity1.Text = Config.CIDADE_OPERADORA1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave3_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default["paramDb3"] = ((KeyValuePair<string, string>)selectCidade.SelectedItem).Value;
                Settings.Default["dbaseState3"] = ((KeyValuePair<string, string>)selectEstado.SelectedItem).Key;
                Settings.Default["dbaseCity3"] = ((KeyValuePair<string, string>)selectCidade.SelectedItem).Key;
                Settings.Default.Save();

                string base_operadora = Settings.Default["paramDb3"].ToString();
                string[] baseConfig = base_operadora.Split('~');

                Config.BASE_OPERADORA3 = baseConfig[1].ToString();
                Config.COD_ESTADO_OPERADORA3 = baseConfig[0].ToString();
                Config.CIDADE_OPERADORA3 = Settings.Default["dbaseCity3"].ToString();
                Config.ESTADO_OPERADORA3 = Settings.Default["dbaseState3"].ToString();

                lblSetState3.Text = Config.ESTADO_OPERADORA3;
                lblSetCity3.Text = Config.CIDADE_OPERADORA3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
