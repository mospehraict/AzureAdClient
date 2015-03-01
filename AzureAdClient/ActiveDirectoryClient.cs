namespace AzureAdClient
{
    using System.Security.Claims;

    using Microsoft.IdentityModel.Clients.ActiveDirectory;

    public class ActiveDirectoryClient : IActiveDirectoryClient
    {
        private readonly string tenant;

        private readonly string client;

        public ActiveDirectoryClient(string tenant, string client)
        {
            this.tenant = tenant;
            this.client = client;
        }

        public AuthenticationResult AuthenticateCredentials(string resource, UserCredential userCredential)
        {
            var authString = string.Format("https://login.windows.net/{0}", tenant);
            var authContext = new AuthenticationContext(authString);
            AuthenticationResult result;
            try
            {
                result = authContext.AcquireToken(resource, client, userCredential);
            }
            catch (AdalServiceException e)
            {
                // unauthorized
                throw;
            }

            return result;
        }

        public ClaimsPrincipal AuthenticateToken(string resource, string token)
        {
            throw new System.NotImplementedException();
        }
    }
}
