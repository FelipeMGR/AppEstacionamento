using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculoEstacionamento.Exceções;

namespace CalculoEstacionamento.Entities
{
    public class CadastroCarro
    {
        private decimal precoInicial = 15;
        private decimal precoPorHora = 2;
        private List<string> veiculos = new List<string>();

        public CadastroCarro()
        {
        }

        public CadastroCarro(decimal precoInicial, decimal precoPorHora, List<string> veiculos)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            this.veiculos = veiculos;
        }

        public void AdicionarCarro()
        {
            Console.WriteLine("Informe a placa do carro: ");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public decimal RemoverCarro()
        {
            Console.WriteLine("Informe a placa do carro: ");
            string placa = Console.ReadLine();
            Console.Write("Informe a hora de entrada, no formato HH:mm: ");
            TimeSpan horaEntrada = TimeSpan.Parse(Console.ReadLine());
            Console.Write("Informe a hora de saída, no formato HH:mm: ");
            TimeSpan horaSaída = TimeSpan.Parse(Console.ReadLine());
            decimal pagar = CalculoPreco(precoPorHora, precoInicial, horaEntrada, horaSaída);
            veiculos.Remove(placa);
            Console.WriteLine($"Valor a ser pago: R${pagar}");
            return pagar;
        }

        public decimal CalculoPreco(decimal precoHora, decimal precoInicial, TimeSpan horaentrada, TimeSpan horasaida)
        {
            TimeSpan totalHoras = TimeSpan.FromHours(horasaida.Hours).Subtract(horaentrada);

            if (totalHoras.Hours > 12)
            {
                decimal precoFinal = precoInicial + totalHoras.Hours * precoHora * 2;
                return precoFinal;
            }

            return totalHoras.Hours * precoHora + precoInicial;

        }

        public void ListarCarros()
        {
            foreach(var item in veiculos)
            {
                Console.WriteLine(item);
            }
        }
        public void CadastroSistema(int opcao)
        {
            bool menuAtivo = true;
            
            while(menuAtivo)
            {
                Console.Write("Selecione uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    AdicionarCarro();
                }
                else if (opcao == 2)
                {
                    RemoverCarro();
                }
                else if (opcao == 3)
                {
                    ListarCarros();
                }
                else if (opcao == 4)
                {
                    
                    Console.WriteLine("Volte sempre!");
                    menuAtivo = false;
                }
                else
                {
                    throw new ExcecoesPrincipais("Opção inválida, recomece a operação.");
                }
            }
               
        }
    }
}
