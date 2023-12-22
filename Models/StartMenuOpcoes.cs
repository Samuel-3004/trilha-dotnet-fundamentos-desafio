using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrilhaDotnetFundamentosDesafio.Models
{
    public class StartMenuOpcoes
    {
        public void MenuOpcoes()
        {

            bool exibirMenu = true;
            decimal precoInicial;
            decimal precoPorHora;
            string opcaoEscolhida;
            string placaInformada;
            VeiculoEstacionado veiculoInformado;
            Estacionamento carrosEstacionados;
            decimal tempoEstacionado;

            Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");

            precoInicial = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Agora informe o preço por hora: ");
            precoPorHora = Convert.ToDecimal(Console.ReadLine());

            carrosEstacionados = new Estacionamento(precoInicial, precoPorHora);
            carrosEstacionados.Veiculos = new List<VeiculoEstacionado>();

            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção: ");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("4 - Encerrar");

                opcaoEscolhida = Console.ReadLine();

                switch (opcaoEscolhida)
                {
                    case "1":
                        Console.WriteLine("Digite a placa do veículo para estacionar: ");
                        placaInformada = Console.ReadLine().ToUpper();
                        veiculoInformado = new VeiculoEstacionado(placaDoVeiculo: placaInformada);
                        veiculoInformado.Show();
                        carrosEstacionados.CadastrarVeiculo(veiculoInformado);
                        break;
                    case "2":
                        Console.WriteLine("Digite a placa do veículo para sair: ");
                        placaInformada = Console.ReadLine().ToUpper();

                        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                        tempoEstacionado = Convert.ToDecimal(Console.ReadLine());

                        VeiculoEstacionado veiculoLocalizado = carrosEstacionados.Veiculos.Find(veiculo => veiculo.PlacaDoVeiculo == placaInformada);

                        if (veiculoLocalizado != null)
                        {
                            carrosEstacionados.RemoverVeiculo(veiculoLocalizado);
                            Console.WriteLine($"O veículo de placa {placaInformada} foi removido e o preço total foi de R$ {precoInicial + (precoPorHora * tempoEstacionado)}");
                        }
                        else
                        {
                            Console.WriteLine("O veículo não foi localizado");
                        }
                        Console.WriteLine("Pressione qualquer tecla para continuar.");
                        Console.ReadKey();
                        break;
                    case "3":
                        carrosEstacionados.ListarVeiculos();
                        break;
                    case "4":
                        Console.WriteLine("Encerrando...");
                        exibirMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }
            }
        }
    }
}