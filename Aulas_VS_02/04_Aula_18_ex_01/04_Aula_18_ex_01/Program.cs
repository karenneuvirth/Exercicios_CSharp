using System;
using System.Globalization;

namespace _04_Aula_18_ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("1º Exercicio de Fixação_04");

            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1}, cujo preço é R$ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é R$ {preco2:F2}");
            Console.WriteLine($"\nRegistro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine($"\nMedida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"\nArredondado (três casas decimais): {medida:F3}");
            Console.WriteLine($"\nSeparador decimal Invariant Culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}
