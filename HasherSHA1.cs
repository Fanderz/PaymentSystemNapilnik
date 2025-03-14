using System;
using System.Linq;
using System.Security.Cryptography;

namespace PaymentSystem
{
    class HasherSHA1 : IHashComputer
    {
        public string ComputeHash(int value)
        {
            return Convert.ToBase64String(SHA1.Create().ComputeHash(BitConverter.GetBytes(value).Reverse().ToArray()));
        }
    }
}
