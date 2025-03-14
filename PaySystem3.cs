using System;

namespace PaymentSystem
{
    class PaySystem3 : IPaymentSystem
    {
        private int _secretKey = 123;

        private string _paySystemLink = "system3.com/pay?amount=";
        private string _currencyType = "&curency=RUB&";
        private string _hashLink = "hash=";

        private IHashComputer _hasher;

        public PaySystem3(IHashComputer hasher)
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

            return string.Format($"{_paySystemLink}{order.Amount}{_currencyType}{_hashLink}{_hasher.ComputeHash(order.Amount + order.Id + _secretKey)}").ToString();
        }
    }
}
