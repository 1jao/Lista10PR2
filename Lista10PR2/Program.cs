using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista10PR2
{
    internal class Program
    {
        public static void Exercicio1()
        {
            Console.Write("Qual o tamanho de seu vetor? ");
            int tam = int.Parse(Console.ReadLine());

            float[] num = new float[tam];

            for (int i = 0; i < tam; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                num[i] = float.Parse(Console.ReadLine());
            }

            float menor = num[0];

            float maior = num[0];

            float soma = num[0];

            for (int i = 1; i < tam; i++)
            {
                if (num[i] < menor)
                {
                    menor = num[i];
                }

                if (num[i] > maior)
                {

                    maior = num[i];

                }


                soma += num[i];
            }

            float media = soma / tam;

            Console.WriteLine($"Seu menor número é: {menor}");

            Console.WriteLine($"Seu maior número é: {maior}");

            Console.WriteLine($"A média aritmética é: {media}");
        }


        public static void Exercicio2()
        {
            int tam1;

            do
            {
                Console.Write("Qual o tamanho do vetor? (Obs: deve ser maior que zero!) ");
                tam1 = int.Parse(Console.ReadLine());

            } while (tam1 <= 0);

            float[] nume = new float[tam1];

            for (int i = 0; i < tam1; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                nume[i] = float.Parse(Console.ReadLine());
            }

            float soma = 0;

            for (int i = 0; i < tam1; i++)
            {
                soma += nume[i];
            }

            float media = soma / tam1;

            Console.WriteLine("Números maiores ou iguais à média:");

            for (int i = 0; i < tam1; i++)
            {
                if (nume[i] >= media)
                {
                    Console.WriteLine(nume[i]);
                }
            }
        }
        public static void Exercicio3()

        {
            int tam2;
            do
            {
                Console.Write("Qual o tamanho do vetor? (Obs: deve ser maior que zero!) ");
                tam2 = int.Parse(Console.ReadLine());


            } while (tam2 <= 0);

            float[] nume1 = new float[tam2];

            Random random = new Random();

            for (int i = 0; i < tam2; i++)
            {
                nume1[i] = (float)random.NextDouble();
            }

            float soma = 0;

            for (int i = 0; i < tam2; i++)
            {
                soma += nume1[i];
            }

            float media = soma / tam2;

            Console.WriteLine("Números maiores ou iguais à média:");

            for (int i = 0; i < tam2; i++)
            {
                if (nume1[i] >= media)
                {
                    Console.WriteLine(nume1[i]);
                }
            }
        }


        public static void Exercicio4()
        {
            int NAss;

            do
            {
                Console.Write("Digite o número de assinaturas: ");
                NAss = int.Parse(Console.ReadLine());


            } while (NAss <= 0);

            List<string> ass = new List<string>();

            for (int i = 0; i < NAss; i++)

            {
                Console.Write($"Digite o nome da assinatura {i + 1}: ");
                string nome = Console.ReadLine();
                ass.Add(nome);
            }

            Console.WriteLine("Assinaturas --- do último ao primeiro:");

            for (int i = ass.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(ass[i]);

            }
        }
        public static void Exercicio5()
        {

            int tam3;

            do
            {
                Console.Write("Qual o tamanho do vetor? (Obs: deve ser maior que zero!)");
                tam3 = int.Parse(Console.ReadLine());


            } while (tam3 <= 0);

            int[] vetor = new int[tam3];

            Random random = new Random();

            int pares = 0;
            int impares = 0;

            for (int i = 0; i < tam3; i++)

            {
                vetor[i] = random.Next(100); 

                if (vetor[i] % 2 == 0) 

                {
                    pares++;
                }
                else


                {
                    impares++;
                }
            }

            Console.WriteLine("Vetor produzido:");

            for (int i = 0; i < tam3; i++)
            {
                Console.Write(vetor[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine($"Quantidade de números pares: {pares}");
            Console.WriteLine($"Quantidade de números ímpares: {impares}");

        }
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("          menu           ");
                Console.WriteLine("para sair digite 0");
                Console.WriteLine("para executar o exercicio 1 - digite 1");
                Console.WriteLine("para executar o exercicio 2 - digite 2");
                Console.WriteLine("para executar o exercicio 3 - digite 3");
                Console.WriteLine("para executar o exercicio 4 - digite 4");
                Console.WriteLine("para executar o exercicio 4 - digite 5");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("obrigado por usar");
                        break;
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    case 5:
                        Exercicio5()
                            ; break;
                    default:
                        Console.WriteLine("o numero não é um exercicio valido");
                        break;
                }

            } while (true);
        }
    }
}


