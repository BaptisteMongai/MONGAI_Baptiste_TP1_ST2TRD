using System;
using System.Collections.Generic;

namespace TP_1
{
    public class Exercice4
    {
        public void Square()
        {
            Console.WriteLine("Please enter N and M :");
            //Read line, and split it by whitespace into an array of strings
            string[] tokens = Console.ReadLine().Split();
            try
            {
                //If there is not exactly 2 numbers -> exception
                if (tokens.Length != 2)
                {
                    throw new IndexOutOfRangeException();
                }
                
                //we get n and m
                int n = int.Parse(tokens[0]);
                int m = int.Parse(tokens[1]);
                
                // If n or m is not in the range -> error message -> exit 
                if (n < 1 || n > 1000 || m < 1 || m > 1000)
                {
                    Console.WriteLine("Please choose numbers between 1 and 1000");
                    Environment.Exit(0);
                }
                
                int number_of_bars_on_x = m - 2;  // Without the zeros in the corners
                int number_of_bars_on_y = n - 2;
                
                // For the following code I can't have a negative number
                if (number_of_bars_on_x < 0)
                {
                    number_of_bars_on_x = 0;
                }

                if (number_of_bars_on_y < 0)
                {
                    number_of_bars_on_y = 0;
                }

                // Initialization
                List<int> stars_position = new List<int>();
                int start = 1;

                // First row
                string horizontal_lines = new String('-', number_of_bars_on_y);
                if (n > 1)
                {
                    Console.WriteLine($"0{horizontal_lines}0");
                }
                else if (n == 1)
                {
                    Console.WriteLine($"0{horizontal_lines}");
                }
                else
                {
                    Console.WriteLine("");
                }

                // The lines in the middle
                for (int a = 1; a <= number_of_bars_on_x; a++)
                {
                    if (n > 1)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.WriteLine("|");
                    }
                    
                    // Find the positions of the stars
                    for (int b = start; b <= number_of_bars_on_y; b += 3)
                    {
                        stars_position.Add(b);
                    }
                    start = (start + 1) % 3;
                    
                    for (int c = 1; c <= number_of_bars_on_y; c++)
                    {
                        if (stars_position.Contains(c))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    if (n > 1)
                    {
                        Console.WriteLine("|");
                    }

                    stars_position = new List<int>();
                }
                
                // Last row
                if (n > 1 && m > 1)
                {
                    Console.Write($"0{horizontal_lines}0");
                }
                else if (n == 1 && m > 1)
                {
                    Console.Write($"0{horizontal_lines}");
                }
                else
                {
                    Console.Write("");
                }
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