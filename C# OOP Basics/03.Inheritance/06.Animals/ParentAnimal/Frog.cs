using System;
using System.Text;

namespace _06.Animals.ParentAnimal
{
    public class Frog : Animals
    {
        public Frog(string name, int age, string gender) 
            : base(name, age, gender)
        {

        }

        public override string ProduceSound()
        {
            return "Frogggg";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            Console.WriteLine(this.GetType().Name);
            sb.Append(this.Name).Append(' ').Append(this.Age).Append(' ').AppendLine(this.Gender)
                .Append(this.ProduceSound());
            return sb.ToString();
        }
    }
}
