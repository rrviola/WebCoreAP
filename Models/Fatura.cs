using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreAP.Models
{
    //Public Object Controller
    public class Fatura
    {
        [JsonProperty("faturaId")]
        public int FaturaId { get; set; }
        
        //[JsonProperty("clienteId")]
        [ForeignKey("Cliente")]
        public int ClienteRefId { get; set; }
        public Cliente Cliente { get; set; }

        //[JsonProperty("instalacaoId")]
        [ForeignKey("Instalacao")]
        public int InstalacaoRefId { get; set; }
        public Instalacao Instalacao { get; set; }

        [JsonProperty("faturaCodigo")]
        public string FaturaCodigo { get; set; }

        [JsonProperty("dataLeitura")]
        public DateTime DataLeitura { get; set; }

        [JsonProperty("dataVencimento")]
        public DateTime DataVencimento { get; set; }

        [JsonProperty("numeroLeitura")]
        public int NumeroLeitura { get; set; }

        [JsonProperty("valorConta")]
        public int ValorConta { get; set; }
    }
}
