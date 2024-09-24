using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motus
{
    internal class ListeMots
    {
        private List<string> mots = new List<string>
    {
        "ABRICOTS", "BANQUISE", "CAMPAGNE", "DESSINER", "ECLAIRER", "FANTOMES", "GARDERIE", "HABITANT", "INSECTES", "JARDINER",
        "KARATEKA", "LUMIERES", "MUSICIEN", "NOUVELLE", "ORANGERS", "PAPIERIE", "QUARTIER", "RIVIERES", "SAVONNER", "TISSERIE",
        "URGENCES", "VOYAGERS", "WIFIABLE", "XYLOPHON", "YOGOURTS", "ZEBRURES", "ACTRICES", "BONBONNE", "CAMPINGS", "DESSINAT",
        "ECLAIRCI", "FANTASME", "GARDERES", "HABITUES", "INSECTIF", "JARDINET", "KARATEES", "LUMINAUX", "MUSIQUES", "NOUVEAUX",
        "ORANGERA", "PAPIERES", "QUARTZES", "RIVERAIS", "SAVONNES", "TISSERAS", "URGENCES", "VOYAGENT", "WIFIABLE", "XYLOPHON"
    };

        private Random rand = new Random();

        public string ObtenirMotAleatoire()
        {
            return mots[rand.Next(mots.Count)];
        }
    }
}
