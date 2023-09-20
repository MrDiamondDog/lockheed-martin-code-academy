using System;

public class WordByWord
{
    const string Punctuation = ".,;:!?";

    static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCases; i++)
        {
            int lines = int.Parse(Console.ReadLine());

            string data = "";
            for (int j = 0; j < lines; j++)
            {
                data += Console.ReadLine() + " ";
            }

            foreach (char c in Punctuation)
            {
                data.Replace(c, ' ');
            }

            string[] words = data.Split(" ");

            int median =
        }
    }
}