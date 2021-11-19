using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3c1BronsilberTeixeiraSantos51.DTO
{
    class usuarioDTO
    {
        private string _cpf;
        private string _email;
        public string email { get => _email; set => _email = value; }
        public string cpf { get => _cpf; set => _cpf = value; }
    }
}
