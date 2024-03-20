using PersonDataLibrary.Models;

namespace PersonDataLibrary.Services;

public class PersonDataService
{
    public IEnumerable<Person> GetPersons()
    {
        // opprette list/array semle persondata
        var persons = new List<Person>();
        
        // lese fra csv fil -> List<string[]>

        // tolke innhold -> gjøre string[] -> person

        // opprette person legge til liste

        // return liste persons

        return persons;
    }
}