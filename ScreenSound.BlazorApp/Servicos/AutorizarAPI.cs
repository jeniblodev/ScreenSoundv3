using ScreenSound.BlazorApp.Modelos;
using ScreenSound.Shared.Modelos;
using System.Net.Http.Json;

namespace ScreenSound.BlazorApp.Servicos;

public class AutorizarAPI
{
    private readonly HttpClient _httpClient;
    public AutorizarAPI(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<UserTokenResponse?> LoginAsync(UserDTO user)
    {
        var response = await _httpClient.PostAsJsonAsync("login", user);
        return await response.Content.ReadFromJsonAsync<UserTokenResponse>();
    }
}
