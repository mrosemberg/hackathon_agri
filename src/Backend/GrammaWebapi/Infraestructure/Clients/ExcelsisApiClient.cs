
using System.Net;

namespace GrammaWebapi;

public class ExcelsisApiClient : IExcelsisApiClient
{
    private readonly IHttpClientFactory _httpClientFactory;
    public ExcelsisApiClient(
        IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    } 

    public async Task<ResponseDto> ObtenerClima()
    {
        var client = _httpClientFactory.CreateClient("ApiExcelsis");
        var response = await client.GetAsync($"https://excelsisdev.github.io/desafiocode/db.json");
        return (await response.Content.ReadFromJsonAsync<ResponseDto>())!;
    }
}
