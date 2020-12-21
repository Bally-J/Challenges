using System;
namespace PalindromeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String response = "";
            while (response != "q")
            {
                Console.WriteLine("Enter value:");
                response = Console.ReadLine();

                Console.WriteLine("Palindrome calculated 1000 times, using String manipulation");
                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                for (int i = 0; i < 100000; i++)
                {
                    PalindromeDecending.FirstAttempt.PalindromeDescendant(response);
                }
                Console.WriteLine($"Is a Palindrome: {PalindromeDecending.FirstAttempt.PalindromeDescendant(response)}");
                watch.Stop();
                Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");


                watch.Reset();
                Console.WriteLine("Palindrome calculated 1000 times, using number calculation");
                watch.Start();
                for (int i = 0; i < 100000; i++)
                {
                    PalindromeDecending.SecondAttempt.PalindromeDescendant(Convert.ToInt32(response));
                }
                Console.WriteLine($"Is a Palindrome: {PalindromeDecending.SecondAttempt.PalindromeDescendant(Convert.ToInt32(response))}");
                watch.Stop();
                Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            }
        }
    }
}
