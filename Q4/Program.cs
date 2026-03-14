using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            //n=5
            // 4,6,12,3,25
            int n, num, mult=1;

            Console.Write("Enter n:");
            n = int.Parse(Console.ReadLine());

            for(int i=1;i<=n;i++)
            {
                Console.WriteLine("Enter a number:");
                num = int.Parse(Console.ReadLine());

                if (num < 10)
                    mult = mult * num;
            }

            Console.WriteLine("Mult={0}",mult);

            Console.ReadKey();

        }
    }
}
