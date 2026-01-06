namespace MyApp;

public static class RemoveDuplicates
{
    public static void Removedup(int[] arr)
    {
        HashSet<int> seen = new HashSet<int>();
        List<int> result = new List<int>();

        foreach(int x in arr)
        {
            if (seen.Add(x))
                result.Add(x);
        }

        foreach(int x in result)
        {
            Console.Write(x + " ");
        }
    }

    public static void RmvDup(int[] arr)
    {
        var result = arr.Distinct();

        Console.WriteLine(string.Join(" ", result));
    }
}