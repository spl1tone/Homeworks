using System.Text.RegularExpressions;

namespace Homeworks
{
    internal class Program
    {
        // Homework lesson-5

        static void Main (string[] args)
        {
            string input = "The quick brown fox jumps over the lazy dog";
            string pattern = "fox";
            Match match = Regex.Match (input, pattern);
            if (match.Success) {
                Console.WriteLine("Found {0} at position {1}", match.Value, match.Index);
            }
            else {
                Console.WriteLine("Not found");
            }
            pattern = @"\b\w{4}\b"; // over,lazy
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach(Match match1 in matches) {
                Console.WriteLine("Found {0} at position {1}", match1.Value, match1.Index);
            }

            pattern = @"\s"; // space
            string replacment = "_";
            string result = Regex.Replace(input, pattern, replacment);
            Console.WriteLine("Replace {0}",result);
        }
        
    }
}