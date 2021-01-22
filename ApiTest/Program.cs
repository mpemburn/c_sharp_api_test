using System.Threading.Tasks;
using System.Collections.Generic;
using ApiTest.Endpoints;
using ApiTest.Handlers;


namespace ApiTest
{
    class Program
    {
 
        static async Task Main(string[] args)
        {
            Dictionary<string, string> specifications =
                new Dictionary<string, string>() {
                    {"baseUri", "https://pemburns-explorations.myshopify.com" },
                    {"username", "5ebc6a65caa3b15554c0ac3bd00f1a6a" },
                    {"password", "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" }
                    //{"username", "[My Username]" },
                    //{"password", "[My Password]" }
                };


            var json = "{\"product\": {\"title\": \"Extra Light Valve Cap\",\"body_html\": \"<strong>When rotating weight is SUPER important!</strong>\",\"vendor\": \"Weight Weeny\",\"product_type\": \"Accessory\",\"tags\": [\"light\",\"lighter\",\"lightest\"]}}";

            //Inject AddProduct(), which implements EndpointInterface;
            //await RequestHandler.Request(new AddProduct(specifications, new StringContent(json)));

            //Inject GetProducts(), which implements EndpointInterface;
            await RequestHandler.Request(new GetProducts(specifications));
        }
    }
}
