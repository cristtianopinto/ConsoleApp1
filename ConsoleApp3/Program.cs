using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numReponse = new Random();
            int Reponse = numReponse.Next(1, 100);
            bool continuerJeux = true;
            int numChoisi;
            int fois = 0;

            while (continuerJeux)
            {
                Console.WriteLine("Bienvenue! \nChoisissez un nombre compris entre 0 et 100!\n---------------------------------------------------------");
                numChoisi = Int32.Parse(Console.ReadLine());
                if (numChoisi > Reponse)
                {
                    Console.WriteLine("Le nombre qui vous devez trouver est inferieur à {0}!", numChoisi);
                    Console.ReadKey();
                }
                else if (numChoisi < Reponse)
                {
                    Console.WriteLine("Le nombre qui vous devez trouver est superieur à {0}!", numChoisi);
                    Console.ReadKey();
                }
                else if (numChoisi == Reponse)
                {
                    Console.WriteLine("Voilà! {0} est le nombre! Vous avez trouvée en {1} fois.", numChoisi, fois);
                    Console.ReadKey();
                    continuerJeux = false;           
                }
                Console.Clear();
                fois++;
            }
           
        }
    }
}
