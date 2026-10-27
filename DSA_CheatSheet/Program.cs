using DSA_CheatSheet.StringPrograms;

public class Program
{
    public static void Main(string[] args)
    {
        string revString = ReverseString.Reverse("HelloWorld");
        Console.WriteLine($"Reversed String: {revString}");

        bool isPalindrome = PalindromeString.IsStringPalindrome("madam");
        Console.WriteLine($"Is 'madam' a palindrome? {isPalindrome}");

        int vowelsCount = CountVowel.CountVowels("Hello World");
        Console.WriteLine($"Number of vowels in 'Hello World': {vowelsCount}");

        int charCount = CountChar.CountCharacter("Hello World", 'l');
        Console.WriteLine($"Number of occurrences of 'l' in 'Hello World': {charCount}");
    }
}