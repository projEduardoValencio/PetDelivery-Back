using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetDelivery.Domain.Models;

namespace PetDelivery.Domain.Entities;

public class Enterprise : EntityBase
{
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Cnpj { get; set; } = string.Empty;
    
    public int OwnerId { get; set; }
    [ForeignKey("OwnerId")]
    public Employee Owner { get; set; }
    
    public EnterpriseAddress Address { get; set; }
    public List<Employee> Employees { get; set; }
}