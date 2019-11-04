using Microsoft.AspNetCore.Mvc;
using SearchFight.Models;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

namespace SearchFight.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BingController
    {
        [HttpGet]
        public BingSearch Get(string id)
        {
            return BingWebResult(id);
        }

        public static BingSearch BingWebResult(string req)
        {
            string search = $"https://api.cognitive.microsoft.com/bing/v7.0/search?q= {req}";
            string key = "2818789504e041e2816cf6cabf15ab56";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(search);
            request.Headers.Add("Ocp-Apim-Subscription-Key", key);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
                {
                    DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(BingSearch));
                    BingSearch result = (BingSearch)deserializer.ReadObject(ms);

                    return result;
                }
            }
        }
    }
}
