using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_v2.Domain
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Foto { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
    }
}
