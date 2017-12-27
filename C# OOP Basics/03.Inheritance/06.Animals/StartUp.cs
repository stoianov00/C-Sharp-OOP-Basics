using System;
using System.Collections.Generic;
using _06.Animals.Animal;
using _06.Animals.ParentAnimal;
using _06.Animals.ParentAnimal.ChildAnimal;

namespace _06.Animals
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string animalType = Console.ReadLine();
            List<Animals> animals = new List<Animals>();

            try
            {
                while (animalType != "Beast!")
                {
                    string[] animalData = Console.ReadLine().Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    string name = animalData[0];
                    int age = int.Parse(animalData[1]);

                    switch (animalType)
                    {
                        case "Dog":
                            var dog = new Dog(name, age, animalData[2]);
                            animals.Add(dog);
                            break;

                        case "Cat":
                            var cat = new Cat(name, age, animalData[2]);
                            animals.Add(cat);
                            break;

                        case "Frog":
                            var frog = new Frog(name, age, animalData[2]);
                            animals.Add(frog);
                            break;

                        case "Kitten":
                            var kitten = new Kitten(name, age);
                            animals.Add(kitten);
                            break;

                        case "Tomcat":
                            var tomcat = new Tomcat(name, age);
                            animals.Add(tomcat);
                            break;

                        default: throw new ArgumentException("Invalid input!");

                    }

                    animalType = Console.ReadLine();
                }

                foreach (var animal in animals)
                {
                    Console.WriteLine(animal);
                }

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
/*
    Frog
    Invalidcho -2
    Male
    Frog
    Validcho 2 Male
    Beast!
*/
