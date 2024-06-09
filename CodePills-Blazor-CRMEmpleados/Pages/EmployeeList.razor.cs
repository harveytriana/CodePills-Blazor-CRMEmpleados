using System.Net.Http.Json;

using Models;

namespace CodePills_Blazor_CRMEmpleados.Pages;

public partial class EmployeeList
{
    readonly List<Employee> employees = [];

    protected override async Task OnInitializedAsync()
    {
        var data = await httpClient.GetFromJsonAsync<List<Employee>>("sample-data/empleados.json");
        if(data is not null) {
            employees.AddRange(data);
        }
    }
}