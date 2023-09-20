using System;

class HelloWorld
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        string result = "";
        for (int i = 0; i < num; i++)
        {
            result += Console.ReadLine();
            if (i != num - 1) result += "\n";
        }

        Console.WriteLine(result);
    }
}