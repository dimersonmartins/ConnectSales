using ConnectSales.Properties;
using HttpNtConnect.Default;
using System;
using System.Windows.Forms;

namespace ConnectSales.Views.DashBoard
{
    public partial class DsBoard : Form
    {
        public DsBoard()
        {
            InitializeComponent();
            panel3.Height = btnUpload.Height;
            panel3.Top = btnUpload.Top;
            importControl1.BringToFront();
        }

        private void LoadSettingsParam()
        {
            //CONFIG PARAM01
            string base_operadora01 = Settings.Default["paramDb1"].ToString();
            if (!string.IsNullOrWhiteSpace(base_operadora01))
            {
                string[] baseConfig01 = base_operadora01.Split('~');
                Config.BASE_OPERADORA1 = baseConfig01[1].ToString();
                Config.COD_ESTADO_OPERADORA1 = baseConfig01[0].ToString();
                Config.CIDADE_OPERADORA1 = Settings.Default["dbaseCity1"].ToString();
                Config.ESTADO_OPERADORA1 = Settings.Default["dbaseState1"].ToString();
            }
           
           

            //CONFIG PARAM02
            string base_operadora02      = Settings.Default["paramDb2"].ToString();
            string[] baseConfig02        = base_operadora02.Split('~');
            if (!string.IsNullOrWhiteSpace(base_operadora02))
            {
                Config.BASE_OPERADORA2 = baseConfig02[1].ToString();
                Config.COD_ESTADO_OPERADORA2 = baseConfig02[0].ToString();
                Config.CIDADE_OPERADORA2 = Settings.Default["dbaseCity2"].ToString();
                Config.ESTADO_OPERADORA2 = Settings.Default["dbaseState2"].ToString();
            }

            //CONFIG PARAM03
            string base_operadora03      = Settings.Default["paramDb3"].ToString();
            string[] baseConfig03        = base_operadora03.Split('~');
            if (!string.IsNullOrWhiteSpace(base_operadora03))
            {
                Config.BASE_OPERADORA3 = baseConfig03[1].ToString();
                Config.COD_ESTADO_OPERADORA3 = baseConfig03[0].ToString();
                Config.CIDADE_OPERADORA3 = Settings.Default["dbaseCity3"].ToString();
                Config.ESTADO_OPERADORA3 = Settings.Default["dbaseState3"].ToString();
            }
        }

        private void DsBoard_Load(object sender, EventArgs e)
        {
            LoadSettingsParam();
        }

        private void DsBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            panel3.Height = btn_Settings.Height;
            panel3.Top = btn_Settings.Top;
            settingsControl1.BringToFront();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            panel3.Height = btnUpload.Height;
            panel3.Top = btnUpload.Top;
            importControl1.BringToFront();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            panel3.Height = btnReports.Height;
            panel3.Top = btnReports.Top;
            reportControl2.BringToFront();
        }
    }
}
