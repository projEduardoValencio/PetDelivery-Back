using PetDelivery.Domain.Models;

namespace PetDelivery.Domain.Entities;

public class User : EntityBase
{
    public string Name { get; set; } = string.Empty;
    public string Document { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Cell { get; set; } = string.Empty;
    public DateTime Birthdate { get; set; }
}