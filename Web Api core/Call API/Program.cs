using Call_API;
using System.Text;
using System.Text.Json;
internal class Program
{
    private static void Main(string[] args)
    {

        var postData = new PostData
        {
            Name = "John Doe",
            Age = 30,
            Address = "2e3 DH"
        };
        var client = new HttpClient();
        client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");

        var json = JsonSerializer.Serialize(postData);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = client.PostAsync("posts", content).Result;
        if (response.IsSuccessStatusCode)
        {
            var responContent = response.Content.ReadAsStringAsync().Result;
            var postResonse = JsonSerializer.Deserialize<PostResponse>(responContent);
            Console.WriteLine(responContent);

        }
        else
        {
            Console.WriteLine("Error" + response.StatusCode);
        }
    }
}