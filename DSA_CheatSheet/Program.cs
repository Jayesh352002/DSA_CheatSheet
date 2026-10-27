using DSA_CheatSheet.StringPrograms;

public class Program
{
    public static void Main(string[] args)
    {
        string revString = ReverseString.Reverse("HelloWorld");
        Console.WriteLine($"Reversed String: {revString}");

        bool isPalindrome = PalindromeString.IsStringPalindrome("madam");
        Console.WriteLine($"Is 'madam' a palindrome? {isPalindrome}");
    }
}