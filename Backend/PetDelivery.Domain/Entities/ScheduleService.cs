using PetDelivery.Domain.Enums;
using PetDelivery.Domain.Models;

namespace PetDelivery.Domain.Entities;

public class ScheduleService : EntityBase
{
    public DateTime RequestDate { get; set; }
    public DateTime EstimatedEndService { get; set; }
    public ServiceStatus Status { get; set; }
    
    public int ServiceRequestId { get; set; }
    public ServiceRequest ServiceRequest { get; set; }
}