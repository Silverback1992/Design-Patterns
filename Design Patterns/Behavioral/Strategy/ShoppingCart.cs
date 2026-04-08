namespace Strategy;

public class ShoppingCart
{
    private IPaymentStrategy? _paymentStrategy;

    public void SetPayment(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void Checkout(decimal amount)
    {
        if (_paymentStrategy == null)
        {
            Console.WriteLine("Please select a payment method.");
            return;
        }

        _paymentStrategy.Pay(amount);
    }
}
