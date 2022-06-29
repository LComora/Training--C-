using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;




namespace Faturamento2
{
    class Program
    {
        static void Main(string[] args)

        {
            var listaDados = new List<Dados>()
            {
                new Dados() {dia = 1, valor = 22174.1664},
                new Dados() {dia = 2, valor = 21537.6698},
                new Dados() {dia = 3, valor = 26139.6134},
                new Dados() {dia = 4, valor = 0.0},
                new Dados() {dia = 5, valor = 0.0},
                new Dados() {dia = 6, valor = 26742.6612},
                new Dados() {dia = 7, valor = 0.0},
                new Dados() {dia = 8, valor = 42889.2258},
                new Dados() {dia = 9, valor = 46251.174},
                new Dados() {dia = 10, valor = 11191.4722},
                new Dados() {dia = 11, valor = 0.0},
                new Dados() {dia = 12, valor = 0.0},
                new Dados() {dia = 13, valor = 3847.4823},
                new Dados() {dia = 14, valor = 373.7838},
                new Dados() {dia = 15, valor = 2659.7563},
                new Dados() {dia = 16, valor = 48924.2448},
                new Dados() {dia = 17, valor = 18419.2614},
                new Dados() {dia = 18, valor = 0.0},
                new Dados() {dia = 19, valor = 0.0},
                new Dados() {dia = 20, valor = 35240.1826},
                new Dados() {dia = 21, valor = 43829.1667},
                new Dados() {dia = 22, valor = 18235.6852},
                new Dados() {dia = 23, valor = 4355.0662},
                new Dados() {dia = 24, valor = 13327.1025},
                new Dados() {dia = 25, valor = 0.0},
                new Dados() {dia = 26, valor = 0.0},
                new Dados() {dia = 27, valor = 25681.8318},
                new Dados() {dia = 28, valor = 1718.1221},
                new Dados() {dia = 29, valor = 13220.495},
                new Dados() {dia = 30, valor = 8414.61},
            };
            //soma total de tudo = 435.172,7735

            
            //Importante colocar igual a zero pq os valores das somas anteriores podem ser acumulados na variável. 
            
            Dados dadosMenorValor = new Dados();
            Dados dadosMaiorValor = new Dados();
            int qtdItens = listaDados.Count;
            MetodosAux metodos = new MetodosAux();
            double dadosSOMA = metodos.calcularSoma(listaDados, qtdItens);
            double mediaValor = metodos.realizarMedia(dadosSOMA, qtdItens);


            Console.WriteLine($"O menor valor é {metodos.calcularMenorValor(listaDados, qtdItens).ToString("F2")} que é do dia {metodos.calcularMenorDia(listaDados, qtdItens)}.");
            Console.WriteLine($"O maior valor é {metodos.calcularMaiorValor(listaDados, qtdItens).ToString("F2")} que é do dia {metodos.calcularMaiorDia(listaDados, qtdItens)}.");
            Console.WriteLine($"A quantidade de itens é igual a {qtdItens}.");
            Console.WriteLine($"A soma dos valores é igual {dadosSOMA.ToString("F2")}.");
            Console.WriteLine($"A media total é igual {mediaValor.ToString("F2")}.");
            Console.WriteLine($"O número de dias no mês com faturamento superior a média mensal foi de {metodos.mediaSuperior(mediaValor, listaDados, qtdItens)}.");
            Console.WriteLine($"O número de dias no mês com faturamento inferior a média mensal foi de {metodos.mediaInferior(mediaValor, listaDados, qtdItens)}.");
        }
    }
}
