using _02_Mapster.Models;

namespace _02_Mapster.Seeding;

public class DemoData
{
    public static Person CreatePerson()
    {
        return new Person()
        {
            Title = "Mr.",
            FirstName = "Peter",
            LastName = "Pan",
            DateOfBirth = new DateTime(2000, 1, 1),
            Address = new Address()
            {
                Country = "Neverland",
                PostCode = "123N",
                Street = "Funny Street 2",
                City = "Neverwood"
            }
        };
    }

    public static ICollection<Person> CreatePeople()
    {
        return new List<Person>()
        {
            new Person()
            {
                Title = "Mr.",
                FirstName = "Peter",
                LastName = "Pan",
                DateOfBirth = new DateTime(2000, 1, 1),
                Address = new Address()
                {
                    Country = "Neverland",
                    PostCode = "123N",
                    Street = "Funny Street 2",
                    City = "Neverwood"
                }
            },
            new Person()
            {
                Title = "Mr.",
                FirstName = "Campanita",
                LastName = "Voladora",
                DateOfBirth = new DateTime(2002, 2, 2),
                Address = new Address()
                {
                    Country = "Neverland",
                    PostCode = "123N",
                    Street = "Funny Street 2",
                    City = "Neverwood"
                }
            }
        };
    }
}