using Factory.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory
{
    public static class AnimalFactory
    {
        public static IAnimal CreateAnimal(AnimalType type)
        {
            switch (type)
            {
                case AnimalType.Cat:
                    return new CatAnimal();
                case AnimalType.Dog:
                    return new DogAnimal();
                case AnimalType.Horse:
                    return new HorseAnimal();
                case AnimalType.Goat:
                    return new GoatAnimal();
                case AnimalType.Turtle:
                    return new TurtleAnimal();
                case AnimalType.Cow:
                    return new CowAnimal();
                default:
                    return null!;
            }
        }
    }
}
