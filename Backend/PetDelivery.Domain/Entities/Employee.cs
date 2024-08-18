using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetDelivery.Domain.Models;

namespace PetDelivery.Domain.Entities;

public class Employee : EntityBase
{
    [Required]
    public RoleType Role { get; set; }
    
    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }
    
    
    public int EnterpriseId { get; set; }
    [ForeignKey("EnterpriseId")]
    public Enterprise Enterprise { get; set; }
    
    public List<EmployeeActivies> Activities { get; set; }
}