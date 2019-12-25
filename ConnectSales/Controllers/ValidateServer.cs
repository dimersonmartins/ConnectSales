using ClientSecret;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectSales.Default;

namespace ConnectSales.Controllers
{
    class ValidateServer
    {
        public string user { get; set; }
        public string password { get; set; }
        public async Task<bool> login()
        {
            HttpClient client = new HttpClient(
                new HttpClientHandler
                {
                    UseCookies = false,
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
                });
            client.Timeout = TimeSpan.FromHours(2);

            string[] Accept = new string[] { "image/gif", "image/jpeg", "image/pjpeg", "application/x-ms-application", "application/xaml+xml", "application/x-ms-xbap", "*/*" };
            string[] AcceptEncoding = new string[] { "gzip", "deflate" };

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Accept", Accept);
            client.DefaultRequestHeaders.Add("Accept-Language", "pt-BR");
            client.DefaultRequestHeaders.Add("Accept-Encoding", AcceptEncoding);
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)");

            HttpResponseMessage response = await client.GetAsync("http://167.71.149.18/nsales/");
            //HttpResponseMessage response = await client.GetAsync("http://contact-nsales.com/");
            var contents = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                JObject server = JObject.Parse(contents);

                foreach (var dataClient in server["Clients"])
                {
                    if (vMachineName(dataClient["machineName"].ToString()))
                    {
                        if (accountActive(dataClient["active"].ToString()))
                        {
                            if (validateUserAndPassword(dataClient["login"].ToString(), dataClient["password"].ToString()))
                            {
                                if (Convert.ToInt32(dataClient["date"]["ano"].ToString()) <= Convert.ToInt32(dataClient["prazo"]["ano"].ToString()))
                                {
                                    //if (Convert.ToInt32(dataClient["date"]["mes"].ToString()) <= Convert.ToInt32(dataClient["prazo"]["mes"].ToString()))
                                    //{
                                    //    if (Convert.ToInt32(dataClient["date"]["dia"].ToString()) >= Convert.ToInt32(dataClient["prazo"]["dia"].ToString()))
                                    //    {
                                    //        return true;
                                    //    }
                                    //}

                                    return true;
                                }
                            }
                        }
                    }
                   
                }
            }
            return false;
        }

        private bool accountActive(string active)
        {
            if (active == "true")
            {
                return true;
            }
            MessageBox.Show("Conta Inativa!", Config.AplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private bool validateUserAndPassword(string login, string pPassword)
        {
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Usuário e Senha são obrigatorios!", Config.AplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (user == login && password == pPassword)
            {
                return true;
            }
            MessageBox.Show("Usuário ou senha invalídos!", Config.AplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private bool vMachineName(string machineName)
        {
            if (Environment.MachineName == machineName)
            {
                return true;
            }
            MessageBox.Show("Produto não foi ativado para este Computador!", Config.AplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    
}
