namespace Homeworks;

internal class AutoService
{
    public string ServiceName { get; set; }
    public List<Vehicle> vehicles { get; set; }

    public AutoService ()
    {

    }

    public AutoService(string serviceName,Vehicle vehicles)
    {
        ServiceName = serviceName;
        this.vehicles.Add(vehicles);
    }

    public int Price { get; set; }
}
