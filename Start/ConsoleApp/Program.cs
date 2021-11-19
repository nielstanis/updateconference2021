using System;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello UpdateConference!");

            DocumentProcessor.Processor proc = new DocumentProcessor.Processor();
            var result = await proc.ProcessDocumentAsync("Docs/schedule.pdf","Output/schedule2021.pdf");
            //var result = await proc.ProcessDocumentAsync("https://www.updateconference.net","update.html");
            
            Console.WriteLine("Done...");
        }
    }
}