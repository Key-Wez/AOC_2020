using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2020
{
    class Day_05
    {
        public static void Challenge()
        {

            //Day05 - challenge 01
            Console.WriteLine("\n------------  Day 05 - Challenge 1  ------------");
            string fichierDuProblemeJour5 = @"../../../Files/AoC_D05_C1.txt";

            string[] DonneesDuProbleme = File.ReadAllLines(fichierDuProblemeJour5);
            //string test = DonneesDuProbleme[0];
            //string rowLTR = test.Substring(0, 7);
            //string colLTR = test.Substring(7, 3);

            //int row = Value(rowLTR);
            //int col = Value(colLTR);
            //int id = seatID(row, col);

            //Console.WriteLine(row + " " + col + " " + id);

            int HighestSeatID = 0;
            List<int> test = new List<int>();

            foreach (string ligne in DonneesDuProbleme)
            {
                string rowLetter = ligne.Substring(0, 7);
                string colLetter = ligne.Substring(7, 3);

                int seat = seatID(Value(rowLetter), Value(colLetter));

                if (seat > HighestSeatID)
                {
                    HighestSeatID = seat;
                }
                //Console.WriteLine(seat);

                test.Add(seat);
            }


            test.Sort();
            /*foreach (int seatValue in test)
            {
                Console.WriteLine(seatValue);
            }*/
            for(int i = 0; i < test.Count-1; i++)
            {
                if (test[i]+1 != test[i + 1])
                {
                    Console.WriteLine("Bris de sequence" + test[i]);
                }
            }



            Console.WriteLine("the highest seat ID is {0}", HighestSeatID);



            static int Value(string code)
            {
                int min = 0;
                int max = Convert.ToInt32(Math.Pow(2, code.Length));

                for (int i = 0; i < code.Length; i++)
                {
                    int puissance = Convert.ToInt32(Math.Pow(2, code.Length - i - 1));
                    //string x = code[i];

                    if (code[i] == 'F' || code[i] == 'L')
                    {
                        max = max - puissance;
                    }
                    else if (code[i] == 'B' || code[i] == 'R')
                    {
                        min = min + puissance;
                    }

                    //Console.WriteLine("min : {0}\tmax : {1}", min, max);
                }
                return min;
            }

            static int seatID(int row, int col)
            {
                return row * 8 + col;
            }


        }

    }
}
