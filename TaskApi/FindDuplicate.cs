namespace MyApp;

public static class FindDuplicate
{
    public static void dupArr(int[] arr)
    {
        bool[] visited = new bool[arr.Length];

        for(int i = 0; i < arr.Length; i++)
        {
            if (visited[i]) continue;

            int count = 1;
            visited[i] = true;

            for (int j = i+1; j< arr.Length;  j++)
            {
                if(arr[j] == arr[i])
                {
                    visited[j] = true;
                    count++;
                }
            }

            if(count > 1)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}