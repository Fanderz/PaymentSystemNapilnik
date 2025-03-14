using System;

namespace PaymentSystem
{
    class PaySystem1 : IPaymentSystem
    {
        private string _paySystemLink = "pay.system1.ru/order?amount=";
        private string _currencyType = "RUB&";
        private string _hashLink = "hash=";

        private IHashComputer _hasher;

        public PaySystem1(IHashComputer hasher)
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

            if(order.Id <= 0)
                throw new ArgumentOutOfRangeException();

            return string.Format($"{_paySystemLink}{order.Amount}{_currencyType}{_hashLink}{_hasher.ComputeHash(order.Id)}").ToString();
        }
    }
}
