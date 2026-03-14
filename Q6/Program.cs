using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    public class Program
    {
        static void Main(string[] args)
        {

            int n;//عدد الحسابات في البنك
            double balance, max;

            Console.Write("Enter the number of accounts:");
            n=int.Parse(Console.ReadLine());

            Console.Write("Enter balance:");
            balance = double.Parse(Console.ReadLine());

            max = balance;


            for(int i=2;i<=n;i++)
            {
                Console.Write("Enter balance:");
                balance =double.Parse(Console.ReadLine());

                if (balance > max)
                    max = balance;
            }

            Console.WriteLine("The max balance:"+max.ToString("f2"));



            Console.ReadKey();
        }
    }
}
