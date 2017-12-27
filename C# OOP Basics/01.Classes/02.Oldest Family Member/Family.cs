using System.Collections.Generic;
using System.Linq;
class Family
{
    public List<Person> family;

    public Family()
    {
        this.family = new List<Person>();
    }

    public void AddMember(Person member)
    {
        this.family.Add(member);
    }

    public Person GetOldestMember()
    {
        return this.family.OrderByDescending(p => p.age).First();
    }
    
    public List<Person> SortAges
    {
        get { return this.family.Where(p => p.age > 30).OrderBy(p => p.name).ToList(); }
    }
    

}
