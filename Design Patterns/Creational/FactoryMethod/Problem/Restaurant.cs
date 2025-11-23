namespace FactoryMethod.Problem;
public class Restaurant
{
    //we could move this code into a simple factory which would mean better single responsibility
    //however the simple factory would still violate the open-closed principle as we would be actively modifying it in case other burgers are needed
    public static Burger OrderBurger(string request)
    {
        return request switch
        {
            "BEEF" => new BeefBurger(),
            "VEGGIE" => new VeggieBurger(),
            _ => throw new ArgumentException("No burger like that."),
        };
    }
}
