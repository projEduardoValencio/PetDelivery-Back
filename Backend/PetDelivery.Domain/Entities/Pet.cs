using PetDelivery.Domain.Enums;
using PetDelivery.Domain.Models;

namespace PetDelivery.Domain.Entities;

public class Pet : EntityBase
{
    public string Name { get; set; } = string.Empty;
    public DateTime Birthdate { get; set; }
    public PetType PetType { get; set; }
    public string Observations { get; set; } = string.Empty;
    
    public int TutorId { get; set; }
    public Client Tutor { get; set; }
}