using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PaymentSystem
{
    class PaySystem2 : IPaymentSystem
    {
        public string GetPayingLink(Order order)
        {
            if (order == null)
                throw new ArgumentNullException();

            string hash = Convert.ToBase64String(MD5.Create().ComputeHash(BitConverter.GetBytes(order.Id + order.Amount).Reverse().ToArray()));

            return new StringBuilder($"order.system2.ru/pay?hash={hash}").ToString();
        }
    }
}
