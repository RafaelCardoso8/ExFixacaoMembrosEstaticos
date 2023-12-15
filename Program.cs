using System;
using System.Globalization;

namespace ExFixaçãoMembrosEstaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cotação, quantia;
            Console.WriteLine("Olá. Vamos te ajudar a converter o dolar. É só seguir as instruções.");
            Console.WriteLine();

            Console.WriteLine("Qual é a cotação do dólar?");
            Console.Write("Real brasileiro: R$ ");
            cotação = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar?");
            Console.Write("$ ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double result = ConversorDeMoeda.DolarParaReal(quantia, cotação);
            Console.WriteLine("Valor a ser pago em reais = R$ " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}