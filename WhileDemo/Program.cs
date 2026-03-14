using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDemo
{
    public class Program
    {
        static void Main(string[] args)
        {

            //for(int i=1;i<=10;i++)
            //    Console.Write('*');

            int i = 1;

            while (i<=10)
            {
                Console.Write('*');
                i++;
            }



            //------2-----//

            int j = 1;
            while (j == 10)
            {
                Console.WriteLine(j);

            }

            Console.WriteLine("End Program");

            Console.ReadKey();
        }
    }
}
