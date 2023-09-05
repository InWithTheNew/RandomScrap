namespace Entities;

public class Person
{
    public Person(
        string firstName,
        string surname,
        DateTime dob,
        string gender,
        int height,
        int weight)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        Surname = surname;
        Dob = dob;
        Gender = gender;
        Height = height;
        Weight = weight;
    }

    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public DateTime Dob { get; set; }
    public string Gender { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }

    //private List<Class> Classes = new List<Class>();



    //  public List<Class> GetClasses()
    //  {
    //return Classes;
    //  }
}

