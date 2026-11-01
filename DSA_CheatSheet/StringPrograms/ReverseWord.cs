using System.Text;

namespace DSA_CheatSheet.StringPrograms
{
    public class ReverseWord
    {
        public static string GetStringAfterReverseWord(string str)
        {
            string[] words = str.Split(' ');
            StringBuilder result = new StringBuilder();

            for(int i=words.Length - 1; i >= 0; i--)
            {
                result.Append(words[i]);
                if (i > 0)
                {
                    result.Append(" ");
                }
            }

            return result.ToString();
        }
    }
}
