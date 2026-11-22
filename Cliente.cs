using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProjectoFaturacao
{
    class Cliente
    {
        public string Nome;
        public string Genero;
        public double ValorCompras;
        public bool Gravida;
        public bool Idoso;
        public bool Deficiente;
    
        public bool TemPrioridade()
        {
            if (Gravida == true || Idoso == true || Deficiente == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}