namespace MyApp;

public static class MissingNums
{
    public static int FindMissNum(int[] arr, int num)
    {
        int expectedSum = num * (num + 1) / 2;
        int actualSum = 0;

        for(int i =0; i < arr.Length; i++)
        {
            actualSum += arr[i];
        }

        return expectedSum - actualSum;
    }

    public static int FindMissLinq(int[] arr, int num)
    {
        int expectedSum = num * (num + 1) / 2;
        return expectedSum - arr.Sum();
    }
}