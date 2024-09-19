class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] training = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] learning = Console.ReadLine().Split().Select(int.Parse).ToArray();


        var arr = new (int training, int selfLearning)[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = (training[i], learning[i]);
        }


        int currentDay = 0;
        int maxCompletionDay = 0;

        foreach (var item in arr)
        {

            currentDay += item.training;

            int completionDay = currentDay + item.selfLearning;

            maxCompletionDay = Math.Max(maxCompletionDay, completionDay);
        }

        Console.WriteLine(maxCompletionDay + 1);
    }
}


//class Program
//{
//    static void Main()
//    {
//        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

//        List<int> traning = Console.ReadLine().TrimEnd().Split(' ').Take(arCount).Select(arTemp => Convert.ToInt32(arTemp)).ToList();

//        List<int> learning = Console.ReadLine().TrimEnd().Split(' ').Take(arCount).Select(arTemp => Convert.ToInt32(arTemp)).ToList();
//        List<int> arr = new List<int>();

//        int value = traning.Count;
//        int totalDays = 0;

//        for (int i = 0; i < value; i++)
//        {
//            if (i == 0)
//            {
//                arr.Add(traning[i] + learning[i]);
//            }
//            else
//            {
//                int sumTran = 0;
//                for (int j = 0; j < i; j++)
//                {

//                    sumTran += traning[j];
//                    /*arr.Add();*/
//                }
//                arr.Add(sumTran + traning[i] + learning[i]);
//            }
//        }      

//        totalDays = arr.Max();

//        Console.WriteLine(totalDays + 1);
//    }
//}