using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Strategy.Abstract;

namespace DesignPatterns.BehavioralPatterns.Strategy.Product
{
    public class Encryptor
    {
        private readonly IEncryptor _iEncryptor;

        public Encryptor(IEncryptor iEncryptor)
        {
            _iEncryptor = iEncryptor;
        }

        public string Encrypt(string data)
        {
            return _iEncryptor.Encrypt(data);
        }

        public string Decrypt(string data)
        {
            return _iEncryptor.Decrypt(data);
        }
    }
}
