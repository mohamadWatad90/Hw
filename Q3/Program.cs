using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {

            //10-50 يشمل بما في ذلك 10 و50
            Random rnd = new Random();
            int n,num;
            int countEven = 0, sumOdd = 0;

            Console.Write("Enter n:");
            n = int.Parse(Console.ReadLine());

            //(High-Low+1)+Low;
            for(int i=1;i<=n;i++)
            {
                //num = rnd.Next(41) + 10;
                num = rnd.Next(10, 51);//10-50
                Console.WriteLine("number:"+num);

                if (num % 2 == 0)
                    countEven++;
                else
                    sumOdd += num;//sumOdd=sumOdd+num;
            }

            Console.WriteLine("The number of even numbers is:"+countEven);
            Console.WriteLine("The sum of odd numbers is:" + sumOdd);


            Console.ReadKey();
        }
    }
}
