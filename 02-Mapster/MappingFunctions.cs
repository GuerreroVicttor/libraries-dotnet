using _02_Mapster.Dtos;
using _02_Mapster.Models;
using _02_Mapster.Seeding;
using Mapster;

namespace _02_Mapster;

public static class MappingFunctions
{
    // Obtener información
    private static readonly Person _person = DemoData.CreatePerson();
    private static readonly ICollection<Person> _people = DemoData.CreatePeople();
    
    public static PersonDto MapPersonToNewDto()
    {
        var personDto = _person.Adapt<PersonDto>();
        
        return personDto;
    }

    public static PersonDto MapPersonToExistingDto()
    {
        var personDto = new PersonDto();
        _person.Adapt(personDto);

        return personDto;
    }
    
    public static IQueryable<PersonDto> MapPersonQueryableToDtoQueryable()
    {
        var peopleQueryable = _people.AsQueryable();
        
        var personDtos = peopleQueryable.ProjectToType<PersonDto>();
        
        return personDtos;
    }

    public static PersonalShortInfoDto CustomMapPersonToShortInfoDto()
    {
        var personShortInfoDto = _person.Adapt<PersonalShortInfoDto>();
        
        return personShortInfoDto;
    }

    public static Person MapPersonDtoToPersonEntity()
    {
        var personDto = new PersonDto();
        var person = personDto.Adapt<Person>();
        
        return person;
    }
}