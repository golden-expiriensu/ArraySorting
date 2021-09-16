using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ArraySorting;
using System.Linq;

namespace ArraySortingTests
{
    [TestClass]
    public class SortingTests
    {
        [TestMethod]
        public void TestSortingToIncrease()
        {
            List<int> processedList = new() { 4, 6, -7, 9, -10, 89, 24 };
            List<int> expectedList = new() { -10, -7, 4, 6, 9, 24, 89 };

            ListSorter.SortIntArrayInIncrease(processedList);

            Assert.IsTrue(expectedList.SequenceEqual(processedList));
        }

        [TestMethod]
        public void TestSortingToDecrease()
        {
            List<int> processedList = new() { 4, 6, -7, 9, -10, 89, 24 };
            List<int> expectedList = new() { 89, 24, 9, 6, 4, -7, -10 };

            ListSorter.SortIntArrayInDecrease(processedList);

            Assert.IsTrue(expectedList.SequenceEqual(processedList));
        }
    }
}
