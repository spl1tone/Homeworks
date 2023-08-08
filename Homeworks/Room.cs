namespace Homeworks;

internal class Room
{
    public string Name { get; set; } = "Room Name";
    public List<Meeting> Meetings { get; } = new();
}
