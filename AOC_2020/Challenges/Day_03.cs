using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2020.Challenges
{
    class Day_03
    {
        public static void Challenge()
        {
            //Day03 - challenge 01
            Console.WriteLine("\n------------  Day 03 - Challenge 1  ------------");

            //string fichierDuProblemeJour3 = "files/test.txt";

            string fichierDuProblemeJour3 = "files/AoC_D03.txt";
            string[] mappeDesSapins = File.ReadAllLines(fichierDuProblemeJour3);


            CompterLesArbres01(mappeDesSapins);


            //Day03 - challenge 02
            Console.WriteLine("\n------------  Day 03 - Challenge 2  ------------");

            CompterLesArbres01(mappeDesSapins,1, 1);
            CompterLesArbres01(mappeDesSapins,3, 1);
            CompterLesArbres01(mappeDesSapins,5, 1);
            CompterLesArbres01(mappeDesSapins,7, 1);
            CompterLesArbres01(mappeDesSapins,1, 2);




        }

        public static void CompterLesArbres01(string[] fichier)
        {
            int compteurDeSapin = 0;
            string[] mappeDesSapins = fichier;

            for (int i = 0; i < mappeDesSapins.Length; i++)
            {
                int position = (i * 3) % 31;
                string ligneDuFichier = mappeDesSapins[i];

                //Console.WriteLine(position);
                //Console.WriteLine(ligneDuFichier[position]);

                if (ligneDuFichier[position].ToString() == "#")
                {
                    compteurDeSapin++;
                }
            }

            Console.WriteLine(compteurDeSapin);
        }


        public static void CompterLesArbres01(string[] fichier, int right, int down)
        {
            int compteurDeSapin = 0;
            string[] mappeDesSapins = fichier;
            int compteurVertival = 0;

            for (int i = 0; i < mappeDesSapins.Length; i++)
            {
                if (i % down == 0)
                {
                    int position = (compteurVertival * right) % 31;
                    string ligneDuFichier = mappeDesSapins[i];
                    compteurVertival++;

                    if (ligneDuFichier[position].ToString() == "#")
                    {
                        compteurDeSapin++;
                    }
                }
                
            }

            Console.WriteLine(compteurDeSapin);
        }



    }
}
