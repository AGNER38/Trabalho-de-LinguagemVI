using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProjectoFaturacao
{
    class Fatura
    {
        public double Bonus;
        public double TotalPagar;
        // bonus de 10% so se as compras forem acima de 100000
        public void Calcular(Cliente c)
        {
            if (c.ValorCompras > 100000)
            {
                Bonus = c.ValorCompras * 0.10;
            }
            else
            {
                Bonus = 0;
            }
            TotalPagar = c.ValorCompras - Bonus;
        }
        public void Mostrar(Cliente c)
        {
            Console.WriteLine("----- FATURA -----");
            Console.WriteLine("Cliente: " + c.Nome);
            Console.WriteLine("Genero: " + c.Genero);
            Console.WriteLine("Compras: " + c.ValorCompras + " Kz");
            Console.WriteLine("Bonus: " + Bonus + " Kz");
            Console.WriteLine("Total a pagar: " + TotalPagar + " Kz");
            if (c.TemPrioridade() == true)
            {
                Console.WriteLine("Atendimento: prioritario");
            }
            else
            {
                Console.WriteLine("Atendimento: normal");
            }
            Console.WriteLine("------------------");
        }
    }
}