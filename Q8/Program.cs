using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n;//عدد اللاعبين
            int goals;
            int max=int.MinValue;
            int theBestPlayer = 0;

            Console.Write("Enter the number of players:");
            n=int.Parse(Console.ReadLine());

            for(int i=1;i<=n;i++)
            {
                Console.WriteLine("Enter goals for player "+i+":");
                goals = int.Parse(Console.ReadLine());  

                if(goals>max)
                {
                    max = goals;
                    theBestPlayer = i;
                }
            }
            Console.WriteLine("The best player is:"+theBestPlayer);

            Console.ReadKey();
        }
    }
}
