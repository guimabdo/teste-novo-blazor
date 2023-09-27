using BlazorApp6.Client.Application.People;
using System.Net.Http.Json;

namespace BlazorApp6.Client.Application;
public class GetPersonClient(HttpClient httpClient) : IGetPerson
{
    public async Task<PersonDto> HandleAsync(GetPersonRequest request)
        => (await httpClient.GetFromJsonAsync<PersonDto>($"{GetEndpoint<IGetPerson>()}?{request.ToQueryString()}"))!;
}
