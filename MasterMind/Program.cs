using System;
using ArcadeModels;

namespace MasterMind
{
    //The program should select 2 colors at random from(Red, Yellow and Blue). The colors can repeat.
    //The program should then prompt the user for their guess.
    //The program should then print a hint to the user if they did not guess correctly:
        //"0-0" if the user did not guess the correct colors at all
        //"1-0" if they guessed one of the colors correctly but not at the correct position
        //"1-1" if they guessed one of the colors correctly at the correct position
        //"2-0" if they guessed both colors correctly but at the wrong positions
    public class MasterMind : ArcadeGame
    {
        private string[] _colors = new string[] { "red", "yellow", "blue" };
        private string _color1;
        private string _color2;

        private void _initGame()
        {
            var rand = new Random();
            var index1 = rand.Next(0, 3);
            var index2 = rand.Next(0, 3);

            _color1 = _colors[index1];
            _color2 = _colors[index2];
        }

        private bool _checkGuess(string guess)
        {
            var colorsCorrect = 0;
            var positionsCorrect = 0;
            
            if (guess.Contains(_color1)) colorsCorrect++;
            if (guess.Contains(_color2)) colorsCorrect++;
            
            var guesses = guess.Split(' ');
            if (guesses[0] == _color1) positionsCorrect++;
            if (guesses[1] == _color2) positionsCorrect++;
            
            if (colorsCorrect == 2 && colorsCorrect == 2)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Your hint is " + colorsCorrect + "-" + positionsCorrect);
                return false;
            }
        }

        public MasterMind()
        {
            _initGame();
        }

        public void Play()
        {
            var guessCount = 0;
            while(guessCount < 5)
            {
                Console.WriteLine("Enter your guess:");
                if(_checkGuess(Console.ReadLine().ToLower()))
                {
                    Console.WriteLine("You won!!");
                    break;
                } else
                {
                    guessCount++;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var game = new MasterMind();
            game.Play();
            Console.ReadLine();
        }
    }
}
