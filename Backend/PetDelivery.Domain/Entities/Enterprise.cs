using PetDelivery.Domain.Models;

namespace PetDelivery.Domain.Entities;

public class Enterprise : EntityBase
{
    public string Name { get; set; } = string.Empty;
    public string Cnpj { get; set; } = string.Empty;
    
    public int OwnerId { get; set; }
    public Employee Owner { get; set; }
    
    public EnterpriseAddress Address { get; set; }
    public List<Employee> Employees { get; set; } = new List<Employee>();
}