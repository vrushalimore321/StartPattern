using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startpattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 6;
            for (int i = 1; i <= row; i++)
            {
               for(int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
               Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
