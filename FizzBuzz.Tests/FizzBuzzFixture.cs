using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzFixture
    {
        [TestCase]
        public void MultipleOf3MustBeFizz()
        {
            var fizzBuzzGame = new Kata.FizzBuzzGame();

            var resultList = fizzBuzzGame.GetFizzBuzzFigures();

            int index = 1;
            foreach (var item in resultList)
            {
                if (index % 3 == 0 && (index % 5 != 0))
                {
                    Assert.That(item == "Fizz");
                }
                index++;
            }
        }

        [TestCase]
        public void MultipleOf5MustBeBuzz()
        {
            var fizzBuzzGame = new Kata.FizzBuzzGame();

            var resultList = fizzBuzzGame.GetFizzBuzzFigures();

            int index = 1;
            foreach (var item in resultList)
            {
                if (index % 5 == 0 && (index % 3 != 0))
                {
                    Assert.That(item == "Buzz");
                }
                index++;
            }
        }

        [TestCase]
        public void MultipleOf5AndOf3MustBeFizzBuzz()
        {
            var fizzBuzzGame = new Kata.FizzBuzzGame();

            var resultList = fizzBuzzGame.GetFizzBuzzFigures();

            int index = 1;
            foreach (var item in resultList)
            {
                if (index % 5 == 0 && index % 3 == 0)
                {
                    Assert.That(item == "FizzBuzz");
                }
                index++;
            }
        }

    }
}
