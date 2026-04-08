using Strategy;

// Client code
var cart = new ShoppingCart();

cart.SetPayment(new CreditCardStrategy(
    name: "John Doe",
    cardNumber: "1234 5678 9012 3456",
    cvv: "123",
    expiryDate: "12/25"
));
cart.Checkout(100.5m);

cart.SetPayment(new PayPalStrategy(
    email: "johndoe@gmail.com",
    password: "password123"
));
cart.Checkout(200.75m);

cart.SetPayment(new BankTransferStrategy(
    bankName: "Bank of America",
    accountNumber: "987654321"
));
cart.Checkout(300.0m);
