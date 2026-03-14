using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {


            int n, count = 0;
            char let;

            Console.Write("Enter n:");//عدد الأحرف التي علينا استقبالها
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter letter:");
                let = char.Parse(Console.ReadLine());

                if (let >= 'A' && let <= 'Z')
                    count++;
            }


            Console.WriteLine("The number of capital letters:" + count);


            Console.ReadKey();
        }
    }
}



