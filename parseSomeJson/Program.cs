using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace parseSomeJson
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var client = new HttpClient();

            var stuff = await client.GetFromJsonAsync<QuoteHolder>("https://raw.githubusercontent.com/bmumz/inspirational-quotes-api/main/db.json");

            var count = stuff.Quotes.Count;

            var junk = string.Empty;
        }


    }

    internal class QuoteHolder
    {
        public List<InspireEntry> Quotes { get; set; }
    }
}
