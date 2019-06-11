using System;
using System.Collections.Generic;
using ArcadeModels;

namespace Arcade
{
    class Program
    {
        private static Dictionary<string, ArcadeGame> _games = new Dictionary<string, ArcadeGame>()
        {
            { "tower", new TowerOfHanoi.TowerOfHanoi() },
            { "mastermind", new MasterMind.MasterMind() }
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a game to play:");
            var gameChoice = Console.ReadLine();
            ArcadeGame gameToPlay = _games[gameChoice];
            
            gameToPlay.Play();
        }
    }
}
