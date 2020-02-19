//using System;
//using System.Collections.Generic;
//using System.Text;
//using Newtonsoft.Json.Linq;
//using System.Net.Http;

//namespace APIandJSONexercise
//{
//    public class Person
//    {
//        public var client { get; set; }
//        public var kanyeURL = "https://api.kanye.rest";
//        public var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
//        public var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
//    }
//}
