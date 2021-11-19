using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3c1BronsilberTeixeiraSantos51.DTO
{
    class BrinquedoDTO
    {
        private int _codigo;
        private string _nome;
        private double _preco;
        private string _fornecedor;
        private string _categoria;

        public string nome { get => _nome; set => _nome = value; }
        public string fornecedor { get => _fornecedor; set => _fornecedor = value; }
        public int codigo { get => _codigo; set => _codigo = value; }
        public string categoria { get => _categoria; set => _categoria = value; }
        public double preco { get => _preco; set => _preco = value; }
    }
}
