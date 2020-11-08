using System;
using System.Collections.Generic;
using System.Text;

namespace CrcSample
{
    public class ErrorResponse
    {
        public ErrorBody BODY { get; set; }
        public ErrorHeader HEADER { get; set; }
        public string REQUESTID { get; set; }
    }

    public class ErrorBody
    {
        public string[] ERRORLIST { get; set; }
    }

    public class ErrorHeader
    {
        public ErrorResponseType RESPONSETYPE { get; set; }
    }

    public class ErrorResponseType
    {
        public string CODE { get; set; }
        public string DESCRIPTION { get; set; }
    }

}
