using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PaymentSystem
{
    class PaySystem2 : IPaymentSystem
    {
        private IHashComputer _hashComputer;

        public PaySystem2(IHashComputer hashComputer)
        {
            _hashComputer = hashComputer;
        }

        public string GetPayingLink(Order order)
        {
            if (order == null)
                throw new ArgumentNullException();

            return new StringBuilder($"order.system2.ru/pay?hash={_hashComputer.ComputeHash(order.Id + order.Amount)}").ToString();
        }
    }
}
