using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjetoEF.Modelo;
using ProjetoEF.Pesquisa;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEF.Contexto
{
    internal class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseSqlServer(@"Server=ANDRÉ\SQLEXPRESS;Database=OFICINA;User Id=SA;Password=001002;Integrated security=True;Encrypt=False");

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pecas> Pecas { get; set; }
        public DbSet<Fornecedores> Fornecedores { get; set; }
        public DbSet<Orcamentos> Orcamentos { get; set;}
        public DbSet<OrcamentosItem> OrcamentosItem { get; set; }
    }
}
