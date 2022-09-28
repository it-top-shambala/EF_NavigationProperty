using EF_NavigationProperty.Models;
using Microsoft.EntityFrameworkCore;

var db = new DB();

/*var person = new Person()
{
    FirstName = "Andrey",
    LastName = "Starinin",
    DateOfBirth = new DateTime(1986, 2, 18)
};
db.TablePersons.Add(person);

var softDev = new Faculty() { Name = "SoftDev" };
var photo = new Faculty() { Name = "Photo" };
db.TableFaculties.Add(softDev);
db.TableFaculties.Add(photo);

db.TableStudents.Add(new()
{
    Person = person,
    Faculty = softDev
});
db.TableStudents.Add(new()
{
    Person = person,
    Faculty = photo
});

db.SaveChanges();*/

/*db.TableStudents
    .Include(s => s.Person)
    .Include(s => s.Faculty)
    .ToList();*/

foreach (var s in db.TableStudents.ToList())
{
    Console.WriteLine($"{s.Person.LastName}: {s.Faculty.Name}");
}

foreach (var p in db.TablePersons.ToList())
{
    foreach (var student in p.Students)
    {
        Console.WriteLine($"{student.Person.LastName} -> {student.Faculty.Name}");
    }
}
