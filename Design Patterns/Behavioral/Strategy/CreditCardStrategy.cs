namespace Strategy;

public class CreditCardStrategy : IPaymentStrategy
{
    private readonly string _name;
    private readonly string _cardNumber;
    private readonly string _cvv;
    private readonly string _expiryDate;

    public CreditCardStrategy(string name, string cardNumber, string cvv, string expiryDate)
    {
        _name = name;
        _cardNumber = cardNumber;
        _cvv = cvv;
        _expiryDate = expiryDate;
    }

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} by credit card.");
    }
}
