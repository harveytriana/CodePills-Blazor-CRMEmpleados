using Models;

namespace CodePills_Blazor_CRMEmpleados.Pages;

public partial class EmployeeList
{
    readonly List<Employee> employees = [];

    protected override async Task OnInitializedAsync()
    {
        var data = await employeesService.GetAll();
        if(data is not null) {
            employees.AddRange(data);
        }
    }
}