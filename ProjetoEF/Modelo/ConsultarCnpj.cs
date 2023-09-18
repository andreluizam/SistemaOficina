using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEF
{
    public class AtividadePrincipal
    {
        public string code { get; set; }
        public string text { get; set; }
    }
    public class AtividadeSecundaria
    {
        public string code { get; set; }
        public string text { get; set; }
    }

    public class Billing
    {
        public bool free { get; set; }
        public bool database { get; set; }
    }
    public class Extra
    {
    }

    public class Qsa
    {
        public string nome { get; set; }
        public string qual { get; set; }
    }

    public class Empresa
    {
        public string abertura { get; set; }
        public string situacao { get; set; }
        public string tipo { get; set; }
        public string nome { get; set; }
        public string porte { get; set; }
        public string natureza_juridica { get; set; }
        public List<Qsa> qsa { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string municipio { get; set; }
        public string bairro { get; set; }
        public string uf { get; set; }
        public string cep { get; set; }
        public string telefone { get; set; }
        public string data_situacao { get; set; }
        public string motivo_situacao { get; set; }
        public string cnpj { get; set; }
        public DateTime ultima_atualizacao { get; set; }
        public string status { get; set; }
        public string fantasia { get; set; }
        public string complemento { get; set; }
        public string email { get; set; }
        public string efr { get; set; }
        public string situacao_especial { get; set; }
        public string data_situacao_especial { get; set; }
        public List<AtividadePrincipal> atividade_pincipal { get; set; }
        public List<AtividadeSecundaria> atividade_secundaria { get; set; }
        public string capital_social { get; set; }
        public Extra extra { get; set; }
        public Billing billing { get; set; }

        public static Empresa ObterByCnpj(string cnpj)
        {
            string url = "https://www.receitaws.com.br/v1/cnpj/" + cnpj;
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(url);

            var empresa = JsonConvert.DeserializeObject<Empresa>(json);

            return empresa;
        }
    }
}
