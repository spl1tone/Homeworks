namespace Homeworks;

internal class Engine : Vehicle
{
    public string CreatorName { get; set; } = "Name";
    public int Power { get; set; } = 0;
    public int maxTemperature { get; set; } = 0;
    public int cylinderCount { get; set; } = 0;

    public Engine ()
    {

    }

    public Engine (string creatorName, int power, int maxTemperature, int cylinderCount)
    {
        CreatorName = creatorName;
        Power = power;
        this.maxTemperature = maxTemperature;
        this.cylinderCount = cylinderCount;
    }

    public override void PrintInfo ()
    {
        Console.WriteLine($"CreatorName: {CreatorName}\nPower: {Power}\nTemperature: {maxTemperature}\nCylinders: {cylinderCount}");
    }
}
