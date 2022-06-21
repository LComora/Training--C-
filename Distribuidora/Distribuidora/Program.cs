using System;


namespace Distribuidora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sp = 67836.43;
            double rj = 36678.66;
            double mg = 29229.88;
            double es = 27165.48;
            double outros = 19849.53;

            double total = (sp+rj+mg+es+outros);
            //Console.WriteLine(total);

            double porcSP = ((sp / total) * 100);
            double porcRj = ((rj / total) * 100);
            double porcMG = ((mg / total) * 100);
            double porcES = ((es / total) * 100);
            double porcOut = ((outros / total) * 100);

            Console.WriteLine("A porcentagem de SP é de " + porcSP.ToString("F2") + ".");
            Console.WriteLine("A porcentagem do RJ é de " + porcRj.ToString("F2") + ".");
            Console.WriteLine("A porcentagem de MG é de " + porcMG.ToString("F2") + ".");
            Console.WriteLine("A porcentagem do ES é de " + porcES.ToString("F2") + ".");
            Console.WriteLine("A porcentagem de outros estados é de " + porcOut.ToString("F2") + ".");
        }
    }
}
