using System;
using System.Collections.Generic;
using ArraySorting;

class Client
{
    static void Main(string[] args)
    {
        int[] originalArray = new int[999];

        FillTheArrayWithNumbers(originalArray);
        int[] sortedOddArray = FirstTask(originalArray);
        ShowArray(sortedOddArray);

        Console.WriteLine("------------------------------------------");

        FillTheArrayWithNumbers(originalArray);
        int[] sortedEvenArray = SecondTask(originalArray);
        ShowArray(sortedEvenArray);

        Console.WriteLine("------------------------------------------");

        FillTheArrayWithNumbers(originalArray);
        int[] sortedArray = ThirdTask(originalArray);
        ShowArray(sortedArray);
    }

    private static int[] FirstTask(int[] array)
    {
        EvenOddSpliter.LeaveOnlyOddNumbers(ref array);
        ArraySorter.SortIntArrayInIncrease(ref array);
        return array;
    }

    private static int[] SecondTask(int[] array)
    {
        EvenOddSpliter.LeaveOnlyEvenNumbers(ref array);
        ArraySorter.SortIntArrayInDecrease(ref array);
        return array;
    }

    private static int[] ThirdTask(int[] array)
    {
        int[] oddList = EvenOddSpliter.LeaveOnlyEvenNumbersAndReturnOddNumbers(ref array);

        ArraySorter.SortIntArrayInIncrease(ref array);
        ArraySorter.SortIntArrayInDecrease(ref oddList);

        List<int> evenNumbers = new(array);
        evenNumbers.AddRange(oddList);
        array = evenNumbers.ToArray();

        return array;
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
