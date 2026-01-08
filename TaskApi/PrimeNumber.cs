namespace MyApp;

public static class PrimeNumber
{
    public static bool PrimeCheck(int num)
    {
        if (num <= 1)
            return false;

        for(int i = 2; i*i <= num; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    public static bool IsPrimeCheck(int num)
    {
        return num > 1 && !Enumerable.Range(2, (int)Math.Sqrt(num) - 1).Any(i => num % i == 0);
    }
}