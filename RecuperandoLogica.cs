using System;
using System.Globalization;
namespace Exercicios_Propostos_1_Rec_Logica
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            Console.WriteLine("Escolha o Exercicio Digitando o Código Correspondente");
            Console.WriteLine("Exercicio 1 - (1)");
            Console.WriteLine("Exercicio 2 - (2)");
            Console.WriteLine("Exercicio 3 - (3)");
            Console.WriteLine("Exercicio 4 - (4)");
            Console.WriteLine("Exercicio 5 - (5)");
            Console.WriteLine("Exercicio 6 - (6)");
            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                // Exercicio - 1

                int a;
                int b;

                int soma = 0;

                Console.WriteLine("Digite um número Inteiro Para A: ");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite um número Inteiro Para B: ");
                b = int.Parse(Console.ReadLine());

                soma = a + b;

                Console.WriteLine("SOMA = " + soma);
            }

            else if (op == 2)
            {
                // Exercico 2

                double raio = 0;
                double pi = 3.14159;
                double area = 0;



                Console.WriteLine("Digite o Valor do Raio: ");
                raio = double.Parse(Console.ReadLine());

                area = pi * Math.Pow(raio, 2);

                area.ToString().Replace(",", ".");
                Console.WriteLine("A=" + area.ToString("F4").Replace(",", "."));


            }

            else if (op == 3)
            {
                // Exercicio 3

                int a;
                int b;
                int c;
                int d;

                int diferençaProduto = 0;

                Console.WriteLine("Digite um número Inteiro Para A: ");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite um número Inteiro Para B: ");
                b = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite um número Inteiro Para C: ");
                c = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite um número Inteiro Para D: ");
                d = int.Parse(Console.ReadLine());

                diferençaProduto = (a * b) - (c * d);

                Console.WriteLine("DIFENREÇA = " + diferençaProduto);
            }

            else if (op == 4)
            {
                // Exercicio 4

                int codFuncionario;
                double horasTrabalhadas;
                double valorHora;
                double salarioFuncionario;

                Console.WriteLine("Digite o Código do Funcionário:");
                codFuncionario = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o Numero de Horas Trabalhadas:");
                horasTrabalhadas = double.Parse(Console.ReadLine());

                Console.WriteLine("Valor por Hora Trabalhada:");
                valorHora = double.Parse(Console.ReadLine());

                salarioFuncionario = (valorHora * horasTrabalhadas);

                Console.WriteLine("NUMBER = " + codFuncionario);
                Console.WriteLine("SALARY = U$ " + salarioFuncionario.ToString("F2", CultureInfo.InvariantCulture));

            }
            else if (op == 5)
            {
                // Exercicio 5

                int codPeca1;
                double numPeca1;
                double valorUnit1;


                int codPeca2;
                double numPeca2;
                double valorUnit2;

                Console.WriteLine("Digite o Código de Pecas1");
                codPeca1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o numero de Pecas1");
                numPeca1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor unitario de Pecas1");
                valorUnit1 = double.Parse(Console.ReadLine());


                Console.WriteLine("Digite o Código de Pecas2");
                codPeca2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o numero de Pecas2");
                numPeca2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor unitario de Pecas2");
                valorUnit2 = double.Parse(Console.ReadLine());

                double valorPagar;

                valorPagar = (numPeca1 * valorUnit1) + (valorUnit2 * numPeca2);

                Console.WriteLine("VALOR A PAGAR: R$ " + valorPagar.ToString("F2", CultureInfo.InvariantCulture));



            }

            else if (op == 6)
            {
                // Exercicio 6

                double a;
                double b;
                double c;
              

                int diferençaProduto = 0;

                Console.WriteLine("Digite um número Inteiro Para A: ");
                a = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite um número Inteiro Para B: ");
                b = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite um número Inteiro Para C: ");
                c = double.Parse(Console.ReadLine());

                // calculo do triangulo retangulo

                double trianguloRetangulo;

                trianguloRetangulo = (a * c) / (2);

                Console.WriteLine("TRIANGULO: " + trianguloRetangulo.ToString("F3").Replace(',', '.'));

                // calculo do circulo

                double areaCirculo;

                areaCirculo = (c * c) * (3.14159);

                Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3").Replace(',', '.'));

                // area do trapezio
                double areaTrapezio;

                areaTrapezio = (((a + b) * (c)) / 2);

                Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3").Replace(',', '.'));

                // area do quadrado


                double areaQuadrado;

                areaQuadrado = (b * b);

                Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3").Replace(',','.'));

                // retangulo

                double areaRetangulo;

                areaRetangulo = (a * b);

                Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3").Replace(',', '.'));
            }

            else
            {
                Console.WriteLine("Opção Invalida - Reiniciar o Programa");
            }

                Console.ReadKey();
        }
    }
}
