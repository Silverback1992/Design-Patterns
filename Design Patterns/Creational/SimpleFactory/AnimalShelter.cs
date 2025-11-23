namespace SimpleFactory;
public class AnimalShelter
{
    public static IAnimal GetPet(int animalId)
    {
        switch (animalId)
        {
            case 0:
                return new Dog();
            case 1:
                return new Cat();
            default:
                throw new Exception("Invalid id");
        }
    }
}
