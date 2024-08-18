using PetDelivery.Domain.Models;

namespace PetDelivery.Domain.Entities;

public class Employee : EntityBase
{
    public int UserId { get; set; }
    public User User { get; set; }
    public RoleType Role { get; set; }
    
    public int EnterpriseId { get; set; }
    public Enterprise Enterprise { get; set; }
    
    public List<EmployeeActivies> Activities { get; set; }
}