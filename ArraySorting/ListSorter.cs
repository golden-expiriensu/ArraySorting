using System.Collections.Generic;

namespace ArraySorting
{
    public static class ListSorter
    {
        public static void SortIntArrayInIncrease(List<int> array)
        {
            array.Sort();
        }

        public static void SortIntArrayInDecrease(List<int> array)
        {
            array.Sort();
            array.Reverse();
        }
    }
}
