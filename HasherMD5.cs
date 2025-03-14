using System;
using System.Linq;
using System.Security.Cryptography;

namespace PaymentSystem
{
    class HasherMD5 : IHashComputer
    {
        public string ComputeHash(int value)
        {
            return Convert.ToBase64String(MD5.Create().ComputeHash(BitConverter.GetBytes(value).Reverse().ToArray()));
        }
    }
}
