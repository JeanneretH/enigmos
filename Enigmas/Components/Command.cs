using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cpln.Enigmos.Enigmas.Components
{
    class Command
    {
        public static Command DEFAULT = new Command("", "Erreur : commande inconnue");
        private string strNom;
        private string strResultat;

        public Command(string nom, string resultat)
        {
            this.strNom = nom;
            this.strResultat = resultat;
        }

        public string getNom()
        {
            return strNom;
        }
    }
}
