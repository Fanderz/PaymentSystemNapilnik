using System;

namespace PaymentSystem
{
    class PaySystem2 : IPaymentSystem
    {
        private string _paySystemLink = "order.system2.ru/pay?hash=";

        private IHashComputer _hasher;

        public PaySystem2(IHashComputer hasher)
        {
            if (hasher == null)
                throw new ArgumentNullException();

            _hasher = hasher;
        }

        public string GetPayingLink(Order order)
        {
            if (order == null)
                throw new ArgumentNullException();

            if (order.Amount < 0)
                throw new ArgumentOutOfRangeException();

            if (order.Id <= 0)
                throw new ArgumentOutOfRangeException();

            return string.Format($"{_paySystemLink}{_hasher.ComputeHash(order.Id + order.Amount)}").ToString();
        }
    }
}
