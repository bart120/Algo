using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.MenuPerso
{
    /// <summary>
    /// Pour faire un menu
    /// </summary>
    class Menu
    {
        private List<MenuItem> menuItems;

        public Menu()
        {
            menuItems = new List<MenuItem>();
        }

        /// <summary>
        /// Insère un MenuItem dans le menu.
        /// </summary>
        /// <param name="item">Element à insérer dans le menu</param>
        /// <exception cref="ArgumentException">Si le numéro de l'item est déjà présent dans le menu</exception>
        public void InsererLigne(MenuItem item)
        {
            /*foreach (var ligne in menuItems)
            {
                if (ligne.Numero == item.Numero)
                {
                    throw new ArgumentException(
                        $"Le numéro {item.Numero} existe déjà dans le menu");
                    
                }
            }*/
            if(menuItems.Exists( x=> x.Numero == item.Numero))
            {
                throw new ArgumentException(
                        $"Le numéro {item.Numero} existe déjà dans le menu");
            }

            menuItems.Add(item);
        }

        /// <summary>
        /// Affiche les élements du menu
        /// </summary>
        public void Afficher()
        {
            foreach (MenuItem ligne in menuItems)
            {
                Console.WriteLine($"{ligne.Numero}- {ligne.Libelle}");
            }
        }

        /// <summary>
        /// récupération du choix de l'utilisateur et test du choix par rapport aux éléments du menu
        /// </summary>
        /// <returns>Le choix de l'utilisateur</returns>
        public int Choisir()
        {
            //récupération de la saisie
            Console.WriteLine("Saisir un choix:");
            int choix;
            choix = int.Parse(Console.ReadLine());

            //test
            while (true)
            {
                foreach (MenuItem item in menuItems)
                {
                    if (choix == item.Numero)
                    {
                        return choix;
                    }
                }
                Console.WriteLine("Erreur, saisir un choix:");
                choix = int.Parse(Console.ReadLine());
            }
        }
    }
}
