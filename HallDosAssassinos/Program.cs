using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallDosAssassinos
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("entrada.txt"))
            {

                SortedList assassinos = new SortedList(); //Lista contendo assassinos
                ArrayList assassinados = new ArrayList(); //Lista contendo assassinados

                Stream entrada = File.Open("entrada.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();

                while (linha != null)
                {
                    string[] nomes = linha.Split(' ');
                    
                    //Armazena o assassino na lista de assassinos se for a primeira morte realizada por ele
                    //Caso contrário apenas se atualiza seu número de assassinatos cometidos
                    if (assassinos.ContainsKey(nomes[0])) 
                    {
                        assassinos[nomes[0]] = (int)assassinos[nomes[0]] + 1;
                    }
                    else
                    {
                        assassinos.Add(nomes[0], 1);
                    }

                    //Adiciona quem tiver sido morto na lista de assassinados caso seu nome não esteja na lista
                    if (!assassinados.Contains(nomes[1]))
                    {
                        assassinados.Add(nomes[1]);
                    }

                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();

                //É retirado da lista de assassinos aqueles que tiverem sido assassinados por alguém
                foreach (string assassinado in assassinados)
                {
                    if (assassinos.ContainsKey(assassinado))
                    {
                        assassinos.Remove(assassinado);
                    }
                }

                Stream saida = File.Open("saida.txt", FileMode.Create);
                StreamWriter writer = new StreamWriter(saida);
                writer.WriteLine("HALL DOS ASSASSINOS");

                //É escrito no arquivo de saída o nome do assassino e o número de mortes causadas por ele
                foreach (DictionaryEntry assassino in assassinos)
                {
                    writer.WriteLine("{0} {1}", assassino.Key.ToString(), assassino.Value.ToString());
                }
                writer.Close();
                saida.Close();
                Console.WriteLine("Fim de Execução.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Arquivo de leitura \"entrada.exe\" não encontrado!");
                Console.WriteLine("Fim de Execução.");
                Console.ReadLine();
            }
        }
    }

}
