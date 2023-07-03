namespace Homeworks
{
    internal class Program
    {
        // Homework lesson-7

        static void Main (string[] args)
        {
            bool isCompare = Compare("Test", "Tast");
            Console.WriteLine($"IsCompare: {isCompare}"); // False

            int alphabetics, digits, special = 0;
            Analyze("Test1234$",out alphabetics,out digits, out special);
            Console.WriteLine($"Alphabetics: {alphabetics} \nDigits: {digits} \nSpecial: {special}");

            string sorted = Sort("Hello");
            Console.WriteLine($"Sorted: {sorted}");
        }

        static bool Compare (string str1, string str2)
        {
            if(str1.Length != str2.Length) return false;

            for(int i = 0; i < str1.Length; i++) {
                if (str1[i] != str2[i]) break; return false;
            }

            return true;
        }

        static void Analyze(string str, out int alphabetic, out int digits, out int special)
        {
            alphabetic = 0; 
            digits = 0; 
            special = 0; 

            for(int i = 0; i < str.Length; i++) {
                if (char.IsLetter(str[i])) {
                    alphabetic++;
                }
               else if (char.IsDigit(str[i])) {
                    digits++;
                }
                else {
                    special++;
                }
            }
        }

        static string Sort(string str)
        {
            var sorted = str.OrderBy(x => x);
            return new string(sorted.ToArray());
        }
    }
}