using System.Collections.Generic;

namespace ApiTest
{
    public class GetProducts : AbstractEndpoint
    {
        public GetProducts(Dictionary<string, string> parameters)
        {
            base.SetVerb("GET");
            base.SetUsesBasicAuth(true);
            base.SetBaseUri(parameters.GetValueOrDefault("baseUri"));
            base.SetEndpoint("/admin/api/2020-10/products.json");
            base.SetUserName(parameters.GetValueOrDefault("username"));
            base.SetPassword(parameters.GetValueOrDefault("password"));
        }
    }
}
