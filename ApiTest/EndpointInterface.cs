using System.Net.Http;

namespace ApiTest
{
    public interface EndpointInterface
    {
        string GetBaseUri();
        string GetEndpoint();
        string GetUri();
        string GetVerb();
        string GetUserName();
        string GetPassword();
        HttpContent GetParameters();
        bool UsesBasicAuth();
        void SetBaseUri(string baseUri);
        void SetVerb(string password);
        void SetEndpoint(string endpoint);
        void SetUserName(string username);
        void SetPassword(string password);
        void SetUsesBasicAuth(bool basicAuthRequired);
    }
}
