using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PaymentSystem
{
    class PaySystem1 : IPaymentSystem
    {
        private IHashComputer _hasher;

        public PaySystem1(IHashComputer hasher)
        {
            _hasher = hasher;
        }

        public string GetPayingLink(Order order)
        {
            if (order == null)
                throw new ArgumentNullException();

            return new StringBuilder($"pay.system1.ru/order?amount={order.Amount}RUB&hash={_hasher.ComputeHash(order.Id)}").ToString();
        }
    }
}
