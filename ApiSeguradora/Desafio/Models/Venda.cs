using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public EnumStatusVenda Status { get; set; }
        public DateTime Data { get; set; }
        public Vendedor_ Vendedor { get; set; }
        public List<Item_> Itens { get; set; }
    }
}