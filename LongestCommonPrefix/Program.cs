//public class Solution
//{
//    public string LongestCommonPrefix(string[] strs)
//    {
//        string prefix = "";
//        if (strs.Length == 1) return strs[0];
//        for (int i = 0; i < strs[0].Length; i++)
//        {
//            for (int j = 1; j < strs.Length; j++)
//            {
//                if (i >= strs[j].Length || strs[j][i] != strs[0][i])
//                {
//                    return prefix;
//                }
//            }
//            prefix = prefix + strs[0][i];
//        }
//        return prefix;
//    }
//}
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        var l = 0;
        var currPrefix = strs[0];
        while (l < strs.Length)
        {
            var currWord = strs[l];
            if (currWord != currPrefix)
            {
                var prefix = FindPrefix(currWord, currPrefix);
                currPrefix = prefix;
            }

            l++;
        }

        return currPrefix;
    }

    public string FindPrefix(string word, string prefix)
    {
        var r = prefix.Length - 1;
        while (r >= 0)
        {
            if (!word.StartsWith(prefix))
            {
                prefix = prefix.Remove(r);
                r--;
            }
            else
            {
                return prefix;
            }

        }

        return "";
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Eneter string amouint: ");
        int n = int.Parse(Console.ReadLine());

        string[] str = new string[n];
        for (int i = 0; i < n; i++)
        {
            str[i] = Console.ReadLine();
        }
        Solution solution = new Solution();
        Console.WriteLine(solution.LongestCommonPrefix(str));
        Console.ReadLine();

    }
}