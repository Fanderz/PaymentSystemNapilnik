using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PaymentSystem
{
    class PaySystem3 : IPaymentSystem
    {
        private int _secretKey = 123;

        private IHashComputer _hasher;

        public PaySystem3(IHashComputer hasher)
        {
            _hasher = hasher;
        }

        public string GetPayingLink(Order order)
        {
            if (order == null)
                throw new ArgumentNullException();

            return new StringBuilder($"system3.com/pay?amount={order.Amount}&curency=RUB&hash={_hasher.ComputeHash(order.Amount + order.Id + _secretKey)}").ToString();
        }
    }
}
