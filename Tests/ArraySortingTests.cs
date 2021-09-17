using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArraySorting;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class ArraySortingTests
    {
        [TestMethod]
        public void TestSortingToIncrease()
        {
            int[] processedList = { 4, 6, -7, 9, -10, 89, 24 };
            int[] expectedList = { -10, -7, 4, 6, 9, 24, 89 };

            ArraySorter.SortIntArrayInIncrease(ref processedList);

            Assert.IsTrue(expectedList.SequenceEqual(processedList));
        }

        [TestMethod]
        public void TestSortingToDecrease()
        {
            int[] processedList = { 4, 6, -7, 9, -10, 89, 24 };
            int[] expectedList = { 89, 24, 9, 6, 4, -7, -10 };

            ArraySorter.SortIntArrayInDecrease(ref processedList);

            Assert.IsTrue(expectedList.SequenceEqual(processedList));
        }
    }
}
