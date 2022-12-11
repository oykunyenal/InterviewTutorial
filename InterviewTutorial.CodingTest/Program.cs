// See https://aka.ms/new-console-template for more information

using static System.Net.Mime.MediaTypeNames;

public class Program
{

    class Solution
    {
        public int solution(string[] A)
        {

            string concated = "";

            foreach (string s in A)
            {
                string result = concated + s;
                foreach (char c in s)
                {
                    if (result.Count(ch => ch == c) > 1)
                    {
                        break;
                    }
                }
                concated = result;
            }

            return concated.Length;
        }
    }

    public static void Main(string[] args)
    {
     
        var solutionObject = new Solution();

        string[] exmp1 = { "co", "dil", "ity" };
        string[] exmp2 = { "potato", "kayak", "banana" };
        string[] exmp3 = { "eva", "jqw", "tyn", "jan" };

        Console.WriteLine(" ---- ->" + solutionObject.solution(exmp2));
    }
}