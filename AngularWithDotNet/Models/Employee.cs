using System.ComponentModel.DataAnnotations.Schema;

namespace AngularWithDotNet.Models;

public partial class Employee
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int EmployeeId { get; set; }

    public string? FirstName { get; set; }

    public string? City { get; set; }

    public string? Department { get; set; }

    public string? Gender { get; set; }
}
