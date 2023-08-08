namespace Homeworks;

internal class Calendar
{
    private List<Room> rooms = new List<Room>();

    public void AddRoom (string roomName) => rooms.Add(new Room { Name = roomName });


    public void ViewAllRooms ()
    {
        foreach (var room in rooms)
            Console.WriteLine($"Room: {room.Name}");
    }

    public void BookMeeting (string roomName, DateTime startTime, DateTime endTime, string buyerName, string title)
    {
        var room = rooms.Find(r => r.Name == roomName);
        if (room == null) {
            Console.WriteLine($"Room {roomName} not found");
            return;
        }

        if (room.Meetings.Exists(m => startTime < m.EndTime && endTime > m.StartTime)) {
            Console.WriteLine("Meeting time does not match with other");
            return;
        }

        room.Meetings.Add(new Meeting {
            StartTime = startTime,
            EndTime = endTime,
            Buyer = buyerName,
            Title = title
        });

        Console.WriteLine("Meeting booked created");
    }

    public void SeeBookedMeetings (string roomName)
    {
        var room = rooms.Find(r => r.Name == roomName);
        if (room == null) { Console.WriteLine($"Room '{roomName}' not found."); return; }

        foreach (var meet in room.Meetings) {
            Console.WriteLine($"Meeting Title: {meet.Title}");
            Console.WriteLine($"Buyer: {meet.Buyer}");
            Console.WriteLine($"Start Time: {meet.StartTime}");
            Console.WriteLine($"End Time: {meet.EndTime}");
            Console.WriteLine();
        }
    }
}
