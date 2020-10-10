using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml;

namespace _07_Aula_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Entrada de Dados - Parte 1_08");

            /*
            Console.ReadLine();// lê a entrada padrão até a quebra de linha e retorna os dados lidos na forma de string.
            */

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            /* comando Split */
            /*string s = Console.ReadLine();*/
            string[] vet = Console.ReadLine().Split(' '); // s.Split ou esse. Vai reconhecer cada parte com um espaço em branco entre eles, vai separar as partes escritas, começando de 0.

            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine("Você digitou: " + frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            //*********************************************************************************************************************
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Entrada de Dados - Parte 2_09");

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            string[] v = Console.ReadLine().Split(' ');
            string nome = v[0];
            char sexo = char.Parse(v[1]);
            int idade = int.Parse(v[2]);
            double altura = double.Parse(v[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2"));
        }
    }
}
