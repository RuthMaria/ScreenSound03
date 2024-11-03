using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Petshop
{
    internal class Medico
    {
        public Medico(string nome, string crm,string especialidade)
        {
            Nome = nome;
            Crm = crm;
            Especialidade = especialidade;
        }

        public string Nome { get; set; }
        public string Crm { get; set; }
        public string Especialidade { get; set; }
    }
}
