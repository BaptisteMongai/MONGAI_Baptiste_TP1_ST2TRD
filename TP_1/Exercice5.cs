using System;
using System.Collections.Generic;

namespace TP_1
{
    public class Exercice5
    {
        public void Chrismas_tree()
        {
            try
            {
                Console.WriteLine("Please enter the size of the tree:");
                int.TryParse(Console.ReadLine(), out var size);
            
                if (size < 3 || size > 20)
                {
                    Console.WriteLine("Please choose numbers between 3 and 20");
                    Environment.Exit(0);
                }
            
                Console.WriteLine("Do you want some decoration? \n(Please enter 1 for Yes or 2 for No)");
                int.TryParse(Console.ReadLine(), out var intDecoration);

                if (intDecoration != 1 && intDecoration != 2)
                {
                    throw new IndexOutOfRangeException();
                }

                if (intDecoration == 2)
                {
                    for (int i = 0; i < size; i++)
                    {
                        string branch = new String('*', i);
                        Console.WriteLine(branch.PadLeft(size) + "*" + branch);
                    }
                }
                else
                {
                    // Initialization
                    List<int> decoration_position = new List<int>();
                    int start = 1;
                    int spaces = size - 1;
                    int end = 3;
                    //70% of 'i' and 30% of 'i'
                    Random rnd = new Random();
                    string[] decoration =
                    {
                        "i", "o", "i", "o", "i",
                        "i", "i", "o", "o", "i", "i"
                    };
                    
                    // First line
                    Console.WriteLine("".PadLeft(size) + "*");
                    
                    // Lines in the middle
                    for (int a = 2; a <= size; a++)
                    {
                        for (int z = 1; z <= spaces; z++)
                        {
                            Console.Write(" ");
                        }

                        // Find the positions of the decoration
                        for (int b = start; b <= end; b += 3)
                        {
                            decoration_position.Add(b);
                        }

                        start = (start + 2) % 3;

                        for (int c = 1; c <= end; c++)
                        {
                            int decorationIndex = rnd.Next(decoration.Length);

                            if (decoration_position.Contains(c))
                            {
                                Console.Write(decoration[decorationIndex]);
                            }
                            else
                            {
                                Console.Write("*");
                            }
                        }

                        Console.Write("\n");
                        spaces--;
                        end += 2;
                        decoration_position = new List<int>();
                    }
                }
                
                // Last Line
                Console.WriteLine("|".PadLeft(size) + " " + "|");
            }
            // Exceptions
            catch (FormatException e)
            {
                Console.WriteLine("Check the information entered and retry please");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("You have not entered the correct amount of information");
            }
        }
    }
}