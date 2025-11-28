using System;

namespace Palavra
{
    class Contrario
    {
        public static void Reversa(string args)
        {
            string invertida = "";                       //hoje
        
            for(int n = args.Length-1; n >= 0; n--)
            {
                invertida += args[n];
            }
            Console.WriteLine($"A palavra {args} ivertida é {invertida}");
        }
    }
}