using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Oficina
{
    internal class Mecanico
    {
        public Mecanico(string nome, string especialidade)
        {
            Nome = nome;
            Especialidade = especialidade;
        }

        public string Nome { get; set; }
        public string Especialidade { get; set; }
    }
}
