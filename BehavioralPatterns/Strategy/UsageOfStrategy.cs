using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Strategy.Concrete;
using DesignPatterns.BehavioralPatterns.Strategy.Product;

namespace DesignPatterns.BehavioralPatterns.Strategy
{
    public class UsageOfStrategy
    {
        public static void Run()
        {
            string data = "secret data";
            Console.WriteLine("Pure Data: " + data);
            Encryptor encryptor = new Encryptor(new Aes());

            string encryptedData = encryptor.Encrypt(data);
            Console.WriteLine("Encrypted data: " + encryptedData);

            string decryptedData = encryptor.Decrypt(encryptedData);
            Console.WriteLine("Decrypted data : " + decryptedData);

        }
    }
}
