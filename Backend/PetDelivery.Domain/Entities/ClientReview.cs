using PetDelivery.Domain.Models;

namespace PetDelivery.Domain.Entities;

public class ClientReview : EntityBase
{
    public string Title { get; set; }
    public string Comment { get; set; }
    
    public int ServiceRequestId { get; set; }
    public ServiceRequest ServiceRequest { get; set; }
}