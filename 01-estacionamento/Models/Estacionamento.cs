using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_estacionamento.Models
{
    public class Estacionamento
    {
        private Decimal precoInicial;
        private Decimal precoPorHora;

        private List<String> veiculos = [];

        public Estacionamento(Decimal precoInicial, Decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo:");
            String placa = Console.ReadLine() ?? string.Empty;
            if (!string.IsNullOrEmpty(placa))
            {
                veiculos.Add(placa.ToUpper());
                Console.WriteLine("Veículo adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Placa inválida!\nDigite 9 para sair ou qualquer tecla para tentar novamente:");
                String opcao = Console.ReadLine() ?? string.Empty;
                if (opcao == "9")
                {
                    Console.WriteLine("Saindo...");
                }
                else
                {
                    AdicionarVeiculo();
                }
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo:");
            String placa = Console.ReadLine() ?? string.Empty;
            if (!string.IsNullOrEmpty(placa) && veiculos.Any(v => v == placa.ToUpper()))
            {
                Console.WriteLine("Informe quantas horas o veiculo ficou estacionado:");
                int horas = int.Parse(Console.ReadLine());
                Decimal preco = precoInicial + (horas * precoPorHora);
                Console.WriteLine($"O veículo com a placa {placa} ficou estacionado por {horas} horas e o valor a ser pago é de R$ {preco}");
            }
            else
            {
                Console.WriteLine("Placa inválida!\nDigite 9 para sair ou qualquer tecla para tentar novamente:");
                String opcao = Console.ReadLine() ?? string.Empty;
                if (opcao == "9")
                {
                    Console.WriteLine("Saindo...");
                }
                else
                {
                    RemoverVeiculo();
                }
            }
        }

        public void ListarVeiculos()
        {
            Console.WriteLine("Veículos estacionados:");
            foreach (String veiculo in veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }
    }
}