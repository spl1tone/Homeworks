namespace Homeworks;

internal class Wheel : Vehicle
{
    public string Model { get; set; } = "Model";
    public int Radius { get; set; } = 0;
    /// <summary>
    ///  <param name="Season">True - Winter, False - Summer</param>
    /// </summary>
    public bool Season { get; set; } = true;
    public Disk disk { get; set; }

    public Wheel ()
    {

    }

    public Wheel (string model, int radius, bool season, Disk disk)
    {
        Model = model;
        Radius = radius;
        Season = season;
        this.disk = disk;
    }

    public override void PrintInfo ()
    {
        Console.WriteLine($"Model: {Model}\nRadius: {Radius}\nSeson: {(Season ? "For Winter" : "For Summer")}");
    }

}
