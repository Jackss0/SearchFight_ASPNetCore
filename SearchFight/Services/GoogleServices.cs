using Microsoft.Extensions.Configuration;
using SearchFight.Controllers.Google;
using SearchFight.Models.Google;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

namespace SearchFight.Services
{
    public class GoogleServices : IGoogleServices
    {
        public GoogleSearch GoogleWebResult(string req, IConfiguration configuration)
        {
            var key = configuration.GetSection("GoogleAPI:key1").Value;
            var url = configuration.GetSection("GoogleAPI:url").Value;
            var properties = configuration.GetSection("GoogleAPI:properties").Value;
            string search = $"{url}{req}{properties}{key}";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(search);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
                {
                    DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(GoogleSearch));
                    GoogleSearch result = (GoogleSearch)deserializer.ReadObject(ms);
                    return result;
                }
            }
        }
    }
}