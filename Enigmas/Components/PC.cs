using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cpln.Enigmos.Enigmas.Components
{
    class PC
    {
        private List<Command> commands = new List<Command>();

        /// <summary>
        /// Ajoute une commande à la liste
        /// </summary>
        /// <param name="nom">Nom de la commande</param>
        /// <param name="resultat">Resultat de la commande</param>
        public void AddCommand(string nom, string resultat)
        {
            commands.Add(new Command(nom, resultat));
        }

        public void AddCommand(string nom, string resultat, PC destination)
        {
            commands.Add(new Command(nom, resultat, destination));
        }

        /// <summary>
        /// Vérifie que la commande existe
        /// </summary>
        /// <param name="nom">nom de la commande</param>
        /// <returns>retourne la commande si elle existe, sinon un message d'erreur</returns>
        public Command GetCommand(string nom)
        {
            foreach (Command command in commands)
            {
                if (nom == command.getNom())
                {
                    return command;
                }
            }

            /*
            foreach équivalent à :
            for (int i = 0; i < commands.Count; i++)
            {
                Command command = commands[i];
                // ...
            }
            */

            return Command.DEFAULT;
        }

        public static PC Laptop()
        {
            PC laptop = new PC();

            laptop.AddCommand("help", "Liste des commandes :\nhelp\nscan /*le nom de ce que vous voulez scanner*\nhack /*le nom du pc cible");
            laptop.AddCommand("scan", "Veuillez indiquer ce que vous voulez scanner ! \nexemple: /reseau");
            laptop.AddCommand("scan/", "Erreur de syntaxe de la commande scan \nexemple: /reseau");
            laptop.AddCommand("scan /", "Veuillez indiquer ce que vous voulez scanner ! \nexemple: /reseau");
            laptop.AddCommand("scan /reseau", "Scan du reseau terminé.\nQue voulez-vous scanner ?\nexemple: scan /home");
            laptop.AddCommand("scan /home", "Groupe de travail inconnu.\nEssayez la liste de droite.");
            laptop.AddCommand("scan /secretariat", "Une vulnérabilité a été detectée\nsur le pc du secrétariat numéro 2");
            laptop.AddCommand("hack", "Pc cible non précisé");
            laptop.AddCommand("hack/", "erreur de syntaxe dans la commande hack");
            laptop.AddCommand("hack /", "Pc cible non précisé");
            laptop.AddCommand("hack /pcSecr1", "Aucune vulnérabilité connue trouvée sur ce pc");
            laptop.AddCommand("hack /pcSecr2", "Vous avez piraté le pc numéro 2 du secrétariat\net vous en avez pris le contrôle. \nDésormais les commandes que vous\ntapez seront directement executée sur le pc du secrétariat. Vous allez donc pouvoir continuer votre progression dans le réseau de l'entreprise en remontant chaque étage jusqu'à l'ordinateur du directeur.", PC.Secretariat());
            laptop.AddCommand("hack /pcSecr3", "Aucune vulnérabilité connue trouvée sur ce pc");
            laptop.AddCommand("", "");
            // autres commandes

            return laptop;
        }

        private static PC Secretariat()
        {
            PC secretariat = new PC();

            return secretariat;
        }
    }
}
