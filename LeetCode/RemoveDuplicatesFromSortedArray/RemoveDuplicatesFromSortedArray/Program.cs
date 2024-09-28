public class Solution
{

    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;

        int value = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[value])
            {
                value++;
                nums[value] = nums[i];
            }
        }

        return value + 1;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        int n = 0;
        Console.WriteLine("Enter the number:");
        n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        Solution solution = new Solution();
        Console.WriteLine(solution.RemoveDuplicates(nums));
        Console.ReadLine();
    }
}