using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using DesignPatterns.BehavioralPatterns.Strategy.Abstract;

namespace DesignPatterns.BehavioralPatterns.Strategy.Concrete
{
    public class TripleDes : IEncryptor
    {
        public static readonly string Key = "Encryption_Key";
        public static readonly Encoding Encoder = Encoding.UTF8;
        public string Encrypt(string data)
        {
            var des = createDes(Key);
            var ct = des.CreateEncryptor();
            var input = Encoding.UTF8.GetBytes(data);
            var output = ct.TransformFinalBlock(input, 0, input.Length);
            return Convert.ToBase64String(output);
        }

        public string Decrypt(string data)
        {
            var des = createDes(Key);
            var ct = des.CreateDecryptor();
            var input = Convert.FromBase64String(data);
            var output = ct.TransformFinalBlock(input, 0, input.Length);
            return Encoding.UTF8.GetString(output);
        }

        private static TripleDES createDes(string key)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            TripleDES des = new TripleDESCryptoServiceProvider();
            var desKey = md5.ComputeHash(Encoding.UTF8.GetBytes(key));
            des.Key = desKey;
            des.IV = new byte[des.BlockSize / 8];
            des.Padding = PaddingMode.PKCS7;
            des.Mode = CipherMode.ECB;
            return des;
        }
    }
}
