namespace Strategy;

public class PayPalStrategy : IPaymentStrategy
{
    private readonly string _email;
    private readonly string _password;

    public PayPalStrategy(string email, string password)
    {
        _email = email;
        _password = password;
    }

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} using PayPal.");
    }
}
