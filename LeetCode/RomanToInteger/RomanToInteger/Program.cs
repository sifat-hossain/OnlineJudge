public class Solution
{
    public int RomanToInt(string s)
    {
        int finalResult = 0;
        var map = new Dictionary<char, int>()
        {
            {'I', 1 },
            {'V', 5 },
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M',1000}
        };
        char[] charArray = s.ToCharArray();
        for (int i = 0; i < charArray.Length; i++)
        {
            if (i + 1 < charArray.Length)
            {
                int a = map[charArray[i]];
                int b = map[charArray[i + 1]];
                if (a < b)
                {
                    finalResult += b - a;
                    i += 1;
                }
                else
                {
                    finalResult += a;
                }
            }
            else
            {
                finalResult += map[charArray[i]];
            }
        }
        return finalResult;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        string s = Console.ReadLine();
        Console.WriteLine(solution.RomanToInt(s));
        Console.ReadLine();
    }
}
