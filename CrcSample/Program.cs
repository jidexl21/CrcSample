using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.IO;
using System.Threading.Tasks;


namespace CrcSample
{
    class Program
    {
        static IConfigurationRoot configuration; 
        static void Main(string[] args)
        {
            ConfigureServices();
            string user = configuration["crc_username"];
            string pass = configuration["crc_password"];
            //Create a new Request And Populate it with the Sample Request
            
            var request = new CRCRequest { Username = user, Password = pass}.SampleRequest();
            
            var t = request.Send(true);
            t.Wait();
            CRCResponse response = t.Result;
            //Acess the results
            //response.ConsumerHitResponse.BODY.
            Console.ReadLine();
        }
        private static void ConfigureServices()
        {
            // Build configuration
            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json", false)
                .Build();
        }
    }


}
