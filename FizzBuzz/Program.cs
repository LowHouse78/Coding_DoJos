using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fizzBuzzGame = new Kata.FizzBuzzGame();
            foreach (var item in fizzBuzzGame.GetFizzBuzzFigures() ?? new List<string>())
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
