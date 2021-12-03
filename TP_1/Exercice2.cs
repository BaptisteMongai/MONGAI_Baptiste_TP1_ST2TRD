using System;
using System.Collections.Generic;

namespace TP_1
{
    public class Exercice2
    {
        public void Prime()
        {
            for (int number = 0; number <=1000; number++)
            {
                if (IsPrime(number))
                {
                    Console.WriteLine(number);
                }
            }

            bool IsPrime(int number)
            {
                if (number <= 1) return false;
                if (number == 2) return true;
                if (number % 2 == 0) return false;

                var boundary = (int)Math.Floor(Math.Sqrt(number));
          
                for (int i = 3; i <= boundary; i += 2)
                    if (number % i == 0)
                        return false;
                
                return true;        
            }
            Console.Write("\n");
        }

        public int Fibonacci(int result)
        {
            if (result == 0) return 1;
            if (result == 1) return 1;
            return Fibonacci(result - 1) + Fibonacci(result - 2);
        }

        public int Factorial(int result)
        {
            if (result == 0) return 1;
            else return result * Factorial(result-1);
        }
    }
}