using System;

namespace FuncoesAula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            double numero = int.Parse(Console.ReadLine());

            while (numero >= 0)
            {

               double resultado = Raiz(numero);
               Console.WriteLine("Raiz é: "+ resultado);


                Console.WriteLine("Digite um número");
                numero = int.Parse(Console.ReadLine());


            }
           
            Console.WriteLine("Número Negativo, programa encerrado...");
            Console.ReadKey();
        }

        static double Raiz (double num)
        {
            double resultado;
            resultado = Math.Sqrt(num); ;
            return resultado;
        }
    }
}
