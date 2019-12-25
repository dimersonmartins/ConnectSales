using System.Collections.Generic;

namespace ConnectSales.Controllers
{
    class StausController
    {
        private string SSTATUS { get; set; }
        public string STATUS
        {
            get
            {
                return this.SSTATUS;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    this.SSTATUS = "NAO_ECONTRADO";
                }
                else
                {
                    this.SSTATUS = value;
                }
            }
        }
        private string SCONTRATO { get; set; }
        public string CONTRATO
        {
            get
            {
                return this.SCONTRATO;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    this.SCONTRATO = "CONTRATO_NAO_ECONTRADO";
                }
                else
                {
                    this.SCONTRATO = value;
                }
            }
        }
        public void save()
        {
            switch (SSTATUS)
            {
                case C_CANCELADO:
                    CANCELADO.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_CONECTADO:
                    CONECTADO.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_CONECTADO_DESABILITACAO:
                    CONECTADO_DESABILITACAO.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_CONECTADO_DESC_OPCAO_DESPACHADA:
                    CONECTADO_DESC_OPCAO_DESPACHADA.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_CONECTADO_DESCONEXAO_OPCAO:
                    CONECTADO_DESCONEXAO_OPCAO.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_CONECTADO_DESCONEXAO_PARCIAL:
                    CONECTADO_DESCONEXAO_PARCIAL.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_CONECTADO_DESCONEXAO_SSI:
                    CONECTADO_DESCONEXAO_SSI.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_CONECTADO_DESCONEXAO_TOTAL:
                    CONECTADO_DESCONEXAO_TOTAL.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_CONECTADO_DESCONEXAO_TOTAL_DESPACHADA:
                    CONECTADO_DESCONEXAO_TOTAL_DESPACHADA.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_CONECTADO_MUDANCA_DE_ENDERECO:
                    CONECTADO_MUDANCA_DE_ENDERECO.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_CONECTADO_DESABILITADO_PARCIAL:
                    CONECTADO_DESABILITADO_PARCIAL.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_CONECTADO_DESCONEXAO_SSI_EBT:
                    CONECTADO_DESCONEXAO_SSI_EBT.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESAB_PARCIAL_DESCONEXAO_SSI_EBT:
                    DESAB_PARCIAL_DESCONEXAO_SSI_EBT.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESABIL_PARCIAL_DESABILITADO_TOTAL:
                    DESABIL_PARCIAL_DESABILITADO_TOTAL.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESABIL_PARCIAL_DESCONECTADO_P_INADIM:
                    DESABIL_PARCIAL_DESCONECTADO_P_INADIM.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESABIL_PARCIAL_DESCONECTADO_OPCAO:
                    DESABIL_PARCIAL_DESCONECTADO_OPCAO.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESABIL_TOTAL_DESABILITADO_PARCIAL:
                    DESABIL_TOTAL_DESABILITADO_PARCIAL.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESABILITADO:
                    DESABILITADO.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESABILITADO_BLOQUEIO_PARCIAL:
                    DESABILITADO_BLOQUEIO_PARCIAL.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESABILITADO_BLOQUEIO_TOTAL:
                    DESABILITADO_BLOQUEIO_TOTAL.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESABILITADO_BP_DESABILITADO_BT:
                    DESABILITADO_BP_DESABILITADO_BT.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESABILITADO_BP_DESCONECTADO_P_INADIM:
                    DESABILITADO_BP_DESCONECTADO_P_INADIM.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESABILITADO_BT_DESCONECTADO_P_INADIM:
                    DESABILITADO_BT_DESCONECTADO_P_INADIM.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESABILITADO_CONECTADO:
                    DESABILITADO_CONECTADO.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESABILITADO_DESCONEXAO_PARCIAL:
                    DESABILITADO_DESCONEXAO_PARCIAL.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESABILITADO_DESCONEXAO_SSI:
                    DESABILITADO_DESCONEXAO_SSI.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESC_INAD_TOTAL_DESCONEXAO_SSI:
                    DESC_INAD_TOTAL_DESCONEXAO_SSI.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESC_PARCIAL_DESCONEXAO_SSI_EBT:
                    DESC_PARCIAL_DESCONEXAO_SSI_EBT.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESCONECTADO_INADIMPLENCIA_TOTAL:
                    DESCONECTADO_INADIMPLENCIA_TOTAL.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESCONECTADO_OPCAO:
                    DESCONECTADO_OPCAO.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESCONECTADO_OPCAO_MUD_ENDERECO:
                    DESCONECTADO_OPCAO_MUD_ENDERECO.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESCONECTADO_DIVERGENCIA_CAD_SSI_EBT:
                    DESCONECTADO_DIVERGENCIA_CAD_SSI_EBT.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESCONECTADO_DIVERGENCIA_DE_CADASTRO_SSI:
                    DESCONECTADO_DIVERGENCIA_DE_CADASTRO_SSI.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESCONECTADO_PARCIAL:
                    DESCONECTADO_PARCIAL.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESCONECTADO_PARCIAL_DESCONEXAO_SSI:
                    DESCONECTADO_PARCIAL_DESCONEXAO_SSI.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESCONECTADO_PARCIAL_MUDANCA_ENDERECO:
                    DESCONECTADO_PARCIAL_MUDANCA_ENDERECO.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESCONECTADO_PARCIAL_RECONEXAO:
                    DESCONECTADO_PARCIAL_RECONEXAO.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESCONECTADO_PARC_RECONEXAO_DESPACHADA:
                    DESCONECTADO_PARC_RECONEXAO_DESPACHADA.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESCONECTADO_PARC_S_DIVIDA_S_RECONEXAO:
                    DESCONECTADO_PARC_S_DIVIDA_S_RECONEXAO.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESCONECTADO_POR_INADIMPLENCIA:
                    DESCONECTADO_POR_INADIMPLENCIA.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESCONECTADO_REINSTALACAO:
                    DESCONECTADO_REINSTALACAO.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_MUD_ENDERECO_DESCONEXAO_OPCAO:
                    MUD_ENDERECO_DESCONEXAO_OPCAO.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_MUD_ENDERECO_SEM_INST_NOVO_ENDERECO:
                    MUD_ENDERECO_SEM_INST_NOVO_ENDERECO.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_MUDANCA_DE_ENDERECO:
                    MUDANCA_DE_ENDERECO.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_NAO_POSSUI:
                    NAO_POSSUI.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_PEND_EM_INSTALACAO:
                    PEND_EM_INSTALACAO.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_PEND_EM_LIBERACAO:
                    PEND_EM_LIBERACAO.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESABILITADO_PARCIAL_DESCONEXAO_SSI:
                    DESABILITADO_PARCIAL_DESCONEXAO_SSI.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESABILITADO_PARCIAL_CONECTADO:
                    DESABILITADO_PARCIAL_CONECTADO.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESABILITADO_DESCONEXAO_SSI_EBT:
                    DESABILITADO_DESCONEXAO_SSI_EBT.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
                case C_DESC_INAD_TOTAL_DESCONEXAO_SSI_EBT:
                    DESC_INAD_TOTAL_DESCONEXAO_SSI_EBT.Add(new KeyValuePair<string, string>(SCONTRATO, SSTATUS));
                    break;
            }
        }

        public void ClearAll()
        {
            NAO_ECONTRADO.Clear();
            CANCELADO.Clear();
            CONECTADO.Clear();
            CONECTADO_DESABILITACAO.Clear();
            CONECTADO_DESC_OPCAO_DESPACHADA.Clear();
            CONECTADO_DESCONEXAO_OPCAO.Clear();
            CONECTADO_DESCONEXAO_PARCIAL.Clear();
            CONECTADO_DESCONEXAO_SSI.Clear();
            CONECTADO_DESCONEXAO_TOTAL.Clear();
            CONECTADO_DESCONEXAO_TOTAL_DESPACHADA.Clear();
            CONECTADO_MUDANCA_DE_ENDERECO.Clear();
            CONECTADO_DESABILITADO_PARCIAL.Clear();
            CONECTADO_DESCONEXAO_SSI_EBT.Clear();
            DESAB_PARCIAL_DESCONEXAO_SSI_EBT.Clear();
            DESABIL_PARCIAL_DESABILITADO_TOTAL.Clear();
            DESABIL_PARCIAL_DESCONECTADO_P_INADIM.Clear();
            DESABIL_PARCIAL_DESCONECTADO_OPCAO.Clear();
            DESABIL_TOTAL_DESABILITADO_PARCIAL.Clear();
            DESABILITADO.Clear();
            DESABILITADO_BLOQUEIO_PARCIAL.Clear();
            DESABILITADO_BLOQUEIO_TOTAL.Clear();
            DESABILITADO_BP_DESABILITADO_BT.Clear();
            DESABILITADO_BP_DESCONECTADO_P_INADIM.Clear();
            DESABILITADO_BT_DESCONECTADO_P_INADIM.Clear();
            DESABILITADO_CONECTADO.Clear();
            DESABILITADO_DESCONEXAO_PARCIAL.Clear();
            DESABILITADO_DESCONEXAO_SSI.Clear();
            DESABILITADO_PARCIAL.Clear();
            DESABILITADO_PARCIAL_DESCONEXAO_SSI.Clear();
            DESABILITADO_PARCIAL_CONECTADO.Clear();
            DESABILITADO_DESCONEXAO_SSI_EBT.Clear();
            DESC_INAD_TOTAL_DESCONEXAO_SSI.Clear();
            DESC_INAD_TOTAL_DESCONEXAO_SSI_EBT.Clear();
            DESC_PARCIAL_DESCONEXAO_SSI_EBT.Clear();
            DESCONECTADO_INADIMPLENCIA_TOTAL.Clear();
            DESCONECTADO_OPCAO.Clear();
            DESCONECTADO_OPCAO_MUD_ENDERECO.Clear();
            DESCONECTADO_DIVERGENCIA_CAD_SSI_EBT.Clear();
            DESCONECTADO_DIVERGENCIA_DE_CADASTRO_SSI.Clear();
            DESCONECTADO_PARCIAL.Clear();
            DESCONECTADO_PARCIAL_DESCONEXAO_SSI.Clear();
            DESCONECTADO_PARCIAL_MUDANCA_ENDERECO.Clear();
            DESCONECTADO_PARCIAL_RECONEXAO.Clear();
            DESCONECTADO_PARC_RECONEXAO_DESPACHADA.Clear();
            DESCONECTADO_PARC_S_DIVIDA_S_RECONEXAO.Clear();
            DESCONECTADO_POR_INADIMPLENCIA.Clear();
            DESCONECTADO_REINSTALACAO.Clear();
            DESCONECTADO_POR_INADIMPLENCIA.Clear();
            MUD_ENDERECO_DESCONEXAO_OPCAO.Clear();
            MUD_ENDERECO_SEM_INST_NOVO_ENDERECO.Clear();
            MUDANCA_DE_ENDERECO.Clear();
            NAO_POSSUI.Clear();
            PEND_EM_INSTALACAO.Clear();
            PEND_EM_LIBERACAO.Clear();
        }

        #region CONSTANTES

        public const string C_NAO_ECONTRADO = "NAO_ECONTRADO";
        public const string C_CANCELADO = "CANCELADO";
        public const string C_CONECTADO = "CONECTADO";
        public const string C_CONECTADO_DESABILITACAO = "CONECTADO (DESABILITACAO)";
        public const string C_CONECTADO_DESC_OPCAO_DESPACHADA = "CONECTADO (DESC. OPCAO DESPACHADA)";
        public const string C_CONECTADO_DESCONEXAO_OPCAO = "CONECTADO (DESCONEXAO - OPCAO)";
        public const string C_CONECTADO_DESCONEXAO_PARCIAL = "CONECTADO (DESCONEXAO PARCIAL)";
        public const string C_CONECTADO_DESCONEXAO_SSI = "CONECTADO (DESCONEXAO SSI)";
        public const string C_CONECTADO_DESCONEXAO_TOTAL = "CONECTADO (DESCONEXAO TOTAL)";
        public const string C_CONECTADO_DESCONEXAO_TOTAL_DESPACHADA = "CONECTADO (DESCONEXAO TOTAL DESPACHADA)";
        public const string C_CONECTADO_MUDANCA_DE_ENDERECO = "CONECTADO (MUDANCA DE ENDERECO)";
        public const string C_CONECTADO_DESABILITADO_PARCIAL = "CONECTADO(DESABILITADO PARCIAL)";
        public const string C_CONECTADO_DESCONEXAO_SSI_EBT = "CONECTADO(DESCONEXAO SSI EBT)";
        public const string C_DESAB_PARCIAL_DESCONEXAO_SSI_EBT = "DESAB PARCIAL(DESCONEXAO SSI EBT)";
        public const string C_DESABIL_PARCIAL_DESABILITADO_TOTAL = "DESABIL PARCIAL(DESABILITADO TOTAL)";
        public const string C_DESABIL_PARCIAL_DESCONECTADO_P_INADIM = "DESABIL PARCIAL(DESCONECTADO P/ INADIM)";
        public const string C_DESABIL_PARCIAL_DESCONECTADO_OPCAO = "DESABIL PARCIAL(DESCONECTADO-OPCAO)";
        public const string C_DESABIL_TOTAL_DESABILITADO_PARCIAL = "DESABIL TOTAL(DESABILITADO PARCIAL)";
        public const string C_DESABILITADO = "DESABILITADO";
        public const string C_DESABILITADO_BLOQUEIO_PARCIAL = "DESABILITADO  BLOQUEIO PARCIAL";
        public const string C_DESABILITADO_BLOQUEIO_TOTAL = "DESABILITADO  BLOQUEIO TOTAL";
        public const string C_DESABILITADO_BP_DESABILITADO_BT = "DESABILITADO BP (DESABILITADO BT)";
        public const string C_DESABILITADO_BP_DESCONECTADO_P_INADIM = "DESABILITADO BP (DESCONECTADO P/ INADIM)";
        public const string C_DESABILITADO_BT_DESCONECTADO_P_INADIM = "DESABILITADO BT (DESCONECTADO P/ INADIM)";
        public const string C_DESABILITADO_CONECTADO = "DESABILITADO (CONECTADO)";
        public const string C_DESABILITADO_DESCONEXAO_PARCIAL = "DESABILITADO (DESCONEXAO PARCIAL)";
        public const string C_DESABILITADO_DESCONEXAO_SSI = "DESABILITADO (DESCONEXAO SSI)";
        public const string C_DESABILITADO_PARCIAL = "DESABILITADO PARCIAL";
        public const string C_DESABILITADO_PARCIAL_DESCONEXAO_SSI = "DESABILITADO PARCIAL (DESCONEXAO SSI)";
        public const string C_DESABILITADO_PARCIAL_CONECTADO = "DESABILITADO PARCIAL(CONECTADO)";
        public const string C_DESABILITADO_DESCONEXAO_SSI_EBT = "DESABILITADO(DESCONEXAO SSI EBT)";
        public const string C_DESC_INAD_TOTAL_DESCONEXAO_SSI = "DESC INAD TOTAL (DESCONEXAO SSI)";
        public const string C_DESC_INAD_TOTAL_DESCONEXAO_SSI_EBT = "DESC INAD(TOTAL)(DESCONEXAO SSI EBT)";
        public const string C_DESC_PARCIAL_DESCONEXAO_SSI_EBT = "DESC PARCIAL(DESCONEXAO SSI EBT)";
        public const string C_DESCONECTADO_INADIMPLENCIA_TOTAL = "DESCONECTADO - INADIMPLENCIA (TOTAL)";
        public const string C_DESCONECTADO_OPCAO = "DESCONECTADO - OPCAO";
        public const string C_DESCONECTADO_OPCAO_MUD_ENDERECO = "DESCONECTADO - OPCAO (MUD. ENDERECO)";
        public const string C_DESCONECTADO_DIVERGENCIA_CAD_SSI_EBT = "DESCONECTADO DIVERGENCIA CAD SSI EBT";
        public const string C_DESCONECTADO_DIVERGENCIA_DE_CADASTRO_SSI = "DESCONECTADO DIVERGENCIA DE CADASTRO SSI";
        public const string C_DESCONECTADO_PARCIAL = "DESCONECTADO PARCIAL";
        public const string C_DESCONECTADO_PARCIAL_DESCONEXAO_SSI = "DESCONECTADO PARCIAL (DESCONEXAO SSI)";
        public const string C_DESCONECTADO_PARCIAL_MUDANCA_ENDERECO = "DESCONECTADO PARCIAL (MUDANCA ENDERECO)";
        public const string C_DESCONECTADO_PARCIAL_RECONEXAO = "DESCONECTADO PARCIAL (RECONEXAO)";
        public const string C_DESCONECTADO_PARC_RECONEXAO_DESPACHADA = "DESCONECTADO PARC.(RECONEXAO DESPACHADA)";
        public const string C_DESCONECTADO_PARC_S_DIVIDA_S_RECONEXAO = "DESCONECTADO PARC.(S/DIVIDA S/RECONEXAO)";
        public const string C_DESCONECTADO_POR_INADIMPLENCIA = "DESCONECTADO POR INADIMPLENCIA";
        public const string C_DESCONECTADO_REINSTALACAO = "DESCONECTADO (REINSTALACAO)";
        public const string C_MUD_ENDERECO_DESCONEXAO_OPCAO = "MUD. ENDERECO (DESCONEXAO - OPCAO)";
        public const string C_MUD_ENDERECO_SEM_INST_NOVO_ENDERECO = "MUD. ENDERECO (SEM INST NOVO ENDERECO)";
        public const string C_MUDANCA_DE_ENDERECO = "MUDANCA DE ENDERECO";
        public const string C_NAO_POSSUI = "NAO POSSUI";
        public const string C_PEND_EM_INSTALACAO = "PEND. EM INSTALACAO";
        public const string C_PEND_EM_LIBERACAO = "PEND. EM LIBERACAO";

        #endregion

        #region LISTA PARA OS STATUS

        public static List<KeyValuePair<string, string>> NAO_ECONTRADO = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> CANCELADO = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> CONECTADO = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> CONECTADO_DESABILITACAO = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> CONECTADO_DESC_OPCAO_DESPACHADA = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> CONECTADO_DESCONEXAO_OPCAO = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> CONECTADO_DESCONEXAO_PARCIAL = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> CONECTADO_DESCONEXAO_SSI = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> CONECTADO_DESCONEXAO_TOTAL = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> CONECTADO_DESCONEXAO_TOTAL_DESPACHADA = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> CONECTADO_MUDANCA_DE_ENDERECO = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> CONECTADO_DESABILITADO_PARCIAL = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> CONECTADO_DESCONEXAO_SSI_EBT = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESAB_PARCIAL_DESCONEXAO_SSI_EBT = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESABIL_PARCIAL_DESABILITADO_TOTAL = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESABIL_PARCIAL_DESCONECTADO_P_INADIM = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESABIL_PARCIAL_DESCONECTADO_OPCAO = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESABIL_TOTAL_DESABILITADO_PARCIAL = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESABILITADO = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESABILITADO_BLOQUEIO_PARCIAL = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESABILITADO_BLOQUEIO_TOTAL = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESABILITADO_BP_DESABILITADO_BT = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESABILITADO_BP_DESCONECTADO_P_INADIM = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESABILITADO_BT_DESCONECTADO_P_INADIM = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESABILITADO_CONECTADO = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESABILITADO_DESCONEXAO_PARCIAL = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESABILITADO_DESCONEXAO_SSI = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESABILITADO_PARCIAL = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESABILITADO_PARCIAL_DESCONEXAO_SSI = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESABILITADO_PARCIAL_CONECTADO = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESABILITADO_DESCONEXAO_SSI_EBT = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESC_INAD_TOTAL_DESCONEXAO_SSI = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESC_INAD_TOTAL_DESCONEXAO_SSI_EBT = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESC_PARCIAL_DESCONEXAO_SSI_EBT = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESCONECTADO_INADIMPLENCIA_TOTAL = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESCONECTADO_OPCAO = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESCONECTADO_OPCAO_MUD_ENDERECO = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESCONECTADO_DIVERGENCIA_CAD_SSI_EBT = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESCONECTADO_DIVERGENCIA_DE_CADASTRO_SSI = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESCONECTADO_PARCIAL = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESCONECTADO_PARCIAL_DESCONEXAO_SSI = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESCONECTADO_PARCIAL_MUDANCA_ENDERECO = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESCONECTADO_PARCIAL_RECONEXAO = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESCONECTADO_PARC_RECONEXAO_DESPACHADA = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESCONECTADO_PARC_S_DIVIDA_S_RECONEXAO = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESCONECTADO_POR_INADIMPLENCIA = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> DESCONECTADO_REINSTALACAO = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> MUD_ENDERECO_DESCONEXAO_OPCAO = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> MUD_ENDERECO_SEM_INST_NOVO_ENDERECO = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> MUDANCA_DE_ENDERECO = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> NAO_POSSUI = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> PEND_EM_INSTALACAO = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> PEND_EM_LIBERACAO = new List<KeyValuePair<string, string>>();
        #endregion
    }
}
