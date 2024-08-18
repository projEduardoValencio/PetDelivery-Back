using PetDelivery.Domain.Enums;
using PetDelivery.Domain.Models;

namespace PetDelivery.Domain.Entities;

public class PetShopServices : EntityBase
{
    public string ServiceName { get; set; }
    public string Description { get; set; }
    public List<PetType> AcceptedPetTypes { get; set; }
    public decimal Price { get; set; }
    public int EstimatedHours { get; set; }
    public int EstimatedMinutes { get; set; }
    public bool IsActive { get; set; }
    
    public int EnterpriseId { get; set; }
    public Enterprise Enterprise { get; set; }
}