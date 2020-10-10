using System;

namespace _11_Aula_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estrutura Condicional (if-else)");
            Console.WriteLine("Simples");

            int a = 10;

            Console.WriteLine("Bom dia!");

            if(a < 10)
            {
                Console.WriteLine("Boa tardeee!");
            }

            //*********************************************
            Console.WriteLine("----------------------------");
            Console.WriteLine("Composta");

            Console.WriteLine("Número Inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Ímpar!");
            }

            //*********************************************
            //não fazer com IF's separados de ELSE
            Console.WriteLine("----------------------------");
            Console.WriteLine("Encadeamentos");

            Console.WriteLine("Qual é a hora atual? ");

            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora >= 12 && hora <18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else {
                Console.WriteLine("Boa noite!");
            }


        }
    }
}
