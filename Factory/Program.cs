using Factory;
using Factory.Animals;
using Factory.Factory;

List<IAnimal> animals = new List<IAnimal>()
{
    AnimalFactory.CreateAnimal(AnimalType.Horse),
    AnimalFactory.CreateAnimal(AnimalType.Dog),
    AnimalFactory.CreateAnimal(AnimalType.Turtle),
    AnimalFactory.CreateAnimal(AnimalType.Cat),
    AnimalFactory.CreateAnimal(AnimalType.Goat),
    AnimalFactory.CreateAnimal(AnimalType.Horse),
    AnimalFactory.CreateAnimal(AnimalType.Cow),
};

foreach (IAnimal animal in animals)
{
    Console.WriteLine(animal.Talk());
}