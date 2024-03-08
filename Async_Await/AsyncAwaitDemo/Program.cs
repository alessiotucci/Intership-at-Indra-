using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var stopwatch = Stopwatch.StartNew();
		//var post1 = GetPost();
		var post = await GetPostAsync();
		stopwatch.Stop();

        Console.WriteLine($"Post: {post}");
        Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds} ms");
    }

	// Task<string> is async.
    static async Task<string> GetPostAsync()
    {
        var client = new HttpClient();
        var response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/1");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
	// This is a syncronus Task
	static string GetPost()
	{
		var client = new HttpClient();
		var response = client.GetAsync("https://jsonplaceholder.typicode.com/posts/1").Result;
		response.EnsureSuccessStatusCode();
		return response.Content.ReadAsStringAsync().Result;
	}

}
