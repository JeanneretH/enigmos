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
        private PC destination;

        /// <summary>
        /// Constructeur de la classe commande sans la destination
        /// </summary>
        /// <param name="nom">nom de la commande</param>
        /// <param name="resultat">resultat de la commande</param>
        public Command(string nom, string resultat)
            : this(nom, resultat, null) //Si ce constructeur est appelé, il appel le deuxième en précisant que la destination est nul
        {
        }

        /// <summary>
        /// Constructeur de la classe commande incluant la destination
        /// </summary>
        /// <param name="nom">nom de la commande</param>
        /// <param name="resultat">resultat de la commande</param>
        /// <param name="destination">nom du pc de destination</param>
        public Command(string nom, string resultat, PC destination)
        {
            this.strNom = nom;
            this.strResultat = resultat;
            this.destination = destination;
        }

        /// <summary>
        /// Accède au nom de l'objet commande
        /// </summary>
        /// <returns>Son nom</returns>
        public string getNom()
        {
            return strNom;
        }

        /// <summary>
        /// Accède au resultat de la commande
        /// </summary>
        /// <returns>Son resultat</returns>
        public string getResultat()
        {
            return strResultat;
        }

        /// <summary>
        /// Défini vers quel pc la commande va pointer
        /// </summary>
        /// <param name="destination">le nom du pc de destination</param>
        public void setDestination(PC destination)
        {
            this.destination = destination;
        }

        /// <summary>
        /// Accède à la destination de la commande
        /// </summary>
        /// <returns>La destination</returns>
        public PC getDestination()
        {
            return destination;
        }
    }
}
