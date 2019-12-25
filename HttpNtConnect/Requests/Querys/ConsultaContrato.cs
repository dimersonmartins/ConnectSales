using HttpNtConnect.Default;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HttpNtConnect.Requests.Querys
{
    public class ConsultaContrato
    {
        public async Task<string> pesquisaContratoParam1(string num_contrato)
        {
            Dictionary<string, string> form_data = new Dictionary<string, string>
            {
                { "acao", "search" },
                { "codCidade", Config.COD_ESTADO_OPERADORA1 },
                { "nomeCidade", Config.CIDADE_OPERADORA1 },
                { "cidContrato",Config.COD_ESTADO_OPERADORA1 },
                { "dddVoip","" },
                { "telefoneVoip","" },
                { "dddTelefone","" },
                { "campoHiddenCidade",Config.CIDADE_OPERADORA1 },
                { "sglEstado",Config.ESTADO_OPERADORA1 },
                { "cidadeText",Config.CIDADE_OPERADORA1 },
                { "cidade",Config.COD_ESTADO_OPERADORA1 },
                { "codNet",num_contrato },
                { "nomeComecando","true" },
                { "tipoCpfCnpj","false" },
                { "tipoTel","false" },
                { "protocolo","" },
                { "dbService",Config.BASE_OPERADORA1 }
            };
            CookieContainer cookies = new CookieContainer();
            HttpClient client = new HttpClient(
                new HttpClientHandler
                {
                    UseCookies = false,
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                    AllowAutoRedirect = false
                });
            client.Timeout = TimeSpan.FromHours(2);

            string[] Accept = new string[] { "image/gif", "image/jpeg", "image/pjpeg", "application/x-ms-application", "application/xaml+xml", "application/x-ms-xbap", "*/*" };
            string[] AcceptEncoding = new string[] { "gzip", "deflate" };

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Accept", Accept);
            client.DefaultRequestHeaders.Add("Accept-Language", "pt-BR");
            client.DefaultRequestHeaders.Add("Accept-Encoding", AcceptEncoding);
            client.DefaultRequestHeaders.Add("Referer", "https://netsales.netservicos.com.br/NETSales/pesquisaAssinantes.do?acao=prepareSearch");
            client.DefaultRequestHeaders.Add("User-Agent", Config.useragent);
            client.DefaultRequestHeaders.Add("Host", "netsales.netservicos.com.br");
            client.DefaultRequestHeaders.Add("Cookie", "asc-key-remote=" + Config.ASC_KEY_REMOTE + ";" + Config.JSESSIONID + ";" + Config.LBNS);

            HttpContent content = new FormUrlEncodedContent(form_data);
            HttpResponseMessage response = await client.PostAsync("https://netsales.netservicos.com.br/NETSales/pesquisaAssinantes.do", content);
            var contents = await response.Content.ReadAsStringAsync();
            HttpContentHeaders headers = content.Headers;

            if (response.IsSuccessStatusCode)
            {
                return contents;
            }
            return null;
        }
        public async Task<string> pesquisaContratoParam2(string num_contrato)
        {
            Dictionary<string, string> form_data = new Dictionary<string, string>
            {
                { "acao", "search" },
                { "codCidade", Config.COD_ESTADO_OPERADORA2 },
                { "nomeCidade", Config.CIDADE_OPERADORA2 },
                { "cidContrato",Config.COD_ESTADO_OPERADORA2 },
                { "dddVoip","" },
                { "telefoneVoip","" },
                { "dddTelefone","" },
                { "campoHiddenCidade",Config.CIDADE_OPERADORA2 },
                { "sglEstado",Config.ESTADO_OPERADORA2 },
                { "cidadeText",Config.CIDADE_OPERADORA2 },
                { "cidade",Config.COD_ESTADO_OPERADORA2 },
                { "codNet",num_contrato },
                { "nomeComecando","true" },
                { "tipoCpfCnpj","false" },
                { "tipoTel","false" },
                { "protocolo","" },
                { "dbService",Config.BASE_OPERADORA2 }
            };
            CookieContainer cookies = new CookieContainer();
            HttpClient client = new HttpClient(
                new HttpClientHandler
                {
                    UseCookies = false,
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                    AllowAutoRedirect = false
                });
            client.Timeout = TimeSpan.FromHours(2);

            string[] Accept = new string[] { "image/gif", "image/jpeg", "image/pjpeg", "application/x-ms-application", "application/xaml+xml", "application/x-ms-xbap", "*/*" };
            string[] AcceptEncoding = new string[] { "gzip", "deflate" };

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Accept", Accept);
            client.DefaultRequestHeaders.Add("Accept-Language", "pt-BR");
            client.DefaultRequestHeaders.Add("Accept-Encoding", AcceptEncoding);
            client.DefaultRequestHeaders.Add("Referer", "https://netsales.netservicos.com.br/NETSales/pesquisaAssinantes.do?acao=prepareSearch");
            client.DefaultRequestHeaders.Add("User-Agent", Config.useragent);
            client.DefaultRequestHeaders.Add("Host", "netsales.netservicos.com.br");
            client.DefaultRequestHeaders.Add("Cookie", "asc-key-remote=" + Config.ASC_KEY_REMOTE + ";" + Config.JSESSIONID + ";" + Config.LBNS);

            HttpContent content = new FormUrlEncodedContent(form_data);
            HttpResponseMessage response = await client.PostAsync("https://netsales.netservicos.com.br/NETSales/pesquisaAssinantes.do", content);
            var contents = await response.Content.ReadAsStringAsync();
            HttpContentHeaders headers = content.Headers;

            if (response.IsSuccessStatusCode)
            {
                return contents;
            }
            return null;
        }
        public async Task<string> pesquisaContratoParam3(string num_contrato)
        {
            Dictionary<string, string> form_data = new Dictionary<string, string>
            {
                { "acao", "search" },
                { "codCidade", Config.COD_ESTADO_OPERADORA3 },
                { "nomeCidade", Config.CIDADE_OPERADORA3 },
                { "cidContrato",Config.COD_ESTADO_OPERADORA3 },
                { "dddVoip","" },
                { "telefoneVoip","" },
                { "dddTelefone","" },
                { "campoHiddenCidade",Config.CIDADE_OPERADORA3 },
                { "sglEstado",Config.ESTADO_OPERADORA3 },
                { "cidadeText",Config.CIDADE_OPERADORA3 },
                { "cidade",Config.COD_ESTADO_OPERADORA3 },
                { "codNet",num_contrato },
                { "nomeComecando","true" },
                { "tipoCpfCnpj","false" },
                { "tipoTel","false" },
                { "protocolo","" },
                { "dbService",Config.BASE_OPERADORA3 }
            };
            CookieContainer cookies = new CookieContainer();
            HttpClient client = new HttpClient(
                new HttpClientHandler
                {
                    UseCookies = false,
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                    AllowAutoRedirect = false
                });
            client.Timeout = TimeSpan.FromHours(2);

            string[] Accept = new string[] { "image/gif", "image/jpeg", "image/pjpeg", "application/x-ms-application", "application/xaml+xml", "application/x-ms-xbap", "*/*" };
            string[] AcceptEncoding = new string[] { "gzip", "deflate" };

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Accept", Accept);
            client.DefaultRequestHeaders.Add("Accept-Language", "pt-BR");
            client.DefaultRequestHeaders.Add("Accept-Encoding", AcceptEncoding);
            client.DefaultRequestHeaders.Add("Referer", "https://netsales.netservicos.com.br/NETSales/pesquisaAssinantes.do?acao=prepareSearch");
            client.DefaultRequestHeaders.Add("User-Agent", Config.useragent);
            client.DefaultRequestHeaders.Add("Host", "netsales.netservicos.com.br");
            client.DefaultRequestHeaders.Add("Cookie", "asc-key-remote=" + Config.ASC_KEY_REMOTE + ";" + Config.JSESSIONID + ";" + Config.LBNS);

            HttpContent content = new FormUrlEncodedContent(form_data);
            HttpResponseMessage response = await client.PostAsync("https://netsales.netservicos.com.br/NETSales/pesquisaAssinantes.do", content);
            var contents = await response.Content.ReadAsStringAsync();
            HttpContentHeaders headers = content.Headers;

            if (response.IsSuccessStatusCode)
            {
                return contents;
            }
            return null;
        }
    }
}
