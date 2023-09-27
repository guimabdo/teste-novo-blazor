namespace BlazorApp6.Client.Application.People;
public interface IGetPerson
{  
    Task<PersonDto> HandleAsync(GetPersonRequest request);
}
