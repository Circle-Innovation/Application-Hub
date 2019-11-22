using CircleInnovation.Model;
using System;
using System.Linq;
using System.Security.Claims;

namespace CircleInnovation.Helper
{
    public static class UserContextHelper
    {
        public static UserContextModel Context
        {
            get
            {
                UserContextModel context = new UserContextModel();
                var identity = (ClaimsIdentity)System.Web.HttpContext.Current.User.Identity;
                var hashedId = identity.Claims.Where(x => x.Type == "uuq").First().Value;
                var email = identity.Name;

                context.Email = email;
                context.UserID = Convert.ToInt32(Decryptor.Decrypt(hashedId));
                //var _roles = identity.Claims
                //            .Where(c => c.Type == ClaimTypes.Role)
                //            .Select(c => c.Value).ToArray();

                return context;
            }
        }
    }
}
