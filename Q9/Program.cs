using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    public class Program
    {
        static void Main(string[] args)
        {
            //n!=1*2*3..*n
            //5! -> 1*2*3*4*5
            //4! -> 1*2*3*4
            int n;
            int mult = 1;
            Console.Write("Enter n:");
            n=int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                mult = mult * i;
            }

            Console.WriteLine("The factorial is:"+mult);





            Console.ReadKey();
        }
    }
}
