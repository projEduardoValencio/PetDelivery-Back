using System.ComponentModel.DataAnnotations;
using PetDelivery.Domain.Models;

namespace PetDelivery.Domain.Entities;

public class PetShopActivity : EntityBase
{
    [Required]
    public string Name { get; set; }
}