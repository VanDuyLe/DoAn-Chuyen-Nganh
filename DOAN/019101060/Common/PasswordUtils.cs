using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace _019101060.Common
{
    class PasswordUtils
    {
        public static string HashingPassword(string password)
        {
            using (MD5CryptoServiceProvider md5CryptoService = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8Encoding = new UTF8Encoding();
                byte[] bytes = md5CryptoService.ComputeHash(utf8Encoding.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
    }
}
