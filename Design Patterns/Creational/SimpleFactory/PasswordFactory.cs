namespace SimpleFactory;
public class PasswordFactory
{
    public static Password Create()
    {
        return new Password();
    }
}
