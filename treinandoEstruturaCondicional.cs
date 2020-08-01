using System;

namespace Exercicios_Estrutura_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicios de Estruturas Condicionais");
            Console.WriteLine("Digite a Opção Desejada");
            Console.WriteLine("Exercicio 1 - Digite 1");
            Console.WriteLine("Exercicio 2 - Digite 2");
            Console.WriteLine("Exercicio 3 - Digite 3");
            Console.WriteLine("Exercicio 4 - Digite 4");
            Console.WriteLine("Exercicio 5 - Digite 5");
            Console.WriteLine("Exercicio 6 - Digite 6");
            Console.WriteLine("Exercicio 7 - Digite 7");
            Console.WriteLine("Exercicio 8 - Digite 8");
            int op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                // Exercicio 1

                int x;

                Console.WriteLine("Digite um número Inteiro");
                x = int.Parse(Console.ReadLine());

                if (x < 0)
                {
                    Console.WriteLine("NEGATIVO");
                }

                else
                {
                    Console.WriteLine("NAO NEGATIVO");
                }

            }

            else if (op == 2)
            {
                // Exercício 2
                int x;

                Console.WriteLine("Digite um número Inteiro");
                x = int.Parse(Console.ReadLine());

                if (x % 2 == 0)
                {
                    Console.WriteLine("PAR");
                }

                else
                {
                    Console.WriteLine("IMPAR");
                }


            }

            else if (op == 3)
            {
                // Exercicio 3

                int a;

                Console.WriteLine("Digite um número Inteiro A:");
                a = int.Parse(Console.ReadLine());

                int b;

                Console.WriteLine("Digite um número Inteiro B:");
                b = int.Parse(Console.ReadLine());

                double aux;
                double resto;
                if ( a > b)
                {
                    aux = a;
                    resto = aux / b;
                }

                else
                {
                    aux = b;
                    resto = aux / a;
                }

                
                if (resto % 2 == 0)
                {
                    Console.WriteLine("Sao Multiplos");
                }

                else
                {
                    Console.WriteLine(" Nao Sao Multiplos");
                }


            }

            else if (op == 4)
            {
                // Exercicio 4

                int a;
                int total = 0;

                Console.WriteLine("Digite a hora inicial do Jogo:");
                a = int.Parse(Console.ReadLine());

                int b;

                Console.WriteLine("Digite a hora final do Jogo:");
                b = int.Parse(Console.ReadLine());

                

                if (a == b)
                {
                    Console.WriteLine("O JOGO DUROU 24 HORAS (S)");
                }

                else if ( a != b)
                {
                    int soma = 1;
                   

                    if ( a > b)
                    {
                        if(a < 24)
                        {
                            soma = 24 - a;
                            total = soma + b;
                        }

                        Console.WriteLine("O JOGO DUROU " + total + " HORAS (S)");
                    }

                    else
                    {
                        if(b > a)
                        {
                            soma = (b - a);
                            total = soma;
                            Console.WriteLine("O JOGO DUROU " + total + "HORAS (S)");
                        }
                    }
                }


            }

            if ( op == 6)
            {
                // Exercico 6

                double num;

                Console.WriteLine("Digite um valor qualquer: ");
                num = double.Parse(Console.ReadLine());

                if( num >= 0 && num <=25)
                {
                    Console.WriteLine("Intervalo [0,25]");
                }

                else if (num > 25 && num <= 50)
                {
                    Console.WriteLine("Intervalo [25,50]");
                }

                else if (num > 50 && num <= 75)
                {
                    Console.WriteLine("Intervalo [50,75]");
                }

                else if (num > 75 && num <= 100)
                {
                    Console.WriteLine("Intervalo [75,100]");
                }

                else
                {
                    Console.WriteLine("Fora de Intervalo");
                }
            }

            else if (op == 7)
            {
                double x;
                double y;

                Console.WriteLine("Digite um valor qualquer para X: ");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite um valor qualquer para Y:");
                y = double.Parse(Console.ReadLine());

                if (x != 0)
                {
                    if (x < 0)
                    {
                        Console.WriteLine(x + " - Q2");
                    }

                    else if (x > 0)
                    {
                        Console.WriteLine(x + " - Q1");
                    }
                }

                if (y != 0)
                { 
                     if (y < 0)
                    {
                        Console.WriteLine(y+" - Q3");
                    }

                    else if (y > 0)
                    {
                        Console.WriteLine(y+" - Q4");
                    }
                }
                else
                {
                    Console.WriteLine("Origem");
                }
            }

            if( op == 8)
            {
                double salario;

                Console.WriteLine("Digite o seu salário:");
                salario = double.Parse(Console.ReadLine());

                salario = Math.Round(salario,2);

                Console.WriteLine("Salario:" + salario);

                if(salario >= 0 && salario <=2000)
                {
                    Console.WriteLine("ISENTO");
                }

                else if (salario > 2000 && salario <= 3000)
                {
                    double imposto = 0.08;
                    double subtracao;

                    double resultado = ((salario - 2000) - 1000);
                    subtracao = 1000 * imposto; // pareia qui
                    resultado = resultado * 0.18;
                    resultado = resultado + subtracao;
                    Console.WriteLine(resultado); 
                }

                else if ( salario > 4500)
                {
                    double imposto = 0.08;
                    double subtracao;

                    double resultado = ((salario - 2000) - 2500);
                    subtracao = 1000 * imposto; // pareia qui
                    subtracao = 1000 * imposto; // pareia qui
                    double aux = 1500 * 0.18;
                    resultado = resultado * 0.28;
                    resultado = resultado + subtracao + aux;
                

                   
                    Console.WriteLine(resultado);

                   
                }
            }
            Console.ReadKey();

        }
    }
}
