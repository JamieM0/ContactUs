using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs
{
    internal class classMD5Operation
    {
        public static string EncryptString(string input)
        {
            //string inputsdfhdfgh
            byte[] hashBytes = Encoding.Unicode.GetBytes(input);
            using (System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider())
            {
                hashBytes = md5.ComputeHash(hashBytes);
                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                    stringBuilder.Append(b.ToString("X2"));
                //txtEncrypt.Text = stringBuilder.ToString();
                return stringBuilder.ToString();
            }
        }
    }
}
