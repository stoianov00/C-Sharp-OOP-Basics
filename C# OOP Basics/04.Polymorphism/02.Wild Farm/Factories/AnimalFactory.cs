using _02.Wild_Farm.Models.Animals;

namespace _02.Wild_Farm.Factories
{
    public class AnimalFactory
    {
        public static Animal GetAnimal(string[] tokens)
        {
            string animalType = tokens[0];
            string animalName = tokens[1];
            double animalWeight = double.Parse(tokens[2]);
            string animalRegion = tokens[3];

            switch (animalType)
            {
                case "Mouse":
                    return new Mouse(animalName, animalType, animalWeight, animalRegion);
                case "Zebra":
                    return new Zebra(animalName, animalType, animalWeight, animalRegion);
                case "Cat":
                    return new Cat(animalName, animalType, animalWeight, animalRegion, tokens[4]);
                case "Tiger":
                    return new Tiger(animalName, animalType, animalWeight, animalRegion);

                default: return null;

            }
        }
    }
}
