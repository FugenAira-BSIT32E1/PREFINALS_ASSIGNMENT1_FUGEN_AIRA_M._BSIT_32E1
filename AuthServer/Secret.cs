using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthServer
{
    public class Secret
    {
        // Generate a strong, random JWT signing key
        public static string GenerateRandomKey()
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, 64)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        // JWT signing key
        public static readonly string Key = GenerateRandomKey();
    }
}
