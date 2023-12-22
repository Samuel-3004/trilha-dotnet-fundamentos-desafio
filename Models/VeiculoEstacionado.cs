using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_dotnet_fundamentos_desafio.Models
{
    public class VeiculoEstacionado
    {
        public VeiculoEstacionado(string placaDoVeiculo)
        {
            PlacaDoVeiculo = placaDoVeiculo;
        }

        private string _placaDoVeiculo;

        public string PlacaDoVeiculo
        {
            get => _placaDoVeiculo;

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("A placa do veículo deve ser informada.");
                }

                _placaDoVeiculo = value;
            }
        }

        public void Show()
        {
            Console.WriteLine($"Placa: {PlacaDoVeiculo}");
        }
    }
}