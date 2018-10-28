using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtracaoDeDiamantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> pilha = new Stack<char>();
            int n;
            int totalDeDiamantes = 0;
            Console.Write("Digite a quantidade de casos de teste: ");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out n))
            {
                while(n > 0)
                {
                    entrada = Console.ReadLine();
                    foreach (char c in entrada)
                    {
                        switch (c)
                        {
                            case '<':
                                pilha.Push(c);
                                break;
                            case '.':
                                break;
                            case '>':
                                if(pilha.Count > 0)
                                {
                                    pilha.Pop();
                                    totalDeDiamantes++;
                                }
                                break;
                            default:
                                Console.WriteLine("Caractere invalido!");
                                break;
                        }
                    }
                    Console.WriteLine(totalDeDiamantes);
                    n--;
                    pilha.Clear();
                    totalDeDiamantes = 0;
                }
            }
            else
            {
                Console.WriteLine("Valor inserido não é válido!");
            }
            Console.WriteLine("Fim de execução! Pressione uma tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
