using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Algo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<MenuItem> list = new List<MenuItem>
            {
                new MenuItem{ Numero = 1, Libelle = "menu 1" },
                new MenuItem{ Numero = 3, Libelle = "menu 3" },
                new MenuItem{ Numero = 3, Libelle = "menu 3BIS" },
                new MenuItem{ Numero = 4, Libelle = "menu 4" },
            };
            int resultat = GererMenu(list);
            Console.WriteLine(resultat);
            Console.ReadLine();

        }

        /// <summary>
        /// Affiche un menu et test et récupère la saisie de l'utilisateur
        /// </summary>
        /// <param name="menu">La liste des choix possible</param>
        /// <returns>Le choix de l'utilisateur</returns>
        private static int GererMenu(List<MenuItem> menu)
        {
            //Affiche les élements de menu
            foreach (MenuItem ligne in menu)
            {
                Console.WriteLine($"{ligne.Numero}- {ligne.Libelle}");
            }

            //récupération du choix de l'utilisateur
            Console.WriteLine("Saisir un choix:");
            int choix;
            choix = int.Parse(Console.ReadLine());
            
            //test du choix par rapport aux éléments du menu
            while (true)
            {
                foreach (MenuItem item in menu)
                {
                    if (choix == item.Numero)
                    {
                        return choix;
                    }
                }
                Console.WriteLine("Erreur, saisir un choix:");
                choix = int.Parse(Console.ReadLine());
            }
            //return -1;


            //return menu.SingleOrDefault(x => x.Numero == choix) != null ? choix : -1;

            
        }

    }

    /// <summary>
    /// Représente une ligne d'un menu
    /// </summary>
    class MenuItem
    {
        public int Numero { get; set; }
        public string Libelle { get; set; }
    }
}
