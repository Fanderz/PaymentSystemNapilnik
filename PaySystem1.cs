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
            if (order == null)
                throw new ArgumentNullException();

            string hash = Convert.ToBase64String(MD5.Create().ComputeHash(BitConverter.GetBytes(order.Id).Reverse().ToArray()));

            return new StringBuilder($"pay.system1.ru/order?amount={order.Amount}RUB&hash={hash}").ToString();
        }
    }
}
