using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreAP.Models
{
    //Public Object Controller
    public class Cliente
    {
        [JsonProperty("clienteId")]
        public int ClienteId { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("cpf")]
        public string Cpf { get; set; }

        [JsonProperty("dataNascimento")]
        public DateTime DataNascimento { get; set; }

        //[JsonProperty("enderecoId")]
        [ForeignKey("Endereco")]
        public int EnderecoRefId { get; set; }
        public Endereco Endereco { get; set; }
                
        //[JsonProperty("enderecoCobrancaId")]
        [ForeignKey("EnderecoCobranca")]
        public int EnderecoCobrancaRefId { get; set; }     
        public EnderecoCobranca EnderecoCobranca { get; set; }     
    }
}
