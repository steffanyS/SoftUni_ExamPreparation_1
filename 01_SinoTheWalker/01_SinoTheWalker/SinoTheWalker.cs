using System;
using System.Linq;
using System.Numerics;

namespace _01_SinoTheWalker
{
    class SinoTheWalker
    {
        static void Main(string[] args)
        {
            var startTime = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
            DateTime leaveTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, startTime[0], startTime[1], startTime[2]);
            BigInteger steps = BigInteger.Parse(Console.ReadLine());
            BigInteger stepTime = BigInteger.Parse(Console.ReadLine());

            //long secondsToAdd = stepTime * steps;
            //var result = leaveTime.AddSeconds(secondsToAdd);
            //Console.WriteLine("Time Arrival: {0:00}:{1:00}:{2:00}", result.Hour, result.Minute, result.Second);

            BigInteger secondsToAdd = stepTime * steps;
            BigInteger initialSeconds = leaveTime.Second + leaveTime.Minute * 60 + leaveTime.Hour * 60 * 60 + secondsToAdd;
            ulong totalSeconds = (ulong)initialSeconds;

            var seconds = totalSeconds % 60;
            var minutes = totalSeconds / 60 % 60;
            var hours = totalSeconds / 60 / 60 % 24;

            Console.WriteLine("Time Arrival: {0:00}:{1:00}:{2:00}", hours, minutes, seconds);
        }
    }
}
