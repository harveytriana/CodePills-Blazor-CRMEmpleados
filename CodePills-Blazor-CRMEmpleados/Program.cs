using CodePills_Blazor_CRMEmpleados;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// from data sample
const string API_ROOT = "https://crm-empleados.onrender.com/";

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(API_ROOT) });

await builder.Build().RunAsync();
