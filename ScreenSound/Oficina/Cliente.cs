using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Oficina
{
    internal class Cliente
    {
        public Cliente(string nome, string endereco, string contato)
        {
            Nome = nome;
            Endereco = endereco;
            Contato = contato;
        }

        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Contato { get; set; }
    }
}
