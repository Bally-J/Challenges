using System;

namespace FirstFactorialApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate the Factroial");
            String response = String.Empty;
            while (response != "q")
            {
                Console.WriteLine("Provide number:");
                response = Console.ReadLine();
                long num = 0;
                if (long.TryParse(response, out num))
                {
                    Console.WriteLine($"Factorial is {CalculateFactorial(num)}");
                }
            }
        }


        static long CalculateFactorial(long num)
        {
            long val = 1;
            for (int i = 1; i <= num; i++)
            {
                val *= i;
            }

            return val;
        }
    }
}
