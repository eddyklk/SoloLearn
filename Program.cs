using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPrice = Convert.ToInt32(Console.ReadLine());

            Discount(totalPrice);


        }
        //complete the method declaration
        static double Discount(double x)
        {
            if (x >= 1000 )
            {
                double a = 0;

                a = 20.0f / 100;
                x = x - (a/x) ;
                return x;
            }

        }
    }
}
