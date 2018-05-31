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
            

        }

        private static int GererMenu(List<MenuItem> menu)
        {    
            foreach (MenuItem ligne in menu)
            {
                Console.WriteLine($"{ligne.Numero}- {ligne.Libelle}");
            }


            int choix;
            choix = int.Parse(Console.ReadLine());
            return choix;
        }

    }

    class MenuItem
    {
        public int Numero { get; set; }
        public string Libelle { get; set; }
    }
}
