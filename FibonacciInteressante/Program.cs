using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciInteressante
{
    class Program
    {
        //Armazena em uma coleção chave-valor os valores de fibonacci já calculados
        public static Dictionary<int, int> fibonaccisCalculados = new Dictionary<int, int>();

        static void Main(string[] args)
        {
            fibonaccisCalculados.Add(0, 0);
            fibonaccisCalculados.Add(1, 1);

            Console.Write("Digite o Número desejado: ");
            string entrada = Console.ReadLine();
            int n;
            if (int.TryParse(entrada, out n))
            {
                if(n >= 0)
                {
                    Console.WriteLine(Fibonacci(n));
                }
            }
            else
            {
                Console.WriteLine("Valor inserido não é válido!");
            }
            Console.WriteLine("Fim de execução! Pressione uma tecla para finalizar...");
            Console.ReadKey();
        }

        public static int Fibonacci(int n)
        {
            // Retorna o valor do fibonacci caso esteja presente na coleção chave-valor fibonaccisCalculados
            // Caso não esteja presente, busca recursivamente o resultado do fibonacci desejado e o armazena na coleção, retornando em seguida seu valor
            if (fibonaccisCalculados.ContainsKey(n))
            {
                return fibonaccisCalculados[n];
            }
            else
            {
                fibonaccisCalculados.Add(n, Fibonacci(n - 2) + Fibonacci(n - 1));
                return fibonaccisCalculados[n];
            }
        }
    }
}
