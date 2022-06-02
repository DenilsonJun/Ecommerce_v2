using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_v2.Domain
{
    public class UsuarioContato
    {
        public string Email { get; set; }
        public string EnderecoResidencial { get; set; }
        public string EnderecoComercial { get; set; }
        public string Celular { get; set; }
        public string TelefoneResidencial { get; set; }
        public string TelefoneComercial { get; set; }
    }
}
