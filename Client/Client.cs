using System;
using System.Collections.Generic;
using ArraySorting;

class Client
{
    static void Main(string[] args)
    {
        int[] originalArray = new int[999];
        FillTheArrayWithNumbers(originalArray);

        List<int> originalList = new(originalArray);

        int[] sortedOddArray = FirstTask(originalList);
        ShowArray(sortedOddArray);

        Console.WriteLine("------------------------------------------");

        originalList = new(originalArray);
        int[] sortedEvenArray = SecondTask(originalList);
        ShowArray(sortedEvenArray);

        Console.WriteLine("------------------------------------------");

        originalList = new(originalArray);
        int[] sortedArray = ThirdTask(originalList);
        ShowArray(sortedArray);
    }

    private static int[] FirstTask(List<int> originalList)
    {
        List<int> oddList = new();
        oddList.AddRange(originalList);
        EvenOddSpliter.LeaveOnlyOddNumbers(oddList);
        ListSorter.SortIntArrayInIncrease(oddList);
        return oddList.ToArray();
    }

    private static int[] SecondTask(List<int> originalList)
    {
        List<int> evenList = new();
        evenList.AddRange(originalList);
        EvenOddSpliter.LeaveOnlyEvenNumbers(evenList);
        ListSorter.SortIntArrayInDecrease(evenList);
        return evenList.ToArray();
    }

    private static int[] ThirdTask(List<int> originalList)
    {
        List<int> eventList = new();
        eventList.AddRange(originalList);
        List<int> oddList = EvenOddSpliter.LeaveOnlyEvenNumbersAndReturnOddNumbers(eventList);

        ListSorter.SortIntArrayInIncrease(eventList);
        ListSorter.SortIntArrayInDecrease(oddList);

        eventList.AddRange(oddList);

        return eventList.ToArray();
    }

    static void FillTheArrayWithNumbers(int[] array)
    {
        Random random = new();
        for (int i = 0; i < array.Length; i++)
            array[i] = random.Next(-9999, 9999);
    }

    private static void ShowArray(int[] array)
    {
        foreach (int number in array)
            Console.WriteLine(number);
    }
}
