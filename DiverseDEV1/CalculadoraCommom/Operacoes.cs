using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public static class Operacoes
    {
        public static float somar(float n1, float n2)
        {
            return n1 + n2;
        }

        public static float subtrair(float n1, float n2)
        {
            return (n1 - n2);
        }

        public static float multiplicar(float n1, float n2)
        {
            return (n1 * n2);
        }

        public static float dividir(float n1, float n2)
        {
            if (n2 != 0)
            {
                return (n1 / n2);
            }
            else
            {
                throw new ArithmeticException("Não é possível fazer divisão por zero.");
            }
        }
    }
}
