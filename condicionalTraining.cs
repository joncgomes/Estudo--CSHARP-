using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Exercicio_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produt2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Exercicio de Fixacao");

            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1 +", cujo preço é $"+preco1);
            Console.WriteLine(produt2 + ", cujo preco é $" + preco2);

            Console.WriteLine("Registro:"+ idade + " anos de idade, codigo " + codigo + " e genero: " + genero);

        
            Console.WriteLine("Medida com oito casas decimais:"+ medida.ToString("F8"));
            Console.WriteLine("Arredondado:"+ medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture:"+ medida.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
