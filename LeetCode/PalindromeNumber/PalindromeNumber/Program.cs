public class Solution
{
    public bool IsPalindrome(int x)
    {
        int reverse = 0;
        int val = x;
        if (val < 0) return false;
        else
        {
            while (val != 0)
            {
                reverse = 10 * reverse + (val % 10);
                val = val / 10;
            }
            if (reverse == x)
            {
                return true;
            }
            return false;
        }
    }


}

class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        int x = 0;
        x = int.Parse(Console.ReadLine());
        Console.WriteLine(s.IsPalindrome(x));
        Console.ReadLine();
    }
}
