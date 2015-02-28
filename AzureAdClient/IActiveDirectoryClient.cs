namespace AzureAdClient
{
    using System.Security.Claims;

    using Microsoft.IdentityModel.Clients.ActiveDirectory;

    interface IActiveDirectoryClient
    {
        string AuthenticateCredentials(string tenant, string resource, UserCredential userCredential);

        ClaimsPrincipal AuthenticateToken(string tenant, string resource, string token);
    }
}
