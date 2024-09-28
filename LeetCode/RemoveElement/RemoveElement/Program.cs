public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int j = 0; // Pointer for the position to place elements not equal to val

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[j] = nums[i];
                j++;
            }
        }

        return j;
        //int removeItem = 0;
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    if (nums[i] == val)
        //    {
        //        nums[i] = int.Parse(" ");
        //        removeItem = i++;
        //    }
        //}
        //return removeItem;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        int n = 0;
        Console.WriteLine("enter the amount of arr 1: ");
        n = int.Parse(Console.ReadLine());
        int[] arr1 = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }

        int val = 0;
        Console.WriteLine("enter the value: ");
        val = int.Parse(Console.ReadLine());

        Solution solution = new Solution();
        Console.WriteLine(solution.RemoveElement(arr1, val));
        Console.ReadLine();

    }
}
