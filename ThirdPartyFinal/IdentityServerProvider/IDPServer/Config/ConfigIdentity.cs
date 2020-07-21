
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IDPServer.Configuration
{
    public class Config
    {
        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                 SubjectId = "0e7cbfbb-4d6a-431b-93ec-165c09ad65ae",
                Username = "alinouri",
                Password = "123",
                Claims = new List<Claim>()
                {
                    new Claim("given_name","ali"),
                    new Claim("family_name","nouri"),
                        new Claim("SSN", "0074625431"),
                      new Claim("address", "khoonamoon"),
                        new Claim("role", "role1"),
                }
                },
                new TestUser
                {
                   SubjectId = "4ef88a0c-28a6-4136-b9d8-88dd76b73769",
             Username = "hamid",
          Password = "123",
                }
            };
        }
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Address()
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
            new Client
                {
                    ClientName = "MY APP",
                    ClientId = "MYAPP",
                    AllowedGrantTypes = GrantTypes.Hybrid,
                    RedirectUris = new List<string>
                    {
                        "https://localhost:5001/signin-oidc"
                    },
                    PostLogoutRedirectUris = new List<string>
                    {
                        "https://localhost:5001/signout-callback-oidc"
                    },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Address,
                        "roles",
                        "MYAPI"
                    },
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    }
                }
            };
        }

        public static IEnumerable<ApiResource> GetResources()
        {
            return new List<ApiResource>
            {
                new ApiResource(
                    name: "MYAPI",
                    displayName: "My API",
                    claimTypes: new List<string> {"role" })
            };
        }
    }
}
