using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrcSample
{
    public class QueryParams
    {
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
        public string REPORT_ID { get; set; }
        public string SUBJECT_TYPE { get; set; }
        public string RESPONSE_TYPE { get; set; }
    }

    public class INQUIRY_REASON
    {
        public string CODE { get; set; }
    }

    public class APPLICATION
    {
        public string PRODUCT { get; set; }
        public string NUMBER { get; set; }
        public string AMOUNT { get; set; }
        public string CURRENCY { get; set; }
    }

    public class SEARCH_PARAMETERS
    {
        public string SEARCHTYPE { get; set; }
        public string BVN_NO { get; set; }
    }

}
