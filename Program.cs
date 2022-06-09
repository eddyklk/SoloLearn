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
            double totalprice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Discount(totalprice));
           

        }

        static double Discount(double monto)
        {
            if (monto >= 10000)
            {
               monto = monto - (0.2 * monto);
               //return monto;
            }
            return monto;

           
        }
    }
}

