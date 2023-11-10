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
                /*
                    Solicitar o peso do animal, informar a dosagem por kg do medicamento 
                    e ao final informar a dose correta.
                */

                if (opcao == 1)
                {
                    Console.WriteLine("-----------CALCULO DE MEDICACAO----------");

                    Console.WriteLine("Qual o peso do animal?");
                    decimal peso_animal = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Qual a dosagem por KG da medicação?");
                    decimal dosagem_kg = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine($"Para um animal de {peso_animal}kg e uma medicação de {dosagem_kg} \n");


                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"A dosagem correta é de {peso_animal * dosagem_kg}");
                    Console.ForegroundColor = ConsoleColor.White;

                    // Volta para o menu
                    opcao = 0;
                    Console.ReadKey();
                }

                // 2 - Calculo de custo do banho
                /*
                    Solicitar o porte do animal (pequeno, medio, grande)
                    Solicitar o adicional de extras (parasitas, shampoo, aparar)
                    
                    Preços:
                    Cada extra adiciona R$20
                    p - 80, m - 100, g - 120
                */

                if (opcao == 2)
                {
                    Console.WriteLine("-------------CUSTO DE BANHO------------");

                    Console.WriteLine("Qual o porte do animal (p, m, g)?");
                    string porte_animal = Console.ReadLine();

                    bool extraParasita = false;
                    bool extraShampoo = false;
                    bool extraAparar = false;
                    string opcoesExtras = "";

                    while (opcoesExtras != "4")
                    {
                        Console.WriteLine("Deseja adicionar algum extra?");
                        // Faz um TESTE TERNÁRIO para saber se um item está marcado 
                        Console.WriteLine($"[{ (extraParasita ? "X" : " ") }] 1 - Remoção de parasitas");
                        Console.WriteLine($"[{ (extraShampoo ? "X" : " ") }] 2 - Shampoo Importado");
                        Console.WriteLine($"[{ (extraAparar ? "X" : " ") }] 3 - Aparar de pelos");
                        Console.WriteLine($"4 - Sair");

                        opcoesExtras = Console.ReadLine();

                        if (opcoesExtras == "1") extraParasita = !extraParasita;
                        if (opcoesExtras == "2") extraShampoo = !extraShampoo;
                        if (opcoesExtras == "3") extraAparar = !extraAparar;

                        Console.Clear();
                    }

                    decimal total = 0;

                    // Soma o valor do banho de acordo com o porte
                    if (porte_animal == "p") total = 80;
                    else if (porte_animal == "m") total = 100;
                    else if (porte_animal == "g") total = 120;

                    // Verifica se adicionou os extras e soma ao total
                    total += extraParasita ? 20 : 0;
                    total += extraShampoo ? 20 : 0;
                    total += extraAparar ? 20 : 0;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"O valor total do banho é de: {total}");
                    Console.ForegroundColor = ConsoleColor.White;

                    opcao = 0;
                    Console.ReadKey();
                }

                // 3 - Calculo alimentação
                /*
                    Pergunta quantos pets existem no petshop, quantos kg de ração
                    a quantidade de dias para verificar a ração.
                    Cada pet consome 100g por dia.

                    Ao final mostrar se precisa ou não comprar mais ração.
                */
                if (opcao == 3)
                {
                    Console.WriteLine("----------CALCULO DE ALIMENTAÇÃO---------");

                    Console.WriteLine("Quantos animais estão no petshop?");
                    int quantidade_animais = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Qual a quantidade de alimento está disponível (em kg)?");
                    decimal alimento_disponivel = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Qual a quantidade de dias deseja verificar?");
                    int quantidade_dias = Convert.ToInt32(Console.ReadLine());

                    // Calculo em gramas do consumo de alimento no periodo
                    decimal consumo_total = quantidade_animais * quantidade_dias * 100m;

                    // Converte a quantidade de alimentos para gramas
                    alimento_disponivel *= 1000;

                    
                    if (consumo_total > alimento_disponivel)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Não existe alimento suficiente.");
                        Console.WriteLine($"Faltariam {consumo_total - alimento_disponivel}g ou {(consumo_total - alimento_disponivel) / 1000}kg");
                    }
                    else if (consumo_total < alimento_disponivel)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Os alimentos são suficientes.");
                        Console.WriteLine($"Sobram {alimento_disponivel - consumo_total}g");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("A quantidade de alimento é exatamente a necessária ao consumo.");
                        Console.WriteLine("Favor comprar mais.");
                    }

                    opcao = 0;
                    Console.ReadKey();
                }

                // Mostra o menu de opções
                if (opcao == 0)
                {
                    Console.WriteLine("-------------------MENU-------------------");
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
