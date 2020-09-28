using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrcSample
{
    public class QueryParams
    {
        [JsonProperty("@REQUEST_ID")]
        public string REQUEST_ID { get; set; }
        public REQUEST_PARAMETERS REQUEST_PARAMETERS { get; set; }
        public SEARCH_PARAMETERS SEARCH_PARAMETERS { get; set; }
    }

    public class REQUEST_PARAMETERS
    {
        public REPORT_PARAMETERS REPORT_PARAMETERS { get; set; }
        public INQUIRY_REASON INQUIRY_REASON { get; set; }
        public APPLICATION APPLICATION { get; set; }
    }

    public class REPORT_PARAMETERS
    {
        [JsonProperty("@REPORT_ID")]
        public string REPORT_ID { get; set; }
        [JsonProperty("@SUBJECT_TYPE")]
        public string SUBJECT_TYPE { get; set; }
        [JsonProperty("@RESPONSE_TYPE")]
        public string RESPONSE_TYPE { get; set; }
    }

    public class INQUIRY_REASON
    {
        [JsonProperty("@CODE")]
        public string CODE { get; set; }
    }

    public class APPLICATION
    {
        [JsonProperty("@PRODUCT")]
        public string PRODUCT { get; set; }
        [JsonProperty("@NUMBER")]
        public string NUMBER { get; set; }
        [JsonProperty("@AMOUNT")]
        public string AMOUNT { get; set; }
        [JsonProperty("@CURRENCY")]
        public string CURRENCY { get; set; }
    }

    public class SEARCH_PARAMETERS
    {
        [JsonProperty("@SEARCH-TYPE")]
        public string SEARCHTYPE { get; set; }
        public string BVN_NO { get; set; }
    }

}
