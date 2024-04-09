using System;
using System.Globalization;
using CalculoEstacionamento.Entities;

namespace Estacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            CadastroCarro carro = new CadastroCarro();
            Console.WriteLine("Seja bem vindo ao nosso estacionamento! Escolha as seguintes opções: ");
            Console.WriteLine("1. Cadastrar veículo");
            Console.WriteLine("2. Remover veículo");
            Console.WriteLine("3. Listar veículos");
            Console.WriteLine("4. Sair");

            Console.Write("Informe a opção desejada: ");
            int opcao = int.Parse(Console.ReadLine());
            carro.CadastroSistema(opcao);
        }
    }
}