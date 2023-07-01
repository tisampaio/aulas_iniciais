using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    class Produto
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Nome { get; set; }
        public Categoria Categoria { get; set; }
    }
}
