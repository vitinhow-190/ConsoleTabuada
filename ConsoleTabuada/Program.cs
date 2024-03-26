using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a Tabuada que deseja saber: ");
            int tbd = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Digite o numero de vezes: ");
            int vzs = int.Parse(Console.ReadLine());
            
            int cont = 1;

            while (cont <= vzs)
            {
                int res = tbd * cont;
               
                Console.WriteLine(tbd + "x" + cont + "=" + res);
               
                cont++;
            }
          
            Console.ReadKey();
        }
    }
}
