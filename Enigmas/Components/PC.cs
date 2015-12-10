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

        public void AddCommand(string nom, string resultat)
        {
            commands.Add(new Command(nom, resultat));
        }

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
