using System.Net.Http.Json;

using Models;

namespace CodePills_Blazor_CRMEmpleados.Pages;

public partial class NewEmployee
{
    readonly Employee employee = new();
    string echo = string.Empty;

    async Task SaveAsync()
    {
        echo = "Validando...";
        await Task.Delay(2000);
        //TODO Validations...

        // perform POST
        try {
            var response = await httpClient.PostAsJsonAsync("api/empleados", employee);
            if(response.IsSuccessStatusCode) {
                // it was successful, then
                navigationManager.NavigateTo("/");
            }
            echo = $"Respuesta:\n{response}";
        }
        catch(Exception exception) {
            // maybe exists CORS restriction or something...
            echo = "Exepción:\n" + exception.Message;
        }
    }
}