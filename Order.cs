namespace PaymentSystem
{
    class Order
    {
        public int Id { get; private set; }
        public int Amount { get; private set; }

        public Order(int id, int amount)
        {
            Id = id;
            Amount = amount;
        }
    }
}
