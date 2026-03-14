using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    public class Program
    {
        static void Main(string[] args)
        {
            double time, max, longest, min, shortest;
            //1-100 

            Console.Write("Enter duration for song number 1:");
            time = double.Parse(Console.ReadLine());//بالدقائق

            max = time;
            longest = 1;
            min = time;
            shortest = 1;


            for (int i = 2; i <= 10; i++)
            {
                Console.Write("Enter duration for song number "+i+":");
                time = double.Parse(Console.ReadLine());//بالدقائق

                if (time > max)
                {
                    max = time;
                    longest = i;
                }

                if (time < min)
                {
                    min = time;
                    shortest = i;
                }

            }

            Console.WriteLine("Longest song number is:"+longest);
            Console.WriteLine("Shortest song number is:" + shortest);


            Console.ReadKey();
        }
    }
}

