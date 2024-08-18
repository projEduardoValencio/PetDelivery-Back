using System.ComponentModel.DataAnnotations.Schema;

namespace PetDelivery.Domain.Entities;

public class EmployeeActivies
{
    public int EmployeeId { get; set; }
    [ForeignKey("EmployeeId")]
    public Employee Employee { get; set; }
    
    public int ActivityId { get; set; }
    [ForeignKey("ActivityId")]
    public PetShopActivity Activity { get; set; }
}