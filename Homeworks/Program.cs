namespace Homeworks
{
    internal class Program
    {
        // Homework lesson-7

        static void Main (string[] args)
        {
           bool isCompare = Compare("Test", "Tast");
           Console.WriteLine(isCompare); // False


        }

        static bool Compare (string str1, string str2)
        {
            if(str1.Length != str2.Length) return false;

            for(int i = 0; i < str1.Length; i++) {
                if (str1[i] != str2[i]) break; return false;
            }

            return true;
        }
    }
}