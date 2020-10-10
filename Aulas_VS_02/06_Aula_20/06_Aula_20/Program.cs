using System;

namespace _06_Aula_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Conversão Implícita e Casting_06");
           
            /*
            Conversão Implícita: Um conteudo pode ser atribuido naturalmente a uma variavel de outro tipo
            */
            
            float x = 4.5f; // recebe 4 bytes
            double y = x; // recebe 8 bytes

            Console.WriteLine(y);


            /*
            Casting: Conversão Explícita entre dois tipos COMPATÍVEIS
            */
            
            double a;
            float b;

            a = 5.1;
            b = (float)a;

            Console.WriteLine(b);

            double c;
            int d;

            c = 5.1;
            d = (int)c;

            Console.WriteLine(d); // valores decimais serão truncados

            int e = 5;
            int f = 2;

            double resultado = (double)e / f;

            Console.WriteLine(resultado);
        }
    }
}
