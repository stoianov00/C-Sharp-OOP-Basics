using System;
using System.Text;

namespace _06.Animals.ParentAnimal.ChildAnimal
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, "Male")
        {

        }


        public override string ProduceSound()
        {
            return "Give me one million b***h";
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
