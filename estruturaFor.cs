using System;

namespace EstruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int soma = 0;
            Console.WriteLine("Digite um Número");
            n = int.Parse(Console.ReadLine());

            for ( int i = 1; i <= n;  i++)
            {
                int valor;

                Console.WriteLine("Digite os Números");
                valor = int.Parse(Console.ReadLine());
                    
                soma = valor + soma;
            }


            Console.WriteLine("Valor total é:" + soma);
            Console.ReadKey();
        }
    }
}
