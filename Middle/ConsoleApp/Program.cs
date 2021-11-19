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

            Console.WriteLine($"ConsoleApp - {typeof(System.Net.Http.HttpClient).Assembly.Location}");
            
            var loadContext = new IsolatedLoadContext("../Pub/lib.dll", new[]{ typeof(IProcessor) });
            var d = loadContext.CreateInstance<IProcessor>("../Pub/lib.dll");

            var result = await d.ProcessDocumentAsync("Docs/schedule.pdf","output/schedule2021.pdf");
            //var result = await d.ProcessDocumentAsync("https://www.updateconference.net","output/update.html");
            
            Console.WriteLine("Done...");
        }
    }
}