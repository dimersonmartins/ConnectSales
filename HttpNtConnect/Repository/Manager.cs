using HttpAscConnect.Requests;
using HttpNtConnect.Default;
using HttpNtConnect.Requests.Auth;
using HttpNtConnect.Requests.Querys;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HttpNtConnect.Repository
{
    public class Manager
    {
        public int totalParams { get; set; }
        public async Task<bool> connect(string user, string password)
        {
            try
            {
                Auth auth = new Auth();
                string[] ASCCookies = await auth.execute();
                if (ASCCookies == null)
                {
                    return false;
                }

                Config.ASC_KEY_REMOTE = ASCCookies[0];

                Net authNetSales = new Net();

                bool v = await authNetSales.execute(user, password);

                return v;
            }
            catch { }
            return false;
        }
        private List<string> ContratosForaFieldsBlackList = new List<string>();
        private List<string> ContratosNgestorForaFieldsBlackList = new List<string>();
        public async Task<string> consultaContrato(string contrato)
        {
            if (!ContratosNgestorForaFieldsBlackList.Contains(contrato))
            {
                ConsultaContrato consultaContrato = new ConsultaContrato();
                string content = await consultaContrato.pesquisaContratoParam1(contrato);
                var status = readContentForaFieldNgestor(content);
                if (string.IsNullOrWhiteSpace(status))
                {
                    if (totalParams == 1)
                    {
                        ContratosNgestorForaFieldsBlackList.Add(contrato);
                        return "NAO ENCONTRADO";
                    }
                    content = await consultaContrato.pesquisaContratoParam2(contrato);
                    status = readContentForaFieldNgestor(content);
                    if (string.IsNullOrWhiteSpace(status))
                    {
                        if (totalParams == 2)
                        {
                            ContratosNgestorForaFieldsBlackList.Add(contrato);
                            return "NAO ENCONTRADO";
                        }
                        content = await consultaContrato.pesquisaContratoParam3(contrato);
                        status = readContentForaFieldNgestor(content);
                        if (string.IsNullOrWhiteSpace(status))
                        {
                            ContratosNgestorForaFieldsBlackList.Add(contrato);
                            return "NAO ENCONTRADO";
                        }
                    }
                    return status;
                }
                else
                {
                    ContratosNgestorForaFieldsBlackList.Add(contrato);
                    return status;
                }
            }
            return "CONTRATO DUPLICADO";
        }
        private string readContentForaFieldNgestor(string CONTENT)
        {
            try
            {
                var htmlDoc = new HtmlAgilityPack.HtmlDocument();
                htmlDoc.LoadHtml(CONTENT);
                var node_td = htmlDoc.DocumentNode.SelectNodes("//table[contains(@id, \"resultadoPesquisaAssinante\")]/tr/td");
                var arrayStatus = criarArray(node_td);
                return arrayStatus[13].Value.Trim();
            }
            catch
            {
                return null;
            }
        }
        private List<KeyValuePair<int, string>> criarArray(HtmlAgilityPack.HtmlNodeCollection htmlNode)
        {
            try
            {
                List<KeyValuePair<int, string>> lista = new List<KeyValuePair<int, string>>();
                int key = 0;

                foreach (var item in htmlNode)
                {
                    lista.Add(new KeyValuePair<int, string>(key, item.InnerText));
                    key++;
                }
                return lista;
            }
            catch
            {
                return null;
            }

        }
    }
}
