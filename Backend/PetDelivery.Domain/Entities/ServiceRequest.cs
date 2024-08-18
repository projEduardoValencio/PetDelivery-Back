using PetDelivery.Domain.Enums;
using PetDelivery.Domain.Models;

namespace PetDelivery.Domain.Entities;

public class ServiceRequest : EntityBase
{
    public string Uuid { get; set; }
    public string ClientDescription { get; set; }
    public decimal TotalPrice { get; set; }
    
    public int ServiceId { get; set; }
    public PetShopServices Service { get; set; }
    
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
    
    public int ClientId { get; set; }
    public Client Client { get; set; }
    
    public int PetId { get; set; }
    public Pet Pet { get; set; }
    
    public int EnterpriseId { get; set; }
    public Enterprise Enterprise { get; set; }
    
    public ScheduleService ScheduleService { get; set; }
}