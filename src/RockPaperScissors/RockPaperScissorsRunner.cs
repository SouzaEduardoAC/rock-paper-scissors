using System;
using RPS.Game;

namespace RPS
{
    internal static class RockPaperScissorsRunner
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(new Tournament().Run());
        }
    }
}
