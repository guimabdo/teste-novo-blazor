using BlazorApp6.Client.Application;
using BlazorApp6.Client.Application.People;

namespace BlazorApp6.Application.People;
public class GetPersonHandler : IGetPerson //, IHandler<GetPersonRequest, PersonDto>
{
    public async Task<PersonDto> HandleAsync(GetPersonRequest request)
    {
        return await Task.FromResult(new PersonDto
        {
            Id = 1,
            Name = "João"
        });
    }
}
