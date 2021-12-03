using System;

namespace TP_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Exercice1 exercice1 = new Exercice1();
            exercice1.Multiplication();
            exercice1.Odd_result();
            exercice1.AskUserForParameter();
            
            Exercice2 exercice2 = new Exercice2();
            exercice2.Prime();
            
            Console.WriteLine("What number of the Fibonacci sequence do you want?");
            int.TryParse(Console.ReadLine(), out var result);
            Console.WriteLine("F({0}) = {1}\n", result, exercice2.Fibonacci(result));  
            
            Console.WriteLine("Factorial of:");
            int.TryParse(Console.ReadLine(), out var result2);
            Console.WriteLine("{0}! = {1} \n", result2, exercice2.Factorial(result2));

            Exercice3 exercice3 = new Exercice3();
            exercice3.Try_catch();
            
            Exercice4 exercice4 = new Exercice4();
            exercice4.Square();
            
            Exercice5 exercice5 = new Exercice5();
            exercice5.Chrismas_tree();
        }
    }
    //PadLeft() pour le sapin de noel 
}