using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CrcSample
{
    public static class SampleExtensions
    {
        /// <summary>
        /// Sample string request
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string SampleStringRequest(this CRCRequest obj)
        {
            return "{\n\t\"Request\": \"{'@REQUEST_ID': '1','REQUEST_PARAMETERS': {   'REPORT_PARAMETERS': {      '@REPORT_ID': '6416',      '@SUBJECT_TYPE': '1', "
             + "     '@RESPONSE_TYPE': '5'   },   'INQUIRY_REASON': {      '@CODE': '1'   },   "
             + "'APPLICATION': {      '@PRODUCT': '017',      '@NUMBER': '232',      '@AMOUNT': '15000',      '@CURRENCY': 'NGN'   }},"
             + "'SEARCH_PARAMETERS': {   '@SEARCH-TYPE': '4',   'BVN_NO': '22151192670' }}\",\n\t\"UserName\": \"26624534nirsal\",\n\t\"Password\": \"Qxho58171\"\n}\n\n";
        }
        /// <summary>
        /// Test Extension Populates the Object with the Sample Request Parameters
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static CRCRequest SampleRequest( this CRCRequest obj )
        {
            string req = SampleStringRequest(obj);
            obj.Request = req;
            var sample = JsonConvert.DeserializeObject<CRCRequest>(req);
            var val = sample.Request;
            val = val.Replace("'@", "'").Replace("\"@", "\""); //Remove @ Symbol prefix from string
            sample.QueryParams = JsonConvert.DeserializeObject<QueryParams>(val); //Populate QueryParams with string
            return sample;
        }

        //public static async Task<CRCResponse> SendSample(this CRCRequest item)
        //{
        //    string stringResult;
        //    CRCResponse obj;
        //    using (var client = new HttpClient())
        //    {
        //        var content = new StringContent(item.SampleStringRequest(), Encoding.UTF8, "application/json");
        //        var result = await client.PostAsync(item.Url, content);
        //        stringResult = await result.Content.ReadAsStringAsync();
        //        obj = JsonConvert.DeserializeObject<CRCResponse>(stringResult);
        //    }
        //    return obj;
        //}

    }
}
