using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    class Mercado
    {
        public int Id { get; set; }
        public List<Funcionario> Funcionarios { get; set; }
        public List<Produto> Produtos { get; set; }
        public GuardaVolume Volumes { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
    }
}
