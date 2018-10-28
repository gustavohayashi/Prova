using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchinho
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("entrada.txt"))
            {
                int codigo;
                int qtde;
                double total = 0;

                Stream entrada = File.Open("entrada.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    string[] items = linha.Split(' ');
                    qtde = Int32.Parse(items[1]);
                    codigo = Int32.Parse(items[0]);
                    switch (codigo)
                    {
                        case 1:
                            total = 3 * qtde;
                            break;
                        case 2:
                            total = 2.5 * qtde;
                            break;
                        case 3:
                            total = 5 * qtde;
                            break;
                        case 4:
                            total = 4.5 * qtde;
                            break;
                        case 5:
                            total = 1.5 * qtde;
                            break;
                        default:
                            Console.WriteLine("Erro! Item de código " + entrada + " não registrado!");
                            break;
                    }
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();

                //Console.WriteLine("Total: R$ {0:0.00}", total);

                Stream saida = File.Open("saida.txt", FileMode.Create);
                StreamWriter writer = new StreamWriter(saida);
                writer.WriteLine("Total: R$ {0:0.00}", total);
                writer.Close();
                saida.Close();
            }
            Console.WriteLine("Fim de Execução.");
            Console.ReadLine();
        }
    }
}
