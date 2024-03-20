using Microsoft.Extensions.Configuration;
using PersonDataLibrary.Models;
using PersonDataLibrary.Services;

// signatur på konstruktøren

#region session 1
/*
Person p = new("Yngve", "Magnussen", 50, "Mann");
Person p2 = new()
{
    FirstName = "Yngve",
    Age = 50,
    Gender = "Mann",
    LastName = "Magnussen"
};

Opprette instans/objekt
Demo d = new()
{
    DemoNumber = 12
};

Console.WriteLine($"FirstName: {p.FirstName}, LastName: {p.LastName}");
Console.WriteLine(p2);
*/
#endregion

#region session 2

// Configure setup
IConfiguration configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

string filename = configuration["PersonsCsvFileName"]
                  ?? throw new ArgumentNullException("Mangler filnavn fra configurasjon");

PersonDataService service = new();
IEnumerable<Person> persons = service.GetPersons(filename);


foreach (Person person in persons)
{
    Console.WriteLine(person);
}

#endregion