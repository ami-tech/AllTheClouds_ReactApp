using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using TheAllCloudsWebClient.Models;
using TheAllCloudsWebClient.Repositories.Interfaces;

namespace TheAllCloudsWebClient.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetProducts()
        {
            HttpWebRequest GETRequest = 
                (HttpWebRequest)WebRequest.Create("http://alltheclouds.com.au/api/Products");
            GETRequest.Method = "GET";
            GETRequest.Headers.Add("api-key", "API-VMCX5TVIAJYX1VX");
            HttpWebResponse GETResponse = (HttpWebResponse)GETRequest.GetResponse();
            Stream GETResponseStream = GETResponse.GetResponseStream();
            StreamReader sr = new StreamReader(GETResponseStream);
            string stringResult = sr.ReadToEnd();
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            return (JsonConvert.DeserializeObject<IEnumerable<Product>>
                    (stringResult, settings)).ToList();
        }
    }
}
