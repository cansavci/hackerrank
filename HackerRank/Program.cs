using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            // For classes that have direct result output.
            var result = CountingValleys.solution(12, "DDUUDDUDUUUD");
            // JumpingOnTheClouds.solution(new[] { 0, 0, 1, 0, 0, 1,0 });
            // NumberLineJump.solution(0, 2, 5, 3);
            // RepeatedString.solution("a", 1000000000000);
            // SockMerchant.solution(9, new [] { 10, 20, 20, 10, 10, 30, 50, 10, 20 });
            // HurdleRace.solution(4, new [] { 1, 6, 3, 5, 2});
            // CatsAndAMouse.solution(2, 5, 4);
            // BreakingTheRecords.solution(new [] { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 });
            // BirthdayCakeCandles.solution(new List<int> { 3, 1, 2, 3 });
            // TimeConversion.solution("07:05:45PM");
            // DiagonalDifference.solution(new List<List<int>> { 
            //     new List<int> { 11, 2, 4 }, 
            //     new List<int> { 4, 5, 6 }, 
            //     new List<int> { 10, 8, -12} });
            // CompareTheTriplets.solution(new List<int> { 1, 2, 3}, new List<int> {3, 2, 1});
            
            Console.WriteLine("Result is => " + JsonConvert.SerializeObject(result));

            // For classes that have result output differently.
            // ExtraLongFactorials.solution(25);
            // AppleAndOrange.solution(7, 10, 4, 12, new []{ 2, 3, -4 }, new []{ 3, -2, -4});
            // ElectronicShop.Main(args);
            // GradingStudents.Main(args);
            // MiniMaxSum.solution(new [] { 1, 2, 3, 4, 5});
            // Staircase.solution(100);
            // PlusMinus.solution(new [] { -4, 3, -9, 0, 4, 1 });

            Console.ReadLine();
        }
    }
}
