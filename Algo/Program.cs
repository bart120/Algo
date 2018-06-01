using Algo.MenuPerso;
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

            Menu menu = new Menu();
            menu.InsererLigne(new MenuItem { Numero = 1, Libelle = "Voyages" });
            menu.InsererLigne(new MenuItem { Numero = 3, Libelle = "Clients" });
            menu.InsererLigne(new MenuItem { Numero = 4, Libelle = "Dossiers" });

            menu.Afficher();
            int resultat = menu.Choisir();

            switch (resultat)
            {
                case 1:
                    SousMenuVoyages();
                    break;
                case 3:
                    SousMenuClients();
                    break;
                case 4:
                    SousMenuDossiers();
                    break;
            }
            Console.ReadLine();

        }

        private static void SousMenuDossiers()
        {
            Menu sousMenu = new Menu();
            sousMenu.InsererLigne(new MenuItem { Numero = 1, Libelle = "Créer" });
            sousMenu.InsererLigne(new MenuItem { Numero = 2, Libelle = "Rechercher" });
            sousMenu.InsererLigne(new MenuItem { Numero = 3, Libelle = "Supprimer" });

            sousMenu.Afficher();
            int resultatSousMenu = sousMenu.Choisir();
            switch (resultatSousMenu)
            {
                case 1:
                    Console.WriteLine("Vous souhaitez: Dossiers => Créer");
                    break;
                case 2:
                    Console.WriteLine("Vous souhaitez: Dossiers => Rechercher");
                    break;
                case 3:
                    Console.WriteLine("Vous souhaitez: Dossiers => Supprimer");
                    break;
            }
        }

        private static void SousMenuClients()
        {
            Menu sousMenu = new Menu();
            sousMenu.InsererLigne(new MenuItem { Numero = 1, Libelle = "Créer" });
            sousMenu.InsererLigne(new MenuItem { Numero = 2, Libelle = "Rechercher" });
            sousMenu.InsererLigne(new MenuItem { Numero = 3, Libelle = "Supprimer" });

            sousMenu.Afficher();
            int resultatSousMenu = sousMenu.Choisir();
            switch (resultatSousMenu)
            {
                case 1:
                    Console.WriteLine("Vous souhaitez: Clients => Créer");
                    break;
                case 2:
                    Console.WriteLine("Vous souhaitez: Clients => Rechercher");
                    break;
                case 3:
                    Console.WriteLine("Vous souhaitez: Clients => Supprimer");
                    break;
            }
        }

        private static void SousMenuVoyages()
        {
            Menu sousMenu = new Menu();
            sousMenu.InsererLigne(new MenuItem { Numero = 1, Libelle = "Destination" });
            sousMenu.InsererLigne(new MenuItem { Numero = 3, Libelle = "Compagnies" });

            sousMenu.Afficher();
            int resultatSousMenu = sousMenu.Choisir();
            switch (resultatSousMenu)
            {
                case 1:
                    Console.WriteLine("Vous souhaitez: Voyages => Destination");
                    break;
                case 3:
                    Console.WriteLine("Vous souhaitez: Voyages => Compagnies");
                    break;
            }
        }
    }

    
}
