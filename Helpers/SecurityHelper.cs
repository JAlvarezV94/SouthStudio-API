using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SouthStudioBlog.Helpers
{
    public static class SecurityHelper
    {

        public static string EncryptSHA521(string text)
        {
            byte[] hash;

            if (text == null)
                text = string.Empty;

            var stringBytes = Encoding.UTF8.GetBytes(text);

            using(var hashManager = new SHA512Managed())
            {
               hash = hashManager.ComputeHash(stringBytes);
            }

            return GetStringFromHash(hash);
        }

        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }
    }
}
