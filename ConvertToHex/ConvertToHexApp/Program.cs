using System;
using System.Linq;
using System.Text;

namespace ConvertToHexApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert To Hex");
            String input = "";
            while (input != "q")
            {
                input = Console.ReadLine();


                Console.WriteLine("HexToText calculated 1000000 times, using String manipulation");
                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                for (int i = 0; i < 1000000; i++)
                {
                    input.ConvertToHex();
                }
                Console.WriteLine($"Hex Value: {input.ConvertToHex()}");
                watch.Stop();
                Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
                Console.WriteLine();

                watch.Reset();
                Console.WriteLine("HexToText calculated 1000000 times, using Linq");
                watch.Start();
                for (int i = 0; i < 1000000; i++)
                {
                    input.ConvertToHex2();
                }
                Console.WriteLine($"Hex Value: {input.ConvertToHex2()}");
                watch.Stop();
                Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            }
        }
    }


    public static class HexConversion
    {
        public static String ConvertToHex(this String value)
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < value.Length; i++)
            {
                output.Append(Convert.ToString(value[i], 16)).Append(" ");
            }

            return output.ToString().ToLower().Trim();
        }

        public static String ConvertToHex2(this String value)
        {
            return String.Join(" ", value.Select(c => String.Format("{0:x2}", Convert.ToInt32(c))));
        }

        public static String ConvertToText(this String value)
        {
            String output = String.Empty;


            return output;
        }
    }

}
