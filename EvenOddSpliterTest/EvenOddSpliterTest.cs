using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ArraySorting;
using System.Linq;

namespace ArraySortingTests
{
    [TestClass]
    public class EvenOddSpliterTest
    {
        [TestMethod]
        public void TestEvenListCreating()
        {
            List<int> processedList = new() { 4, 6, -7, 9, -10, 89, 24 };
            List<int> expectedList = new() { 4, 6, -10, 24 };

            EvenOddSpliter.LeaveOnlyEvenNumbers(processedList);

            Assert.IsTrue(expectedList.SequenceEqual(processedList));
        }

        [TestMethod]
        public void TestOddListCreating()
        {
            List<int> processedList = new() { 4, 6, -7, 9, -10, 89, 24 };
            List<int> expectedList = new() { -7, 9, 89 };

            EvenOddSpliter.LeaveOnlyOddNumbers(processedList);

            Assert.IsTrue(expectedList.SequenceEqual(processedList));
        }

        [TestMethod]
        public void TestOddAndEvenListSpliting()
        {
            List<int> processedList = new() { 4, 6, -7, 9, -10, 89, 24 };
            List<int> oddList = new() { -7, 9, 89 };
            List<int> evenList = new() { 4, 6, -10, 24 };

            List<int> newOddList = EvenOddSpliter.LeaveOnlyEvenNumbersAndReturnOddNumbers(processedList);

            Assert.IsTrue(oddList.SequenceEqual(newOddList));
            Assert.IsTrue(evenList.SequenceEqual(processedList));
        }
    }
}
