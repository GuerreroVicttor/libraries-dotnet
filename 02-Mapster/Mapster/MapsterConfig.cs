using System.Reflection;
using _02_Mapster.Dtos;
using _02_Mapster.Models;
using Mapster;

namespace _02_Mapster.Mapster;

public static class MapsterConfig
{
    public static void RegisterMapsterConfiguration(this IServiceCollection services)
    {
        TypeAdapterConfig<Person, PersonalShortInfoDto>
            .NewConfig()
            .Map(dest => dest.FullName, src => $"{src.Title} {src.FirstName} {src.LastName}")
            .Map(dest => dest.Age, 
                src => DateTime.Now.Year - src.DateOfBirth.Value.Year,
                srcCondition => srcCondition.DateOfBirth.HasValue)
            .Map(dest => dest.FullAddress, src => $"{src.Address.Street} {src.Address.PostCode} {src.Address.City}");

        TypeAdapterConfig<Person, PersonDto>
            .NewConfig()
            .Ignore(dest => dest.Title)
            .BeforeMapping((src, result) => result.SayHello())
            .AfterMapping((src, result) => result.SayGoodbye())
            .TwoWays(); // ******* Para mapear en ambos sentidos (Person -> PersonDto y PersonDto -> Person) *******

        TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());
    }
}