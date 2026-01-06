namespace MyApp;

public static class SecondLargest
{
    public static void largestNum(int[] arr)
    {
        if (arr.Length < 2)
        {
            Console.WriteLine("Array must contain at least two elements.");
            return;
        }
        int first = int.MinValue;
        int second = int.MinValue;

        for(int i = 0; i< arr.Length; i++)
        {
            if (arr[i] > first)
            {
                second = first;
                first = arr[i];
            }
            else if (arr[i] > second && arr[i] != first)
            {
                second = arr[i];
            }
        }
        if (second == int.MinValue)
            Console.WriteLine("No second largest element found.");
        else
            Console.WriteLine($"Largest: {first}, Second Largest: {second}");
    }

    // Using Linq Methods 

    public static void largestSecond(int[] arr)
    {
        int secondLargest = arr.Distinct().OrderByDescending(x => x).Skip(1).First();
        Console.WriteLine(secondLargest);
    }
}