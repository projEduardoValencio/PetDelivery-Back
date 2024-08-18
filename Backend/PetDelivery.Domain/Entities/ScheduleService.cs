using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetDelivery.Domain.Enums;
using PetDelivery.Domain.Models;

namespace PetDelivery.Domain.Entities;

public class ScheduleService : EntityBase
{
    [Required]
    public DateTime RequestDate { get; set; }
    [Required]
    public DateTime EstimatedEndService { get; set; }
    [Required]
    public ServiceStatus Status { get; set; }
    
    public int ServiceRequestId { get; set; }
    [ForeignKey("ServiceRequestId")]
    public ServiceRequest ServiceRequest { get; set; }
}