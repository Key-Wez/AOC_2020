using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AOC_2020.Challenges
{
    class Day_02
    {
        public static void Challenge()
        {
            //Day02 - challenge 01
            Console.WriteLine("\n------------  Day 02 - Challenge 1  ------------");
            string fichierDuProblemeJour2 = "files/AoC_D02_C1.txt";
            string[] pair = File.ReadAllLines(fichierDuProblemeJour2);


            Func<string, bool> ValidatedPasswordOnPolicy = delegate (string pwPolicyPair)
            {
                //string test = "5-8 t: ttttbttttc";
                string test = pwPolicyPair;
                string[] SplitArray = test.Split(new char[] { '-', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int ruleMIN = int.Parse(SplitArray[0]);
                int ruleMAX = int.Parse(SplitArray[1]);
                string KeyLetter = SplitArray[2];
                string StringToLookUP = SplitArray[3];
                int compteur = 0;

                for (int i = 0; i < StringToLookUP.Length; i++)
                {
                    if (StringToLookUP.Substring(i, 1) == KeyLetter)
                    {
                        compteur++;
                    }
                }

                return (compteur >= ruleMIN && compteur <= ruleMAX);

            };

            FiltrerMotDeOasseValide(pair, ValidatedPasswordOnPolicy);

            //Day02 - challenge 02
            Console.WriteLine("\n------------  Day 02 - Challenge 2  ------------");

            /*Func<string, bool> SecondPasswordPolicy = delegate (string pwPolicyPair)
            {
                string test = "5-8 t: ttttbttttc";
                //string test = pwPolicyPair;
                string[] SplitArray = test.Split(new char[] { '-', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int position01 = int.Parse(SplitArray[0]) - 1;
                int position02 = int.Parse(SplitArray[1]) - 1;
                string KeyLetter = SplitArray[2];
                string StringToLookUP = SplitArray[3];
                *//*  METTRE CETTE  *//*
                if()

                return false;
            };*/




        }

        public static void FiltrerMotDeOasseValide(string[] pwPolicyPairs, Func<string, bool> filtrage)
        {
            int nombreValide = 0;

            foreach (string pair in pwPolicyPairs)
            {
                if (filtrage(pair))
                {
                    nombreValide++;
                }
            }
            //return nombreValide;
            Console.WriteLine(nombreValide);
        }




    }
}
