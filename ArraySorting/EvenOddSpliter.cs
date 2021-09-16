using System;
using System.Collections.Generic;

namespace ArraySorting
{
    public static class EvenOddSpliter
    {
        public static void LeaveOnlyEvenNumbers(List<int> numberArray)
        {
            numberArray.RemoveAll((int i) => (i % 2) != 0);
        }

        public static void LeaveOnlyOddNumbers(List<int> numberArray)
        {
            numberArray.RemoveAll((int i) => (i % 2) == 0);
        }

        public static List<int> LeaveOnlyEvenNumbersAndReturnOddNumbers(List<int> numberArray)
        {
            Predicate<int> oddFinderDelegate = (int i) => (i % 2) != 0;
            List<int> oddNumbers = numberArray.FindAll(oddFinderDelegate);

            numberArray.RemoveAll(oddFinderDelegate);

            return oddNumbers;
        }
    }
}
