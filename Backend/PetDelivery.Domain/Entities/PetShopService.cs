using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetDelivery.Domain.Enums;
using PetDelivery.Domain.Models;

namespace PetDelivery.Domain.Entities;

public class PetShopService : EntityBase
{
    [Required]
    public string ServiceName { get; set; }
    public string Description { get; set; }
    [Required]
    public AcceptPetType AcceptedPetTypes { get; set; }
    public decimal Price { get; set; }
    [Required]
    public int EstimatedHours { get; set; }
    [Required]
    public int EstimatedMinutes { get; set; }
    [Required]
    public bool IsActive { get; set; }
    
    public int EnterpriseId { get; set; }
    [ForeignKey("EnterpriseId")]
    public Enterprise Enterprise { get; set; }
}