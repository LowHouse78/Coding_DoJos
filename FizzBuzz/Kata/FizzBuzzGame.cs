using System.Collections.Generic;

namespace FizzBuzz.Kata
{
    public class FizzBuzzGame
    {
        public List<string> GetFizzBuzzFigures()
        {
            var result = new List<string>();
            for (int i = 1; i < 101; i++)
            {
                result.Add((i % 3 == 0 && i % 5 == 0 ? "FizzBuzz" :
                    i % 3 == 0 ? "Fizz" :
                    i % 5 == 0 ? "Buzz" : i.ToString()));
            }

            return result;
        }
    }
}
