using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            int i = 0;
            //var prenomsDynamiques = new ArrayList();// Ma chaine de caractères
            var prenomsDynamiques = new List<string>();
            while (i < 3)//on ajoute trois éléments saisis par l'utilisateur
            {
                Console.WriteLine((i+1)+")Done moi un nom?");
                prenomsDynamiques.Add(Console.ReadLine());
                i++;
                Console.Clear();
            }
            Console.WriteLine("\nR) Voilà le deuxième: "+ prenomsDynamiques[1]);// affichage du deuxième
            Console.ReadKey();
        }
    }
}
