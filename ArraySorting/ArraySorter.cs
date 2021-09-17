using System.Collections.Generic;

namespace ArraySorting
{
    public static class ArraySorter
    {
        public static void SortIntArrayInIncrease(ref int[] array)
        {
            List<int> list = new(array);
            list.Sort();
            array = list.ToArray();
        }

        public static void SortIntArrayInDecrease(ref int[] array)
        {
            List<int> list = new(array);
            list.Sort();
            list.Reverse();
            array = list.ToArray();
        }
    }
}
