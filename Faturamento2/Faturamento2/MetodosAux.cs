using System;
using System.Collections.Generic;
using System.Text;

namespace Faturamento2
{
    public class MetodosAux
    {
        public MetodosAux() { }
        public double realizarMedia(double soma, int quantidade)
        {
            return soma / quantidade;
        }


        public double calcularMenorValor(List<Dados> lista, int quantidadeItens)//descobrir qual as variaveis de entrada
        {
            Dados menorValor = new Dados();
            for (int i = 0; i < quantidadeItens; i++)//descobrir como calcular menor valor. 
            {
                if (i == 0 && lista[i].valor != 0)
                {
                    menorValor = lista[i];
                }
                else
                {
                    if (lista[i].valor < menorValor.valor && lista[i].valor != 0)
                    {
                        menorValor = lista[i];
                    }
                }
            }
            return menorValor.valor;//descobrir o que retorna.
        }


        public double calcularMenorDia(List<Dados> lista, int quantidadeItens)
        {
            Dados menorValor = new Dados();

            for (int i = 0; i < quantidadeItens; i++)
            {
                if (i == 0 && lista[i].valor != 0)
                {
                    menorValor = lista[i];
                }
                else
                {
                    if (lista[i].valor < menorValor.valor && lista[i].valor != 0)
                    {
                        menorValor = lista[i];
                    }
                }
            }
            return menorValor.dia;
        }


        public double calcularMaiorValor(List<Dados> lista, int quantidadeItens) 
        {
            Dados maiorValor = new Dados();

            for (int i = 0; i < quantidadeItens; i++)
            {
                if (i == 0 && lista[i].valor != 0)
                {
                    maiorValor = lista[i];
                }
                else
                {
                    if (lista[i].valor > maiorValor.valor)
                    {
                        maiorValor = lista[i];
                    }
                }
            }
            return maiorValor.valor;
        }


        public double calcularMaiorDia(List<Dados> lista, int quantidadeItens)//descobrir qual as variaveis de entrada
        {
            Dados maiorValor = new Dados();

            for (int i = 0; i < quantidadeItens; i++)//descobrir como calcular menor valor. 
            {
                if (i == 0 && lista[i].valor != 0)
                {
                    maiorValor = lista[i];
                }
                else
                {
                    if (lista[i].valor > maiorValor.valor)
                    {
                        maiorValor = lista[i];
                    }
                }
            }
            return maiorValor.dia;//descobrir o que retorna.
        }


        public double calcularSoma(List<Dados> lista, int quantidadeItens)
        {
            double dadosSOMA = 0;
            for (int i = 0; i < quantidadeItens; i++)
            {
                dadosSOMA = dadosSOMA + lista[i].valor;
            }
            return dadosSOMA;
        }


        public int mediaSuperior(double media, List<Dados> lista, int quantidadeItens)//variaveis de entrada
        {//número de dias no mês em que o valor de faturamento foi superior e inferior a média mensal.

            int diasMaiorMedia = 0;

            for (int i = 0; i < quantidadeItens; i++)
            {
                if (lista[i].valor > media)
                {
                    diasMaiorMedia = diasMaiorMedia + 1;
                }
            }
            return diasMaiorMedia;
        }


        public int mediaInferior(double media, List<Dados> lista, int quantidadeItens)
        {
            int diasMenorMedia = 0;
            for (int i = 0; i < quantidadeItens; i++)
            {
                if (lista[i].valor < media && lista[i].valor != 0)
                {
                    diasMenorMedia = diasMenorMedia + 1;
                }
            }
            return diasMenorMedia;
        }
    }
}
      

