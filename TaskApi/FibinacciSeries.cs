//Fibinacci series finding Nth Occurences

namespace MyApp;

public static class FibinacciSeries
{
    public static int series(int num)
    {
        if(num <= 1)
        {
            return num;
        }

        int a = 0,b = 1;
        for(int i = 2; i<=num; i++)
        {
            int next = a + b;
            a = b;
            b = next;
        }
        return b;
    }
}