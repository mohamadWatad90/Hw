using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    public class Program
    {
        static void Main(string[] args)
        {
            //2-n (لا يشمل n)

            int n;
            Console.Write("Enter n:");
            n=int.Parse(Console.ReadLine());

            for(int i=2; i<n; i++)
            {
                if(i%2==0)//اذا كان العدد زوجي
                   //Console.Write(i + " ");
                    Console.Write("{0,3}",i);
                
            }

            Console.ReadKey();
        }
    }
}
