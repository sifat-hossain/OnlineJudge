public class Solution
{
    public bool IsValid(string s)
    {
        var characterArray = new char[s.Length];
        int a = -1;
        var dictionary = new Dictionary<char, char>()
        {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };

        for (int i = 0; i < s.Length; i++)
        {
            if (!dictionary.ContainsKey(s[i]))
            {
                a++;
                characterArray[a] = s[i];
            }
            else if (a >= 0 && a < s.Length && dictionary[s[i]] == characterArray[a])
            {
                a--;
            }
            else
                return false;
        }
        return a == -1;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        string str = Console.ReadLine();
        Solution s = new Solution();
        Console.WriteLine(s.IsValid(str));
        Console.ReadLine();
    }
}
