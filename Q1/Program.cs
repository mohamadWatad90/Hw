using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sumInt = 0;
            double num, sumDouble=0;

            Console.Write("Enter n:");
            n = int.Parse(Console.ReadLine());

            for(int i=1;i<=n;i++)
            {
                Console.Write("Enter a real number:");
                num = double.Parse(Console.ReadLine());
                sumInt += (int)num;// sumInt=sumInt+(int)num;
                sumDouble += (num - (int)num);//sumDouble=sumDouble+(num-(int)num);
            }
            Console.WriteLine("The sum of integer numbers:"+sumInt);
            Console.WriteLine("The sum of double numbers:" + sumDouble);


            Console.ReadKey();


        }
    }
}
