using Motus;
using Resultat;
using System;
using System.Collections.Generic;





ListeMots listeMots = new ListeMots();
string motSecret = listeMots.ObtenirMotAleatoire();
int essaisMax = 6;
int longueurMot = motSecret.Length;
List<string> essais = new List<string>();

Console.WriteLine("Bienvenue dans le jeu Motus !");
Console.WriteLine($"Vous devez deviner un mot de {longueurMot} lettres. Vous avez {essaisMax} essais.");

while (essais.Count < essaisMax)
{
    Console.Write($"Essai {essais.Count + 1}/{essaisMax}: ");
    string essai = Console.ReadLine().ToUpper();

    if (essai.Length != longueurMot)
    {
        Console.WriteLine($"Le mot doit contenir {longueurMot} lettres.");
        continue;
    }

    essais.Add(essai);

    AfficherResult.AfficherResultat(essai, motSecret);

    if (essai == motSecret)
    {
        Console.WriteLine("Félicitations ! Vous avez trouvé le mot !");
        break;
    }
}

if (essais.Count == essaisMax && essais[essais.Count - 1] != motSecret)
{
    Console.WriteLine($"Dommage ! Le mot secret était: {motSecret}");
}


