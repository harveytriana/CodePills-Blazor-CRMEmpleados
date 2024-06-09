using System.Net.Http.Json;

using Models;

namespace CodePills_Blazor_CRMEmpleados.Pages;

public partial class NewEmployee
{
    readonly Employee employee = new();

    async Task SaveAsync()
    {
        bool isValid = false;

        //TODO Validation...

        if(isValid) {
            // perform POST
            try {
                await httpClient.PostAsJsonAsync("api/empleados", employee);
                // exit
                navigationManager.NavigateTo("/");
            }
            catch(Exception exception) {
                Console.WriteLine("Exception: " + exception.Message);
            }
        }
    }
}