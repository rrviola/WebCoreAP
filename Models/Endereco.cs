using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreAP.Models
{
    public class Endereco
    {
        [JsonProperty("enderecoId")]
        public int EnderecoId { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("cidade")]
        public string Cidade { get; set; }

        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("numero")]
        public int Numero { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }
    }

    public class EnderecoCobranca : Endereco
    { }

    public class EnderecoInstalacao : Endereco
    { }
}
