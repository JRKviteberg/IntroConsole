﻿using PersonDataLibrary.Models;

// signatur på konstruktøren
Person p = new("Yngve", "Magnussen", 50, "Mann");
Person p2 = new()
{
    FirstName = "Yngve",
    Age = 50,
    Gender = "Mann",
    LastName = "Magnussen"
};

Console.WriteLine($"FirstName: {p.FirstName}, LastName: {p.LastName}");
Console.WriteLine(p2);