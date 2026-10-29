using DSA_CheatSheet.ArrayPrograms;
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

        int[] arr = new int[] {10,20,30,40,50,60,70,80,90,100};
        int[] arr2 = new int[] { 110, 120, 130, 140, 150 };
        int target = 70;
        int index = BinarySearch.Search(arr, target);
        Console.WriteLine("Binary Search: Target {0} found at index {1}", target, index);

        Console.WriteLine("Largest Element in Array: " + LargestElementInArray.GetLargestElement(arr));
        Console.WriteLine("Second Largest Element in Array: " + SecondLargestInArray.GetSecondLargestElement(arr));
        Console.WriteLine("Third Largest Element in Array: " + ThirdLargestInArray.GetThirdLargestElement(arr));

        Console.WriteLine("Smallest Element in Array: " + SmallestElementInArray.GetSmallestElement(arr));
        Console.WriteLine("Second Smallest Element in Array: " + SecondSmallestInArray.GetSecondSmallestElement(arr));
        Console.WriteLine("Third Smallest Element in Array: " + ThirdSmallestInArray.GetThirdSmallestElement(arr));

        var res = TwoSum.GetTwoSumArray(arr,50);
        Console.WriteLine("Two Sum Solution: ");
        foreach(var item in res)
        {
            Console.Write(item + ", ");
        }

        var res1 = MergeArray.GetMergeSortedArray(arr, arr2);
        Console.WriteLine("Sorted Merge Array: ");
        foreach(var item in res1)
        {
            Console.Write(item + ", ");
        }
    }
}