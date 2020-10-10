using System;

namespace _05_Aula_19_e_21
{
    class Program
    {
        static void Main(string[] args)
        {
            // OPERADORES DE ATRIBUIÇÃO 05
            /* 
            a = 10   ==   a RECEBE 10;
            a += 2   ==   a RECEBE a + 2;
            a -= 2   ==   a RECEBE a - 2;
            a *= 2   ==   a RECEBE a * 2;
            a /= 2   ==   a RECEBE a / 2;
            a %= 3   ==   a RECEBE a % 3;
            a = 10   ==   a RECEBE 10
            */

            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Operadores de Atribuição_05");

            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a -= 2;
            Console.WriteLine(a);

            a *= 2;
            Console.WriteLine(a);

            a /= 2;
            Console.WriteLine(a);

            a %= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Operadores Aritméticos / Atribuição_06 ");

            /*
            a++ ou ++a;   =   a = a + 1;
            a-- ou --a;   =   a = a - 1;
            */

            int b = 10;
            b++;
            Console.WriteLine(b);

            int c = 10;
            int d = c++;
            Console.WriteLine(c);
            Console.WriteLine(d);

            int e = 10;
            int f = ++e;
            Console.WriteLine(e);
            Console.WriteLine(f);

            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Operadores Aritméticos_07");
            /*
            +   adição
            -   subtração
            *   multiplicação
            /   divisão
            %   resto da divisão (mod)

            NOTAS:
            1) *  /  % tem precedência maior que +  e  -.

            2) 3 + 4 * 2   =   11
             (3 + 4) * 2   =   14
            
            3)Pode-se usar parênteses à vontade

            4) Exemplo com MOD:
            17 % 3   =   2
            17 / 3 = 5, mas o que sobra é 2.
            */

            int g = 3 + 4 * 2;
            int h = (3 + 4) * 2;
            int i = 17 % 3;
            double j = 10.0 / 8; // (double) ou 10.0 ou 8.0

            double ak = 1.0, bl = -3.0, cm = -4.0;

            double delta = /*(bl * bl)*/Math.Pow(bl, 2.0) - 4.0 * ak * cm;

            double x1 = (-bl + Math.Sqrt(delta)) / (2.0 * ak);/*raiz quadrada*/
            double x2 = (-bl - Math.Sqrt(delta)) / (2.0 * ak);/*raiz quadrada*/

            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}
