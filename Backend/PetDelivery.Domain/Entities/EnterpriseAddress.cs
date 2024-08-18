using System.ComponentModel.DataAnnotations.Schema;
using PetDelivery.Domain.Models;

namespace PetDelivery.Domain.Entities;

public class EnterpriseAddress : Address
{
    public int EnterpriseId { get; set; }
    [ForeignKey("EnterpriseId")]
    public Enterprise Enterprise { get; set; }
}