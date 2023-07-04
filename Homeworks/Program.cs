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

            pattern = "fox";
            Console.WriteLine(Regex.IsMatch(input,pattern)); // True

            input = "+38(050)1234567";
           string input2 = "+38(050)12345";
           string input3 = "+38(050)1234";
            pattern = @"\+38\(0\d{2}\)\d{5,7}"; // From 5 digits to 7
            Console.WriteLine(Regex.IsMatch(input,pattern)); // True
            Console.WriteLine(Regex.IsMatch(input2,pattern)); // True
            Console.WriteLine(Regex.IsMatch(input3,pattern)); // False

            string i1 = "Іваненко І.І.";
            string i2 = "Іваненко Іван Іванович";

            int firstI = (int)i1[0];
            int secondI = (int)i1[1];

            Console.WriteLine(firstI);
            Console.WriteLine(secondI);
        }
        
    }
}