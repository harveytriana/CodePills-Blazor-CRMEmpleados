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
        var response = await employeesService.CreateEmployee(employee);
        if(response is not null && response.IsSuccessStatusCode) {
            // it was successful, then
            navigationManager.NavigateTo("/");
        }
        echo = $"Respuesta:\n{response}";
    }
}