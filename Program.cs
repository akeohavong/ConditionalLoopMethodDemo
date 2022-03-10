using System;

namespace ConditionalLoopMethodDemo
{
    class MainClass
    {
        static void Main()

        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter a target number: ");
            int targetNum = int.Parse(Console.ReadLine());
            Console.Write("Enter a range: ");
            int range = int.Parse(Console.ReadLine());

            Console.WriteLine($"{IsWithinRange(number, targetNum, range)}");

            string fname = GetRequiredString("Enter you first name: ");
            Console.WriteLine($"First name: {fname}");

            Console.WriteLine("Good job!");

        }

        private static string GetRequiredString(string prompt)
        {
            string input = "";

            while (string.IsNullOrEmpty(input)) {
                Console.Write(prompt);
                input = Console.ReadLine();

            }
            return input;
        }

        //access modifier - static(no not) - return type - name (params in here)
        private static bool IsWithinRange(int num, int target, int range)
        {
         
            return (num % target <= range);
        }
    }
}
