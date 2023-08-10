using Newtonsoft.Json;
namespace Homeworks;

internal class Program
{
    private static void Main ()
    {
        PrintAPIInfoAsync();
        Console.ReadLine();
    }


    private static async Task PrintAPIInfoAsync ()
    {
        using (HttpClient client = new HttpClient()) {
            try {
                var response = await client.GetAsync("https://api.breakingbadquotes.xyz/v1/quotes/100");

                var quotesInfo = JsonConvert.DeserializeObject<APIModel[]>(await response.Content.ReadAsStringAsync());

                for (var i = 0; i < quotesInfo.Length; i++) {
                    Console.WriteLine($"Quote: {quotesInfo[i].Quote}\nAuthor: {quotesInfo[i].Author}\n" + new string('-', 30));
                }
            }
            catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }

}