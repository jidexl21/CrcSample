using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace CrcSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new Request And Populate it with the Sample Request
            var request = new CRCRequest().SampleRequest();
            
            var t = request.Send(true);
            t.Wait();
            CRCResponse response = t.Result;
            //response.ConsumerHitResponse.BODY.
            Console.ReadLine();
        }
    }


}
