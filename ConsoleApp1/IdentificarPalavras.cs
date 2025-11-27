using System;
using System.Text.RegularExpressions;

namespace Texto
{
    public class BlackHole
    {
        public static void Palavra()
        {
           string text  = "Buracos negros são regiões do espaço-tempo com gravidade tão intensa que nem a luz pode escapar, formados pelo colapso de estrelas massivas ou acúmulo de matéria no centro das galáxias. Eles são invisíveis, mas podem ser detectados pelos efeitos que causam em sua vizinhança, como o movimento de estrelas ao redor. A primeira imagem de um buraco negro foi capturada em 2019 pelo projeto Event Horizon Telescope. ";
           string procurar = "mas";
           MatchCollection matches = Regex.Matches(text, procurar);
            foreach (Match n in matches)
            {
                Console.WriteLine(string.Format($"[{procurar}] posição {n.Index}"));
            }
            Console.WriteLine(string.Format(">> Achado '{0}' nomes ", matches.Count));
           

        }
    }
}