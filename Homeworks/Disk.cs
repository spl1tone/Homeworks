namespace Homeworks;

internal class Disk : Wheel
{
    public string Name { get; set; } = "Name";
    public int Radius { get; set; } = 0;
    public int Size { get; set; } = 0;

    public Disk ()
    {

    }

    public Disk (string name, int radius, int size)
    {
        Name = name;
        Radius = radius;
        Size = size;
    }

    public override void PrintInfo ()
    {
        Console.WriteLine($"Name: {Name}\nRadius: {Radius}\nSize{Size}");
    }
}
