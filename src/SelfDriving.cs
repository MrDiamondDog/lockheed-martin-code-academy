using System;

class SelfDriving
{
    static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCases; i++)
        {
            string data = Console.ReadLine();
            string[] split = data.Split(":");

            float speed = float.Parse(split[0]);
            float obstacleDist = float.Parse(split[1]);
            float timeUntilObstacle = obstacleDist / speed;

            if (timeUntilObstacle <= 1) Console.WriteLine("SWERVE");
            else if (timeUntilObstacle <= 5) Console.WriteLine("BRAKE");
            else Console.WriteLine("SAFE");
        }
    }
}