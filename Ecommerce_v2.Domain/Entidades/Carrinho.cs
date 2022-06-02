using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_v2.Domain.Entidades
{
    public class Carrinho
    {
        public bool Vazio { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
