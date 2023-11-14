using System;

class Program
{
    static void Main(string[] args)
    {
        int[] sampleArray = { 1, 5, 10, 15, 20, 25, 30 };

        Array arrayObject = new Array(sampleArray);

        int lessCount = arrayObject.Less(20);
        int greaterCount = arrayObject.Greater(10);

        Console.WriteLine($"Number of elements less than 20: {lessCount}");
        Console.WriteLine($"Number of elements greater than 10: {greaterCount}");

        arrayObject.ShowEven();
        arrayObject.ShowOdd();

        int distinctCountCount = arrayObject.CountDistinct(15);
        int equalCount = arrayObject.EqualToValue(15);
    }
}

interface ICalc
{
    int Less(int valueToCompare);
    int Greater(int valueToCompare);
}
interface IOutput2
{
    void ShowEven();
    void ShowOdd();
}
interface ICalc2
{
    int CountDistinct(int valueToCompare);
    int EqualToValue(int valueToCompare);
}

class Array : ICalc, IOutput2, ICalc2
{
    private int[] array;

    public Array(int[] array)
    {
        this.array = array;
    }

    public int Less(int valueToCompare)
    {
        int count = 0;
        foreach (var element in array)
        {
            if (element < valueToCompare)
            {
                count++;
            }
        }
        return count;
    }

    public int Greater(int valueToCompare)
    {
        int count = 0;
        foreach (var element in array)
        {
            if (element > valueToCompare)
            {
                count++;
            }
        }
        return count;
    }
    public void ShowEven()
    {
        System.Console.WriteLine("Even numbers: ");
        foreach (var element in array)
        {
            if (element % 2 == 0)
            {
                System.Console.Write(element + " ");
            }
        }
        System.Console.WriteLine();
    }
    public void ShowOdd()
    {
        System.Console.WriteLine("Odd numbers:");
        foreach (var element in array)
        {
            if (element % 2 != 0)
            {
                System.Console.Write(element + " ");
            }
        }
    }
    public int CountDistinct(int valueToCompare)
    {
        int count = 0;
        foreach (var element in array)
        {
            if (element != valueToCompare)
            {
                count++;
            }
        }
        return count;
    }

    public int EqualToValue(int valueToCompare)
    {
        int count = 0;
        foreach (var element in array)
        {
            if (element == valueToCompare)
            {
                count++;
            }
        }
        return count;
    }
}


