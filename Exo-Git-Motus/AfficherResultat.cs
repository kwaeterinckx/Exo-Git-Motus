using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resultat
{
    public class AfficherResult
    {
        public static void AfficherResultat(string essai, string motSecret)
        {
            for (int i = 0; i < essai.Length; i++)
            {
                if (essai[i] == motSecret[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(essai[i]);
                }
                else if (motSecret.Contains(essai[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(essai[i]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(essai[i]);
                }
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
