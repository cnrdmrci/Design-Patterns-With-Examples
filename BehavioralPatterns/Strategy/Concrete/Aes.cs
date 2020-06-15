using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using DesignPatterns.BehavioralPatterns.Strategy.Abstract;

namespace DesignPatterns.BehavioralPatterns.Strategy.Concrete
{
    public class Aes : IEncryptor
    {
        private static byte[] cryptkey = Encoding.ASCII.GetBytes("1njanrhdkCnsahrebfdMvbjo32hqnd31");
        private static byte[] initVector = Encoding.ASCII.GetBytes("jsKidmshatyb4jdu");
        public string Encrypt(string data)
        {
            try
            {
                using (var rijndaelManaged = new RijndaelManaged { Key = cryptkey, IV = initVector, Mode = CipherMode.CBC })
                using (var memoryStream = new MemoryStream())
                using (var cryptoStream = new CryptoStream(memoryStream, 
                    rijndaelManaged.CreateEncryptor(cryptkey, initVector),CryptoStreamMode.Write))
                {
                    using (var ws = new StreamWriter(cryptoStream))
                    {
                        ws.Write(data);
                    }
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                return null;
            }
        }

        public string Decrypt(string data)
        {
            try
            {
                using (var rijndaelManaged = new RijndaelManaged { Key = cryptkey, IV = initVector, Mode = CipherMode.CBC })
                using (var memoryStream = new MemoryStream(Convert.FromBase64String(data)))
                using (var cryptoStream = new CryptoStream(memoryStream, 
                    rijndaelManaged.CreateDecryptor(cryptkey, initVector), CryptoStreamMode.Read))
                {
                    return new StreamReader(cryptoStream).ReadToEnd();
                }
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                return null;
            }
        }
    }
}
