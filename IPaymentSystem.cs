namespace PaymentSystem
{
    interface IPaymentSystem
    {
        string GetPayingLink(Order order);
    }
}
