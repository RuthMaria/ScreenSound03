using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Petshop
{
    internal class Consulta
    {
        public Pet Animal { get; set; }
        public Dono DonoAnimal { get; set; }
        public Medico Veterinario { get; set; }
        public string DataConsulta { get; set; }

        public Consulta(Pet animal, Dono dono, Medico veterinario, string dataConsulta)
        {
            Animal = animal;
            DonoAnimal = dono;
            Veterinario = veterinario;
            DataConsulta = dataConsulta;
        }
    }
}
