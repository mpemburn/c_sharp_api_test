using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ApiTest.Interfaces;

namespace ApiTest.Handlers
{
    public class RequestHandler
    {
        static readonly HttpClient client = new HttpClient();

        public static async Task Request(EndpointInterface endpoint)
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                // Test whether this endpoing uses Basic Auth
                if (endpoint.UsesBasicAuth())
                {
                    var byteArray = Encoding.ASCII.GetBytes(endpoint.GetUserName() + ":" + endpoint.GetPassword());
                    client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                }

                HttpResponseMessage response = null;
                HttpContent endpointParameters = endpoint.GetParameters();

                switch (endpoint.GetVerb())
                {
                    case "GET":
                        response = await client.GetAsync(endpoint.GetUri());
                        break;
                    case "POST":
                        response = await client.PostAsync(endpoint.GetUri(), endpointParameters);
                        break;
                }

                if (response != null)
                {
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBody);
                }
                else
                {
                    throw new HttpRequestException("No Endpoint verb specified");
                }

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught in {0} request", endpoint.GetVerb());
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
    }
}
