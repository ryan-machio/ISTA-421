using System;
using System.Text;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Collections;

namespace Exercise09
{
    public class Hashing
    {
        public static string ComputerSha256Hash(string password)
        {
            //Create a SHA256
            using (SHA256 pwhash = SHA256.Create())
            {
                //Compute hash - returns byte array
                byte[] bytes = pwhash.ComputeHash(Encoding.UTF8.GetBytes(password));
                // Converts byte to string using StringBuilder
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
