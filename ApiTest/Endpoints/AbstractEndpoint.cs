using System.Net.Http;
using ApiTest.Interfaces;

namespace ApiTest.Endpoints
{

    abstract public class AbstractEndpoint : EndpointInterface
    {
        string baseUri;
        string verb;
        string endpoint;
        string username;
        string password;
        bool basicAuthRequired;
        HttpContent parameters;


        public string GetBaseUri()
        {
            return this.baseUri;
        }

        public string GetEndpoint()
        {
            return this.endpoint;
        }

        public string GetUri()
        {
            return this.baseUri + this.endpoint;
        }

        public string GetVerb()
        {
            return this.verb;
        }

        public string GetUserName()
        {
            return this.username;
        }

        public string GetPassword()
        {
            return this.password;
        }

        public HttpContent GetParameters()
        {
            return this.parameters;
        }

        public bool UsesBasicAuth()
        {
            return basicAuthRequired;
        }

        public void SetBaseUri(string baseUri)
        {
            this.baseUri = baseUri;
        }

        public void SetEndpoint(string endpoint)
        {
            this.endpoint = endpoint;
        }

        public void SetVerb(string verb)
        {
            this.verb = verb;
        }

        public void SetUserName(string username)
        {
            this.username = username;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }

        public void SetUsesBasicAuth(bool basicAuthRequired)
        {
            this.basicAuthRequired = basicAuthRequired;
        }

        public void SetParameters(HttpContent parameters)
        {
            this.parameters = parameters;
        }

    }
}
