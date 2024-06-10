
using System.Net.Http.Json;

using Models;

namespace Services;

public class EmployeesService : IDisposable
{
    // Can be set in a Development and Production appsettings.json file
    readonly string _apiRoot = "https://crm-empleados.onrender.com/";

    readonly HttpClient _httpClient;

    public EmployeesService()
    {
        _httpClient = new HttpClient { BaseAddress = new Uri(_apiRoot) };
    }

    public async Task<List<Employee>?> GetAll()
    {
        return await _httpClient.GetFromJsonAsync<List<Employee>>("api/empleados");
    }

    public async Task<HttpResponseMessage?> CreateEmployee(Employee employee)
    {
        return await _httpClient.PostAsJsonAsync("api/empleados", employee);
    }

    // When registering as Scoped, it is good practice to remove the API client when the system collects memory.
    // Update 10-06-24
    public void Dispose()
    {
        _httpClient?.Dispose();
        GC.SuppressFinalize(this);
    }
}
