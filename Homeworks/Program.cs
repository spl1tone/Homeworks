namespace Homeworks
{
    internal class Program
    {
        // Homework lesson-5

        static void Main (string[] args)
        {
            Console.WriteLine($"MaxValue: {MaxValue(5,10)}");
            Console.WriteLine($"MinValue: {MinValue(5,10)}");
            TrySumIfOdd(5, 10, out int sum);
            Console.WriteLine($"Repeat SomeText: {Repeat("str",3)}");
        }

        static int MaxValue (int num1, int num2)
        {
            int value = Math.Max (num1, num2);
            return value;
        }
        static int MaxValue (int num1, int num2,bool degree,int degreeNum)
        {           
            int value = Math.Max(num1, num2);
            if (degree) value = (int)Math.Pow(value, degreeNum);
            return value;
        }
        static int MinValue (int num1, int num2)
        {
            int value = Math.Min(num1, num2);
            return value;
        }
        static int MinValue (int num1, int num2, bool degree, int degreeNum)
        {
            int value = Math.Min(num1, num2);
            if (degree) value = (int)Math.Pow(value, degreeNum);
            return value;
        }

        static void TrySumIfOdd (int num1, int num2, out int sum)
        {
            sum = 0;
            if (num1 < num2) {
                for(int i = num1; i < num2; i++) {
                    sum += i;
                }
            }
            else if (num1 > num2) {
                for (int i = num2; i < num1; i++) {
                    sum += i;
                }
            }
            else {
                sum = num1;          
            }

            if (sum % 2 == 0) {
                Console.WriteLine($"{sum} - Це число парне");
            }
            else {
                Console.WriteLine($"{sum} - Це число непарне");
            }
        }

        static string Repeat(string text,int count)
        {
            string rText = string.Empty;
            for(int i = 0; i < count; i++) {
                rText += text;
            }
            return rText;
        }
        

        
    }
}