using System;

namespace _12_Aula_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escopo e Inicialização");

            Console.Write("Valor da compra: R$ ");
            double preco = double.Parse(Console.ReadLine());

            double desconto = 0.0;

            if (preco > 100.0)
            {
                desconto = preco * 0.1;
            }

            Console.WriteLine("Desconto de R$: " + desconto.);
        }
    }
}
