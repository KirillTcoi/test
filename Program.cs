using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            int g = 0;
            int[] Mass = new int[10] { 1, 0, 1, 1, 1, 1, 1, 0, 0, 1 };
            for (int i = 1; i < 10; i++)
            {
                if (Mass[i] == Mass[i-1])
                {
                    g++;
                }
            }
            Console.WriteLine(g);
            Console.ReadKey();
        }
    }
}
