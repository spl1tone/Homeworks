namespace Homeworks;

internal class AutoService
{
    public string ServiceName { get; set; } = "Service Name";
    public List<Vehicle> vehicles { get; set; }

    public AutoService ()
    {

    }

    public AutoService(string serviceName,Vehicle vehicle)
    {
        ServiceName = serviceName;
        vehicles.Add(vehicle);
    }

    public void AddVehicle (Vehicle vehicle) => vehicles.Add(vehicle);
    public void RemoveVehicle (Vehicle vehicle) => vehicles.Remove(vehicle);

}
