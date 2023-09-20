using System;

class Addify
{
    static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCases; i++)
        {
            string data = Console.ReadLine();
            string[] split = data.Split(" ");

            int num1 = int.Parse(split[0]);
            int num2 = int.Parse(split[1]);

            Console.WriteLine($"{num1 + num2} {num1 * num2}");
        }
    }
}