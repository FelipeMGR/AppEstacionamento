using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculoEstacionamento.Exceções;

namespace CalculoEstacionamento.Entities
{
    class CadastroCarro
    {
        private readonly ICalculoPreco _preco;

        public List<string> Placas { get; set; }

        public CadastroCarro()
        {
        }

        public CadastroCarro(List<string> placaCarro)
        {
            Placas = placaCarro;
        }

        public void AdicionarCarro(string placa)
        {
            Placas.Add(placa);
        }

        public decimal RemoverCarro(string placa)
        {
            Placas.Remove(placa);
            return _preco.CalculoPreco(_preco.PrecoInicial, _preco.PrecoHora, _preco.HoraEntrada, _preco.HoraSaida);
        }

        public void ListarCarros()
        {
            Placas.ToList();
        }
        public void CadastroSistema(int opcao)
        {
            Console.Write("Informe a quantidade de veículos que serão cadastrados: ");
            int quantidade = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantidade; i++)
            {

                if (opcao == 1)
                {
                    Console.WriteLine("Informe a placa do carro: ");
                    var placa = Console.ReadLine();
                    AdicionarCarro(placa);
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Informe a placa do carro: ");
                    var placa = Console.ReadLine();
                    RemoverCarro(placa);
                }
                else if (opcao == 3)
                {
                    ListarCarros();
                }
                else if (opcao == 4)
                {
                    Console.WriteLine("Volte sempre!");
                }
                else
                {
                    throw new ExcecoesPrincipais("Opção inválida, recomece a operação.");
                }
            }
        }
    }
}
