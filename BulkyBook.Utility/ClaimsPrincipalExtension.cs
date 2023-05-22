using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Utility
{
    public static class ClaimsPrincipalExtension
    {
        public static string? GetFullName(this ClaimsPrincipal principal)
        {
            var fullName = principal.Claims.FirstOrDefault(u => u.Type == "FullName");
            System.Console.WriteLine("THIS IS FULLNAME   " + fullName?.Value);
            return fullName?.Value;
        }
    }
}
