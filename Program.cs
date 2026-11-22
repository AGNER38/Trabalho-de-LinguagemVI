using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProjectoFaturacao
{
    class Program
    {
        static bool PerguntarSimNao(string pergunta)
        {
            Console.Write(pergunta + " (S/N): ");
            string resposta = Console.ReadLine();
            if (resposta == "S" || resposta == "s")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static Cliente RegistarCliente()
        {
            Cliente c = new Cliente();
            Console.Write("Nome do cliente: ");
            c.Nome = Console.ReadLine();
            Console.Write("Genero (M/F): ");
            c.Genero = Console.ReadLine();
            Console.Write("VALOR Gasto total das compras : ");
            c.ValorCompras = double.Parse(Console.ReadLine());
         
            if (c.Genero == "F" || c.Genero == "f")
            {
                c.Gravida = PerguntarSimNao("É gravida?");
            }
            c.Idoso = PerguntarSimNao("É idoso(a)?");
            c.Deficiente = PerguntarSimNao("Tem deficiente?");
            return c;
        }
        static void Main(string[] args)
        {
            Atendimento atendimento = new Atendimento();
            int opcao = -1;
            while (opcao != 0)
            {
                Console.WriteLine();
                Console.WriteLine("===== LOJA DE PRODUTOS ALIMENTARES =====");
                Console.WriteLine("1 - Registar cliente");
                Console.WriteLine("2 - Ver fila de atendimento");
                Console.WriteLine("3 - Atender proximo cliente");
                Console.WriteLine("0 - Sair");
                Console.Write("Opcao: ");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Cliente novo = RegistarCliente();
                    atendimento.Adicionar(novo);
                    Console.WriteLine("Cliente registado.");
                 
                }
                else if (opcao == 2)
                {
                    atendimento.MostrarFila();
                }
                else if (opcao == 3)
                {
                    atendimento.AtenderProximo();
                }
                else if (opcao == 0)
                {
                    Console.WriteLine("Fim do programa.");
                }
                else
                {
                    Console.WriteLine("Opcao invalida.");
                }
            }
            Console.ReadKey();
        }
    }
}