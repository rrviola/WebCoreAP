using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreAP.Models
{
    //Public Object Controller
    public class Instalacao
    {
        [JsonProperty("instalacaoId")]
        public int InstalacaoId { get; set; }

        //[JsonProperty("clienteId")]
        [ForeignKey("Cliente")]
        public int ClienteRefId { get; set; }
        public Cliente Cliente { get; set; }

        //[JsonProperty("enderecoInstalacaoId")]
        [ForeignKey("EnderecoInstalacao")]
        public int EnderecoInstalacaoRefId { get; set; }
        public EnderecoInstalacao EnderecoInstalacao { get; set; }

        [JsonProperty("codigo")]
        public string Codigo { get; set; }

        [JsonProperty("dataInstalacao")]
        public DateTime DataInstalacao { get; set; }
    }

    public class ListaInstalacao
    {
        [JsonProperty("listaInstalacaoId")]
        public int ListaInstalacaoId { get; set; }

        [JsonProperty("listaInstalacao")]
        public ICollection<Instalacao> Instalacoes { get; set; }
    }

}
