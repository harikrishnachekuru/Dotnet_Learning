// Count Number of characters from the given string 

namespace MyApp;

public static class CountChars
{
    public static Dictionary<char, int> CountingChars(string input)
    {
        Dictionary<char, int> counts = new Dictionary<char, int>();

        foreach(char c in input)
        {
            if (counts.ContainsKey(c))
            {
                counts[c]++;
            }
            else
            {
                counts[c] = 1;
            }
        }
        return counts;
    }

    public static Dictionary<char, int> CountCharactersLinq(string input)
    {
        return input
            .GroupBy(c => c)
            .ToDictionary(g => g.Key, g => g.Count());
    }

}