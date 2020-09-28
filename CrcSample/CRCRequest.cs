using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CrcSample
{
    public class CRCRequest
    {
        public Uri Url { get; set; } = new Uri("https://webserver.creditreferencenigeria.net/JsonLiveRequest/JsonService.svc/CIRRequest/ProcessRequestJson");
        public CRCRequest()
        {

        }
        public CRCRequest(string url)
        {
            Url = new Uri(url);
        }

        public string Username { get; set; } 
        public string Password { get; set; }
        public string Request { get; set; }
        public QueryParams QueryParams { get; set; }
        /// <summary>
        /// Sends a request
        /// </summary>
        /// <param name="useObject">True to use QueryParams property (Object) or default false to use Request Property(string)</param>
        /// <returns></returns>
        public async Task<CRCResponse> Send(bool useObject = false)
        {
            string stringResult;
            CRCResponse obj;
            using (var client = new HttpClient())
            {
                string req = (useObject) ? JsonConvert.SerializeObject(QueryParams).Replace('"','\'') : Request; 
                string qry = string.Format("{{\n\t\"Request\": \"{0}\",\n\t\"UserName\":\"{1}\",\n\t\"Password\":\"{2}\"\n}}", req, Username, Password);
                //qry = qry.Replace("SEARCHTYPE", "SEARCH-TYPE");
                var content = new StringContent(qry, Encoding.UTF8, "application/json");
                try
                {
                    var result = await client.PostAsync(Url, content);
                    stringResult = await result.Content.ReadAsStringAsync();
                    obj = JsonConvert.DeserializeObject<CRCResponse>(stringResult);
                }
                catch (Exception e) {
                    throw e;
                }
                

            }
            return obj;
        }
    }

}
