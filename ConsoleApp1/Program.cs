using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void ArrayListEXE()
        {
            int i = 0;
            ArrayList prenomsDynamiques = new ArrayList();
            while (i < 3)
            {
                Console.WriteLine("Done moi un nom?");
                prenomsDynamiques.Add(Console.ReadLine());
                i++;
                Console.Clear();
            }
            foreach (string a in prenomsDynamiques)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
            static void TableauxEXE()
        {
            //taille est fixe!
            string[] prenoms = new string[3];
            Console.WriteLine("Done moi le premiere nom?");
            prenoms[0] = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Done moi le deuxieme nom?");
            prenoms[1] = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Done moi le troisieme nom?");
            prenoms[2] = Console.ReadLine();
            Console.Clear();
            foreach(string a in prenoms)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
        static void Variables()
        {
            int vInt = 10;
            //DateTime vDate = new DateTime(2018,05,07);
            DateTime vDate = DateTime.Today;
            DateTime vHeure = DateTime.Now;
            bool vBool = true;
            string vString = "voilà!";

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;

            while (true)
            {
                Console.WriteLine("La variable" + " vInt " + "a pour valeur = " + vInt);
                Console.WriteLine("La variable" + " vDate " + "a pour valeur = " + vDate.ToShortDateString());
                Console.WriteLine("La variable" + " vHeure " + "a pour valeur = " + vHeure.TimeOfDay.Hours + ":" + vHeure.TimeOfDay.Minutes + ":" + vHeure.TimeOfDay.Seconds);
                Console.WriteLine("La variable" + " vBool " + "a pour valeur = " + vBool);
                Console.WriteLine("La variable" + " vString " + "a pour valeur = " + vString);
                System.Threading.Thread.Sleep(1000); //wait for 1 sec
                vHeure = DateTime.Now;
                Console.Clear();
            }


            //Console.ReadKey();
        }
        static void Main(string[] args)
        {
            //Variables(); //1 
            //TableauxEXE(); //2
            ArrayListEXE(); //3
        }
    }
}
