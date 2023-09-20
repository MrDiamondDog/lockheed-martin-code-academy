using System;

public class Anagram
{
    static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCases; i++)
        {
            string data = Console.ReadLine();
            string[] split = data.Split("|");

            string word1 = split[0];
            string word2 = split[1];

            bool success = true;
            if (word1.Equals(word2))
            {
                Console.WriteLine(data + " = NOT AN ANAGRAM");
                continue;
            }
            foreach (char c in word1)
            {
                if (!success) break;

                if (word2.Contains(c))
                    word2 = word2.Remove(word2.IndexOf(c), 1);
                else
                {
                    Console.WriteLine(data + " = NOT AN ANAGRAM");
                    success = false;
                }
            }

            if (!success) continue;
            Console.WriteLine(data + " = ANAGRAM");
        }
    }
}