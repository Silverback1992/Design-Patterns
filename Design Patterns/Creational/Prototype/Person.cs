namespace Prototype;
public record class Person(string Name, List<string> Hobbies)
{
    public Person ShallowClone()
    {
        return this with { };
    }

    public Person DeepClone()
    {
        return new(Name, [.. Hobbies]);
    }
}
