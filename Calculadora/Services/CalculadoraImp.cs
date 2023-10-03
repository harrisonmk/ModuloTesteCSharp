using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int somar(int x, int y)
        {
            return x + y;
        }

        public bool EhPar(int x)
        {
            return x % 2 == 0;
        }
    }
}
