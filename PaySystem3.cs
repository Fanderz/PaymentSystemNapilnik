﻿using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PaymentSystem
{
    class PaySystem3 : IPaymentSystem
    {
        private int _secretKey = 123;

        public string GetPayingLink(Order order)
        {
            if (order == null)
                throw new ArgumentNullException();

            string hash = Convert.ToBase64String(SHA1.Create().ComputeHash(BitConverter.GetBytes(order.Amount + order.Id + _secretKey).Reverse().ToArray()));

            return new StringBuilder($"system3.com/pay?amount={order.Amount}&curency=RUB&hash={hash}").ToString();
        }
    }
}
