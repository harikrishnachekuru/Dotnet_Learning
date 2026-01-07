//Palindrome check from given string 

namespace MyApp;

public static class Palindrome
{
    public static bool isPalindrome(string input)
    {
        if (string.IsNullOrEmpty(input))
            return true;

        int left = 0;
        int right = input.Length - 1;

        while(left < right)
        {
            if (input[left] != input[right])
                return false;

            left++;
            right--;
        }
        return true;
    }

    public static bool IsPalindromeLinq(string input)
    {
        var res = new string(input.Reverse().ToArray());
        return input == res;
    }
}