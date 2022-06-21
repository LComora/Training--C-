using System;
using static System.Console;
using System.Collections.Generic;

namespace Fibonacci
{
    internal class Program
    {
        static int Main(string[] args)
        {


            int[] fib = new int[4];
            fib[0] = 0;
            fib[1] = 1;
            fib[2] = 0;
            fib[3] = 0;

            WriteLine("Informe o número: ");
            int num = int.Parse(ReadLine());
            fib[3] = num;
            for (int i = 0; i < fib[3]; i++)
            {
                fib[2] = fib[0] + fib[1];
                if (fib[2] == fib[3])
                {
                    WriteLine($"O número {fib[3]} pertence a sequência de Fibonacci!");
                    return 0;
                }
                fib[0] = fib[1];
                fib[1] = fib[2];
            }
            WriteLine($"O número {fib[3]} não pertence a sequência de Fibonacci.");
            return 0;

        }
    }
}
