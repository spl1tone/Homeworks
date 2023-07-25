namespace Homeworks;

internal class Topic
{
    public int topicID { get; set; } = 0;
    public string TopicName { get; set; } = "Topic Name";
    public List<string> VotersName = new();
    public int votesCount { get; set; } = 0;

    public void CreateTopic (int topicId, string topicName)
    {
        topicID = topicId;
        TopicName = topicName;
    }

    public void AddVoute (string voter)
    {
        VotersName.Add(voter);
        votesCount++;
    }

    public void PrintResults ()
    {
        if (VotersName.Count == 0) Console.WriteLine($"TopicId: {topicID}, TopicName: {TopicName}, VoterName: -, Votes: {votesCount}");
        else {
            Console.WriteLine($"TopicId: {topicID}, TopicName: {TopicName}, Votes: {votesCount}");
            foreach (var c in VotersName) {
                Console.WriteLine($"VoterName: {c}");
            }
        }

    }
}
