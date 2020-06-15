using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Strategy.Abstract
{
    public interface IEncryptor
    {
        string Encrypt(string data);
        string Decrypt(string data);
    }
}
