using System;

namespace TP_1
{
    public class Exercice3
    {
        public void Try_catch()
        {
            for (int x = -3; x<=3; x++)
            {
                int result = 0;
                try
                {
                    result = 10 / (x * x - 4);
                    Console.WriteLine(result);

                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Division by zero");
                }
            }
            Console.Write("\n");
        }
    }
}