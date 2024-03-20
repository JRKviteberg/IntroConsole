using PersonDataLibrary.Models;
using PersonDataLibrary.Utilities;

namespace PersonDataLibrary.Services;

public class PersonDataService
{
    public IEnumerable<Person> GetPersons(string filename)
    {
        // opprette list/array semle persondata
        var persons = new List<Person>();
        
        // lese fra csv fil -> List<string[]>
        IEnumerable<string[]> personDatas = CSVReader.ReadFromFile(filename);

        // tolke innhold -> gjøre string[] -> person
        foreach (var personDataArr in personDatas)
        {
            // list pattern matching
            // string fName = personDataArr[0];
            
            // [Marte, Knutsen, 29, Kvinne]
            if (personDataArr is [string fname, string lname, string agestr, string gender])
            {
                if (int.TryParse(agestr, out var age))
                {
                    // opprette person legge til liste
                    persons.Add(new Person(fname, lname, age, gender));
                }
                else
                {
                    Console.WriteLine($"Klarte ikke å parse {agestr} som Integer");
                }
            }
            
        }
        
        // return liste persons

        return persons;
    }
}