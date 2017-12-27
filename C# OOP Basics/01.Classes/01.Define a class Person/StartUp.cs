using System;
class Program
{
    static void Main()
    {

        
        Type personType = typeof(Person);
        var emptyCtor = personType.GetConstructor(new Type[] { });
        var ageCtor = personType.GetConstructor(new[] { typeof(int) });
        var nameAgeCtor = personType.GetConstructor(new[] { typeof(string), typeof(int) });
        
        bool swapped = false;
        if (nameAgeCtor == null)
        {
            nameAgeCtor = personType.GetConstructor(new[] { typeof(int), typeof(string) });
            swapped = true;
        }

        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        var basePerson = (Person)emptyCtor.Invoke(new object[] { });
        var personWithAge = (Person)ageCtor.Invoke(new object[] { age });
        var personWithAgeAndName = swapped ? (Person)nameAgeCtor.Invoke(new object[] { age, name }) : (Person)nameAgeCtor.Invoke(new object[] { name, age });

        Console.WriteLine("{0} {1}", basePerson.name, basePerson.age);
        Console.WriteLine("{0} {1}", personWithAge.name, personWithAge.age);
        Console.WriteLine("{0} {1}", personWithAgeAndName.name, personWithAgeAndName.age);
        

    }
}

