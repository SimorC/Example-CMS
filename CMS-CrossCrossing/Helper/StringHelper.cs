using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CMS_CrossCutting.Helper
{
    public static class StringHelper
    {
        /// <summary>
        /// Get a MD5 crypto string from a string
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>Output string</returns>
        public static string Md5Encrypt(string input)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] cryptoValue = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder strBuilder = new StringBuilder();

            for (int i = 0; i < cryptoValue.Length; i++)
            {
                strBuilder.Append(cryptoValue[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        /// <summary>
        /// Get a MD5 crypto string from a string (with salt)
        /// </summary>
        /// <param name="input">Input string</param>
        /// <param name="extraSalty">Extra salt for protection</param>
        /// <returns>Output string</returns>
        public static string Md5EncryptSalt(string input, string extraSalty = "SimorC.com.br")
        {
            MD5 md5Hasher = MD5.Create();
            input = "Asje@#csAh2cy" + input + "Un87923fUofc682c123R7" + extraSalty;
            byte[] cryptoValue = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder strBuilder = new StringBuilder();

            for (int i = 0; i < cryptoValue.Length; i++)
            {
                strBuilder.Append(cryptoValue[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        /// <summary>
        /// Converts a date to a DateTime (extension method)
        /// </summary>
        /// <param name="date">DateTime to be converted</param>
        /// <returns>Converted string</returns>
        public static string ToDbString(this DateTime date)
        {
            return date.ToString("yyyy'-'MM'-'dd HH':'mm':'ss");
        }

        /// <summary>
        /// Returns an (kinda) unique string
        /// </summary>
        /// <returns></returns>
        public static string GetUniqueString()
        {
            var rand1 = new Random().Next(1, 666);
            Thread.Sleep(rand1);
            var rand2 = new Random().Next(1, 666);
            Thread.Sleep(rand2);
            var rand3 = new Random().Next(1, 666);

            return DateTime.Now.ToString("HHmmssffffddMMyyyy") + rand1 + rand2 + rand3;
        }

        /// <summary>
        /// Transforms the first letter in a string in LowerCase
        /// </summary>
        /// <param name="str"></param>
        /// <param name="flagLower"></param>
        /// <returns></returns>
        public static string FirstLowerCase(string str, bool flagLower)
        {
            if (String.IsNullOrEmpty(str))
            {
                return null;
            }

            if (flagLower)
            {
                str = str.ToLower();
            }

            return Char.ToLower(str[0]) + str.Substring(1);
        }

        /// <summary>
        /// Transforms the first letter in a string in UpperCase
        /// </summary>
        /// <param name="str"></param>
        /// <param name="flagLower"></param>
        /// <returns></returns>
        public static string FirstUpperCase(string str, bool flagLower)
        {
            if (String.IsNullOrEmpty(str))
            {
                return null;
            }

            if (flagLower)
            {
                str = str.ToLower();
            }

            return Char.ToUpper(str[0]) + str.Substring(1);
        }
    }
}