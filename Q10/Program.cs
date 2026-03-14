using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    public class Program
    {
        static void Main(string[] args)
        {
            //n=5  -> 1+1/2+1/3+1/4+1/5

            int n;
            double sum = 0;

            Console.Write("Enter n:");
            n=int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                //sum = sum + 1 / (double)i;
                //OR 
                sum += 1.0 / i;
            }

            Console.WriteLine("SUM:"+sum);

            Console.ReadKey();
        }
    }
}
