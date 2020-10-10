using System;
using System.Globalization;

namespace _01_Aula_15
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("Tipos Básico de Dados_01");  // Tipos Básicos de Dados - Partes 01 e 02

            SByte x = 100;
            Byte n1 = 126; // não aceita num negativo, de 0 a 255, quando ultrapassa o ovalor, ele pula pro limite oposto
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L; //L - indica explicitamente que esta trablhando com LONG
            float n5 = 4.5f; // f - indica float ao inves de double
            double n6 = 4.5;

            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);

            //*******************************

            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);

            //*******************************

            string nome = "Maria Green"; // string - é imutável, é mais seguro e livre de erros
            object obj1 = "Alex Brown"; // aceita qualquer coisa
            object obj2 = "4.5f";

            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            //*******************************

            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            sbyte n9 = sbyte.MinValue;
            decimal n10 = decimal.MaxValue;

            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine(n10);

            /*
            //Exemplo 01
            double a;
            float b;

            a = 5.1;
            b = (float)a;

            Console.WriteLine(b);

            //Esemplo 02
            double a1;
            int b1;

            a1 = 5.1;
            b1 = (int)a1;

            Console.WriteLine(b1);

            //Exemplo 03
            int a2 = 5;
            int b2 = 2;

            double resultado = (double) a / b;

            Console.WriteLine(resultado);

            // Saida de dados em C#
            //Console.WriteLine(valor);
            //Console.Write(valor);
            */
        }
    }
}
