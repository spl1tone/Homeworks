namespace Homeworks;

internal class Engine : Vehicle
{
    public string CreatorName { get; set; }
    public int Power { get; set; }
    public int Temperature { get; set; }
    public int cylinderCount { get; set; }

    public Engine ()
    {

    }

    public Engine (string creatorName, int power, int temperature, int cylinderCount)
    {
        CreatorName = creatorName;
        Power = power;
        Temperature = temperature;
        this.cylinderCount = cylinderCount;
    }

    public override void PrintInfo ()
    {
        Console.WriteLine($"CreatorName: {CreatorName}\nPower: {Power}\nTemperature: {Temperature}\nCylinders: {cylinderCount}");
    }
}
