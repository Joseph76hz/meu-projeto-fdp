using System;

namespace Name
{
    class Funcao
    {
        public static void kai(int args)
        {
            int n1 = args;
            Console.WriteLine(n1);
            Console.Write($"Digite um numero a ser somado com {n1}: ");
            int n2 = int.Parse(Console.ReadLine()!);
            int soma = n1 + n2;
            Console.WriteLine(soma);

            Console.WriteLine($"A média foi {soma / 2}");
            float celsius = (soma - 32) / 1.8F;
            Console.WriteLine($"{soma}F é igual a {celsius:F2}C");
            Console.WriteLine();
        }
    }
}