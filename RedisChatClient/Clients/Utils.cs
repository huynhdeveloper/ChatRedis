using System;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;

namespace RedisChatClient.Clients
{
    internal sealed class Utils
    {
        private Utils()
        {
        }

        public static String hashing(String salt, String pharse)
        {
            var bsalt = Encoding.Unicode.GetBytes(salt);
            var preHash = new Rfc2898DeriveBytes(pharse, bsalt, 10000);
            var hashed = preHash.GetBytes(20);
            return Convert.ToBase64String(hashed);
        }

        public static long toUnixTime(DateTime date)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return Convert.ToInt64((date - epoch).TotalSeconds);
        }

        public static DateTime toDateTime(long unixTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTime);
        }

        public static bool emailValidate(String emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}