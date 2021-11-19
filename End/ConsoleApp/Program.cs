using System;
using System.Threading.Tasks;
using iLib;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello UpdateConference!");

            Console.WriteLine($"ConsoleApp - {typeof(System.IO.File).Assembly.Location}");
            
            var loadContext = new IsolatedLoadContext("../Pub/lib.dll", new[]{ typeof(IProcessor) });
            var d = loadContext.CreateInstance<IProcessor>("../Pub/lib.dll");
            var result = await d.ProcessDocumentAsync("Docs/schedule.pdf","schedule2021.pdf");
            //var result = await d.ProcessDocumentAsync("https://www.updateconference.net","output/test.html");
            Console.WriteLine($"{result.Item1} - {result.Item2}");

            // var client = new System.Net.Http.HttpClient();
            // var download = await client.GetStreamAsync("https://www.updateconference.net");
            // var fileStream = new System.IO.FileStream("output.html", System.IO.FileMode.CreateNew);
            // await download.CopyToAsync(fileStream);
            
            Console.WriteLine("Done...");
        }
    }
}