using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LalaDog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variável para opções do menu
            int opcao = 0;
            bool imprimeLogo = true;

            // Laço de repetição principal
            while (opcao != 9)
            {
                if (imprimeLogo)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("===============================================");
                    Console.WriteLine("|                                             |");
                    Console.WriteLine("|                                             |");
                    Console.WriteLine("|              PET SHOP LALADOG               |");
                    Console.WriteLine("|                                             |");
                    Console.WriteLine("|                                             |");
                    Console.WriteLine("===============================================");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                // Selecionou uma opção que não existe
                int[] opcoes = {1, 2, 3, 9};
                if (!opcoes.Contains(opcao))
                {
                    opcao = 0;
                }

                // 1 - Calculo de medicação
                if (opcao == 1)
                {
                    Console.WriteLine("-------CALCULO DE MEDICACAO------");
                    Console.ReadKey();
                }

                // 2 - Calculo de custo do banho
                if (opcao == 2)
                {
                    Console.WriteLine("----------CUSTO DE BANHO---------");
                    Console.ReadKey();
                }

                // 3 - Calculo alimentação
                if (opcao == 3)
                {
                    Console.WriteLine("-------CALCULO DE ALIMENTAÇÃO------");
                    Console.ReadKey();
                }

                // Mostra o menu de opções
                if (opcao == 0)
                {
                    Console.WriteLine("----------------MENU----------------");
                    Console.WriteLine("1 - Calculo de medicação");
                    Console.WriteLine("2 - Calculo de custo do banho");
                    Console.WriteLine("3 - Calculo de alimentação");
                    Console.WriteLine("9 - Sair");

                    // Se não conseguir converter define como 0
                    if (!int.TryParse(Console.ReadLine(), out opcao))
                        opcao = 0;

                    Console.Clear();
                }
            }

        }
    }
}
