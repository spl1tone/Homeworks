namespace Homeworks
{
    internal class Program
    {
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        // Homework lesson-6

        static void Main (string[] args)
        {
            var firstDay = WeekDays.Monday;
            var numFirstDay = (int)WeekDays.Monday;
            var element = 2;
            WeekDays weekDays = (WeekDays)Enum.Parse(typeof(WeekDays), element.ToString());
            Console.WriteLine(weekDays);
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] r1 = a[1..5];

            int[] r2 = a[5..];
            int r3 = a[^1];
            Console.WriteLine(r3);

            int[] mas = { 1, 2, 3, 4 };
            Array.Resize(ref mas, 5);
            foreach (int a1 in mas) {
                Console.WriteLine(a1);
            }
            Tuple<int, string, string> person =
                new Tuple<int, string, string>(1, "Steve", "Jobs");
            var person1 = Tuple.Create(1, "Steve", "Jobs");
            var persons = new[] { person, person1 };
            var age = person.Item1;
            var name = person.Item2;
            var group = person.Item3;

            PrintTuple(person1);

        }

        static void PrintTuple (Tuple<int, string, string> tuple)
        {
            Console.WriteLine(tuple.Item1 + " " + tuple.Item2 + " " + tuple.Item3);
        }

    }
}