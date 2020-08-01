using System;

namespace ExerciciosWhileFunctions
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o Número do Exercico");
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("Exercicio de Senha");

                int senha = 2002;

                int password;

                Console.WriteLine("Digite um Senha Valida");
                password = int.Parse(Console.ReadLine());

                while (password != senha)
                {


                    Console.WriteLine("Senha Invalida");
                    Console.WriteLine("Digite um Senha Valida");
                    password = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Acesso Permitido!");


                Console.ReadKey();
            }


            if (num == 2)
            {

                Console.WriteLine("Exercicio 2");

                Console.WriteLine("Digite o valor de X e Y:");

                string[] valores = Console.ReadLine().Split(' ');
                int x = int.Parse(valores[0]);
                int y = int.Parse(valores[1]);


                while (x != 0 || y != 0)
                {


                    if (x > 0 && y > 0)
                    {
                        Console.WriteLine("Primeiro");
                    }
                    else if (x < 0 && y > 0)
                    {
                        Console.WriteLine("Segundo");
                    }
                    else if (x < 0 && y < 0)
                    {
                        Console.WriteLine("Terceiro");
                    }
                    else
                    {
                        Console.WriteLine("Quarto");
                    }


                    valores = Console.ReadLine().Split(' ');
                    x = int.Parse(valores[0]);
                    y = int.Parse(valores[1]);

                }


               
            }
            if (num == 3)
            {
                Console.WriteLine("Exercicio - 3");

                Console.WriteLine("Execicio de Posto de Combustível");

                int alcool = 0;
                int gasolina = 0;
                int diesel = 0;
                int fim = 0;

                int codigo;

                Console.WriteLine("Digite o Combustível Desejado.");
                codigo = int.Parse(Console.ReadLine());

                while( codigo != 4)
                {
                 

                    if( codigo == 1 )
                    {
                        Console.WriteLine("Alcool");

                        alcool = alcool + 1;
                    }

                    else if (codigo == 2)
                    {
                        Console.WriteLine("Gasolina");

                        gasolina = gasolina + 1;
                    }

                    else if (codigo == 2)
                    {
                        Console.WriteLine("Diesel");

                        gasolina = gasolina + 1;
                    }
                   

                    else if (codigo == 4)
                    {
                        Console.WriteLine("MUITO OBRIGADO!");
                    }

                    Console.WriteLine("Digite um novo Código de Combustível");
                    codigo = int.Parse(Console.ReadLine());
                }


               

                Console.WriteLine("Quantidade de Alcool: " + alcool);
                Console.WriteLine("Quantidade de Gasolina: " + gasolina);
                Console.WriteLine("Quantidade de Diesel: " + diesel);

            }
            Console.ReadKey();
        }
    }
}
