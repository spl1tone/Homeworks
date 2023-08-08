namespace Homeworks;

internal class Program
{
    private static void Main ()
    {
        Calendar calendar = new Calendar();
        bool isReadOnly = false; // ReadOnly / RW mode

        if (!isReadOnly) {
            calendar.AddRoom("Meeting Room1");
            calendar.AddRoom("Meeting Room2");
            calendar.AddRoom("Meeting Room3");
            calendar.AddRoom("Meeting Room4");
        }

        calendar.ViewAllRooms();

        if (!isReadOnly) {
            calendar.BookMeeting("Meeting Room1", DateTime.Now.AddHours(1), DateTime.Now.AddHours(2), "John", "Some Title");
            calendar.BookMeeting("Meeting Room2", DateTime.Now.AddHours(2), DateTime.Now.AddHours(3), "Steve", "Some Title");
            calendar.BookMeeting("Meeting Room3", DateTime.Now.AddHours(3), DateTime.Now.AddHours(4), "Michael", "Some Title");
            calendar.BookMeeting("Meeting Room4", DateTime.Now.AddHours(4), DateTime.Now.AddHours(5), "Oleg", "Some Title");
        }

        calendar.SeeBookedMeetings("Meeting Room1");
        calendar.SeeBookedMeetings("Meeting Room2");
        calendar.SeeBookedMeetings("Meeting Room3");
        calendar.SeeBookedMeetings("Meeting Room4");
    }
}