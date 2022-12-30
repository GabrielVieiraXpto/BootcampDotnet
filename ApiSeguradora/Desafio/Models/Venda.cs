using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public Vendedor Vendedor { get; set; }
        public EnumStatusVenda Status { get; set; }
        public DateTime Data { get; set; }
        public List<Item> Itens { get; set; }
    }
}