using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetDelivery.Domain.Enums;
using PetDelivery.Domain.Models;

namespace PetDelivery.Domain.Entities;

public class Pet : EntityBase
{
    [Required]
    public string Name { get; set; } = string.Empty;
    public DateTime Birthdate { get; set; }
    [Required]
    public PetType PetType { get; set; }
    public string Observations { get; set; } = string.Empty;
    
    public int TutorId { get; set; }
    [ForeignKey("TutorId")]
    public Client Tutor { get; set; }
}