using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_v2.Domain.Enums
{
    public enum TipoPagamento
    {
        CREDITO = 1,
        DEBITO,
        BOLETO,
        PIX,
        PAYPAL,
        CHEQUE,
    }
}
