using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_dotnet_fundamentos_desafio.Models
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
    }
}