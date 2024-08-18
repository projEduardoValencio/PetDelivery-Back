using PetDelivery.Domain.Models;

namespace PetDelivery.Domain.Entities;

public class EnterpriseAddress : Address
{
    public int EnterpriseId { get; set; }
    public Enterprise Enterprise { get; set; }
}