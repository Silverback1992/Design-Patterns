namespace SimpleFactory;
public class Product
{
    private Product()
    {

    }

    public static Product Create()
    {
        return new Product();
    }
}
