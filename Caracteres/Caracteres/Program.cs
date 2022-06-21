using System;
using System.Diagnostics;
using System.Linq;
using static System.Console;

namespace Caracteres
{
    internal class Program
    {
        public static string TrocaPalavra(string x)
        {
            char[] charArray = x.ToCharArray();
            string troca = String.Empty;
            for(int i = charArray.Length - 1; i >= 0; i--)
            {
                troca += charArray[i];
            }
            return troca;
        }
        static void Main(string[] args)
        {
            WriteLine("Digite a palavra a ser invertida: ");
            string original = ReadLine();
            string trocada = TrocaPalavra(original);
            WriteLine($"Palavra digitada: {original}");
            WriteLine($"Palavra invertida: {trocada}");
        }
    }
}
