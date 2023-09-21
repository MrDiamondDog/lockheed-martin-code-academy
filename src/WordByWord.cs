using System;
using System.Linq;
using System.Collections.Generic;

public class WordByWord
{
    const string Punctuation = "`~!@#$%^&*()-=_+[]{}\\|;':\",./<>?";

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
                data = data.Replace(c.ToString(), "");
            }

            string[] words = data.Split(" ");

            List<int> individualLenghts = new List<int>();
            Dictionary<int, int> wordCounts = new Dictionary<int, int>();
            float average = 0;

            foreach (string word in words)
            {
                int len = word.Length;
                average += len;

                if (wordCounts.ContainsKey(len))
                {
                    wordCounts.TryGetValue(len, out int value);
                    wordCounts.Remove(len);
                    wordCounts.Add(len, ++value);
                }
                else
                {
                    if (len == 0) continue;
                    wordCounts.Add(len, 1);
                }
                individualLenghts.Add(len);
            }
            average /= individualLenghts.Count;

            individualLenghts.Sort();

            var keys = wordCounts.Keys;
            int[] keyArray = keys.ToArray();
            var values = wordCounts.Values;


            // MIN MAX
            int min = int.MaxValue;
            int max = int.MinValue;

            foreach (int value in values)
            {
                if (value < min) min = value;
                if (value > max) max = value;
            }

            int minKey = int.MaxValue;
            int maxKey = int.MinValue;

            foreach (int key in keyArray)
            {
                if (key < minKey) minKey = key;
                if (key > maxKey) maxKey = key;
            }


            // MODE
            List<int> modes = new List<int>();

            foreach (int key in keys)
            {
                wordCounts.TryGetValue(key, out int value);
                if (value == max) modes.Add(key);
            }

            modes.Sort();


            // MEDIAN
            float median;

            if (individualLenghts.Count % 2 == 0)
            {
                median = (individualLenghts[individualLenghts.Count / 2] + individualLenghts[individualLenghts.Count / 2 - 1]) / 2f;
            }
            else
            {
                median = individualLenghts[(individualLenghts.Count - 1) / 2];
            }

            // Console.WriteLine(string.Join(", ", individualLenghts));

            Console.WriteLine("Average: " + Format(average));
            Console.WriteLine("Median: " + Format(median));
            Console.WriteLine("Modes: " + string.Join(",", modes));
            Console.WriteLine("Range: " + (maxKey - minKey));

            for (int row = minKey; row < maxKey + 1; row++)
            {
                wordCounts.TryGetValue(row, out int val);
                Console.WriteLine((row < 10 ? " " : "") + row + "|" + Repeat('x', val));
            }
        }
    }

    static string Format(float val)
    {
        return string.Format("{0:0.0}", val).Replace(",", ".");
    }

    static string Repeat(char c, int amount)
    {
        string result = "";

        for (int i = 0; i < amount; i++)
        {
            result += c;
        }

        return result;
    }
}