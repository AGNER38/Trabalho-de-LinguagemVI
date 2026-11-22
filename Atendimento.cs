using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProjectoFaturacao
{
    class Atendimento
    {    
        List<Cliente> prioritarios = new List<Cliente>();
        List<Cliente> normais = new List<Cliente>();
        public void Adicionar(Cliente c)
        {
            if (c.TemPrioridade() == true)
            {
                prioritarios.Add(c);
            }
            else
            {
                normais.Add(c);
            }
        }
        public void MostrarFila()
        {
            if (prioritarios.Count == 0 && normais.Count == 0)
            {
                Console.WriteLine("A fila esta vazia.");
                return;
            }
            int posicao = 1;
            foreach (Cliente c in prioritarios)
            {
                Console.WriteLine(posicao + " - " + c.Nome + " (prioritario)");
                posicao++;
            }
            foreach (Cliente c in normais)
            {
                Console.WriteLine(posicao + " - " + c.Nome);
                posicao++;
            }
        }
        public void AtenderProximo()
        {
            Cliente atual = null;
            if (prioritarios.Count > 0)
            {
                atual = prioritarios[0];
                prioritarios.RemoveAt(0);
            }
            else if (normais.Count > 0)
            {
                atual = normais[0];
                normais.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("NÃO HÁ  CLIENTES NA FILA!!!.");
                return;
            }
            Console.WriteLine(" A SEGUIR: " + atual.Nome);
            Fatura f = new Fatura();
            f.Calcular(atual);
            f.Mostrar(atual);
        }
    }
}