using System.Threading.Tasks;
using System.Collections.Generic;

namespace ApiTest
{
    class Program
    {
 
        static async Task Main(string[] args)
        {
            Dictionary<string, string> parameters =
                new Dictionary<string, string>() {
                    {"baseUri", "https://pemburns-explorations.myshopify.com" },
                    {"username", "5ebc6a65caa3b15554c0ac3bd00f1a6a" },
                    {"password", "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" }
                };

            //Inject GetProducts(), which implements EndpointInterface;
            await RequestHandler.Request(new GetProducts(parameters));
        }
    }
}
