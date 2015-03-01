namespace AzureAdClient.Frontend
{
    using System;

    using Microsoft.IdentityModel.Clients.ActiveDirectory;

    class Program
    {
        static void Main(string[] args)
        {
            var client = new ActiveDirectoryClient(Constants.Tenant, Constants.NativeClientId);
            var uc = new UserCredential("johndie@testaddirectory.onmicrosoft.com", "Saju1123");
            var authResult = client.AuthenticateCredentials(Constants.Resource, uc);
            var token = authResult.AccessToken;
            Console.WriteLine(token);
        }
    }
}
