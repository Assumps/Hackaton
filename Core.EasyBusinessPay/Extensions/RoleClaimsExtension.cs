using Core.EasyBusinessPay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Core.EasyBusinessPay.Extensions
{
    public static class RoleClaimsExtension
    {
        public static IEnumerable<Claim> GetClaims(this Person company)
        {
            var result = new List<Claim>
        {
            new(ClaimTypes.Email, company.Email)
        };

            return result;
        }
    }
}
