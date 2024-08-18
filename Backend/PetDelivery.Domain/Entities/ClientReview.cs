using System.ComponentModel.DataAnnotations;
using PetDelivery.Domain.Models;

namespace PetDelivery.Domain.Entities;

public class ClientReview : EntityBase
{
    public string Title { get; set; }
    public string Comment { get; set; }
    [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
    public int Rating { get; set; }
    
    public int ServiceRequestId { get; set; }
    public ServiceRequest ServiceRequest { get; set; }
}