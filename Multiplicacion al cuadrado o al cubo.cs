using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    internal class Multiplicacion_al_cuadrado_o_al_cubo
    {
        static int Pow(int x, int y = 3)
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }
        static void main(string[] args)
        {
            Console.WriteLine(Pow(5));
            // Despues de la coma se 5 hace la referencia del numero que se multiplicara asi mismo y 3 las veces que lo hará.
            Console.WriteLine(Pow(5, 3));
        }
    }
}
