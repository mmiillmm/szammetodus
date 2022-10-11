using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamolas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3 + 4 = {Szamol(3, 4, '+')} ");

            Console.ReadKey();


        }

        static int Szamol(int x, int y, char op)
        {
            int eredmeny = 0;

            switch (op)
            {
                case '+':
                    eredmeny = x + y;
                    break;
            }

            return eredmeny;
        }
    }
}
