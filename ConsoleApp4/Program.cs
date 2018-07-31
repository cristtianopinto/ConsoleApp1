using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static string PoserQuestion(string question)
        {
            Console.WriteLine(question);
            var saisie = Console.ReadLine();
            return saisie;
        }
        static void Main(string[] args)
        {

            /*
            var prenomsDynamiques = new ArrayList();// Ma chaine de caractères
                                                    //var prenomsDynamiques = new List<string>();
            
            Console.WriteLine("1 )Quelle est votre Prénom?");
            prenomsDynamiques.Add(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("2 )Quelle est votre nom?");
            prenomsDynamiques.Add(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("3 )Quelle est votre age?");
            prenomsDynamiques.Add(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("\nBonjour {0} {1}.\nTu as {2} ans.",prenomsDynamiques[0], prenomsDynamiques[1], prenomsDynamiques[2]);// affichage du deuxième
            */
            var prenom = PoserQuestion("1)Quelle est votre Prénom?");
            var nom = PoserQuestion("2)Quelle est votre nom?");
            var age = PoserQuestion("3)Quelle est votre age?");
            Console.WriteLine($"\nBonjour {prenom} {nom}.\nTu as {age} ans.");
            Console.ReadKey();
        }
    }
}
