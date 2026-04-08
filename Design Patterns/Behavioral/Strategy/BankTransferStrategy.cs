namespace Strategy;

public class BankTransferStrategy : IPaymentStrategy
{
    private readonly string _bankName;
    private readonly string _accountNumber;

    public BankTransferStrategy(string bankName, string accountNumber)
    {
        _bankName = bankName;
        _accountNumber = accountNumber;
    }

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} by bank transfer.");
    }
}
