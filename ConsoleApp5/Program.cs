using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void PoserQuestionTVA()
        //fonction qui pose la question et répond
        {
            decimal valeurEntrer;
            Console.Clear();
            Console.WriteLine("Calcule TVA:\nDone moi un valeur:");
            valeurEntrer = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Le TVA de {0} est {1}", valeurEntrer, CalculerPrixNet(valeurEntrer));
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            PoserQuestionTVA();
            PoserQuestionTVA();
            PoserQuestionTVA();
        }        

        static decimal CalculerPrixNet(decimal prixBrut)
        // fonction responsable de recevoir une valeur et de retourner une augmentation de TVA 
        {
            decimal prixTTC = prixBrut*1.206m;
            return prixTTC;// m marque un valeur decimal
        }
    }
}
