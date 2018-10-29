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
            Console.WriteLine("Digite o caminho para o arquivo de entrada");
            string arquivo = Console.ReadLine();
            if (File.Exists(arquivo))
            {
                int codigo;
                int qtde;
                double total = 0;
                string resultado = "";

                Stream entrada = File.Open("entrada.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();
                string[] items = linha.Split(' ');

                qtde = Int32.Parse(items[1]);
                codigo = Int32.Parse(items[0]);

                switch (codigo)
                {
                    case 1:
                        total = 3 * qtde;
                        resultado = String.Format("Total: R$ {0:0.00}", total);
                        break;
                    case 2:
                        total = 2.5 * qtde;
                        resultado = String.Format("Total: R$ {0:0.00}", total);
                        break;
                    case 3:
                        total = 5 * qtde;
                        resultado = String.Format("Total: R$ {0:0.00}", total);
                        break;
                    case 4:
                        total = 4.5 * qtde;
                        resultado = String.Format("Total: R$ {0:0.00}", total);
                        break;
                    case 5:
                        total = 1.5 * qtde;
                        resultado = String.Format("Total: R$ {0:0.00}", total);
                        break;
                    default:
                        resultado = "Erro! Item de código " + entrada + " não registrado!";
                        break;
                }
                leitor.Close();
                entrada.Close();

                Console.WriteLine(resultado);

                Stream saida = File.Open("saida.txt", FileMode.Create);
                StreamWriter writer = new StreamWriter(saida);
                writer.WriteLine(resultado);
                writer.Close();
                saida.Close();
                Console.WriteLine("Arquivo de saída criado em: {0}", Path.GetFullPath("saida.txt"));
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
