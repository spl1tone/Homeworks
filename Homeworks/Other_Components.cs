namespace Homeworks;

internal class Other_Components : Vehicle
{
    public int Gasoline { get; set; } = 0;
    public int Oil { get; set; } = 0;
    public int Coolant { get; set; } = 0;
    public int brakeFluid { get; set; } = 0; 

    public Other_Components ()
    {

    }

    public Other_Components (int gasoline,int oil,int coolant,int brakeFluid)
    {
        Gasoline = gasoline;
        Oil = oil;
        Coolant = coolant;
        this.brakeFluid = brakeFluid;
    }

    public override void PrintInfo ()
    {
        Console.WriteLine($"Gasoline: {Gasoline}\nOil: {Oil}\nCoolant: {Coolant}\nBrakeFluid: {brakeFluid}");
    }
}
