// Definindo o encoding UTF-8 para a saída usando acentos
using _01_estacionamento.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento Tabajara\nDigite o preço inicial da tarifa:");
precoInicial = decimal.Parse(Console.ReadLine());

Console.WriteLine("Digite o preço por hora:");
precoPorHora = decimal.Parse(Console.ReadLine());

Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

while (true)
{
    Console.WriteLine("Digite 1 para adicionar um veículo, 2 para remover um veículo, 3 para listar os veículos ou 9 para sair:");
    String opcao = Console.ReadLine() ?? string.Empty;

    switch (opcao)
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;
        case "2":
            estacionamento.RemoverVeiculo();
            break;
        case "3":
            estacionamento.ListarVeiculos();
            break;
        case "9":
            Console.WriteLine("Saindo...");
            return;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}