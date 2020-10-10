using System;
using System.Globalization;

namespace _08_Aula_23_ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ALEX GREEN / 3 / 500.50 / GREEN 21 1.73*/

            Console.WriteLine("Digite seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de quartos em sua casa: ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu ultimo nome, idade e altura (na mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Seus Dados São: ");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine(quartos + " quarto(s)");
            Console.WriteLine("R$: " + valor.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Sobrenome: "+ sobrenome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
