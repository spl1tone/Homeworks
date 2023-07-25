namespace Homeworks;

class Program
{
    static List<Topic> topics = new();

    static void Main (string[] args)
    {
        var id = 0;

        while (true) {
            Console.WriteLine("1 Create Topic");
            Console.WriteLine("2 Vote For Topic");
            Console.WriteLine("3 See Vote Results");
            Console.WriteLine("4 Exit");

            string input = Console.ReadLine();

            switch (input) {
                case "1":
                    id++;
                    CreateTopic(id);
                    break;
                case "2":
                    VoteForTopic();
                    break;
                case "3":
                    PrintVoteResults();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrrong input");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CreateTopic (int id)
    {
        Topic topic = new();
        Console.WriteLine("Enter Topic Name:");
        topic.CreateTopic(id, Console.ReadLine());
        topics.Add(topic);
        Console.WriteLine("Topic added");
    }
    static void VoteForTopic ()
    {
        Console.WriteLine("Enter Topic Name To Vote: ");
        string topicName = Console.ReadLine();
        var topic = topics.Find(x => x.TopicName == topicName);
        if (topic == null) Console.WriteLine("Wrrong Topic Name");
        else {
            Console.WriteLine("Enter Vouter Name: ");
            topic.AddVoute(Console.ReadLine());
        }

    }
    static void PrintVoteResults ()
    {
        if (topics.Count == 0) Console.WriteLine("Add Some Topics To View Results");
        else {
            foreach (var c in topics) {
                c.PrintResults();
            }
        }
    }

}

