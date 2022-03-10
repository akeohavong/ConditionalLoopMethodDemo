using System;

namespace ConditionalLoopMethodDemo
{
    class MainClass
    {
        static void Main()
        {
            string fname = GetRequiredString("Enter you first name: ");
            Console.WriteLine($"First name: {fname}");

            Console.WriteLine($"The numbers 10, 23, 3 is {IsWithinRange(23, 10, 3)}");
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
            return (num % target < range);
        }
    }
}
