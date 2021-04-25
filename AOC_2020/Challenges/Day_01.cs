using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2020.Challenges
{
    class Day_01
    {
        public static void Challenge()
        {
            //Day01 - challenge 01
            Console.WriteLine("------------  Day 01 - Challenge 1  ------------");
            string fichierDuProbleme = @".. / .. / .. / Files /AoC_D01_C1.txt";
            int[] donneesDuProbleme = Program.ConvertirFicherVersTableau(fichierDuProbleme);

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
    }
}
