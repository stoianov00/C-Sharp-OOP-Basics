using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
class Program
{
    static void Main()
    {
        MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
        MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
        if (oldestMemberMethod == null || addMemberMethod == null)
        {
            throw new Exception();
        }

        var family = new Family();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine().Split(' ');
            string name = tokens[0];
            int age = int.Parse(tokens[1]);
            
            family.AddMember(new Person(name, age));
        }

        Person oldestMember = family.GetOldestMember();
        List<Person> sortMember = family.SortAges;
        
        foreach (var person in sortMember)
        {
            Console.WriteLine($"{person.name} {person.age}");
        }


    }

    
}

