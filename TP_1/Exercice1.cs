using System;

namespace TP_1
{
    public class Exercice1
    {
        public void Multiplication()
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    int resultat = i * j;
                    {
                        Console.WriteLine($"{i} * {j} = {resultat}");
                    }
                }
            }
            Console.Write("\n");
        }

        public void Odd_result()
        {
            Console.WriteLine("\n");
            for (int i = 1; i <= 10; i += 2)
            {
                for (int j = 1; j <= 10; j += 2)
                {
                    int resultat = i * j;
                    if (resultat % 2 != 0)
                    {
                        Console.WriteLine($"{i} * {j} = {resultat}");
                    }
                }
            }
            Console.Write("\n");
        }

        public void AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            for (int k = 0; k <= 10; k++)
            {
                int resultat = k * result;
                Console.WriteLine($"{k} * {result} = {resultat}");
            }
            Console.Write("\n");
        }
    }
}