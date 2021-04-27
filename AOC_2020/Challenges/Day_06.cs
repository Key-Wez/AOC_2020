using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2020
{
    class Day_06
    {
        public static void Challenge()
        {

            //Day06 - challenge 01
            Console.WriteLine("\n------------  Day 06 - Challenge 1  ------------");
            string fichierDuProblemeJour6 = @"../../../Files/AoC_D06.txt";

            string[] DonneesDuProbleme = File.ReadAllLines(fichierDuProblemeJour6);

            bool[] reponses = new bool[26];
            
            int reponsesOui = 0;

            
            foreach (string ligne in DonneesDuProbleme)
            {
                if (ligne != "")
                {
                    foreach (char ch in ligne)
                    {
                        reponses[ch - 'a'] = true;
                    }
                }

                else
                {
                    reponsesOui += Array.FindAll(reponses, e => e == true).Length;
                    reponses = new bool[26];
                    //Console.WriteLine(reponsesOui);

                }

            }

            // Process the last line because no empty line.
            reponsesOui += Array.FindAll(reponses, e => e == true).Length;
            reponses = new bool[26];
            Console.WriteLine(reponsesOui);

            
            //Day06 - challenge 02
            Console.WriteLine("\n------------  Day 06 - Challenge 2  ------------");

            int compteurLignes = 0;
            int[] reponseINT = new int[26];
            int reponsesTousOui = 0;
            
            foreach (string ligne in DonneesDuProbleme)
            {
                if (ligne != "")
                {
                    foreach (char ch in ligne)
                    {
                        reponseINT[ch - 'a'] += 1 ;
                    }
                    compteurLignes++;
                    //Console.WriteLine(compteurLignes);
                }

                else
                {
                    int TousOui = Array.FindAll(reponseINT, e => e == compteurLignes).Length;
                    reponsesTousOui += TousOui;
                    reponseINT = new int[26];
                    compteurLignes = 0;
                    //Console.WriteLine(TousOui);
                    //Console.WriteLine(reponsesTousOui);

                }

            }

            // Process the last line because no empty line.
            reponsesTousOui += Array.FindAll(reponseINT, e => e == compteurLignes).Length;
            reponseINT = new int[26];
            Console.WriteLine(reponsesTousOui);

        }

    }
}
