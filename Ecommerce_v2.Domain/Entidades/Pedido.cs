using Ecommerce_v2.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_v2.Domain
{
    public class Pedido
    {
        public Guid Id { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataPedido { get; set; }
        public StatusPedido Status { get; set; }
        public decimal Total { get; set; }
    }
}
