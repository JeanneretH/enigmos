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
    }
}
