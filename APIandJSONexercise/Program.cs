using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading;

namespace APIandJSONexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                KanyeQuote();
                RonQuote();
                Console.WriteLine();
            }
        }

        static void KanyeQuote()
        {
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest";
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"Kanye: {kanyeQuote}");
            Thread.Sleep(3000);
        }

        static void RonQuote()
        {
            var clientRon = new HttpClient();
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = clientRon.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse).First;

            Console.WriteLine($"Ron: {ronQuote}");
            Thread.Sleep(3000);
        }
    }
}
