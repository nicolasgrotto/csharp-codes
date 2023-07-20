using System.Runtime.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        /*int num;
        int[] nums = new int[10];
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("Digite um número: ");
            num = Convert.ToInt16(Console.ReadLine());
            nums[i] = num;
         }
        foreach(int n in nums)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine($"Valor digitado: {n} - é um número par");
            }
            else
            {
                Console.WriteLine($"Valor digitado: {n} - é um número ímpar");
            }
        }*/

        int[] numeros = new int[5];
        int soma = 0;
        for(int i = 0; i <5 ; i++)
        {
            Console.WriteLine("digite um número: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());

            soma += numeros[i];
        }
        foreach(int num in numeros)
        {
            Console.WriteLine($"número: {num}");
        }

        Console.WriteLine("A soma entre todos os valores digitados totaliza em: " + soma);

        Console.WriteLine("fim");
        Console.ReadKey();
    }
}