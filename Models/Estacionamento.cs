using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrilhaDotnetFundamentosDesafio.Models
{
    public class Estacionamento
    {
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }
        public Estacionamento(decimal precoInicial, decimal precoPorHora, List<VeiculoEstacionado> placasDosVeiculos)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
            Veiculos = placasDosVeiculos;
        }

        public decimal PrecoInicial { get; set; }
        public decimal PrecoPorHora { get; set; }
        public List<VeiculoEstacionado> Veiculos { get; set; }

        public void CadastrarVeiculo(VeiculoEstacionado newVeiculo)
        {
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
            Veiculos.Add(newVeiculo);
        }

        public void ListarVeiculos()
        {
            Console.WriteLine("Os carros estacionados são:");
            foreach (VeiculoEstacionado veiculo in Veiculos)
            {
                Console.WriteLine(veiculo.PlacaDoVeiculo);
            }
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
        }

        public bool RemoverVeiculo(VeiculoEstacionado sairVeiculo)
        {
            bool success = Veiculos.Remove(sairVeiculo);
            return success;
        }
    }
}