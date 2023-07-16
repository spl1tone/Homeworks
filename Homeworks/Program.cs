namespace Homeworks;

internal class Program
{

    static void Main (string[] args)
    {
        var service = new AutoService();
        service.ServiceName = "Alden";
        var vehicle = new Vehicle("BMW", 2010, "X7");
        var engine = new Engine("Vlad", 660, 1200, 8);
        var wheel = new Wheel("Good Year", 21, false, new Disk("Some Name", 21, 21));
        var othercomponents = new Other_Components(100, 100, 100, 100);

        service.AddVehicle(vehicle);

    }

}