using System;
using System.Text;

namespace _06.Animals.ParentAnimal.ChildAnimal
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age)  
            : base(name, age, "Female")
        {

        }

        public override string ProduceSound()
        {
            return "Miau";
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
