using NUnit.Framework;
using LinkedList.Kata;
using System.Linq;

namespace LinkedList.Tests
{
    [TestFixture]
    class LinkedListFixture
    {

        [Test]
        public void LinkedListCount_CountIsOneAfterFirstAdding()
        {
            var linkedList = new LinkedList<int>();

            linkedList.Add(5);

            var count = linkedList.Count;
            Assert.AreEqual(count,1);
        }

        [TestCase(1,5)]
        [TestCase(2,5,15)]
        [TestCase(3,5,15,20)]
        public void LinkedListCount_CountIncreasesWithOneAfterAdding(int paramCount, params int[] figures)
        {
            var linkedList = new LinkedList<int>();

            foreach (var figure in figures)
            {
                linkedList.Add(figure);
            }
            var listCount = linkedList.Count;
            
            Assert.AreEqual(listCount, paramCount);
        }

        [TestCase(0)]
        [TestCase(0, 1)]
        [TestCase(0, 1, 2)]
        [TestCase(0, 1, 2, 3)]
        [TestCase(0, 1, 2, 3, 4)]
        public void LinkedListIndexer_IndexIsCorrectAfterAdding(params int[] figures)
        {
            var linkedList = new LinkedList<int>();

            foreach (var figure in figures)
            {
                linkedList.Add(figure);
            }

            var maxFigure = figures.Max();
            var item = linkedList[maxFigure];

            Assert.AreEqual(maxFigure, item);

        }


        [TestCase(0,1,2)]
        public void LinkedListIndexer_IndexSetter(params int[] figures)
        {

            var linkedList = new LinkedList<int>(){0,0,0};

            foreach (var figure in figures)
            {
                linkedList[figure] = figure;
            }

            for (int i = 0; i < figures.Count(); i++)
            {
                Assert.AreEqual(i, linkedList[i]);
            }
        }
    }
}
