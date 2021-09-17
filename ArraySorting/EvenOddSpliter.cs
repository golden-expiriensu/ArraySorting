using System;
using System.Collections.Generic;

namespace ArraySorting
{
    public static class EvenOddSpliter
    {
        public static void LeaveOnlyEvenNumbers(ref int[] numberArray)
        {
            List<int> list = new(numberArray);
            list.RemoveAll((int i) => (i % 2) != 0);
            numberArray = list.ToArray();
        }

        public static void LeaveOnlyOddNumbers(ref int[] numberArray)
        {
            List<int> list = new(numberArray);
            list.RemoveAll((int i) => (i % 2) == 0);
            numberArray = list.ToArray();
        }

        public static int[] LeaveOnlyEvenNumbersAndReturnOddNumbers(ref int[] numberArray)
        {
            List<int> list = new(numberArray);
            static bool oddFinderDelegate(int i) => (i % 2) != 0;

            List<int> oddNumbers = list.FindAll(oddFinderDelegate);
            list.RemoveAll(oddFinderDelegate);
            numberArray = list.ToArray();

            return oddNumbers.ToArray();
        }
    }
}
