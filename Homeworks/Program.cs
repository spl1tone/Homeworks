namespace Homeworks
{
    internal class Program
    {
        // Homework lesson-5

        static void Main (string[] args)
        {
            int iRef = 0; 
            var someOut = 5;

            PrintValue(5,"Vlad",out someOut,ref iRef,5);

            Console.WriteLine(someOut);
            Console.WriteLine(iRef);
            Console.WriteLine(SomeMethod("Name",new string[] {"Vlad","Misha","Nikita"}));
        }
        
        static string SomeMethod(string title, params string[] words)
        {
            string head = title + ": ";

            foreach(var word in words) {
                head += word + ", ";
            }

            return head;
        }


        static void PrintValue (int val, string str, out int res, ref int someValue, int opt = 1)
        {
            someValue = someValue + 1;
            val = someValue + opt + 5;
            res = opt + 1;
            Console.WriteLine($"{val},{str},{someValue},{res},{opt}");

        }

    }
}