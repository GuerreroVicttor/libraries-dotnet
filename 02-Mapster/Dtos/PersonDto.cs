using Mapster;

namespace _02_Mapster.Dtos;

public class PersonDto
{
    [AdaptIgnore]
    public string? Title { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime? DateOfBirth { get; set; }
    
    public void SayHello()
    {
        Console.WriteLine("Hello...");
    }
    
    public void SayGoodbye()
    {
        Console.WriteLine("Goodbye...");
    }
}