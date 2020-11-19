using System;
using System.Globalization;

namespace Exercício_individual___Tema_Conversor_de_moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é cotação do dólar? "); // Entrada do usuário para a cotação do dólar
            conversor.cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares irão ser comprados. "); // Entrada do usuário para a quantidade em dólar a ser comprada
            conversor.valor = double.Parse(Console.ReadLine());

            Console.Write("Valor em reais: " + conversor.Reais().ToString("F2", CultureInfo.InvariantCulture)); // Escrever valor em reais que ele ira pagar
            //Digitar decimais com virgula, NÃO ponto.

            Console.ReadKey();
        }
    }
}
