using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Desafio.Models;


namespace Desafio.Context
{
    public class Seguradora : DbContext
    {
        public Seguradora (DbContextOptions<Seguradora> options) : base(options)
        {

        }
        public DbSet<Venda> Vendas { get; set; }
    }
}