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
#if false
            string fichierDuProblemeJour4 = "files/test.txt";
#else
            string fichierDuProblemeJour4 = "files/AoC_D04.txt";
#endif         
            string[] DonneesDuPasseport = File.ReadAllLines(fichierDuProblemeJour4);
            int TotalPasseportValid = 0;

            bool byr = false;
            bool iyr = false;
            bool eyr = false;
            bool hgt = false;
            bool hcl = false;
            bool ecl = false;
            bool pid = false;
            bool cid = false;

            foreach (string ligne in DonneesDuPasseport)
            {
                

                if (ligne != "")
                {
                    string[] champs = ligne.Split();
                    foreach(string kvalue in champs)
                    {
                        switch (kvalue[0])
                        {
                            case 'b':
                                byr = true;
                                break;

                            case 'i':
                                iyr = true;
                                break;

                            case 'e':
                                if(kvalue[1] == 'y')
                                {
                                    eyr = true;
                                }
                                else
                                {
                                    ecl = true;
                                }
                                break;

                            case 'h':
                                if (kvalue[1] == 'g')
                                {
                                    hgt = true;
                                }
                                else
                                {
                                    hcl = true;
                                }
                                break;

                            case 'p':
                                pid = true;
                                break;
                            case 'c':
                                cid = true;
                                break;
                        }
                    }
                    
                }

                else
                {
                    if(byr && iyr && eyr && hgt && hcl && ecl && pid)
                    {
                    TotalPasseportValid++;
                    }

                    byr = false;
                    iyr = false;
                    eyr = false;
                    hgt = false;
                    hcl = false;
                    ecl = false;
                    pid = false;
                    cid = false;
                }


 
            }

            // Process the last line because no empty line.
            if (byr && iyr && eyr && hgt && hcl && ecl && pid)
            {
                TotalPasseportValid++;
            }

            Console.WriteLine("Le nombre de passeport valide = {0}", TotalPasseportValid);
            //la bonne reponse est 237


        




        }
    }
}
