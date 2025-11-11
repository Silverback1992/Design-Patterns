namespace Decorator;
public class ArmorUpgrade : InfantryDecorator
{
    public override int Armor => _infantry.Armor + 1;

    public ArmorUpgrade(IInfantry infantry) : base(infantry)
    {
    }
}
