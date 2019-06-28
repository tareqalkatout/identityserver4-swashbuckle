using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentitySrv
{
    public class Config
    {
        public static List<TestUser> GetUsers()
        {
            return new List<TestUser> { new TestUser
            {
                 SubjectId = "1" ,
                 Username = "tariq" ,
                 Password = "tariq"
            } };
        }
        public static IEnumerable<ApiResource> GetAllApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("valuesApi" , "Our Api that will be documented by swashbuckle")
            };
        }

        public static IEnumerable<Client> GetAllClients()
        {
            return new List<Client>
            {
                new Client
                {
                     ClientId = "swaggerapiui",
                     ClientName = "Swagger API UI",
                     AllowedGrantTypes = GrantTypes.Implicit ,
                     RedirectUris = {"http://localhost:5001/swagger/oauth2-redirect.html" },
                     PostLogoutRedirectUris = { "http://localhost:5001/swagger" },
                     AllowedScopes = { "valuesApi" },
                     AllowAccessTokensViaBrowser = true
                }
            };
        }
    }
}
