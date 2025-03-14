using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PaymentSystem
{
    class PaySystem1 : IPaymentSystem
    {
        public string GetPayingLink(Order order)
        {
            string hash = Convert.ToBase64String(MD5.Create().ComputeHash(BitConverter.GetBytes(order.Id).Reverse().ToArray()));

            return new StringBuilder($"pay.system1.ru/order?amount=12000RUB&hash={hash}").ToString();
        }
    }
}
