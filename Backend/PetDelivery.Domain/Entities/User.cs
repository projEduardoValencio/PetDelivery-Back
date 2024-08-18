using System.ComponentModel.DataAnnotations;
using PetDelivery.Domain.Models;

namespace PetDelivery.Domain.Entities;

public class User : EntityBase
{
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Document { get; set; } = string.Empty;
    [Required]
    public string Email { get; set; } = string.Empty;
    [Required]
    public string Cell { get; set; } = string.Empty;
    [Required]
    public DateTime Birthdate { get; set; }
}