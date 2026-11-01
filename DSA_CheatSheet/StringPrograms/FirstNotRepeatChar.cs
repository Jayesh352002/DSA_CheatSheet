namespace DSA_CheatSheet.StringPrograms
{
    public class FirstNotRepeatChar
    {
        public static char GetFirstNonRepeatChar(string str)
        {
            str = str.ToLower();
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                charCount[str[i]] = charCount.ContainsKey(str[i]) ? charCount[str[i]] + 1 : 1;
            }

            foreach (var c in str)
            {
                if (charCount[c] == 1)
                {
                    return c;
                }
            }

            return '\0'; // Return null character if no non-repeating character is found
        }
    }
}
