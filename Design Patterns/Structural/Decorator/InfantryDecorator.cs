namespace Decorator;
public abstract class InfantryDecorator : IInfantry
{
    protected IInfantry _infantry;

    public virtual int Damage => _infantry.Damage;
    public virtual int Armor => _infantry.Armor;

    public InfantryDecorator(IInfantry infantry)
    {
        _infantry = infantry;
    }
}
