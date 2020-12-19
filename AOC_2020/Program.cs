using System;
using System.IO;

namespace AOC_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Day01 - challenge 01
            Console.WriteLine("------------  Day 01 - Challenge 1  ------------");
            string fichierDuProbleme = "files/AoC_D01_C1.txt";
            int[] donneesDuProbleme = ConvertirFicherVersTableau(fichierDuProbleme);

            for (int i = 0; i < donneesDuProbleme.Length; i++)
            {
                int a = donneesDuProbleme[i];
                for (int j = i + 1; j < donneesDuProbleme.Length; j++)
                {
                    int b = donneesDuProbleme[j];
                    if (a + b == 2020)
                    {
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                        Console.WriteLine(a * b);


                    }
                }
            }

            //Day01 - challenge 02
            Console.WriteLine("\n------------  Day 01 - Challenge 2  ------------");
            for (int i = 0; i < donneesDuProbleme.Length; i++)
            {
                int a = donneesDuProbleme[i];
                for (int j = i + 1; j < donneesDuProbleme.Length; j++)
                {
                    int b = donneesDuProbleme[j];

                    for (int k = j + 1; k < donneesDuProbleme.Length; k++)
                    {
                        int c = donneesDuProbleme[k];
                        if (a + b + c == 2020)
                        {
                            Console.WriteLine(a);
                            Console.WriteLine(b);
                            Console.WriteLine(c);
                            Console.WriteLine(a * b * c);
                        }
                    }
                }
            }
        
        
        }


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
