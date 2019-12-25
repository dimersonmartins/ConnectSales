using ConnectSales.Controllers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ConnectSales.Views.Modules
{
    public partial class ReportControl : UserControl
    {
        public ReportControl()
        {
            InitializeComponent();
        }

        private int countPendentes      = 0;
        private int countConectados     = 0;
        private int countNaoEncontrados = 0;
        private int countCancelados     = 0;
        private int countDesabilitados  = 0;
        private int countDesconectados  = 0;

        private void ReportControl_Load(object sender, EventArgs e)
        {
            lblCountPendentes.Text = countPendentes.ToString();
            lblCountConectados.Text = countConectados.ToString();
            lblCountNaoLocalizados.Text = countNaoEncontrados.ToString();
            lblCountCancelados.Text = countCancelados.ToString();
            lblCountDesconestados.Text = countDesconectados.ToString();
            lblCountDesabilitados.Text = countDesabilitados.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            countPendentes =  StausController.PEND_EM_INSTALACAO.Count() + StausController.PEND_EM_LIBERACAO.Count();
            countConectados = StausController.CONECTADO.Count();
            countNaoEncontrados = StausController.NAO_ECONTRADO.Count();
            countCancelados = StausController.CANCELADO.Count();

            countDesabilitados = StausController.DESABILITADO.Count()
                + StausController.DESABILITADO_BLOQUEIO_PARCIAL.Count()
                + StausController.DESABILITADO_BLOQUEIO_TOTAL.Count()
                + StausController.DESABILITADO_BP_DESABILITADO_BT.Count()
                + StausController.DESABILITADO_BP_DESCONECTADO_P_INADIM.Count()
                + StausController.DESABILITADO_BT_DESCONECTADO_P_INADIM.Count()
                + StausController.DESABILITADO_CONECTADO.Count()
                + StausController.DESABILITADO_DESCONEXAO_PARCIAL.Count()
                + StausController.DESABILITADO_DESCONEXAO_SSI.Count()
                + StausController.DESABILITADO_DESCONEXAO_SSI_EBT.Count()
                + StausController.DESABILITADO_PARCIAL.Count()
                + StausController.DESABILITADO_PARCIAL_CONECTADO.Count()
                + StausController.DESABILITADO_PARCIAL_DESCONEXAO_SSI.Count()
                + StausController.DESABIL_PARCIAL_DESABILITADO_TOTAL.Count()
                + StausController.DESABIL_PARCIAL_DESCONECTADO_OPCAO.Count()
                + StausController.DESABIL_PARCIAL_DESCONECTADO_P_INADIM.Count()
                + StausController.DESABIL_TOTAL_DESABILITADO_PARCIAL.Count()
                + StausController.DESAB_PARCIAL_DESCONEXAO_SSI_EBT.Count();

            countDesconectados = StausController.DESCONECTADO_DIVERGENCIA_CAD_SSI_EBT.Count()
                + StausController.DESCONECTADO_DIVERGENCIA_DE_CADASTRO_SSI.Count()
                + StausController.DESCONECTADO_INADIMPLENCIA_TOTAL.Count()
                + StausController.DESCONECTADO_OPCAO.Count()
                + StausController.DESCONECTADO_OPCAO_MUD_ENDERECO.Count()
                + StausController.DESCONECTADO_PARCIAL.Count()
                + StausController.DESCONECTADO_PARCIAL_DESCONEXAO_SSI.Count()
                + StausController.DESCONECTADO_PARCIAL_MUDANCA_ENDERECO.Count()
                + StausController.DESCONECTADO_PARCIAL_RECONEXAO.Count()
                + StausController.DESCONECTADO_PARC_RECONEXAO_DESPACHADA.Count()
                + StausController.DESCONECTADO_PARC_S_DIVIDA_S_RECONEXAO.Count()
                + StausController.DESCONECTADO_POR_INADIMPLENCIA.Count()
                + StausController.DESCONECTADO_REINSTALACAO.Count()
                + StausController.DESC_INAD_TOTAL_DESCONEXAO_SSI.Count()
                + StausController.DESC_INAD_TOTAL_DESCONEXAO_SSI_EBT.Count()
                + StausController.DESC_PARCIAL_DESCONEXAO_SSI_EBT.Count();

            lblCountPendentes.Text = countPendentes.ToString();
            lblCountConectados.Text = countConectados.ToString();
            lblCountNaoLocalizados.Text = countNaoEncontrados.ToString();
            lblCountCancelados.Text = countCancelados.ToString();
            lblCountDesconestados.Text = countDesconectados.ToString();
            lblCountDesabilitados.Text = countDesabilitados.ToString();

        }
    }
}
