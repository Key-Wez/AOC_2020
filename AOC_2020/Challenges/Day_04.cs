using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2020.Challenges
{
    class Day_04
    { 
        public static void Challenge()
        {
            //Day04 - challenge 01
            Console.WriteLine("\n------------  Day 04 - Challenge 1  ------------");

            string fichierDuProblemeJour4 = @"../../../Files/AoC_D04_test.txt";
            string fichierDuProblemeJour4a = @"../../../Files/AoC_D04.txt";
            
            string[] DonneesDuPasseport = File.ReadAllLines(fichierDuProblemeJour4);

            List<string[]> EnsembleDesPasseport = new List<string[]>();
            //List<string[]> passport = new List<string[]>();

            List<string> passport = new List<string>();

            foreach (string ligne in DonneesDuPasseport)
            {
                if (ligne != "")
                {
                    string[] elements = ligne.Split();
                    foreach(string el in elements)
                    {
                        passport.Add(el);
                        //passport.Sort();
                        //Console.WriteLine(el);
                    }
                }

                if (ligne == "")
                {
                    passport.Sort();
                    string[] test = passport.ToArray();
                    File.AppendAllLines(fichierDuProblemeJour4a, test);
                    EnsembleDesPasseport.Add(test);

                    /*foreach (string t in test)
                    {
                        Console.WriteLine(t);
                    }*/
                    
                    passport.Clear();
                }

                
                /*if (ligne != "" && IncrementDeListe != 0)
                {
                    string[] deliste = passport[compteur];
                    string[] elements = ligne.Split(" ");
                    passport.Add(elements);
                    passport.Add(deliste + elements);
                }*/
            }

            Console.WriteLine("*************************");

        /*    foreach (string[] pas in EnsembleDesPasseport)
            {
                File.AppendAllLines(fichierDuProblemeJour4a, pas);
                foreach (string p in pas)
                {
                    Console.WriteLine(p);
                }
            }*/






        }
    }
}
