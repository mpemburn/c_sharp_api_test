using System;
using System.Collections.Generic;
using System.Net.Http;

namespace ApiTest.Endpoints
{
    public class AddProduct : AbstractEndpoint
    {
        public AddProduct(
            Dictionary<string, string> specifications,
            HttpContent parameters
            )
        {
            base.SetVerb("POST");
            base.SetUsesBasicAuth(true);
            base.SetBaseUri(specifications.GetValueOrDefault("baseUri"));
            base.SetEndpoint("/admin/api/2020-10/products.json");
            base.SetUserName(specifications.GetValueOrDefault("username"));
            base.SetPassword(specifications.GetValueOrDefault("password"));
            base.SetParameters(parameters);
        }
    }
}
