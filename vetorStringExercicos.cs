using System;

namespace Exercicio_Vetor_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Alex Green";
            int qtde = 3;
            double precoProduto = 500.50;

            string dados;

            
            Console.WriteLine("Nome Completo:" + nome);
            Console.WriteLine("Quantos Quartos tem na sua casa"+ qtde);
            Console.WriteLine("Entre com o preco de um produto" + precoProduto);

            Console.WriteLine("Digite seu ultimo nome, idade e altura (mesma linha): ");
            dados = Console.ReadLine();

            string[] s = dados.Split(' ');
            string a = s[0];
            string b = s[1];
            string c = s[2];

            Console.WriteLine("Dados digitados");

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
    
        }
    }
}
