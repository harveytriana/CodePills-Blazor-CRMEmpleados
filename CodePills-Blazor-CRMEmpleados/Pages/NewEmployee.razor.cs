#nullable disable
using System.Net.Http.Json;
using System.Text.Json;

using Models;

namespace CodePills_Blazor_CRMEmpleados.Pages;

public partial class NewEmployee
{
    readonly Employee employee = new();
    string echo = string.Empty;

    async Task SaveAsync()
    {
        //TODO Validation...
        echo = "Validando...";
        await Task.Delay(2000);

        //// sample:
        //if(employee.Department.Contains("direccion, desarrollo, dise�o, recursoshumanos") == false) {
        //    echo = "El campo departamento s�lo puede tener uno de los siguientes valores: direccion, desarrollo, dise�o, recursoshumanos";
        //    return;
        //}

        Console.WriteLine("**\n{0}", JsonSerializer.Serialize(employee));

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
            echo = "Exepci�n:\n" + exception.Message;
        }
    }
}