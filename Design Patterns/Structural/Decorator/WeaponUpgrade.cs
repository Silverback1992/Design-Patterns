namespace Decorator;
public class WeaponUpgrade : InfantryDecorator
{
    public override int Damage => _infantry.Damage + 1;

    public WeaponUpgrade(IInfantry infantry) : base(infantry)
    {
    }
}
