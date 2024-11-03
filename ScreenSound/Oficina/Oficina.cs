using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Oficina
{
    internal class Oficina
    {
        private List<Veiculo> veiculos;

        public Oficina()
        {
            veiculos = new List<Veiculo>();
        }

        public void AgendarServico(Veiculo veiculo, Cliente cliente, Mecanico mecanico, string dataAgendamento)
        {
            veiculos.Add(veiculo);
            Console.WriteLine($"Serviço agendado para o veiculo {veiculo.Placa}");
        }

        public void RealizarServico(Veiculo veiculo, Mecanico mecanico)
        {
            if (veiculos.Contains(veiculo))
            {
                veiculos.Remove(veiculo);
                Console.WriteLine($"Serviço realizado em {veiculo.Placa} pelo mecânico {mecanico.Nome}.");
            }
            else
            {
                Console.WriteLine($"O veículo {veiculo.Placa} não está na oficina para realizar o serviço.");
            }
        }
    }
}
