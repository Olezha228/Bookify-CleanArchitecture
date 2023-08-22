using System.Text.Json.Serialization;

namespace Bookify.Infrastucture.Authentication.Models;

internal class AuthorizationToken
{
    [JsonPropertyName("access_token")] 
    public string AccessToken { get; set; }
}
