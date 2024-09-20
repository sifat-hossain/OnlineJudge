public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int b = 0, a = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if (nums.Contains(diff))
            {
                b = i;
                a = Array.IndexOf(nums, diff);
                if (a != b)
                {
                    int[] finalResult = [b, a];
                    return finalResult;
                }
            }
        }
        return null;
    }

    public static void Main(string[] args)
    {
        int n = 0;
        n = int.Parse(Console.ReadLine());

        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        int target = int.Parse(Console.ReadLine());

        Solution solution = new Solution();
        var result = solution.TwoSum(nums, target);
        Console.WriteLine("[" + string.Join(",", result) + "]");
    }
}