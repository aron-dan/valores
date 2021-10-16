using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {

            /*string[] mouths = new string[] { "empt", "january", "february", "march", "april", "may",
                "june", "july", "august", "september", "october", "november", "december"};

            Console.WriteLine(mouths[number]);*/
            
            //variaveis
            int valores;
            
            //entrada

            Console.WriteLine("Digite os numeros");
            valores = int.Parse(Console.ReadLine());

            //processamento
            if ( valores % 2 == 0)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine(valores + 1);
                Console.WriteLine(valores + 3);
                Console.WriteLine(valores + 5);
                Console.WriteLine(valores + 7);
                Console.ReadKey();

            }

            else
            {
                Console.WriteLine(valores);
                Console.WriteLine(valores + 2);
                Console.WriteLine(valores + 4);
                Console.WriteLine(valores + 6);
                Console.ReadKey();

            }

            //saida
        }
    }
}
