namespace PaymentSystem
{
    class Order
    {
        public Order(int id, int amount)
        {
            Id = id;
            Amount = amount;
        }

        public int Id { get; private set; }
        public int Amount { get; private set; }

    }
}
