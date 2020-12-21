using AOC_2020.Challenges;
using System;
using System.IO;

namespace AOC_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Day_01.Challenge();
            //Day_02.Challenge();
            Day_03.Challenge();


        }


        /* ------- DEBUT DE MES METHODES ------- */


        //Lit les fichier et retourne un array de int - utilise au jour 01
        public static int[] ConvertirFicherVersTableau(string Fichier)
        {
            string[] donnesDuFichier = File.ReadAllLines(Fichier);
            int[] mesDonnees = new int[donnesDuFichier.Length];

            for (int i = 0; i < donnesDuFichier.Length; i++)
            {
                mesDonnees[i] = int.Parse(donnesDuFichier[i]);
            }

            return mesDonnees;
        }




    }


    
}
