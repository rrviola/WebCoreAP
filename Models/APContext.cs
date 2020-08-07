using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCoreAP.Models;


namespace WebCoreAP.Models
{
    public class APContext : DbContext 
    {
        public APContext(DbContextOptions<APContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<EnderecoCobranca> EnderecosCobranca { get; set; }
        public DbSet<EnderecoInstalacao> EnderecosInstalacao { get; set; }
        public DbSet<Instalacao> Instalacoes { get; set; }
        public DbSet<Fatura> Faturas { get; set; }       
        public DbSet<WebCoreAP.Models.ListaInstalacao> ListaInstalacao { get; set; }
    }
}
