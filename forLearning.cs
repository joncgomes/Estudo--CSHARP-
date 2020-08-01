using System;

namespace ExerciciosForLearning
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;

            Console.WriteLine("Digite o número do Exercicio");
            Console.WriteLine("1 - Exercicio(1)\n 2 - Exercicio(2)\n 3 - Exercicio(3)\n 4 - Exercicio(4)\n 5 - Exercicio(5)\n 6 - Exercicio(6)\n");
            num = int.Parse(Console.ReadLine());

            if(num == 1)
            {
                Console.WriteLine("Exercicio 1");


                Console.WriteLine("Digite um número");
                int x = int.Parse(Console.ReadLine());
                for ( int i = 1; i <= x; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                    
                }
            }

            if(num == 2)
            {
                int x = int.Parse(Console.ReadLine());

                if( x >=10 && x <= 20)
                {
                    Console.WriteLine("in");

                }

                else
                {
                    Console.WriteLine("out");
                }
            }

            Console.ReadKey();
        }
    }
}
