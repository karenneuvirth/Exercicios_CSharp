using System;
using System.Globalization;

namespace _03_Aula_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Placeholders, Concatenação e Interpolação_03");

            int idade = 32;
            double saldo = 10.35784;
            String nome = "Maria";

            /*
            //não é muito funcional, muito cod.
            
            Console.Write(nome); 
            Console.Write("tem");
            Console.Write(idade);
            Console.Write("anos.");
            */

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); // Placeholder // IMPORTANTE !!

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais"); // Concatenação = mais antigo
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais"); // COM PONTO, È NECESSARIO USAR TOSTRING

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); // Interpolação 
        }
    }
}
