using System.Text.Json;



namespace ChuckNorrisAPI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();

            string apiUrl = "https://api.chucknorris.io/jokes/random";

            Console.WriteLine("Fetching a joke....");

            var responce = await client.GetAsync(apiUrl);

            responce.EnsureSuccessStatusCode();

            string json= await responce.Content.ReadAsStringAsync();

            var joke = JsonSerializer.Deserialize<Joke>(json);




            List<Joke>listOfJokes=new List<Joke>();
            listOfJokes.Add(joke);
        }
    }
}
