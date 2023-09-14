using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the for Loop");
            for (int i= 0; i<5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("This is the While Loop");
            int j = 0;

            while (j <= 5)
            {
                Console.WriteLine(j);
                j++;

            }
            Console.Read();



        }
    }
}
