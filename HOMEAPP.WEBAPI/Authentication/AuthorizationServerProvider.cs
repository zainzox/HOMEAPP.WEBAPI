using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Security.Claims;
using HOMEAPP.WEBAPI.HOMEAPP_Interfaces;
using HOMEAPP.WEBAPI.HOMEAPP_DBConnection;
using System.Data.SqlClient;
using System.Data;

namespace HOMEAPP.WEBAPI.Authentication
{   
    /// <summary>
/// 
/// </summary>
    public class AuthorizationServerProvider: OAuthAuthorizationServerProvider
    { 

        Connection db;

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override async  Task  GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);

            db = new Connection();
            SqlParameter[] paraArr = {

                    new SqlParameter("@Username",context.UserName),
                    new SqlParameter("@Password",context.Password)
                };

            DataTable getUserAuth = db.GetDataTable("AdminLogin", paraArr);

           if (getUserAuth.Columns.Count>1)
            {
                identity.AddClaim(new Claim("username", context.UserName));
                identity.AddClaim(new Claim(ClaimTypes.Role, "admin"));
                context.Validated(identity);
            }

            else
            {
                context.SetError("Invalide_grant", "UserName and UserPassword is incorrect");

            }

         

        }


    }
}