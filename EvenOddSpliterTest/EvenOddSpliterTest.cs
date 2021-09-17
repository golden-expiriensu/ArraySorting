using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArraySorting;
using System.Linq;

namespace ArraySortingTests
{
    [TestClass]
    public class EvenOddSpliterTest
    {
        [TestMethod]
        public void TestEvenArrayCreating()
        {
            int[] processedList = { 4, 6, -7, 9, -10, 89, 24 };
            int[] expectedList = { 4, 6, -10, 24 };

            EvenOddSpliter.LeaveOnlyEvenNumbers(ref processedList);

            Assert.IsTrue(expectedList.SequenceEqual(processedList));
        }

        [TestMethod]
        public void TestOddArrayCreating()
        {
            int[] processedList = { 4, 6, -7, 9, -10, 89, 24 };
            int[] expectedList = { -7, 9, 89 };

            EvenOddSpliter.LeaveOnlyOddNumbers(ref processedList);

            Assert.IsTrue(expectedList.SequenceEqual(processedList));
        }

        [TestMethod]
        public void TestOddAndEvenArraySpliting()
        {
            int[] processedList = { 4, 6, -7, 9, -10, 89, 24 };
            int[] oddList = { -7, 9, 89 };
            int[] evenList = { 4, 6, -10, 24 };

            int[] newOddList = EvenOddSpliter.LeaveOnlyEvenNumbersAndReturnOddNumbers(ref processedList);

            Assert.IsTrue(oddList.SequenceEqual(newOddList));
            Assert.IsTrue(evenList.SequenceEqual(processedList));
        }
    }
}
