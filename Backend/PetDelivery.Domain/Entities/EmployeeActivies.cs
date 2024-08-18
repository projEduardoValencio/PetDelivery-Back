namespace PetDelivery.Domain.Entities;

public class EmployeeActivies
{
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
    
    public int ActivityId { get; set; }
    public PetShopActivity Activity { get; set; }
}