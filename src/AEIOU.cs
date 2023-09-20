using System;

public class AEIOU
{
    public const string Vowels = "aeiou";

    static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCases; i++)
        {
            string data = Console.ReadLine();

            int count = 0;
            for (int j = 0; j < data.Length; j++)
            {
                char current = data[j];

                if (Vowels.Contains(current)) count++;
            }

            Console.WriteLine(count);
        }
    }
}