using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2020.Challenges
{
    class Day_04b
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
                    foreach (string kvalue in champs)
                    {
                        string split = kvalue.Split(':')[1];

                        switch (kvalue[0])
                        {
                            case 'b':
                                {
                                    byr = int.TryParse(split, out int annee) && annee >= 1920 && annee <= 2002;
                                }
                                break;

                            case 'i':
                                {
                                    iyr = int.TryParse(split, out int annee) && annee >= 2010 && annee <= 2020;
                                }
                                break;

                            case 'e':
                                if (kvalue[1] == 'y')
                                {
                                    eyr = int.TryParse(split, out int annee) && annee >= 2020 && annee <= 2030;
                                }
                                else
                                {
                                    string[] EyeColors = { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };
                                    foreach (string clr in EyeColors)
                                    {
                                        if (split == clr)
                                        {
                                            ecl = true;
                                            break;
                                        }
                                    }
                                }
                                break;

                            case 'h':
                                if (kvalue[1] == 'g')
                                {
                                    if (split.Substring(split.Length - 2, 2) == "cm")
                                    {
                                        hgt = int.TryParse(split.Substring(0, split.Length - 2), out int height) && height >= 150 && height <= 193;
                                    }
                                    else if(split.Substring(split.Length - 2, 2) == "in")
                                    {
                                        hgt = int.TryParse(split.Substring(0, split.Length - 2), out int height) && height >= 59 && height <= 76;
                                    }
                                }
                                else
                                {
                                    if(split[0] == '#' && split.Length == 7)
                                    {
                                        hcl = true;

                                        for (int i = 1; i< 7; i++)
                                        {
                                            bool isValid = (split[i] >= '0' && split[i] <= '9') || (split[i] >= 'a' && split[i] <= 'f');
                                            if (!isValid)
                                            {
                                                hcl = false;
                                            }
                                        }
                                    }
                                    
                                }
                                break;

                            case 'p':
                                {
                                    pid = (int.TryParse(split, out int value) && split.Length == 9);
                                }
                                break;
                            case 'c':
                                cid = true;
                                break;
                        }
                    }

                }

                else
                {
                    if (byr && iyr && eyr && hgt && hcl && ecl && pid)
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
