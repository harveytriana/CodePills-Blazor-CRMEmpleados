using System.Text.Json.Serialization;

namespace Models;

// map mongo db name rules
//
public class Employee
{
    [JsonPropertyName("_id")]
    public string? Id { get; set; }

    [JsonPropertyName("nombre")]
    public string? FirstName { get; set; }

    [JsonPropertyName("apellidos")]
    public string? LastName { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("telefono")]
    public string? Phone { get; set; }

    [JsonPropertyName("departamento")]
    public string? Department { get; set; }

    [JsonPropertyName("salario")]
    public decimal Salary { get; set; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; } = default;

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; set; } = default;
}


