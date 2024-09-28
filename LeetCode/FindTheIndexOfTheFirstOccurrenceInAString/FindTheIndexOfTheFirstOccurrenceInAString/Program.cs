class Program
{
    public int StrStr(string haystack, string needle)
    {
        int M = needle.Length;
        int N = haystack.Length;


        for (int i = 0; i <= N - M; i++)
        {
            int j = 0;

            for (j = 0; j < M; j++)
            {
                if (haystack[i + j] != needle[j])
                    break;
            }

            if (j == M)
            {
                return i;
            }
        }
        return -1;
    }
}
class GFG
{
    // Driver's code
    public static void Main()
    {
        string txt = "leetcode";
        string pat = "leeto";

        Program program = new Program();

        Console.WriteLine(program.StrStr(txt, pat));
        Console.ReadLine();
    }
}
