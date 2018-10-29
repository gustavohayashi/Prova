using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenioDeAdivinhacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o caminho para o arquivo de entrada");
            string arquivo = Console.ReadLine();
            if (File.Exists(arquivo))
            {
                bool isQueue = true;
                bool isStack = true;
                bool isPriorityQueue = true;

                Queue<int> queue = new Queue<int>();
                List<int> priorityQueue = new List<int>();
                Stack<int> stack = new Stack<int>();

                Stream entrada = File.Open(arquivo, FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();

                while (linha != null)
                {
                    for (int n = Int32.Parse(linha); n > 0; n--)
                    {
                        linha = leitor.ReadLine();

                        string[] leitura = linha.Split(' ');
                        int operacao = Int32.Parse(leitura[0]);
                        int valor = Int32.Parse(leitura[1]);
                        if (operacao == 1) //Operação de inserir valor na sacola
                        {
                            //Armazena o elemento recebido
                            queue.Enqueue(valor);
                            priorityQueue.Add(valor);
                            priorityQueue.Sort();
                            stack.Push(valor);
                        }
                        else //Operação de remover valor da sacola
                        {
                            //Caso ocorra mais remoções de elementos do que inserções, a sequência será considerada impossível
                            if (queue.Count == 0 || priorityQueue.Count == 0 || stack.Count == 0)
                            {
                                isQueue = false;
                                isStack = false;
                                isPriorityQueue = false;
                            }

                            //Verifica se a operação de remoção se encaixa com as regras das estruturas de dados
                            //Não é realizado a verificação caso seja descartado a possibilidade de ser determinada estrutura de dados
                            if (isQueue)
                            {
                                isQueue = isQueue && (queue.Dequeue() == valor);
                            }
                            if (isPriorityQueue)
                            {
                                isPriorityQueue = isPriorityQueue && (priorityQueue[priorityQueue.Count - 1] == valor);
                                priorityQueue.RemoveAt(priorityQueue.Count - 1);
                            }
                            if (isStack)
                            {
                                isStack = isStack && (stack.Pop() == valor);
                            }
                        }

                    }

                    if (isStack || isPriorityQueue || isQueue)
                    {
                        //Caso haja mais de uma possibilidade de estrutura de dados utilizada
                        if ((isStack && isPriorityQueue) || (isStack && isQueue) || (isPriorityQueue && isQueue))
                        {
                            Console.WriteLine("not sure");
                        }
                        else if (isStack)
                        {
                            Console.WriteLine("stack");
                        }
                        else if (isPriorityQueue)
                        {
                            Console.WriteLine("priority queue");
                        }
                        else
                        {
                            Console.WriteLine("queue");
                        }

                    }
                    else
                    {
                        //Impossível ser qualquer uma das estruturas de dados
                        Console.WriteLine("impossible");
                    }

                    //Esvazia as listas/pilhas utilizadas e reinicializa as variáveis booleanas utilizadas
                    queue.Clear();
                    priorityQueue.Clear();
                    stack.Clear();
                    isQueue = true;
                    isStack = true;
                    isPriorityQueue = true;
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();
            }
            else
            {
                Console.WriteLine("Arquivo de leitura no endereço especificado \"{0}\" não encontrado!", arquivo);
            }
            Console.WriteLine("Fim de Execução.Pressione qualquer tecla para fechar o programa.");
            Console.ReadKey();
        }
    }
}
