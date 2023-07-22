namespace Homeworks;

internal class Program
{

    static void Main (string[] args)
    {
        Stack<int> stack = new();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);

        var pop = stack.Pop();
        Console.WriteLine("Pop: " + pop);

        var peek = stack.Peek();
        Console.WriteLine("Peek: " + peek);

        int[] array = new int[0];
        stack.CopyTo(ref array);
        Console.WriteLine("Array: " + string.Join(", ", array));

        var count = stack.Count();
        Console.WriteLine($"Count: {count}");

        stack.Clear();

    }

}