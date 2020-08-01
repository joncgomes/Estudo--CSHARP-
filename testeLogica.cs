using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_de_logica
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            Console.WriteLine("Escolha o Exercício");
            Console.WriteLine("Exercicio 1 - Digite - 1");
            Console.WriteLine("Exercicio 2 - Digite - 2");
            Console.WriteLine("Exercicio 3 - Digite - 3");
            Console.WriteLine("Exercicio 4 - Digite - 4");
            Console.WriteLine("Exercicio 5 - Digite - 5");
            Console.WriteLine("Exercicio 6 - Digite - 6");

            Console.WriteLine("Escolha o Exercicio Desejado");
            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                string peça1;
                int numeroPecas1;
                float valorUnitarioPeca1;
                string peça2;
                float totalPeca1;
                int numeroPecas2;
                float valorUnitarioPeca2;
                float totalPeca2;
                float totalCompra;

                Console.WriteLine("Digite o Código de uma Peça 1: ");
                peça1 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Digite o número de peças 1: ");
                numeroPecas1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor unitario de peça 1: ");
                valorUnitarioPeca1 = float.Parse(Console.ReadLine());

                totalPeca1 = numeroPecas1 * valorUnitarioPeca1;


                Console.WriteLine("Digite o Código de uma Peça 2: ");
                peça2 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Digite o número de peça 2: ");
                numeroPecas2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor unitario de peça 2: ");
                valorUnitarioPeca2 = float.Parse(Console.ReadLine());
                totalPeca2 = numeroPecas2 * valorUnitarioPeca2;


                // total a pagar

                totalCompra = totalPeca1 + totalPeca2;

                Console.WriteLine("O total a pagar é: " + totalCompra);
            }

            else if (op == 2)
            {

                double pi = 3.14159;
                double raio;
                double area;
                Console.WriteLine("Digite o Raio de um Circulo");
                raio = double.Parse(Console.ReadLine());

                area = pi * Math.Pow(raio, 2);

                area = Math.Round(area, 4);
                Console.WriteLine("O valor da AREA desse Circulo É:" + area);


                // Exercicio 2
            }

            else if (op == 3)
            {

                int codigoProduto;

                Console.WriteLine("Escolha o Seu Produto");
                Console.WriteLine("Cachorro Quente - Codigo: 1 ");
                Console.WriteLine(" X-SALADA - Codigo: 2 ");
                Console.WriteLine(" X-BACON - Codigo: 3 ");
                Console.WriteLine(" Torrada Simples - Codigo: 4 ");
                Console.WriteLine(" Refrigerante - Codigo: 5 ");

                Console.WriteLine("Digite o Código Desejado");
                codigoProduto = int.Parse(Console.ReadLine());

                if (codigoProduto == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Cachorro Quente");

                    int quantidadeDesejada;

                    Console.WriteLine("Digite a Quantidade Desejada");
                    quantidadeDesejada = int.Parse(Console.ReadLine());

                    double preco = 4.00;

                    double totalPagar = preco * quantidadeDesejada;

                    totalPagar = Math.Round(totalPagar, 2);
                    Console.WriteLine("Total a Paga é: " + totalPagar.ToString("C", CultureInfo.CurrentCulture));
                }

                if (codigoProduto == 2)
                {
                    Console.Clear();
                    Console.WriteLine("X-SALADA");

                    int quantidadeDesejada;
                    Console.WriteLine("Digite a Quantidade Desejada");
                    quantidadeDesejada = int.Parse(Console.ReadLine());
                    double preco = 4.50;

                    double totalPagar = preco * quantidadeDesejada;
                    totalPagar = Math.Round(totalPagar, 2);
                    Console.WriteLine("Total a Paga é: " + totalPagar.ToString("C", CultureInfo.CurrentCulture));
                }
                if (codigoProduto == 3)
                {
                    Console.Clear();
                    Console.WriteLine("X-BACON");
                    double quantidadeDesejada;
                    Console.WriteLine("Digite a Quantidade Desejada");
                    quantidadeDesejada = double.Parse(Console.ReadLine());
                    double preco = 5.00;

                    double totalPagar = preco * quantidadeDesejada;
                    totalPagar = Math.Round(totalPagar, 2);
                    Console.WriteLine("Total a Paga é: " + totalPagar.ToString("C", CultureInfo.CurrentCulture));
                }
                if (codigoProduto == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Torrada Simples");
                    int quantidadeDesejada;
                    Console.WriteLine("Digite a Quantidade Desejada");
                    quantidadeDesejada = int.Parse(Console.ReadLine());
                    double preco = 2.00;


                    double totalPagar = preco * quantidadeDesejada;
                    totalPagar = Math.Round(totalPagar, 2);
                    Console.WriteLine("Total a Paga é: " + totalPagar.ToString("C", CultureInfo.CurrentCulture));
                }
                if (codigoProduto == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Refrigerante");

                    int quantidadeDesejada;
                    Console.WriteLine("Digite a Quantidade Desejada");
                    quantidadeDesejada = int.Parse(Console.ReadLine());
                    double preco = 1.50;

                    double totalPagar = preco * quantidadeDesejada;
                    totalPagar = Math.Round(totalPagar, 2);
                    Console.WriteLine("Total a Paga é: " + totalPagar.ToString("C", CultureInfo.CurrentCulture));


                }

                // Exercicio 3
            }

            else if (op == 4)
            {
                // exercio equacao segundo grau

                double a;
                double b;
                double c;

                double raiz;

                double solucao;
                double auxSolucao1;
                double auxSolucao2;

                double delta;
                double aux;
                //double aux2
                Console.Write("Digite o valor de A:");
                a = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor de B:");
                b = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor de C:");
                c = double.Parse(Console.ReadLine());


                if (a == 0)
                {
                    Console.WriteLine("O valor de A - Não pode ser 0");
                }

                else
                {
                    aux = Math.Pow(b, 2) - (4 * a * c);

                    delta = aux;





                    if (a == 0 || delta < 0)
                    {
                        Console.WriteLine("Impossível Calcular");
                        Console.WriteLine("Delta é: " + delta);

                    }

                    else
                    {
                        //delta = b - 4 +(aux2);

                        Console.WriteLine("Delta é: " + delta);

                        // Calculando Raizes

                        raiz = Math.Sqrt(delta);
                        b = Math.Abs(b);
                        solucao = -((b) + raiz) / (2 * a);
                        auxSolucao1 = solucao;

                        solucao = -((b) - raiz) / (2 * a);
                        auxSolucao2 = solucao;

                        auxSolucao1 = Math.Round(auxSolucao1, 5);
                        auxSolucao2 = Math.Round(auxSolucao2, 5);
                        Console.WriteLine("O Calculo Das Raizes é  X¹: " + auxSolucao2 + ", X²:" + auxSolucao1);

                    }
                }
            }

            else if (op == 5)
            {
                int n = 0;

                Console.WriteLine("Programa de Teste de SENHA");
                Console.WriteLine("Digite a Senha:");
                n = int.Parse(Console.ReadLine());

                if (n == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                }
                    while (n != 2002)
                    {
                   
                        Console.WriteLine("Digite a Senha:");
                        n = int.Parse(Console.ReadLine());
                        if (n != 2002)
                        {
                            Console.WriteLine("Senha Invalida");
                        }
                       

                }
                    Console.WriteLine("Acesso Permitido");
                
                
            }

            else if (op == 6)
            {
                int n;
                int dentro = 0;
                int fora = 0;
                Console.WriteLine("Digite um Numero Inteiro: Exemplo: (10)");
                Console.WriteLine("Digite o Numero Inteiro");
                n = int.Parse(Console.ReadLine());

                for(int i = 999999999; n < i; i++)
                {
                    int x;

                    if (n >= 10 && n <= 20)
                    {
                        dentro = dentro + 1;

                    }

                    else
                    {
                        fora = fora + 1;
                    }
                }

                Console.Write("Dentro in" + dentro);
                Console.WriteLine("Fora Out" + fora);
               

               

             


            }
            else
            {
                Console.WriteLine("Opção Invalida - Reinicie o Programa!");
            }
           
            Console.ReadKey();
        }
    }
}
