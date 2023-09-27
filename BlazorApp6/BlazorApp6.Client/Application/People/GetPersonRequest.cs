namespace BlazorApp6.Client.Application;

public record GetPersonRequest(int Id)
{
    // Talvez poderíamos usar source generators
    // para gerar esse método. Talvez um atributo [ToQueryString] em um partial method
    public string ToQueryString() => $"{nameof(Id)}={Id}";    
}

