namespace AzureAdClient
{
    using System.Security.Claims;

    using Microsoft.IdentityModel.Clients.ActiveDirectory;

    interface IActiveDirectoryClient
    {
        AuthenticationResult AuthenticateCredentials(string resource, UserCredential userCredential);

        ClaimsPrincipal AuthenticateToken(string resource, string token);
    }
}
