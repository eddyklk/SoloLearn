using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        
        static void Main(string[] args)
        {




            string dia1, mes1, ano1, dia2, mes2, ano2 = "";
            double conv_dia1, conv_mes1, conv_ano1, conv_dia2, conv_mes2, conv_ano2, dif_dia, dif_mes, dif_ano, res, anoact, reshora, resmin = 0;
            Console.WriteLine("Bienvenido al sistema de calculo de edad.");
            Console.ReadKey();
            Console.WriteLine("Escriba la fecha de inicio");
            Console.WriteLine("Escriba el dia : ");
            dia1 = Console.ReadLine();
            Console.WriteLine("Escriba el mes: ");
            mes1 = Console.ReadLine();
            Console.WriteLine("Escriba el año: ");
            ano1 = Console.ReadLine();


            Console.WriteLine("Ahora la fecha final");
            Console.WriteLine("Escriba el dias : ");
            dia2 = Console.ReadLine();
            Console.WriteLine("Escriba el mes: ");
            mes2 = Console.ReadLine();
            Console.WriteLine("Escriba el año: ");
            ano2 = Console.ReadLine();


            conv_dia1 = Convert.ToDouble(dia1);
            conv_dia2 = Convert.ToDouble(dia2);
            conv_mes1 = Convert.ToDouble(mes1);
            conv_mes2 = Convert.ToDouble(mes2);
            conv_ano1 = Convert.ToDouble(ano1);
            conv_ano2 = Convert.ToDouble(ano2);


            dif_dia = conv_dia1 - conv_dia2;
            dif_mes = conv_mes1 - conv_mes2;
            dif_ano = conv_ano1 - conv_ano2;

            res = dif_dia + (dif_mes * 30.627) + (dif_ano * 365.25);
            res = -(res);
            anoact = res / 365.25;

            reshora = res * 24;
            resmin = reshora * 60;


            Console.WriteLine("\n");
            //se redondeo el monto a 3 decimales para que no salgan tanto numero mostrando la edad, tampoco a menos de 3 por que se redondeaba dias antes de cumplirse el cumple. 
            Console.WriteLine("Actualmente tienes " + Math.Round(anoact, 3) + " años de edad y han transcurrido al rededor de " + Math.Round(res) + " dias " + Math.Round(reshora) + " horas y " + Math.Round(resmin) + " minutos. ");

            Console.WriteLine("");

            Console.WriteLine("Nota");
            if (anoact >= 20 && anoact <= 25)
            {
                Console.WriteLine("A esta edad experimentas muchas cosas nuevas como podrian ser: Graduaciones, nuevo trabajos y la oportunidad iniciar un proyecto personal que de ti dependeras que tanto zeros a la izquierdad tendra tu cuenta de banco. ");
            }
            else if (anoact >= 26 && anoact <= 29)
            {
                Console.WriteLine("A esta edad si no estas casad@ y no tienes novi@, sientes que te ha cogido lo tarde para todo, pero no te desesperes, cuando haz visto que las frutas se comen antes de tiempo.");
            }
            else if (anoact >= 30)
                Console.WriteLine("Ya a esta edad deberias de estar ejercido y con una familia por quien hechar adelante, de no ser asi vamos que nunca es tarde. ");
            else
            {
                Console.WriteLine("Tienes un futuro por delante, a darle con animo.");
            }

            Console.ReadKey();
            Console.WriteLine("\nDesde que naciste hasta el proximo siglo tu edad se reflejará de la siguiente manera.");

            //imprime las estadistica de tu edad de un siglo.
            double limitano = conv_ano1 + 100;
            double edad = 0;

            for (conv_ano1 = 1993; conv_ano1 <= limitano; conv_ano1++)
            {

                Console.WriteLine(conv_ano1 + " = " + edad++);

            }



            Console.ReadKey();




        }
    }
}
