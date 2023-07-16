namespace Homeworks;

internal class Vehicle : AutoService
{
    public string Name { get; set; } = "Name";
    public int Year { get; set; } = 0;
    public string Model { get; set; } = "Model"; 

    public Vehicle ()
    {

    }

    public Vehicle (string name, int year, string model)
    {
        Name = name;
        Year = year;
        Model = model;
    }

    public virtual void PrintInfo ()
    {
        Console.WriteLine($"CarName: {Name}\nYear: {Year}\nModel: {Model}");
    }

}
