using System.Collections.Generic;
using NUnit.Framework;

namespace Problem1.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestEmptyList()
        {
            var sorter = new Sorter();
            

            var list = new int[] {2, 8, 7, 1, 3, 5, 6, 4};
            sorter.QuickSort(list);

            Assert.AreEqual(new int[] {1, 2, 3, 4, 5, 6, 7, 8}, list);
        }
    }
}