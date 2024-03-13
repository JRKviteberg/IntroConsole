namespace PersonDataLibrary.Models;

// Fornavn,Etternavn,Alder,Kjønn
public class Person
{
    public Person()
    {
        
    }
    
    // signatur => new(string, string, int, string) 4 parameter
    public Person(string firstName, string lastName, int age, string gender)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Gender = gender;
    }
    
    public string FirstName { get; init; } = string.Empty;
    public string LastName { get; init; } = string.Empty;
    public int Age { get; init; } = default;
    public string Gender { get; init; } = string.Empty;

    public override string ToString()
    {
        return $"{FirstName}, {LastName}, {Age}, {Gender}";
    }
}
