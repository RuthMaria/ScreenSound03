using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Petshop
{
    internal class Pet
    {
        public Pet(string nome, int idade, string especie)
        {
            Nome = nome;
            Idade = idade;
            Especie = especie;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Especie { get; set; }
    }
}
