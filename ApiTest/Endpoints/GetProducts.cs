using System.Collections.Generic;

namespace ApiTest.Endpoints
{
    public class GetProducts : AbstractEndpoint
    {
        public GetProducts(Dictionary<string, string> specifications)
        {
            base.SetVerb("GET");
            base.SetUsesBasicAuth(true);
            base.SetBaseUri(specifications.GetValueOrDefault("baseUri"));
            base.SetEndpoint("/admin/api/2020-10/products.json");
            base.SetUserName(specifications.GetValueOrDefault("username"));
            base.SetPassword(specifications.GetValueOrDefault("password"));
        }
    }
}
