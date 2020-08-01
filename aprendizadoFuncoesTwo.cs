using System;

namespace LearningFunctionsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Eu vou aprender a realizar a codificação de uma função com apenas uma responsábilidade
            // Eu vou aprender
            // Vini, vidi, vici

            Console.WriteLine("Digite três numeros");
            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());
            int numero3 = int.Parse(Console.ReadLine());

            double resultado = Maior(numero1, numero2, numero3);

            Console.WriteLine("Maior é :" + resultado);
        }

        static int Maior (int num, int num2, int num3)
        {
            int maior;

            if( num > num2 && num > num3)
            {
                maior = num;
            }

            else if ( num2 > num3)
            {
                maior = num2;
            }

            else
            {
                maior = num3;
            }

            return maior;
        }
    }
}
